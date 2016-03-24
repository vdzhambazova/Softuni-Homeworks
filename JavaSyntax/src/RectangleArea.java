import java.util.Scanner;


public class RectangleArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int sideA = scanner.nextInt();
        int sideB = scanner.nextInt();
        System.out.println(calculateArea(sideA,sideB));
    }

    private static int calculateArea(int a, int b) {
        return a * b;
    }
}
