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
        double num1 = scan.nextDouble();
        scan.nextLine();
        System.out.println("Введите знак: ");
        String operation = scan.nextLine();
        System.out.println("Введите второе число: ");
        double num2 = scan.nextDouble();
        scan.close();
        double result = 0;
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
                break;
            default:
                flag = false;
                System.out.println("Введен не знак!");
                break;
        }
        if (flag) System.out.printf("%s %s %s = %s", num1, operation, num2, result);
    }
}