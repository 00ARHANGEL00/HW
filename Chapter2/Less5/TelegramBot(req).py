# Задача 1. Напишите бота для техподдержки. Бот должен записывать обращения пользователей в файл.

import telebot

bot = telebot.TeleBot("Token")

@bot.message_handler(commands=['start', 'help'])
def send_welcome(message):
	bot.send_message(message.chat.id, 'Привет, как дела?')
	
@bot.message_handler(content_types=["text"])
def find_words(message):
    with open('quession.txt', mode='a', encoding='utf-8') as data:
          data.write(f'{message.from_user.id}:{message.text}\n')
		
bot.polling()