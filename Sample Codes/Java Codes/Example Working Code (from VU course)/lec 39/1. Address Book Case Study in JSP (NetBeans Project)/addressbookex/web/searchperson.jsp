<%-- defining error page --%>
<%@page errorPage="addbookerror.jsp" %>
<html>
    <body>
    <center>
        <h2> Address Book </h2>
        <h3> Search Person</h3>
        <%--
        Form that contains Text input field and sending it to
        showperson.jsp
        --%>
        <form name ="search" action="showperson.jsp" />
        <TABLE BORDER="1" >
            <TR>
                <TD> <h4 >Name</h4> </TD>
                <TD> <input type="text" name="name" /> </TD>
            </TR>
            <TR>
                <TD COLSPAN="2" ALIGN="CENTER"">
                    <input type="submit" value="search" />
                    <input type="reset" value="clear" />
                </TD>
            </TR>
        </TABLE>
    </form>
    <h4>
        <a href="addperson.jsp" > Add Person </a>
    </h4>
</center>
</body>
</html>