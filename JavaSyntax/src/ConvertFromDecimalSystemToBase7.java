import java.util.Scanner;

public class ConvertFromDecimalSystemToBase7 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int dec = scanner.nextInt();
        String baseSeven = Integer.toString(dec, 7);
        System.out.println(baseSeven);
    }
}
