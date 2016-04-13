import java.util.*;

public class SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<String> input = Arrays.asList(scanner.nextLine().split(" "));
        List<Integer> numbers = new LinkedList<>();
        input.forEach(number -> numbers.add(Integer.parseInt(number)));
        String sortingOrder = scanner.nextLine();

        if (sortingOrder.equals("Ascending")) {
            numbers.sort(Comparator.naturalOrder());
            numbers.forEach(number -> System.out.print(number + " "));
        } else {
            numbers.sort(Comparator.reverseOrder());
            numbers.forEach(number -> System.out.print(number + " "));
        }
    }
}
