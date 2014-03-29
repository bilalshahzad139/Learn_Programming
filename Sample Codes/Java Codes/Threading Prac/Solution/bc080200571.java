//BC080200571

// importing required packages
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


//Note: to show data, I've Used List class, I could not find a method to insert at 0 index to add at top
// Other way can be to use TextArea and concat new string with previous string.

// Main Class
public class bc080200571 {

	//Frame & Other GUI Components
	JFrame frameObj;
	JTextField ftTime,stTime;
	JLabel l1,l2,l3,l4,l5,l6;
	JButton btnStartThread,btnClear;
	List lst1,lst2;
	//Starting X & Y to change all elements starting position from single location
	int startX=10;
	int startY=10;
	//Default Time for Threads to Sleep
	int defaultTime1 = 300;
	int defaultTime2 = 350;

	public bc080200571()
	{
		initGUI();
	}
	public void initGUI()
	{
		//Main Frame Object
		frameObj = new JFrame("Assignment 4 - Threading");
		frameObj.setLayout(null);
		frameObj.setBounds(100,100,700,500);

		//Buttons
		btnStartThread = new JButton("Start Threads");
		btnStartThread.setBounds(startX+260,100,130,30);

		btnClear = new JButton("Clear");
		btnClear.setBounds(startX+275,140,100,30);

		//Labels
		l1 = new JLabel("Thread 1:");
		l1.setBounds(startX+80,startY,100,20);
		l2 = new JLabel("Speed");
		l2.setBounds(startX+20,startY+25,100,20);
		l3 = new JLabel("ms");
		l3.setBounds(startX+170,startY+25,100,20);

		l4 = new JLabel("Thread 2:");
		l4.setBounds(startX+480,startY,100,20);
		l5 = new JLabel("Speed");
		l5.setBounds(startX+420,startY+25,100,20);
		l6 = new JLabel("ms");
		l6.setBounds(startX+570,startY+25,100,20);

		//Text Boxes
		ftTime= new JTextField();
		ftTime.setBounds(startX+60,startY+25,100,20);
		stTime= new JTextField();
		stTime.setBounds(startX+460,startY+25,100,20);

		//Lits
		lst1 = new List();
		lst1.setBounds(startX,startY+60,250,340);

		lst2 = new List();
		lst2.setBounds(startX+400,startY+60,250,340);

		//Add GUI elements to Frame
		frameObj.add(btnStartThread);
		frameObj.add(btnClear);
		frameObj.add(l1);
		frameObj.add(l2);
		frameObj.add(l3);
		frameObj.add(l4);
		frameObj.add(l5);
		frameObj.add(l6);
		frameObj.add(ftTime);
		frameObj.add(stTime);
		frameObj.add(lst1);
		frameObj.add(lst2);

		//Add Click Event to buttons
		btnStartThread.addActionListener(new MyListener());
		btnClear.addActionListener(new MyListener());

		//Set frame properities
		frameObj.setVisible(true);
		frameObj.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frameObj.setResizable(false);

	}

    public static void main(String args[]) {
		new bc080200571();
    }//end main

	//Action Listener class for Buttons
    class MyListener implements ActionListener{

			public void actionPerformed(ActionEvent e){

				//Check if clicked button is Start Thread Button
				 if(e.getSource()==btnStartThread){
					String time1 = ftTime.getText();
					String time2 = stTime.getText();

					int t1 = defaultTime1;
					int t2 = defaultTime2;

					//Perform Validation of Input Values
					try {
						t1 = Integer.parseInt(time1);
					}catch(Exception ex)
					{
						JOptionPane.showMessageDialog(null, "Error Invalid Input:\nExecution Speed of thread 1 has been set to default value(" + defaultTime1 + "ms)");
						ftTime.setText(defaultTime1 + "");
					}
					try {
						t2 = Integer.parseInt(time2);
					}catch(Exception ex)
					{
						JOptionPane.showMessageDialog(null, "Error Invalid Input:\nExecution Speed of thread 2 has been set to default value(" + defaultTime2 + "ms)");
						stTime.setText(defaultTime2 + "");
					}
					if(t1 == 0)
					{
						JOptionPane.showMessageDialog(null, "Error Invalid Input:\nExecution Speed of thread 1 has been set to default value(" + defaultTime1 + "ms)");
						ftTime.setText(defaultTime1 + "");
						t1 = defaultTime1;
					}
					if(t2 == 0)
					{
						JOptionPane.showMessageDialog(null, "Error Invalid Input:\nExecution Speed of thread 2 has been set to default value(" + defaultTime2 + "ms)");
						stTime.setText(defaultTime2 + "");
						t2 = defaultTime2;
					}

					if(t1 < 0)
					{
						JOptionPane.showMessageDialog(null, "Error! Invalid input speed of thread 1 execution speed.\nNegative value(" + t1 + ") is entered and has been converted to postive value (" + -1*t1 + ")");
						ftTime.setText(-1*t1 + "");
						t1 = -1*t1;
					}
					if(t2 < 0)
					{
						JOptionPane.showMessageDialog(null, "Error! Invalid input speed of thread 2 execution speed.\nNegative value(" + t2 + ") is entered and has been converted to postive value (" + -1*t2 + ")");
						stTime.setText(-1*t2 + "");
						t2 = -1*t2;
					}

					//Start Thread for First List
					MyClientThread mct = new MyClientThread(t1,lst1);
					mct.start();
					//Start Thread for Second List
					MyClientThread mct1 = new MyClientThread(t2,lst2);
					mct1.start();


				 }
				//Check if clicked button is Clears Button
				 if(e.getSource()==btnClear){
						lst1.clear();
						lst2.clear();
				 }

			 }
		 }// End of MyListener class

	//Thread Handling Class, this will show output in Lists
	class MyClientThread extends Thread{

			int time;
			List lst;
			MyClientThread(int t,List l){
				time = t;
				lst = l;
			}
			public void run(){
				lst.clear();
				for(int i=20;i>=1;i--)
				{
					try{
						//Send Thread to sleep mode for mentioned time
						Thread.sleep(time);
					}catch(Exception e){
						System.out.println(e);
					}
					lst.add("Loop Iteration " + i);
				}
			}
	}//End of MyClientThread

} // end class