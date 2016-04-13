import java.io.*;

public class CreateReadAndWriteInFiles {
    private static final String FILE_PATH = "resources/users.txt";
    private static final String SAVE_PATH = "resources/total-time.txt";

    public static void main(String[] args) {

        File file = new File(FILE_PATH);
        File outputFile = new File(SAVE_PATH);

        try (
                BufferedReader br = new BufferedReader(new FileReader(file));
                FileWriter fr = new FileWriter(outputFile, true);
                PrintWriter pr = new PrintWriter(fr, true);
        ) {
            String line = br.readLine();
            while (line != null) {
                String[] lineArgs = line.split(" ");
                String username = lineArgs[0];
                int totalMinutes = 0;


                for (int i = 1; i < lineArgs.length; i++) {
                    String[] loggedTime = lineArgs[i].split(":");
                    int hours = Integer.parseInt(loggedTime[0]);
                    int minutes = Integer.parseInt(loggedTime[1]);
                    totalMinutes += (60 * hours) + minutes;
                }

                String output = username + " " + totalMinutes;

                int minutes = totalMinutes % 60;
                int hours = totalMinutes / 60;
                int days = hours / 24;
                hours = hours % 24;

                pr.printf("%s (%d days, %d hours, %d minutes)", output, days, hours, minutes);
                pr.println();
                line = br.readLine();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }


    }

}
