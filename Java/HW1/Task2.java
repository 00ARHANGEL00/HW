/**
 * 2) Вывести все простые числа от 1 до 1000
 */

import java.util.ArrayList;
import java.util.List;

public class Task2 {
    public static void main(String[] args) {
        List<Integer> simpleNumbers = new ArrayList<>();
        for (int i = 2; i <= 1000; i++) {
            boolean isSimpleNumber = true;
            for (int j = 2; j < i; j++) {
                if (i % j == 0) {
                    isSimpleNumber = false;
                    break;
                }
            }
            if (isSimpleNumber) {
                simpleNumbers.add(i);
            }
        }
        System.out.println("Простые числа: " + simpleNumbers);   
    }
}