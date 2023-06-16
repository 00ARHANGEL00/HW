package Java.HW3;

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

/**
 * Пусть дан произвольный список целых чисел.
 * 1) Нужно удалить из него чётные числа
 * 2) Найти минимальное значение
 * 3) Найти максимальное значение
 * 4) Найти среднее значение
 */
public class Task {
    public static void main(String[] args) throws Exception {
        System.out.print("Введите длину списка N: ");
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.close();
        ArrayList<Integer> nums = GetRandomArray(n);
        System.out.println("Произвольный список целых чисел: " + nums);
        System.out.println("Минимальное значение: " + FindMin(nums));
        System.out.println("Максимальное значение: " + FindMax(nums));
        System.out.println("Среднее арифметическое значение: " + FindAverage(nums));
        System.out.println("Список с удаленными четными числами: " + DeleteEvev(nums));
    }

    public static ArrayList<Integer> GetRandomArray(int n) {
        ArrayList<Integer> array = new ArrayList<Integer>();
        Random rand = new Random();
        for (int i = 0; i < n; i++) {
            int temp = rand.nextInt(10);
            array.add(temp);
        }
        return array;
    }

    public static ArrayList<Integer> DeleteEvev(ArrayList<Integer> array) {
        for (int i = 0; i < array.size(); i++) {
            if (array.get(i) % 2 == 0) {
                array.remove(i);
                i--;
            }
        }
        return array;
    }

    public static int FindMin(ArrayList<Integer> array) {
        int min = array.get(0);
        for (int i = 1; i < array.size(); i++) {
            int num = array.get(i);
            if (num < min) {
                min = num;
            }
        }
        return min;
    }

    public static int FindMax(ArrayList<Integer> array) {
        int max = array.get(0);
        for (int i = 1; i < array.size(); i++) {
            int num = array.get(i);
            if (num > max) {
                max = num;
            }
        }
        return max;
    }

    public static double FindAverage(ArrayList<Integer> array) {
        double average = 0;
        int length = array.size();
        for (int i = 0; i < length; i++) {
            average += array.get(i);
        }
        average /= length;
        return average;
    }
}