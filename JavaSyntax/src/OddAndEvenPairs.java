import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class OddAndEvenPairs {
    public static void main(String[] args) {
        System.out.println("Enter the numbers: ");
        Scanner scanner = new Scanner(System.in);
        List<Integer> numbers = new ArrayList<>();

        gettingTheNumbersFromTheUser(numbers,scanner);
        shuttingIfTheSizeIsNotEven(numbers);
        pairsHandling(numbers);
    }

    private static void  shuttingIfTheSizeIsNotEven(List<Integer> numbers) {
        if(numbers.size() % 2 == 1){
            System.out.println("Invalid length");
            System.exit(0);
        }
    }

    private static void pairsHandling(List<Integer> numbers) {
        for (int i = 0; i < numbers.size() ; i+=2) {
            boolean isThePairEven = false;
            boolean isThePairOdd = false;

            if(numbers.get(i) % 2 == 0 && numbers.get(i + 1) % 2 == 0){
                isThePairEven = true;
            } else if(numbers.get(i) % 2 == 1 && numbers.get(i + 1) % 2 == 1) {
                isThePairOdd = true;
            }

            printingPairsCompatability(isThePairEven, isThePairOdd, numbers.get(i), numbers.get(i + 1));
        }
    }

    private static void printingPairsCompatability(boolean isThePairEven, boolean isThePairOdd, Integer one, Integer two) {
        System.out.printf("%s, %s -> ", one, two);
        if(isThePairEven){
            System.out.println("both are even");
        } else if(isThePairOdd){
            System.out.println("both are odd");
        } else {
            System.out.println("different");
        }

    }

    private static void gettingTheNumbersFromTheUser(List<Integer> numbers, Scanner scanner) {
        String[] input = scanner.nextLine().split(" ");
        for (String anInput : input) {
            numbers.add(Integer.parseInt(anInput));
        }
    }
}