<HTML>
    <HEAD>
        <!-- start of scripting code and mentioning type -->
        <SCRIPT TYPE = "text/javascript">
            /* defining a function that receives form’s reference, defined
        inside the body and returns false if any requirement violated
             */
            function validateForm(thisform) {
                /* checking the value of the name field, if it is left empty
        then displaying a message
                 */
                if (thisform.name.value == null || thisform.name.value == "")
                {
                    alert("Username is required");
                    return false;
                }
                // if value of age is negative, displaying a message 
                if (thisform.age.value < 0 )
                {
                    alert("Age can't be negative");
                    return false;
                }
            } // end of function
        </SCRIPT> 
        <!--end of script -->
        </HEAD>
        <BODY>
        <!-- validateForm method is called and specified as a value of
        onsubmit value, if this method returns false, the user remains
        on the same page -->
    <FORM method="post" onsubmit="return validateForm(this)" action = "greeting.jsp" >
        <h2> Client Side Validation Example </h2>
        <BR/>
        Name: <INPUT type="text" name="name" size="30" />
        <BR/> <BR/>
        Age: <INPUT type="text" name="age" size="30" />
        <BR/> <BR/>
        <INPUT type="submit" value="Submit">
    </FORM>
</BODY>
</HTML>