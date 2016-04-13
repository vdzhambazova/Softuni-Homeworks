import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine().toUpperCase();
        String specificWord = scanner.next().toUpperCase();
        String[] textArgs = text.split("\\P{Alpha}+");

        int specificWordCount = (int) Arrays.stream(textArgs)
                .filter(w -> w.equals(specificWord))
                .count();

        System.out.println(specificWordCount);
    }
}
