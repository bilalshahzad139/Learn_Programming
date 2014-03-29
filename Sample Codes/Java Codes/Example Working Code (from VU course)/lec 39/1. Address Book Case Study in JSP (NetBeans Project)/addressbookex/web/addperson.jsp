<%--
Although there are no chances of exception to arise on this page,
for consistency, error page is defined on top of all JSPs
--%>
<%@page errorPage="addbookerror.jsp" %>
<html>
<body>
<center>
<h2> Address Book </h2>
<h3> Add New Person</h3>
<%-- Form that contains Text input fields and sending it to
saveperson.jsp
--%>
<form name ="register" method="get" action="saveperson.jsp" />
<TABLE BORDER="1" >
<TR>
<TD> <h4 > Name </h4> </TD>
<TD> <input type="text" name="name" /> </TD>
</TR>
<TR>
<TD> <h4> Address </h4> </TD>
<TD> <input type="text" name="address" /> </TD>
</TR>
<TR>
<TD> <h4>Phone Number</h4> </TD>
<TD> <input type="text" name="phoneNum" /> </TD>
</TR>
<TR>
<TD COLSPAN="2" ALIGN="CENTER" >
<input type="submit" value="save" />
<input type="reset" value="clear" />
</TD>
</TR>
</TABLE>
</form>
<h4>
<%-- A link to searchperson.jsp --%>
<a href="searchperson.jsp" > Search Person </a>
</h4>
</center>
</body>
</html>