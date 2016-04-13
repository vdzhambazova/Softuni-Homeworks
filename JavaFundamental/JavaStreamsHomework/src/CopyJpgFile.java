import java.io.*;

public class CopyJpgFile {
    private static final String FILE_PATH = "res/picture.jpg";
    private static final String SAVE_PATH = "res/my-copied-picture.jpg";

    public static void main(String[] args) {
        File file = new File(FILE_PATH);
        File outputFile = new File(SAVE_PATH);

        try (
                FileInputStream fis = new FileInputStream(file);
                FileOutputStream fos = new FileOutputStream(outputFile);
        ) {

            byte[] buffer = new byte[4096];
            int readBytes;
            while ((readBytes = fis.read(buffer)) != -1) {
                fos.write(buffer, 0 ,readBytes);
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
