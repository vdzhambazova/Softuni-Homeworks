import java.util.Scanner;

public class CountAllWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();

        String[] lineArgs = line.split("\\P{Alpha}+");

        System.out.println(lineArgs.length);
    }
}

