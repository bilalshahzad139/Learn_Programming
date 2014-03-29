import java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class MyServlet extends HttpServlet {

    public void doGet(HttpServletRequest req,
            HttpServletResponse res)
            throws ServletException, IOException {
// reading first name parameter/textfield
        String fName = req.getParameter("firstName");
// reading surname parameter/textfield
        String sName = req.getParameter("surName");
// gettting stream from HttpServletResponse object
        PrintWriter out = res.getWriter();
        out.println("Hello: " + fName + " " + sName);
        out.close();
    }
}// end FormServlet