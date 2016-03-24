import java.util.Scanner;

public class GhettoNumeralSystem {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] num = scanner.nextLine().split("");
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < num.length; i++) {
            switch (num[i]) {
                case "0":
                    stringBuilder.append("Gee");
                    break;
                case "1":
                    stringBuilder.append("Bro");
                    break;
                case "2":
                    stringBuilder.append("Zuz");
                    break;
                case "3":
                    stringBuilder.append("Ma");
                    break;
                case "4":
                    stringBuilder.append("Duh");
                    break;
                case "5":
                    stringBuilder.append("Yo");
                    break;
                case "6":
                    stringBuilder.append("Dis");
                    break;
                case "7":
                    stringBuilder.append("Hood");
                    break;
                case "8":
                    stringBuilder.append("Jam");
                    break;
                case "9":
                    stringBuilder.append("Mack");
                    break;
            }
        }

        System.out.println(stringBuilder);
    }
}

