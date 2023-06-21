package Java.HW4;

import java.util.ArrayDeque;
import java.util.Arrays;
import java.util.Deque;
import java.util.LinkedList;

/**
 * Даны два Deque, представляющие два целых числа. Цифры хранятся в обратном
 * порядке и каждый из их узлов содержит одну цифру.
 * 1) Умножьте два числа и верните произведение в виде связанного списка.
 * 2) Сложите два числа и верните сумму в виде связанного списка.
 * Одно или два числа могут быть отрицательными
 */

public class Task {
    public static void main(String[] args) {
        Deque<Character> num1 = new ArrayDeque<>(Arrays.asList('1', '2', '3'));
        Deque<Character> num2 = new ArrayDeque<>(Arrays.asList('5', '4', '7', '-'));
        LinkedList<Character> resMult = Multiply(new ArrayDeque<>(num1), new ArrayDeque<>(num2));
        System.out.println("Произведение равно: " + resMult);
        LinkedList<Character> resSum = Sum(new ArrayDeque<>(num1), new ArrayDeque<>(num2));
        System.out.println("Сумма равна: " + resSum);
    }

    public static LinkedList<Character> Multiply(Deque<Character> num1, Deque<Character> num2) {
        LinkedList<Character> result = new LinkedList<>();
        String str1 = "";
        String str2 = "";
        while (!num1.isEmpty()) {
            str1 += num1.removeLast();
        }
        while (!num2.isEmpty()) {
            str2 += num2.removeLast();
        }
        String sum = Integer.toString(Integer.parseInt(str1) * Integer.parseInt(str2));
        for (int i = 0; i < sum.length(); i++) {
            result.add(sum.charAt(i));
        }
        return result;
    }

    public static LinkedList<Character> Sum(Deque<Character> num1, Deque<Character> num2) {
        LinkedList<Character> result = new LinkedList<>();
        String str1 = "";
        String str2 = "";
        while (!num1.isEmpty()) {
            str1 += num1.removeLast();
        }
        while (!num2.isEmpty()) {
            str2 += num2.removeLast();
        }
        String sum = Integer.toString(Integer.parseInt(str1) + Integer.parseInt(str2));
        for (int i = 0; i < sum.length(); i++) {
            result.add(sum.charAt(i));
        }
        return result;
    }
}