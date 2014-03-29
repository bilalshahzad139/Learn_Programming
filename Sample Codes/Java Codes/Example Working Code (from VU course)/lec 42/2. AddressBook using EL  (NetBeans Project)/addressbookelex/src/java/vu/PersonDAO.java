package vu;
import java.util.*;
import java.sql.*;
public class PersonDAO{
private Connection con;
// constructor
public PersonDAO() throws ClassNotFoundException , SQLException {
establishConnection();
}
//used to establish connection with database
private void establishConnection()
throws ClassNotFoundException , SQLException
{
// establishing connection
Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
String conUrl = "jdbc:odbc:PersonDSN";
con = DriverManager.getConnection(conUrl);
}
// used to search person records against name
public ArrayList retrievePersonList(String pName)
throws SQLException
{
ArrayList personList = new ArrayList();
String sql = " SELECT * FROM Person WHERE name = ?";
PreparedStatement pStmt = con.prepareStatement(sql);
pStmt.setString( 1, pName);
System.out.println("retrieve person list");
ResultSet rs = pStmt.executeQuery();
String name;
String add;
int pNo;
while ( rs.next() ) {
name = rs.getString("name");
add = rs.getString("address");
pNo = rs.getInt("phoneNumber");

// creating a PersonInfo object
PersonInfo personBean = new PersonInfo();
personBean.setName(name);
personBean.setAddress(add);
personBean.setPhoneNum(pNo);
// adding a bean to arraylist
personList.add(personBean);
} // end while
return personList;
} // end retrievePersonList
//overriding finalize method to release resources
public void finalize( ) {
try{
if(con != null){
con.close();
}
}catch(SQLException sex){
System.out.println(sex);
}
} // end finalize
} // end class