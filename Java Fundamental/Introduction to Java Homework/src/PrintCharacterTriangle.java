import java.util.Scanner;

public class PrintCharacterTriangle {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int num = scanner.nextInt();
        for (int i = 1; i < num + 1; i++) {
            for (char c = 'a'; c < 'a' + i; c++) {
                System.out.print(c + " ");
            }
            System.out.println();
        }

        for (int i = num - 1; i > 0; i--) {
            for (char c = 'a'; c < 'a' + i; c++) {
                System.out.print(c + " ");
            }
            System.out.println();
        }
    }
}
