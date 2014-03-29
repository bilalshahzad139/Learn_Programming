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
        <%--
        As mentioned in MVC2, all the requests are submitted to
        controller, that?s why action?s contains the value of
        ?controller.jsp?
        --%>
        <form name ="register" action="controller.jsp" />
        <TABLE BORDER="1" >
            <TR>
                <TD> <h4> Name </h4> </TD>
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
                <TD COLSPAN="2" ALIGN="CENTER"">
                    <%--
                    As described above the technique to differentiate
                    between the requests, the name of the button is
                    ?action? with value ?save?.
                    --%>
                    <input type="submit" name ="action" value="save" />
                    <input type="reset" value="clear" />
                </TD>
            </TR>
        </TABLE>
    </form>

    <h4>
        <%--
        The hyperlink will also sends the request to controller
        Note the action parameter with its value are also part of
        hyperlink using the query string technique.
        --%>
        <a href="controller.jsp?action=searchperson" >
            Search Person
        </a>
    </h4>
</center>
</body>
</html>