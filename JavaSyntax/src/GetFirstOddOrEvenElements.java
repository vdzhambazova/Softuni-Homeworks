import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<Integer> numbers = new ArrayList<>();
        fillListWithNumbers(scanner, numbers);
        String[] commands = scanner.nextLine().split(" ");
        executeCommands(numbers, commands);
    }

    private static void executeCommands(List<Integer> numbers, String[] commands) {
        String oddOrEven = commands[2];
        int countOfNums = Integer.parseInt(commands[1]);
        switch (oddOrEven) {
            case "odd":
                getOddNumbers(numbers, countOfNums);
                break;
            case "even":
                getEvenNumbers(numbers, countOfNums);
        }
    }

    private static void getEvenNumbers(List<Integer> numbers, int countOfNums) {
        int counter = 0;
        for (Integer number : numbers) {
            if (number % 2 == 0) {
                System.out.print(number + " ");
                counter++;
            }

            if (counter > countOfNums) {
                break;
            }
        }
    }

    private static void getOddNumbers(List<Integer> numbers, int countOfNums) {
        int counter = 0;
        for (Integer number : numbers) {
            if (number % 2 == 1) {
                System.out.print(number + " ");
                counter++;
            }
            if (counter > countOfNums) {
                break;
            }
        }
    }

    private static void fillListWithNumbers(Scanner scanner, List<Integer> numbers) {
        String[] input = scanner.nextLine().split(" ");
        for (String anInput : input) {
            numbers.add(Integer.parseInt(anInput));
        }
    }
}
