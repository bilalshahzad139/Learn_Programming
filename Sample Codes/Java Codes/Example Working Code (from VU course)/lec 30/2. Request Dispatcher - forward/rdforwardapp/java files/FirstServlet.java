import java.io.*;
import java.net.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class FirstServlet extends HttpServlet {
// this method is being called by both doGet() and doPost()
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
// getting value of salary text filed of the HTML form
        String salary = request.getParameter("salary");
// converting it to the integer.
        int sal = Integer.parseInt(salary);
// calculating 15% tax
        int tax = (int) (sal * 0.15);
// converting tax into string
        String taxValue = tax + "";
// request object can store values in key-value form, later it
// can be retrieved by using getAttribute() method
        request.setAttribute("tax", taxValue);
// getting object of servletContext
        ServletContext sContext = getServletContext();
// getting object of request dispatcher
        RequestDispatcher rd =
                sContext.getRequestDispatcher("/secondservlet");
// calling forward method of request dispatcher
        rd.forward(request, response);
    }
// This method is calling processRequest()
    protected void doGet(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }
// This method is calling processRequest()
    protected void doPost(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }
}