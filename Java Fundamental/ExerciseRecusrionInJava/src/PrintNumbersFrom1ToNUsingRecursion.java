import java.util.Scanner;

public class PrintNumbersFrom1ToNUsingRecursion {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = Integer.parseInt(scanner.nextLine());

        printRecursive(number);

    }

    private static void printRecursive(int number) {
        if (number < 1) {
            return;
        }
        printRecursive(number - 1);

        System.out.println(number);
    }
}
