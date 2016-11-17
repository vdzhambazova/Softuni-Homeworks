import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();

        Pattern substringPattern = Pattern.compile("[A-Za-z]+");
        Matcher matcher = substringPattern.matcher(text);
        List<String> words = new ArrayList<>();

        while (matcher.find()) {
            words.add(matcher.group());
        }

        for (String word:
             words) {
            System.out.print(word + " ");
        }
    }
}
