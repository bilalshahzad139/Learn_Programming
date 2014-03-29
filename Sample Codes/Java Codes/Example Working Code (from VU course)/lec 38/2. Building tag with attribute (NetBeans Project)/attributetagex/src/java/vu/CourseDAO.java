package vu;

import vubean.*;

import java.io.*;
import java.sql.*;
import java.util.*;

public class CourseDAO implements Serializable {

    private Connection con;

    public CourseDAO() {
        establishConnection();
    }
//********** establishConnection method ********************
// method used to make connection with database
    private void establishConnection() {
        try {
// establishing conection
            Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
            String conUrl = "jdbc:odbc:CourseDSN";
            con = DriverManager.getConnection(conUrl);
        } catch (Exception ex) {
            System.out.println(ex);
        }
    }

//*********** retrieveCourseList method ********************
    public ArrayList retrieveCourseList(String cName) {
        ArrayList courseList = new ArrayList();
        try {
            String sql = " SELECT sessionNo, topic, assignment "
                    + " FROM Course, SessionDetail"
                    + " WHERE courseName = ? "
                    + " AND Course.courseId = SessionDetail.courseID ";
            PreparedStatement pStmt = con.prepareStatement(sql);
            pStmt.setString(1, cName);
            ResultSet rs = pStmt.executeQuery();
            int sNo;
            String topic;
            String assignment;
            while (rs.next()) {
                sNo = rs.getInt("sessionNo");
                topic = rs.getString("topic");
                assignment = rs.getString("assignment");
                if (assignment == null) {
                    assignment = "";
                }
// creating a CourseOutlineBean object
                CourseOutlineBean cBean = new CourseOutlineBean();
                cBean.setSessionNo(sNo);
                cBean.setTopic(topic);
                cBean.setAssignment(assignment);
// adding a bean to arraylist
                courseList.add(cBean);
            }
        } catch (Exception ex) {
            System.out.println(ex);
        } finally {
// to close connection
            releaseResources();
        }
// returning ArrayList object
        return courseList;
    } // end retrieveCourseOutline

//********** releaseResources method ********************
    private void releaseResources() {
        try {
            if (con != null) {
                con.close();
            }
        } catch (Exception ex) {
            System.out.println();
        }
    } // end releaseResources
}// end CourseDAO