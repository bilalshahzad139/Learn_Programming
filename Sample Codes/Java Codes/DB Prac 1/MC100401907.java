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

//Class which will display our first screen ,Login
class MainDisplayScreen{

	//Declare Class Members
	JFrame frame;
	JLabel lblLogin, lblPassword;
    JTextField txtLogin;
    JPasswordField txtPassword;
	JButton btnSignin;

	public void initGUI(){
		frame = new JFrame();
		frame.setTitle("Administrator");

		lblLogin = new JLabel("Login Name:");
		lblLogin.setBounds(20,30,100,30);

		txtLogin = new JTextField(15);
		txtLogin.setBounds(110,30,100,30);

		lblPassword = new JLabel("Password:");
		lblPassword.setBounds(20,70,100,30);

        txtPassword = new JPasswordField(15);
        txtPassword.setBounds(110,70,100,30);

		btnSignin = new JButton("Sign In");
		btnSignin.setBounds(100,110,100,30);

		btnSignin.addActionListener(new ButtonActionHandler());

		Container cont = frame.getContentPane();
		cont.setLayout(null);
		cont.add(lblLogin);
		cont.add(txtLogin);
		cont.add(lblPassword);
		cont.add(txtPassword);
		cont.add(btnSignin);

		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setBounds(100,110,300,300);
        frame.setVisible(true);

	}
	public MainDisplayScreen(){
		initGUI();
	}

	public class ButtonActionHandler implements ActionListener{
		public void actionPerformed(ActionEvent event) {
			try{
				if (event.getSource() == btnSignin) {
					String userName = txtLogin.getText();
					String password = txtPassword.getText();
					DBHandler dal = new DBHandler();
					Boolean flag = dal.VerifyLogin(userName,password);
					if(flag == true)
					{
						frame.setVisible(false);
						new ProductsScreen();
					}
					else {
						JOptionPane.showMessageDialog(null,"Username or Password is incorrect");
					}
				}//end of if
			}catch(Exception e){}
		}//end of actionPerformed
	}//end of ButtonActionHandler
}

//To create Products/View products screen
class ProductsScreen
{
	//Declare Class Members
	JFrame frame;
	JLabel lblProdID, lblProdName,lblCat,lblPrice,lblAvail,lblQty,lblDesc;

	JTextField txtProdID,txtProdName,txtPrice,txtQty;
	JComboBox cmbCat;
	JRadioButton chkYes,chkNo;
	JTextArea txtDesc;

	JLabel lblProdIDSearch,lblProdID1, lblProdName1,lblCat1,lblPrice1,lblAvail1,lblQty1,lblDesc1;

	JTextField txtProdIDSearch,txtProdID1,txtProdName1,txtCat1,txtPrice1,txtAvail1,txtQty1;
	JTextArea txtDesc1;

	JButton btnSave,btnReset,btnSearch,btnReset1;
	JTabbedPane tabs=new JTabbedPane();

	public void initGUI(){
		frame = new JFrame();
		frame.setTitle("");
		JPanel panel=new JPanel();
		panel.setOpaque(false);
		panel.setLayout(null);

		tabs.addTab("Products", panel);//add a tab for the panel with the title


		//Container cont = frame.getContentPane();
		//cont.setLayout(null);

		lblProdID = new JLabel("Product ID:");
		lblProdID.setBounds(20,30,100,20);
		txtProdID = new JTextField(15);
		txtProdID.setBounds(110,30,100,20);
		panel.add(lblProdID);
		panel.add(txtProdID);

		lblProdName = new JLabel("Product Name:");
		lblProdName.setBounds(20,60,100,20);
		txtProdName = new JTextField(15);
		txtProdName.setBounds(110,60,100,20);
		panel.add(lblProdName);
		panel.add(txtProdName);

		lblCat = new JLabel("Product Name:");
		lblCat.setBounds(20,90,100,20);
		cmbCat = new JComboBox();
		cmbCat.addItem("Handouts");
		cmbCat.addItem("CDs");
		cmbCat.addItem("Computers");

		cmbCat.setBounds(110,90,100,20);
		panel.add(lblCat);
		panel.add(cmbCat);

		lblPrice = new JLabel("Price:");
		lblPrice.setBounds(20,120,100,20);
		txtPrice = new JTextField(15);
		txtPrice.setBounds(110,120,100,20);
		panel.add(lblPrice);
		panel.add(txtPrice);

		ButtonGroup bg = new ButtonGroup();

		lblAvail = new JLabel("Available:");
		lblAvail.setBounds(20,150,100,20);
		chkYes = new JRadioButton("Yes");
		chkYes.setBounds(110,150,50,20);
		chkYes.setSelected(true);
		chkNo = new JRadioButton("No");
		chkNo.setBounds(160,150,50,20);
		bg.add(chkYes);
		bg.add(chkNo);
		panel.add(lblAvail);
		panel.add(chkYes);
		panel.add(chkNo);

		lblQty = new JLabel("Quantity:");
		lblQty.setBounds(20,180,100,20);
		txtQty = new JTextField(15);
		txtQty.setBounds(110,180,100,20);
		panel.add(lblQty);
		panel.add(txtQty);

		lblDesc = new JLabel("Description:");
		lblDesc.setBounds(20,210,100,20);
		txtDesc = new JTextArea(5,5);
		txtDesc.setBounds(110,210,100,60);
		panel.add(lblDesc);
		panel.add(txtDesc);

		btnSave = new JButton("Save");
		btnSave.setBounds(50,280,100,30);
		btnReset = new JButton("Reset");
		btnReset.setBounds(160,280,100,30);
		panel.add(btnSave);
		panel.add(btnReset);
		btnSave.addActionListener(new ButtonActionHandler());
		btnReset.addActionListener(new ButtonActionHandler());



		JPanel searchPanel = GetSearchProdPanel();
		tabs.addTab("View Products", searchPanel);

		frame.setContentPane(tabs);

		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setBounds(100,110,500,400);
		frame.setVisible(true);

	}

	public JPanel GetSearchProdPanel()
	{
		JPanel panel=new JPanel();
		panel.setOpaque(false);
		panel.setLayout(null);


		lblProdIDSearch = new JLabel("Enter Product ID:");
		lblProdIDSearch.setBounds(50,30,100,20);
		txtProdIDSearch = new JTextField(15);
		txtProdIDSearch.setBounds(170,30,100,20);
		panel.add(lblProdIDSearch);
		panel.add(txtProdIDSearch);

		btnSearch = new JButton("Search");
		btnSearch.setBounds(70,60,100,30);
		btnReset1 = new JButton("Reset");
		btnReset1.setBounds(180,60,100,30);
		panel.add(btnSearch);
		panel.add(btnReset1);
		btnSearch.addActionListener(new ButtonActionHandler());
		btnReset1.addActionListener(new ButtonActionHandler());

		lblProdID1 = new JLabel("Product ID:");
		lblProdID1.setBounds(20,150,100,20);
		txtProdID1 = new JTextField(15);
		txtProdID1.setBounds(90,150,100,20);
		panel.add(lblProdID1);
		panel.add(txtProdID1);


		lblProdName1 = new JLabel("Product Name:");
		lblProdName1.setBounds(200,150,100,20);
		txtProdName1 = new JTextField(15);
		txtProdName1.setBounds(290,150,100,20);
		panel.add(lblProdName1);
		panel.add(txtProdName1);

		//Label l,lblAvail1,lblQty1,lblDesc1;

		//JTextField ,txtAvail1,txtQty1;
		//JTextArea txtDesc1;


		lblCat1 = new JLabel("Category:");
		lblCat1.setBounds(20,180,100,20);
		txtCat1 = new JTextField(15);
		txtCat1.setBounds(90,180,100,20);
		panel.add(lblCat1);
		panel.add(txtCat1);


		lblPrice1 = new JLabel("Price:");
		lblPrice1.setBounds(200,180,100,20);
		txtPrice1 = new JTextField(15);
		txtPrice1.setBounds(290,180,100,20);
		panel.add(lblPrice1);
		panel.add(txtPrice1);

		lblAvail1 = new JLabel("Availability:");
		lblAvail1.setBounds(20,210,100,20);
		txtAvail1 = new JTextField(15);
		txtAvail1.setBounds(90,210,100,20);
		panel.add(lblAvail1);
		panel.add(txtAvail1);


		lblQty1 = new JLabel("Quantity:");
		lblQty1.setBounds(200,210,100,20);
		txtQty1 = new JTextField(15);
		txtQty1.setBounds(290,210,100,20);
		panel.add(lblQty1);
		panel.add(txtQty1);

		lblDesc1 = new JLabel("Description:");
		lblDesc1.setBounds(20,240,100,20);
		txtDesc1 = new JTextArea(5,5);
		txtDesc1.setBounds(90,240,200,60);
		panel.add(lblDesc1);
		panel.add(txtDesc1);

		ShowHideSearchFields(false);

		return panel;
	}

	public void ShowHideSearchFields(Boolean flag)
	{

		lblProdID1.setVisible(flag);
		lblProdName1.setVisible(flag);
		lblCat1.setVisible(flag);
		lblPrice1.setVisible(flag);
		lblAvail1.setVisible(flag);
		lblQty1.setVisible(flag);
		lblDesc1.setVisible(flag);

		txtProdID1.setVisible(flag);
		txtProdName1.setVisible(flag);
		txtCat1.setVisible(flag);
		txtPrice1.setVisible(flag);
		txtAvail1.setVisible(flag);
		txtQty1.setVisible(flag);
		txtDesc1.setVisible(flag);

	}

	public ProductsScreen(){
		initGUI();
	}
	public void ClearForm()
	{
		txtProdID.setText("");
		txtProdName.setText("");
		cmbCat.setSelectedIndex(0);
		txtPrice.setText("");
		chkYes.setSelected(true);
		chkNo.setSelected(false);
		txtQty.setText("");
		txtDesc.setText("");

	}
	public class ButtonActionHandler implements ActionListener{
			public void actionPerformed(ActionEvent event) {
				try{
					if (event.getSource() == btnReset1) {
							txtProdIDSearch.setText("");
							ShowHideSearchFields(false);
					}
					else if (event.getSource() == btnSearch) {
							DBHandler dal = new DBHandler();
							String prodId = txtProdIDSearch.getText();
							if(prodId.equals(""))
							{
								JOptionPane.showMessageDialog(null,"Product ID is missing");
								ShowHideSearchFields(false);
								return;
							}
							Product prod = dal.SearchProduct(prodId);

							if(prod != null)
							{
								txtProdID1.setText(prod.ProductID);
								txtProdName1.setText(prod.ProductName);
								txtCat1.setText(prod.Category);
								txtPrice1.setText(prod.Price);
								txtAvail1.setText(prod.Availability);
								txtQty1.setText(prod.Quantity);
								txtDesc1.setText(prod.Description);
								ShowHideSearchFields(true);
							}
							else {
								ShowHideSearchFields(false);
								JOptionPane.showMessageDialog(null,"Incorrect Product ID");
							}


					}
					else if (event.getSource() == btnReset) {
						ClearForm();
					}
					else if (event.getSource() == btnSave) {
						System.out.println("save clicked");
						Product prodObj = new Product();

						prodObj.ProductID = txtProdID.getText();
						prodObj.ProductName = txtProdName.getText();
						prodObj.Category = String.valueOf(cmbCat.getSelectedItem());
						prodObj.Price = txtPrice.getText();


						prodObj.Availability = "No";
						if(chkYes.isSelected())
							prodObj.Availability = "Yes";

						prodObj.Quantity = txtQty.getText();
						prodObj.Description = txtDesc.getText();

						DBHandler dal = new DBHandler();
						Boolean flag = true;
						flag = dal.SaveProduct(prodObj);
						if(flag == true)
						{
							JOptionPane.showMessageDialog(null,"Record is added successfully");
							ClearForm();

						}
						else {
							JOptionPane.showMessageDialog(null,"Unable to save record");
						}
					}//end of if
				}catch(Exception e){}
			}//actionPerformed
	}//end of ButtonActionHandler class

}//end of ProductsScreen class

//Class to handle database operations
class DBHandler{

	Connection con;
	public DBHandler()
	{
	}
	public Connection GetConnection(){
		try{
			Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
			Connection con = DriverManager.getConnection("jdbc:odbc:productDSN");
			return con;
		}
		catch(Exception e)
		{
			return null;
		}
	}
	//Check login data
	public Boolean VerifyLogin(String username,String password) throws Exception
	{
		try{
			System.out.println(username + " " + password);

			con = GetConnection();

			String sql = "SELECT * FROM admin WHERE userName='" + username +"' and password='"+ password +"'";
			System.out.println(sql);

			Statement stmt = con.createStatement();
			ResultSet rs = stmt.executeQuery(sql);
			int count=0;
			while(rs.next()){
				count++;
			}

			if(count > 0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		catch(Exception ex)
		{
			System.out.println(ex.toString());
			return false;
		}
		finally
		{
			if(con != null)
				con.close();
		}
	}

	//Save product
	public Boolean SaveProduct(Product prod) throws Exception
	{
		try{

			con = GetConnection();

			String sql = "INSERT INTO product(Id, productName, category, price, availability, quantity, description) Values('"+prod.ProductID+"','"+prod.ProductName+"','"+prod.Category+"','"+prod.Price+"','"+prod.Availability+"','"+prod.Quantity+"','"+prod.Description+"')";
			System.out.println(sql);

			Statement stmt = con.createStatement();

			System.out.println("Executing Query");
			int id = stmt.executeUpdate(sql);

			return true;

		}
		catch(Exception ex)
		{
			System.out.println(ex.toString());
			return false;
		}
		finally
		{
			if(con != null)
				con.close();
		}

	}


	//Search product
	public Product SearchProduct(String prodId) throws Exception
	{
		Product prod = null;

		try{

			con = GetConnection();

			String sql = "Select * from product where ProductID='" +prodId+ "'";
			System.out.println(sql);

			Statement stmt = con.createStatement();

			System.out.println("Executing Query");
			ResultSet rs = stmt.executeQuery(sql);

			if(rs.next())
			{
				prod = new Product();
				prod.ProductID = rs.getString("Id");
				prod.ProductName = rs.getString("productName");
				prod.Category = rs.getString("category");
				prod.Price = rs.getString("price");
				prod.Availability = rs.getString("availability");
				prod.Quantity = rs.getString("quantity");
				prod.Description = rs.getString("description");
			}

			return prod;

		}
		catch(Exception ex)
		{
			System.out.println(ex.toString());
			return prod;
		}
		finally
		{
			if(con != null)
				con.close();
		}
	}
}

//Class to hold product object
class Product
{
	public String ProductID;
	public String ProductName;
	public String Category;
	public String Price;
	public String Availability;
	public String Quantity;
	public String Description;

}

