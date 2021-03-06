<%@page import="java.util.*" %>
<%-- importing vu package that contains the JavaBeans--%>
<%@page import="vu.*" %>
<html>
    <body>
    <center>
        <h2> Welcome to Java Course </h2>
        <h3> Course Outline</h3>
        <TABLE BORDER="1" >
            <TR>
                <TH>Session No.</TH>
                <TH>Topics</TH>
                <TH>Assignments</TH>
            </TR>
            <%-- start of scriptlet --%>
            <%
            // creating CourseDAO object
                CourseDAO courseDAO = new CourseDAO();
            // calling retrieveCourseList() of CourseDAO class and
            // passing ?java? as value. This method returns ArrayList
                ArrayList courseList = courseDAO.retrieveCourseList("java");
                CourseOutlineBean javaBean = null;
            // iterating over ArrayList to display course outline
                for (int i = 0; i < courseList.size(); i++) {
                    javaBean = (CourseOutlineBean) courseList.get(i);
            %>
            <%-- end of scriptlet --%>
            <TR>
                <TD> <%= javaBean.getSessionNo()%> </TD>
                <TD> <%= javaBean.getTopic()%> </TD>
                <TD> <%= javaBean.getAssignment()%> </TD>
            </TR>
            <%
                } // end for
            %>
        </TABLE >
    </center>
</body>