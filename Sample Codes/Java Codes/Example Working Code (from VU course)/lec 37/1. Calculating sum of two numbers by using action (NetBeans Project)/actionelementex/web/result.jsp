<%-- importing vu package that contains the SumBean --%>
<%@page import="vu.*"%>
<html>
    <body>
        <h2>The sum is:
            <%-- instantiating bean using action element -- %>
            <%--
            //Servlet equivalent code of useBean
            SumBean sBean = new SumBean();
            --%>
            <jsp:useBean id="sBean" class="vu.SumBean" scope="page"/>
            <%-- setting firstNumber property of sBean
            using action elements
            -- %>
            <%-- implicit conversion from string to int as num1 is of type
            String and firstNumber is of type int
            --%>
            <%--
            //Servlet equivalent code of setProperty for num1
            int no = Integer.parseInt(request.getParameter("num1"));
            sBean.setFirstNumber(no);
            --%>
            <jsp:setProperty name="sBean"
                             property="firstNumber" param="num1" />
            <%--
            //Servlet equivalent code of setProperty for num2
            int no = Integer.parseInt(request.getParameter("num2"));
            sBean.setSecondNumber(no);
            --%>
            <jsp:setProperty name="sBean"
                             property="secondNumber" param="num2" />
            <%
            // calling calculateSum() method that will set the value of
            // sum attribute
                sBean.calculateSum();
            %>
            <%--
            // servlet equivalent code of displaying sum
            int res = sBean.getSum();
            out.println(res);
            --%>
            <jsp:getProperty name="sBean" property="sum" />
        </h2>
    </body>
</html>