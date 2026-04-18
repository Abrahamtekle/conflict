public class NumberLoop {
    public static void main(String[] args) {

        long number = 1234567890L; // 10-digit number

        System.out.println("Starting Number : " + number);
        System.out.println("Ending Number   : " + (number + 100));
        System.out.println("----------------------------------");

        for (long i = number; i <= number + 100; i++) {
            System.out.println(i);
        }

        System.out.println("----------------------------------");
        System.out.println("Loop Finished!");
    }
}
