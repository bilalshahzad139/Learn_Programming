<%-- importing required packages--%>
<%@page import="java.util.*" %>
<%@page import="vu.*" %>
<html>
<body>
<center>
<h2> Address Book </h2>
<h3> Following results meet your search criteria</h3>
<TABLE BORDER="1" >
<TR>
<TH>Name</TH>
<TH>Address</TH>
<TH>PhoneNum</TH>
</TR>
<%-- start of scriptlet --%>
<%
// retrieving ArrayList from request scope
ArrayList personList =(ArrayList)request.getAttribute("plist");
PersonInfo person = null;
for(int i=0; i<personList.size(); i++) {
person = (PersonInfo)personList.get(i);
// storing PersonInfo object in request scope
/* As mentioned, an object must be stored in
some scope to work with Expression Language*/
request.setAttribute("p", person);
%>
<%-- end of scriptlet --%>
<TR>
<%-- accessing properties of stored PersonInfo
object with name ?p? using EL --%>
<TD> ${ p.name } </TD>
<TD> ${ p.address} </TD>
<TD> ${ p.phoneNum} </TD>
<%-- The following expressions are now replaced
by EL statements written above--%>
<%-- <%= person.getName()%> --%>
<%-- <%= person.getAddress()%> --%>
<%-- <%= person.getPhoneNum()%> --%>
</TR>
<%
} // end for
%>
</TABLE >
</center>
</body>
</html>