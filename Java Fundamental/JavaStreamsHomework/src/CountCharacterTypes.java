import java.io.*;

public class CountCharacterTypes {
    private static final String FILE_PATH = "res/words.txt";
    private static final String SAVE_PATH = "res/count-chars.txt";

    public static void main(String[] args) {

        File file = new File(FILE_PATH);
        File outputFile = new File(SAVE_PATH);

        try (
                BufferedReader br = new BufferedReader(new FileReader(file));
                PrintWriter pr = new PrintWriter(new FileWriter(outputFile, true), true)
        ) {
            String line = br.readLine();
            int vowelsCount = 0;
            int consonantsCount = 0;
            int punctMarksCount = 0;
            while (line != null) {
                line = line.replaceAll("\\s","");
                for (int i = 0; i < line.length(); i++) {
                    boolean vowelSymbol = (line.charAt(i) == 'a' || line.charAt(i) == 'e' || line.charAt(i) == 'i'
                            || line.charAt(i) == 'o' || line.charAt(i) == 'u');
                    boolean punctuationMark = (line.charAt(i) == '.' || line.charAt(i) == ',' || line.charAt(i) == '?'
                            || line.charAt(i) == '!');
                    if (vowelSymbol) {
                        vowelsCount++;
                    } else if (punctuationMark) {
                        punctMarksCount++;
                    } else {
                        consonantsCount++;
                    }
                }
                pr.printf("Vowels: %d\nConsonants: %d\nPunctuation: %d\n", vowelsCount, consonantsCount, punctMarksCount);
                line = br.readLine();
            }

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
