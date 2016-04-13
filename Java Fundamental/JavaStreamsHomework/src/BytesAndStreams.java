import java.io.*;

/**
 * Created by Roni on 3/24/2016.
 */
public class BytesAndStreams {
    public static void main(String[] args) {
        try (
                BufferedInputStream bufferedInputStream = new BufferedInputStream(
                        new FileInputStream("res/picture.jpg"));
                BufferedOutputStream bufferedOutputStream = new BufferedOutputStream(
                        new FileOutputStream("res/my-copied-picture..jpg"));
        ) {
            int input;
            while ((input = bufferedInputStream.read()) != -1) {
                bufferedOutputStream.write(input);
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
