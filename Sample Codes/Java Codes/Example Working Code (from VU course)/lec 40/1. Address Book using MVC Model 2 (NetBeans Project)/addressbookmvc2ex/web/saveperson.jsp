<%-- defining error page --%>
<%@page errorPage="addbookerror.jsp" %>
<html>
    <body>
    <center>
        <h3> New Person Record is saved successfully!</h3>
        <h4>
            <a href="controller.jsp?action=addperson" >
                Add Person
            </a>
        </h4>
        <h4>
            <a href="controller.jsp?action=searchperson" >
                Search Person
            </a>
        </h4>
    </center>
</body>
</html>