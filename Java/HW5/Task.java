import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

/**
* Реализуйте структуру телефонной книги с помощью HashMap.
* Программа также должна учитывать, что во входной структуре будут повторяющиеся имена с разными телефонами, 
* их необходимо считать, как одного человека с разными телефонами. Вывод должен быть отсортирован по убыванию числа телефонов.
*/
public class Task {
    public static void main(String[] args) {
        Map<String, ArrayList<String>> mp = new HashMap<>();
        Scanner scaner = new Scanner(System.in, "cp866");
        String str = "";
        while (true) {
            str = scaner.nextLine();
            if (str.equals("exit")) break;
            String[] kv = str.split(" ");
            if (mp.containsKey(kv[0]))
                mp.get(kv[0]).add(kv[1]);
            else
                mp.put(kv[0], new ArrayList<String>(Arrays.asList(kv[1])));
        }
        scaner.close();
        String[] arrayNN = new String[mp.size()];
        String key = "";
        for (int i = 0; i < arrayNN.length; i++) {
            int val = 0;
            for (var item : mp.entrySet()) {
                int size = item.getValue().size();
                if (val < size) {
                    key = item.getKey();
                    val = size;
                }
            }
            arrayNN[i] = key + mp.get(key).toString();
            mp.remove(key);
        }
        System.out.println(Arrays.toString(arrayNN));
    }
}