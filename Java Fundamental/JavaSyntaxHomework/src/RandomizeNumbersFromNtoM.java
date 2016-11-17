import java.util.*;

public class RandomizeNumbersFromNtoM {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();
        int m = scanner.nextInt();
        List<Integer> numbers = new ArrayList<>();

        if (m <= n) {
            for (int i = m; i <= n; i++) {
                numbers.add(i);
            }

            Collections.shuffle(numbers);

            for (int number : numbers) {
                System.out.print(number + " ");
            }
        }
    }
}
