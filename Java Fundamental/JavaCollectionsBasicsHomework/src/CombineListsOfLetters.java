import java.util.Scanner;

public class CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String firstLine = scanner.nextLine();
        String secondLine = scanner.nextLine();

        StringBuilder sb = new StringBuilder();
        sb.append(firstLine);

        for (int i = 0; i < secondLine.length(); i++) {
            char currentElement = secondLine.charAt(i);
            if (firstLine.chars().noneMatch(ch -> ch == currentElement)) {
                sb.append(" " + currentElement);
            }
        }
        System.out.println(sb.toString());
    }
}
