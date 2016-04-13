import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class MostFrequentWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] textArray =  scanner.nextLine().split("\\W+");
        Map<String, Integer> wordCount = new TreeMap<>();
        int maxWordCount = 0;

        for (String word :
                textArray) {
            word = word.toLowerCase();
            Integer count = wordCount.get(word);
            if (count == null) {
                count = 0;

            }

            if (count + 1 > maxWordCount) {
                maxWordCount = count + 1;
            }

            wordCount.put(word, count + 1);
        }

        for (Map.Entry<String, Integer> entry : wordCount.entrySet()) {
            if (entry.getValue() == maxWordCount) {
                System.out.printf("%s -> %d times", entry.getKey(), maxWordCount);
                System.out.println();
            }
        }
    }
}