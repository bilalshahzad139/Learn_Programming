<%-- defining error page --%>
<%@page errorPage="addbookerror.jsp" %>
<%-- importing required packages --%>
<%@page import="java.util.*" %>
<%@page import="vu.*" %>
<html>
<body>
<center>
<h2> Address Book </h2>
<h3> Following results meet your search criteria</h3>
<TABLE BORDER="1" >
<TR>
<TH> Name </TH>
<TH> Address </TH>
<TH> PhoneNum </TH>
</TR>
<jsp:useBean id="pDAO" class="vu.PersonDAO" scope="page" />
<%
// getting search criteria sent by searchperson.jsp
String pName = request.getParameter("name");
// retrieving matching records from the Database using
// retrievePersonList() method of PersonDAO
ArrayList personList = pDAO.retrievePersonList(pName);
PersonInfo person = null;
// Showing all matching records by iterating over ArrayList
for(int i=0; i<personList.size(); i++) {
person = (PersonInfo)personList.get(i);
%>
<TR>
<TD> <%= person.getName()%> </TD>
<TD> <%= person.getAddress()%> </TD>
<TD> <%= person.getPhoneNum()%> </TD>
</TR>
<%
} // end for
%>
</TABLE >
<a href="addperson.jsp" > Add Person </a> <br />

<a href="searchperson.jsp" > Search Person </a>
</center>
</body>
</html>