import java.util.Scanner;
import java.util.TreeSet;

public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        input = input.toLowerCase();
        String[] inputArray = input.split("\\P{Alpha}+");

        TreeSet<String> sortedWords = new TreeSet<>();

        for (int i = 0; i < inputArray.length; i++) {
            sortedWords.add(inputArray[i]);
        }

        System.out.println(sortedWords);
    }
}

