# Задача 2. Напишите программу, которая позволяет считывать из файла вопрос, отвечать на него и отправлять ответ обратно пользователю.

import telebot
import time

try:
    with open('NumRow.txt', mode='r', encoding='utf-8') as data:
        num_row = int(data.readline())
except:
    with open('NumRow.txt', mode='w', encoding='utf-8') as data:
        num_row = 0

bot = telebot.TeleBot("Token")

data = open('quession.txt', mode='r', encoding="utf-8")
for i in range(num_row):
    data.readline()
print("Начало вопросов и ответов")
while True:
    question = data.readline().replace('\n','').split(':')
    if len(question) < 2:
        time.sleep(3)
    else:
        num_row += 1
        answer = input(f'{question[1]}\nОтвет: ')
        if answer == 'STOP':
            print("Ответь на вопрос и можешь отдыхать!")
            bot.send_message(question[0], f'Ваш вопрос: {question[1]}\nОтвет: {input()}')
            break
        bot.send_message(question[0], f'Ваш вопрос: {question[1]}\nОтвет: {answer}')

data.close()

with open('NumRow.txt', mode='w', encoding='utf-8') as data:
    data.write(str(num_row))