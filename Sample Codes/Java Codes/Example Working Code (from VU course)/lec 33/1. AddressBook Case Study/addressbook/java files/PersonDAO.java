//File: PersonDAO.java
import java.sql.*;
public class PersonDAO {
// method searchPerson
public PersonInfo searchPerson(String sName){
PersonInfo person = null;
try {
Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
String url = "jdbc:odbc:AddressBookDSN";
Connection con = DriverManager.getConnection(url);
String sql = "SELECT * FROM Person WHERE name = ?";
PreparedStatement pStmt = con.prepareStatement(sql);
pStmt.setString(1, sName);
ResultSet rs = pStmt.executeQuery();
if (rs.next( ) ) {
String name = rs.getString("name");
String add = rs.getString("address");
String pNum = rs.getString("phoneNum");
person = new PersonInfo(name, add, pNum);
}
con.close();
}catch(Exception ex){
System.out.println(ex);
}
return person;
}// end method
}