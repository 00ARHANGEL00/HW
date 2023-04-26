import random

# Задача 1. Задайте список случайных чисел от 1 до 10, выведите все элементы больше 5. Используйте для решения лямбда-функцию.
def Task1():
  nums = [random.randint(1, 10) for _ in range(10)]
  print(nums)
  print(list(filter(lambda x: x > 5, nums)))

# Task1()

# Задача 2. Дан список случайных чисел. Создайте список, в который попадают числа, описывающие случайную возрастающую последовательность. Порядок элементов менять нельзя.
def Task2(): # Не все перебрал
  nums = [random.randint(1, 10) for _ in range(10)]
  print(nums)
  lenght = len(nums)
  ascending_sequence = []
  sequence = []
  for i in range(lenght):
    ind = i
    while ind != lenght - 1:
      sequence.append(nums[i])
      for j in range(ind + 1, lenght):
        if sequence[-1] < nums[j]:
          sequence.append(nums[j])
      ind += 1
      if len(sequence) > 1 and sequence not in ascending_sequence:
        ascending_sequence.append(sequence)
      sequence = []
  print(ascending_sequence)

# Task2()

# Задача 3. Задайте список случайных чисел от 1 до 10. Посчитайте, сколько всего совпадающих элементов есть в списке. Удалите все повторяющиеся элементы.
def Task3():
  nums = [random.randint(1, 10) for _ in range(10)]
  nums_d = []
  print(nums)
  lenght = len(nums)
  count_d = 0
  for i in range(lenght):
    count = 1
    for j in range(i + 1, lenght):
      if nums[i] == nums[j]:
        count += 1   
    if count > 1 and nums[i] not in nums_d:
      count_d += count
      nums_d.append(nums[i])
  print(f"{count_d} элемента совпадают")
  print(f"Список уникальных элементов {set(nums)}")  

Task3()