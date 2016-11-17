import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountAllWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();

        Pattern substringPattern = Pattern.compile("\\w+");
        Matcher matcher = substringPattern.matcher(text);
        int occurrenceCount = 0;

        while (matcher.find()) {
            occurrenceCount++;
        }

        System.out.println(occurrenceCount);
    }
}
