package vu;

import java.util.*;
import java.sql.*;

public class PersonDAO {

    private Connection con;
// default constructor
    public PersonDAO() throws ClassNotFoundException, SQLException {
        establishConnection();
    }
// method used to establish connection with db
    private void establishConnection() throws ClassNotFoundException,
            SQLException {
// establishing conection
        Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
        String conUrl = "jdbc:odbc:PersonDSN";
        con = DriverManager.getConnection(conUrl);
    }
// used to search the person records against name and returns
// the ArrayList that contains only those PersonInfo objects
// which matches the search criteria i.e. name
    public ArrayList retrievePersonList(String pName) throws
            SQLException {
        ArrayList personList = new ArrayList();
// preparing query
        String sql = " SELECT * FROM Person WHERE name = ?";

        PreparedStatement pStmt = con.prepareStatement(sql);
        pStmt.setString(1, pName);
// executing query
        ResultSet rs = pStmt.executeQuery();
        String name;
        String add;
        int pNo;
        while (rs.next()) {
            name = rs.getString("name");
            add = rs.getString("address");
            pNo = rs.getInt("phoneNumber");
// creating a CourseOutlineBean object
            PersonInfo personBean = new PersonInfo();
            personBean.setName(name);
            personBean.setAddress(add);
            personBean.setPhoneNum(pNo);
// adding a bean to arraylist
            personList.add(personBean);
        } // end while
        return personList;
    } // end retrievePersonList
// this method accepts an object of PersonInfo, and stores it into
// the database
    public void addPerson(PersonInfo person) throws SQLException {
        String sql = " INSERT INTO Person(name, address, phoneNumber) VALUES (?, ?, ?)";
        PreparedStatement pStmt = con.prepareStatement(sql);
        String name = person.getName();
        String add = person.getAddress();
        int pNo = person.getPhoneNum();
        pStmt.setString(1, name);
        pStmt.setString(2, add);
        pStmt.setInt(3, pNo);
        pStmt.executeUpdate();
    } // end addPerson

// overriding finalize method to release acquired resources
    public void finalize() {
        try {
            if (con != null) {
                con.close();
            }
        } catch (SQLException sqlex) {
            System.out.println(sqlex);
        }
    } // end finalize
} // end PersonDAO class