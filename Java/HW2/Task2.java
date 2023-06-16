package Java.HW2;

import java.io.IOException;
import java.util.Arrays;
import java.util.logging.FileHandler;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

/**
 * 2) Реализуйте алгоритм сортировки пузырьком числового массива, результат
 * после каждой итерации запишите в лог-файл.
 */

public class Task2 {
    public static void main(String[] args) throws IOException {
        Logger logger = Logger.getLogger(Task2.class.getName());
        FileHandler fh = new FileHandler("Java\\HW2\\logTask2.txt", false);
        logger.addHandler(fh);
        SimpleFormatter formatter = new SimpleFormatter();
        fh.setFormatter(formatter);
        logger.info("Sort Array");
        int[] array = { -5, 4, 0, -7, 3, 14, 1 };
        logger.info(Arrays.toString(array));
        for (int i = 0; i < array.length - 1; i++) {
            for (int j = 0; j < array.length - i - 1; j++) {
                if (array[j] > array[j + 1]) {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
                logger.info(Arrays.toString(array));
            } 
        }
    }
}