/**
 * 3) Реализовать простой калькулятор
 * + - / *
 * Введите первое число: A \n
 * Введите знак: *
 * Введите второе число: B
 * Результат: A*B
 */

import java.util.Scanner;

public class Task3 {
    public static void main(String[] args) {
        System.out.println("Введите первое число: ");
        Scanner scan = new Scanner(System.in);
        float num1 = scan.nextInt();
        scan.nextLine();
        System.out.println("Введите знак: ");
        String operation = scan.nextLine();
        System.out.println("Введите второе число: ");
        float num2 = scan.nextInt();
        float result = 0;
        boolean flag = true;
        switch (operation) {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
            default:
                flag = false;
                System.out.println("Введен не знак!");
                break;
        }
        if (flag) System.out.printf("%s %s %s = %s", num1, operation, num2, result);
    }
}