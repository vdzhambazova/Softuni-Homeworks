import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Stream;

import static java.util.Arrays.stream;

public class FilterArray {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<String> line = Arrays.asList(scanner.nextLine().split(" "));
       line.stream()
                .filter(w -> w.length() > 3)
                .forEach(w -> System.out.print(w + " "));
    }
}
