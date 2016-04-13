import java.util.Scanner;

public class GetAverage {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double firstNum = scanner.nextDouble();
        double secondNum = scanner.nextDouble();
        double thirdNum = scanner.nextDouble();
        double average = calculateAverageOfThree(firstNum, secondNum,thirdNum);
        System.out.println(String.format("%.2f", average));
    }

    private static double calculateAverageOfThree(double a, double b, double c) {
        double average = (a+b+c)/3;

        return average;
    }
}
