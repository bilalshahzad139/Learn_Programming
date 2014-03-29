import javax.swing.*;

public class InputOutputTest {

    public static void main(String[] args) {
        //takes input through GUI
        String input = JOptionPane.showInputDialog("Enter number");

        int number = Integer.parseInt(input);
        int square = number * number;

        //Display square on console
        System.out.println("square:" + square);

        //Display square on GUI
        JOptionPane.showMessageDialog(null, "square:" + square);
        System.exit(0);
    }
}