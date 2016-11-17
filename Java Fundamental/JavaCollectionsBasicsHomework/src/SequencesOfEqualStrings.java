import java.util.Scanner;

public class SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();

        String[] strings = line.split(" ");

        for (int i = 0; i < strings.length; i++) {
            if (i == 0) {
                System.out.print(strings[i] + " ");
                continue;
            }
            if (strings[i].contains(strings[i - 1])) {
                System.out.print(strings[i] + " ");
            } else {
                System.out.println();
                System.out.print(strings[i] + " ");
            }
        }
    }
}
