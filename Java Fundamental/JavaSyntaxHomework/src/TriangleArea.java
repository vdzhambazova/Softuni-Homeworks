import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int pointAx = scanner.nextInt();
        int pointAy = scanner.nextInt();
        int pointBx = scanner.nextInt();
        int pointBy = scanner.nextInt();
        int pointCx = scanner.nextInt();
        int pointCy = scanner.nextInt();

        int triangleArea = triangleArea(pointAx, pointAy, pointBx,pointBy,pointCx,pointCy);
        System.out.println(triangleArea);
    }

    private static int triangleArea(int pointAx, int pointAy, int pointBx, int pointBy, int pointCx, int pointCy) {
        return Math.abs(pointAx*(pointBy-pointCy)+ pointBx*(pointCy-pointAy)+pointCx*(pointAy-pointBy))/2;
    }
}
