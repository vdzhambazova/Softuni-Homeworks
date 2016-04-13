import java.io.*;

/**
 * Created by Roni on 3/24/2016.
 */
public class Writer {
    public static void main(String[] args) {
        try (
                BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter("res/file"));
                FileWriter fileWriter = new FileWriter("res/file");
        ) {
            bufferedWriter.append("Teo0");
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
