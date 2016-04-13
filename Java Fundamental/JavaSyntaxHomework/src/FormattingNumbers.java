import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int integer = scanner.nextInt();
        float floatingPoint1 = scanner.nextFloat();
        float floatingPoint2 = scanner.nextFloat();

        System.out.printf("|%1$-10s|%2$010d|%3$10s|%4$-10s",
                Integer.toHexString(integer).toUpperCase(),
                Integer.parseInt(Integer.toBinaryString(integer)),
                String.format("%.2f", floatingPoint1),
                String.format("%.3f", floatingPoint2));
    }
}
