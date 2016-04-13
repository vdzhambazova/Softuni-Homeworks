import java.io.*;

public class AllCapitals {
    private static final String FILE_PATH = "res/allCapitals.txt";

    public static void main(String[] args) {
        File file = new File(FILE_PATH);
        StringBuilder sb = new StringBuilder();

        try (
                BufferedReader br = new BufferedReader(new FileReader(file));
        ) {

            String line = br.readLine();
            while (line != null) {
                sb.append(line + "\n");
                line = br.readLine();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }

        //file.delete();

        try (
                FileWriter fr = new FileWriter(file);
                PrintWriter pr = new PrintWriter(fr, true);
        ) {
            pr.println(sb.toString().toUpperCase());
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
