import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();

        String[] strings = line.split(" ");
        List<String> currentSequence = new ArrayList<>();
        List<String> largestSequence = new ArrayList<>();
        for (int i = 0; i < strings.length; i++) {
            if (i == 0) {
                currentSequence.add(strings[i]);
                continue;
            }

            if (strings[i].contains(strings[i - 1])) {
                currentSequence.add(strings[i]);
            } else {
                currentSequence.clear();
            }

            if (currentSequence.size() > largestSequence.size()) {
                for (String string :
                        currentSequence) {
                    largestSequence.add(string);
                }
            }
        }

        System.out.println(largestSequence);
    }
}
