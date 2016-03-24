import java.util.Scanner;

public class ConvertFromBase7ToDecimal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String baseSeven = scanner.next();
        int dec = Integer.valueOf(baseSeven, 7);

        System.out.println(dec);
    }
}
