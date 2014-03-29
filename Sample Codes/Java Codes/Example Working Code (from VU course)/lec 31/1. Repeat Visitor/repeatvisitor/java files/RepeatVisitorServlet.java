import java.io.*;
import java.net.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class RepeatVisitorServlet extends HttpServlet {
// Handles the HTTP <code>GET</code> method.
    protected void doGet(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }
// Handles the HTTP <code>POST</code> method.
    protected void doPost(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }
// called from both doGet() & doPost()
    protected void processRequest(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html");
        PrintWriter out = response.getWriter();
// writing html
        out.println("<html>");
        out.println("<body>");
        out.println("<h2>Cookie Example </h2>");
        String msg = "";
        boolean repeatVisitor = false;
// reading cookies
        Cookie[] cookies = request.getCookies();
// if cookies are returned from request object
        if (cookies != null) {
//search for cookie -- repeat
            for (int i = 0; i < cookies.length; i++) {
// retrieving one cookie out of array
                Cookie c = cookies[i];
// retrieving name & value of the cookie
                String name = c.getName();
                String val = c.getValue();
// confirming if cookie name equals "repeat" and
// value equals "yes"
                if (name.equals("repeat") && val.equals("yes")) {
                    msg = "Welcome Back";
                    repeatVisitor = true;
                    break;
                }
            } // end for
        } // end if
// if no cookie with name "repeat" is found
        if (repeatVisitor == false) {
// create a new cookie
            Cookie c1 = new Cookie("repeat", "yes");
// setting time after which cookies expires
            c1.setMaxAge(60);
// adding cookie to the response
            response.addCookie(c1);
            msg = "Welcome Aboard";
        }
// displaying message value
        out.println("<h2>" + msg + "</h2>");
        out.println("</body>");
        out.println("</html>");
        out.close();
    }
}// end RepeatVisitorServlet