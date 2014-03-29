import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

public class SmallCalcApp {

    JFrame frame;
    JLabel firstOperand, secondOperand, answer;
    JTextField op1, op2, ans;
    JButton plus, mul;
// setting layout

    public void initGUI() {
        frame = new JFrame();
        firstOperand = new JLabel("First Operand");
        secondOperand = new JLabel("Second Operand");
        answer = new JLabel("Answer");
        op1 = new JTextField(15);
        op2 = new JTextField(15);
        ans = new JTextField(15);
        plus = new JButton("+");
        plus.setPreferredSize(new Dimension(70, 25));
        mul = new JButton("*");
        mul.setPreferredSize(new Dimension(70, 25));
        Container cont = frame.getContentPane();
        cont.setLayout(new FlowLayout());
        cont.add(firstOperand);
        cont.add(op1);
        cont.add(secondOperand);
        cont.add(op2);
        cont.add(plus);
        cont.add(mul);
        cont.add(answer);
        cont.add(ans);
        /*
         * Creating an object of the class which is handling button events &
         * registering it with generators
         */
        ButtonHandler bHandler = new ButtonHandler();
        plus.addActionListener(bHandler);
        mul.addActionListener(bHandler);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(200, 220);
        frame.setVisible(true);
    }
    //constructor

    public SmallCalcApp() {
        initGUI();
    }
//Inner class implementation of ActionListener

    private class ButtonHandler implements ActionListener {

        public void actionPerformed(ActionEvent event) {
            String oper, result;
            int num1, num2, res;
            if (event.getSource() == plus) {
                oper = op1.getText();
                num1 = Integer.parseInt(oper);
                oper = op2.getText();
                num2 = Integer.parseInt(oper);
                res = num1 + num2;
                result = res + "";
                ans.setText(result);
            } else if (event.getSource() == mul) {
                oper = op1.getText();
                num1 = Integer.parseInt(oper);
                oper = op2.getText();
                num2 = Integer.parseInt(oper);
                res = num1 * num2;
                result = res + "";
                ans.setText(result);
            }
        } // end actionPerformed method
    } // end inner class ButtonHandler

    public static void main(String args[]) {
        SmallCalcApp scApp = new SmallCalcApp();
    }
}// end class