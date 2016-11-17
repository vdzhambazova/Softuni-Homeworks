import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();
        String[] strings = line.split(" ");
        Integer[] integers = new Integer[strings.length];
        List<Integer> currentSequence = new ArrayList<>();
        List<Integer> largestSequence = new ArrayList<>();

        for (int i = 0; i < integers.length; i++) {
            integers[i] = Integer.parseInt(strings[i]);
        }

        for (int i = 0; i < integers.length; i++) {
            if (i == 0) {
                currentSequence.add(integers[i]);
                System.out.print(integers[i] + " ");
                continue;
            }

            if (integers[i] > (integers[i - 1])) {
                currentSequence.add(integers[i]);
                System.out.print(integers[i] + " ");
            } else {
                currentSequence.clear();
                System.out.println();
                System.out.print(integers[i] + " ");
            }

            if (currentSequence.size()>largestSequence.size()){
                for (Integer num :
                        currentSequence) {
                    largestSequence.add(num);
                }
            }
        }

        System.out.println();
        System.out.println(largestSequence);
    }
}
