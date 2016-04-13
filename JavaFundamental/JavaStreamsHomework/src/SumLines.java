import java.io.*;

public class SumLines {
    private static final String FILE_PATH = "res/line.txt";
    public static void main(String[] args) {

        File file = new File(FILE_PATH);
        try(
                BufferedReader bf = new BufferedReader(new FileReader(file))
        ){
            String line = bf.readLine();
            while (line != null){
                int sumLine = 0;
                for (int i = 0; i < line.length(); i++) {
                    sumLine += line.charAt(i);
                }

                System.out.println(sumLine);
                line = bf.readLine();
            }

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

