import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class SaveAnArrayListOfDoubles {
    private static final String FILE_PATH = "res/doubles.list";

    public static void main(String[] args) {
        File file = new File(FILE_PATH);

        List<Double> doubles = new ArrayList<Double>();
        doubles.add(3.7);
        doubles.add(0.56);
        doubles.add(2.8);
        doubles.add(5.98);
        doubles.add(4.6);

        try (
                ObjectOutputStream writer = new ObjectOutputStream(
                        new BufferedOutputStream(
                                new FileOutputStream(file)))
        ) {
            writer.writeObject(doubles);

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        try (
                ObjectInputStream reader = new ObjectInputStream(
                        new BufferedInputStream(
                                new FileInputStream(file)))
        ) {
            List<Double> result = (List<Double>)reader.readObject();
            System.out.println(result);

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
    }
}
