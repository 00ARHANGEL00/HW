package Java.HW2;

/**
 * 1) Дана строка sql-запроса "select * from students WHERE ". Сформируйте часть
 * WHERE этого запроса, используя StringBuilder.
 * Данные для фильтрации приведены ниже в виде json-строки.
 */

public class Task1 {
    public static void main(String[] args) {
        String inputStr = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"}";
        StringBuilder newStr = new StringBuilder("select * from students");
        inputStr = inputStr.replaceAll("[{}\"]", "");
        if ((inputStr.split("null", -1).length - 1) != 4) {
            newStr.append(" WHERE ");
            boolean isPrev = false;
            String[] arrayData = inputStr.split(", ");
            for (int i = 0; i < arrayData.length; i++) {
                String[] arrData = arrayData[i].split(":");
                if (!arrData[1].equals("null")) {
                    if (isPrev) newStr.append(" AND ");
                    newStr.append(arrData[0]);
                    newStr.append("=");
                    newStr.append(arrData[1]);
                    isPrev = true;
                }
            }
        }
        System.out.println(newStr);
    }
}