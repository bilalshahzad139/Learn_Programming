//MC100401907
//required packages
import javax.swing.*;
import java.awt.*;
import javax.swing.border.*;
import java.awt.event.*;

//main class
public class mc100401907 implements ActionListener {

	//main frame object
    JFrame frameObject;
    BallShape ballObj;
	JPanel mainPanel;
    int xDifferential, yDifferential;
	int borderThick=3;

    public mc100401907() {
		//Main Frame Object
        frameObject = new JFrame("Assignment 3 - MC100401907");
        //Get the contact area to add controls
        Container c = frameObject.getContentPane();

		//Initialize the differential variables
        xDifferential = 5;
		yDifferential = 3;
		//Initialize the Ball Object
		ballObj = new BallShape();

		//Need to create a panel to add border to the frame
        mainPanel = new JPanel();
        c.add(mainPanel,"Center");

		//Set layout and add ball object to panel
        mainPanel.setLayout(new BorderLayout());
		mainPanel.add(ballObj);

        frameObject.setSize(400, 400);
        frameObject.setVisible(true);
        frameObject.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frameObject.setResizable(false);

		//Set timer to call the repainting of ball after 20 ms
        Timer t = new Timer(20, this);
        t.start();

    } // end constructor
// event handler method
    public void actionPerformed(ActionEvent ae) {

		//To handle the collision with right border
        if ( (ballObj.mX <=  frameObject.getWidth())
        	&& (ballObj.mX >  frameObject.getWidth()-40)) {
            xDifferential = -5;
            mainPanel.setBorder(new LineBorder(ballObj.ballColor,borderThick));
            ballObj.ballColor = Color.red;
        }
        //To handle the collision with bottom border
        if ( (ballObj.mY <=  frameObject.getHeight())
        	&& (ballObj.mY >  frameObject.getHeight()-60)) {
            yDifferential = -3;
            mainPanel.setBorder(new LineBorder(ballObj.ballColor,borderThick));
            ballObj.ballColor = Color.green;
        }
        //To handle the collision with left border
        if (ballObj.mX-3 <= 0) {
            xDifferential = 5;
            mainPanel.setBorder(new LineBorder(ballObj.ballColor,borderThick));
            ballObj.ballColor = Color.yellow;
        }
        //To handle the collision with top border
        if (ballObj.mY-2 <= 0) {
            yDifferential = 3;
            mainPanel.setBorder(new LineBorder(ballObj.ballColor,borderThick));
            ballObj.ballColor = Color.cyan;
        }

		//set the new position of the ball
        ballObj.mX += xDifferential;
        ballObj.mY += yDifferential;

		//repaint the ball object
        ballObj.repaint();
    } // end actionPerformed() method
// main method
    public static void main(String args[]) {
        mc100401907 at = new mc100401907();
    }

	//inner class for Ball Shape
    class BallShape extends JPanel {

		//initial position of the ball
	    int mX = 10;
	    int mY = 3;
	    //To hold color of the ball, default is blue
	    Color ballColor = Color.blue;
	    public void paintComponent(Graphics g)
	    {
	        super.paintComponent(g);
	        Graphics2D g2 = (Graphics2D) g;
	        g2.setColor(ballColor);
	        g2.fillOval(mX, mY, 20, 20);
			//draw position of the ball
			g2.setColor(Color.black);
	        g2.drawString("X:" + mX + ",Y:" + mY , 100, 20);
	        g2.setColor(ballColor);

	    }// end paintComponent
	} // end BallShape class
} // end mc100401907 class

