<%-- defining error page --%>
<%@page errorPage="addbookerror.jsp" %>
<%@ page import="java.sql.*" %>
<html>
    <body>
        <%-- creating PersonDAO object and storing in page scope --%>
        <jsp:useBean id="pDAO" class="vu.PersonDAO" scope="page" />
        <%-- creating PersonBean object and storing in page scope --%>
        <jsp:useBean id="personBean" class="vu.PersonInfo" scope = "page" />
        <%--
        setting all properties of personBean object with input
        parameters using *
        --%>
        <jsp:setProperty name="personBean" property="*" />
        <%--
        to save Person record into the database, calling addperson
        method of PersonDAO
        --%>
        <%
            pDAO.addPerson(personBean);
        %>
    <center>
        <h3> New Person Record is saved successfully!</h3>
        <h4>
            <a href="addperson.jsp" > Add Person </a>
        </h4>
        <h4>
            <a href="searchperson.jsp" > Search Person </a>
        </h4>
    </center>
</body>
</html>