import java.util.Scanner;

public class CalculateExpression {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double aa = scanner.nextDouble();
        double b = scanner.nextDouble();
        double c = scanner.nextDouble();

        double result1 = calcFirstExpression(aa, b, c);
        double result2 = calcSecondExpression(aa, b, c);
        double average = (aa + b + c) / 3;

        double diff = calcDifference(result1, result2, average);

        System.out.printf("F1 result: %1$.2f; F2 result: %2$.2f; Diff: %3$.2f", result2, result1, diff);
    }

    private static double calcDifference(double result1, double result2, double average) {
        return Math.abs((result1+result2)/2-average);
    }

    private static double calcSecondExpression(double a, double b, double c) {
        return Math.pow((Math.pow(a, 2) + Math.pow(b, 2)) / (Math.pow(a, 2) - Math.pow(b, 2)), ((a + b + c) / Math.sqrt(c)));
    }

    private static double calcFirstExpression(double a, double b, double c) {
        return Math.pow((Math.pow(a, 2) + Math.pow(b, 2) - Math.pow(c, 3)), (a - b));
    }
}