import java.util.Scanner;


public class CharacterMultiplier {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String firstString = scanner.next();
        String secondString = scanner.next();
        Long sum = 0L;

        sum = multiplyChars(firstString, secondString, sum);

        System.out.println(sum);
    }

    private static Long multiplyChars(String firstString, String secondString, Long sum) {
        for (int i = 0; i < firstString.length(); i++) {
            sum += firstString.charAt(i) * secondString.charAt(i);
        }

        sum += addRemaining(firstString, secondString);

        return sum;
    }

    private static Long addRemaining(String firstString, String secondString) {
        long sumOfReminder = 0;
        if (firstString.length() > secondString.length()) {
            String remainder = firstString.substring(secondString.length());
            for (int i = 0; i < remainder.length(); i++) {
                sumOfReminder += remainder.charAt(i);
            }
        } else if (secondString.length() > firstString.length()) {
            String remainder = secondString.substring(firstString.length());
            for (int i = 0; i < remainder.length(); i++) {
                sumOfReminder += remainder.charAt(i);
            }
        }

        return sumOfReminder;
    }
}
