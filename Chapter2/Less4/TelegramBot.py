# Задача 3. Добавьте в telegram-бота игру «Угадай числа». 
# Бот загадывает число от 1 до 1000. Когда игрок угадывает его, бот выводит количество сделанных ходов.
import telebot
import random

bot = telebot.TeleBot("Token")

@bot.message_handler(commands=['start', 'help'])
def send_welcome(message):
	bot.send_message(message.chat.id, 'Привет, как дела?')
	
@bot.message_handler(content_types=["text"])
def find_words(message):
    if(message.text == "игра"):
        bot.send_message(message.chat.id, 'Давай начнем игру!')
        msg = bot.send_message(message.chat.id, 'Я загадал число от 1 до 1000, угадай, какое?')
        bot.register_next_step_handler(msg, game_guess_the_number, num=str(random.randint(1, 1001)), count=1)


def game_guess_the_number(message, num, count):
    if message.text == num:
        bot.send_message(message.chat.id, f'Угадал! Количество попыток: {count}')
        count = 0
    elif message.text == 'стоп':
        count = 0
        bot.send_message(message.chat.id, f'Конец игры! Я загадал: {num}')
        print(num) 
    else:
        count += 1
        if message.text > num:
            msg = bot.send_message(message.chat.id, 'Меньше')
        else:
            msg = bot.send_message(message.chat.id, 'Больше')      
        bot.register_next_step_handler(msg, game_guess_the_number, num, count)
		
bot.polling()