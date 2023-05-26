# Задача 1. Создайте пользовательский аналог метода map().
def task1():
    def our_map(op, data):
        return (op(i) for i in data)

    a = [1, 2, 3, 4]
    print(f"map: {list(map(lambda x: x * 2, a))}")
    print(f"our_map: {list(our_map(lambda x: x * 2, a))}")


# task1()


# Задача 2. Создайте декоратор, повторяющий функцию заданное количество раз.
def task2():
    def repeat(count):
        def our_rep(func):
            def decorator(num, symbol='*'):
                for _ in range(count):
                    func(num, symbol)
            return decorator
        return our_rep


    @repeat(10)
    def print_zv(num, symbol='*'):
        print(num * symbol)

    print_zv(100)


task2()
