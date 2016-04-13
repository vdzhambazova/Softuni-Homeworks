import java.util.Scanner;

public class CalculateNFactorial {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = scanner.nextInt();

        int factorial = calculateFactorial(number);
        System.out.println(factorial);
    }

    private static int calculateFactorial(int number) {
        if(number == 0){
            return  1;
        } else {
            return number * calculateFactorial(number - 1);
        }
    }
}
