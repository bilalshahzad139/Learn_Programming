//Studetn ID: MC100401907
//Requuired Packages
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.util.*;
import javax.swing.table.*;
import java.sql.*;

// Main class to show the screen
public class MC100401907{
	public static void main(String[] args){
		try{
			MainDisplayScreen screeNobj = new MainDisplayScreen();
		} catch(Exception e){
			System.out.println(e);
		}
	}
}//End of MC100401907 Class

//Class which will display our basic Layout
class MainDisplayScreen extends JFrame{

	//Declare Class Members
	private JTable jtDataContainer;
	private JScrollPane jtScrollPane;
	private java.util.List<JCheckBox> chkboxListObj = new ArrayList<JCheckBox>();

	DefaultTableModel jtModelObj;

	//constructor, Intitialze form elements
	public MainDisplayScreen(){
		this.setTitle("Assignment 2 (CS506)");
		this.setSize(500,500);
		//Set flow layout
		this.setLayout(new FlowLayout());
		//Panel to show checkboxes
		JPanel mainPanelObj = new JPanel();
		mainPanelObj.setLayout(new BorderLayout());

		/*Add Checkboxes on the screen */
		JPanel chkboxPanel = new JPanel();
		chkboxPanel.setPreferredSize(new Dimension(400,100));
		chkboxPanel.setBorder(BorderFactory.createTitledBorder("Grades Selection"));
		Box boxObj = Box.createHorizontalBox();
		chkboxListObj.add(new JCheckBox("A"));
		chkboxListObj.add(new JCheckBox("B"));
		chkboxListObj.add(new JCheckBox("C"));
		chkboxListObj.add(new JCheckBox("D"));
		chkboxListObj.add(new JCheckBox("F"));

		//Attach event listener to checkboxes
		for(JCheckBox cbObj: chkboxListObj){
			cbObj.addItemListener(new ChkBoxStateChangeListener());
			boxObj.add(cbObj);
		}
		chkboxPanel.add(boxObj);
		//-----------------------------------

		/*Add JTAble on the screen */
		JPanel jtPanel = new JPanel();
		//Define columns of JTable
		String jtColumns[] = {"ID","Name","Subject","Class","Grades","Address"};
		String result[][] = {{}};
		//Create default model and this will be used to add rows at later time
		jtModelObj = new DefaultTableModel(result,jtColumns);
		//Create JTable object with created jtModelObj
		jtDataContainer = new JTable(jtModelObj);
		//Add Scroll panel for jTable
		jtScrollPane = new JScrollPane(jtDataContainer);
		jtScrollPane.setAutoscrolls(true);
		jtScrollPane.setPreferredSize(new Dimension(400,200));
		jtPanel.add(jtScrollPane);
		//-----------------------------------

		JPanel formElements = new JPanel();
		formElements.setLayout(new BoxLayout(formElements, BoxLayout.Y_AXIS));
		formElements.add(chkboxPanel);
		formElements.add(jtPanel);

		mainPanelObj.add(formElements,BorderLayout.CENTER);
		Container con = this.getContentPane();
		con.add(mainPanelObj);
		this.setVisible(true);
		this.setResizable(false);
	}//end constructor

	//data base connection function
	public void LoadSearchResult(String s){
	try{
		//Create connection using DSN
		Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
		Connection con = DriverManager.getConnection("jdbc:odbc:myDSN");
		//Query
		String sql = "SELECT * FROM Students WHERE Grades IN("+s+") ";
		//Create statement which will be used execute the query
		Statement stmt = con.createStatement();
		ResultSet rs = stmt.executeQuery(sql);
		//Iterate the result until resultset is finished
		while(rs.next()){
			String sid = rs.getString("ID");
			String sname = rs.getString("Name");
			String sub = rs.getString("Subject");
			String cl = rs.getString("Class");
			String gr = rs.getString("Grades");
			String add = rs.getString("Address");
			//add rows to model (which was attached to JTable)
			jtModelObj.insertRow(0, new Object[]{sid, sname, sub, cl, gr, add});
		}
		//Close the connection
		con.close();
		} catch(Exception e){
			System.out.println(e);
		}
	}//end of LoadSearchResult function

	//ChkBoxStateChangeListener Inner Class to handler itemlisteners for checkboxes
		class ChkBoxStateChangeListener implements ItemListener{
			//Handlre function
			public void itemStateChanged(ItemEvent event){
				String subStr = "";
				for(JCheckBox box: chkboxListObj){
					if(box.isSelected()){
						subStr += "'" + box.getText() + "'" + ",";
					}
				}
				//Clear the old result
				jtModelObj.setRowCount(0);

				if (!subStr.equals("")){
					if(subStr.length() > 0)
					{
						subStr = subStr.substring(0, subStr.length()-1);
					}
					//Load Data from Database against selected Grades
					LoadSearchResult(subStr);
				}
			}
	}// end ChkBoxStateChangeListener class
}

