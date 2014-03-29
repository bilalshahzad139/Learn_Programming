<%-- defining error page --%>
<%@page errorPage="addbookerror.jsp" %>
<html>
    <body>
    <center>
        <h2> Address Book </h2>
        <h3> Search Person</h3>
        <form name ="search" method="get" action="controller.jsp" />
        <TABLE BORDER="1" >
            <TR>
                <TD> <h4> Name </h4> </TD>
                <TD> <input type="text" name="name" /> </TD>
            </TR>
            <TR>
                <TD COLSPAN="2" ALIGN="CENTER">
                    <%--
                    The name of the button is still ?action? but with
                    different value ?search?.
                    --%>
                    <input type="submit" name ="action" value="search" />
                    <input type="reset" value="clear" />
                </TD>
            </TR>
        </TABLE>
    </form>
    <h4>
        <%--
        The action parameter with different value ?addperson? are
        part of hyperlink here as well.
        --%>
        <a href="controller.jsp?action=addperson" >
            Add Person
        </a>
    </h4>
</center>
</body>
</html>