# Задача 1. Напишите программу, которая принимает на вход число N и выдает список факториалов для чисел от 1 до N.
def Task1():
  factorials = []
  f = 1
  num = int(input("Введите число: "))
  for i in range(1, num + 1):
    f *= i
    factorials.append(f)
  print(factorials)
  
# Task1()

# Задача 2. Выведите таблицу истинности для выражения ¬(X ∧ Y) ∨ Z.
def Task2():
  print("X | Y | Z | ¬(X ∧ Y) ∨ Z")
  for i in range(2):
    for j in range(2):
      for k in range(2):
        print(f"{i} | {j} | {k} |\t { int( not(i and j) or k) }")

# Task2()

# Задача 3. Даны две строки. Посчитайте сколько раз каждый символ первой строки встречается во второй.
def Task3():
  string = input("Введите первую строку: ")
  mainString = input("Введите вторую строку: ")
  for i in string:
    count = 0
    for j in mainString:
      if (i == j):
        count += 1
    print(f"{i} - {count}")

# Task3()

# Задача 4. Задайте список из N элементов, заполненных числами из промежутка [-N, N]. Сдвиньте все элементы списка на 2 позиции вправо.
def Task4(shear = 2):
  num = abs(int(input("Введите число: ")))
  numbers = [i for i in range(-num, num + 1)]
  lengthList = len(numbers)
  copyList = numbers.copy()
  for i in range(lengthList):
    numbers[(i + shear) % lengthList] = copyList[i]
  print(numbers)

Task4(3)