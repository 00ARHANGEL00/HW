import numpy as np

# Задача 1. Дан список элементов. Используя библиотеку NumPy, подсчитайте количество уникальных элементов в нём.
def task1():
    my_list = [11, 32, 11, 89, 4, 8, 6, 32]
    my_uniq_list = np.unique(my_list)
    print(f"Количество уникальных элементов в списке: {len(my_uniq_list)}")

# task1()


# Задача 2. Создайте двумерный массив, размером 5х5. Определите, есть ли в нём одинаковые строки.
def task2():
    array = np.array([[1, 1, 2, 3, 4], 
                     [1, 2, 3, 4, 5], 
                     [1, 1, 2, 3, 4], 
                     [0, 1, 0, 3, 4], 
                     [2, 1, 4, 5, 4]])
    uniques = np.unique(array, axis=0)
    print(array)
    if uniques.shape[0] == array.shape[0]:
        print("Нет одинаковых строк")
    else:
        print("Есть одинаковые строки")

# task2()


# Задача 3. Создайте двумерный массив случайного размера. Найдите индексы максимального и минимального элементов в нём.
# выведите элементы главной диагонали матрицы в виде одномерного массива.
def task3():
    array = np.random.randint(0, 21, (np.random.randint(2, 5, 2)))
    print(array)
    print(f"Индекс максимального элемента: {np.unravel_index(array.argmax(), array.shape)}")
    print(f"Индекс минимального элемента: {np.unravel_index(array.argmin(), array.shape)}")
    diag = np.diagonal(array)
    print(f"Элементы главной диагонали: {diag}")

task3()