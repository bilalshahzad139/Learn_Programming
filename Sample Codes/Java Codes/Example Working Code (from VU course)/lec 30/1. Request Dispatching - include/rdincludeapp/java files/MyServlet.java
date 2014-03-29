import java.io.*;
import java.net.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class MyServlet extends HttpServlet {
    /*
     * this method is being called by both doGet() and doPost().We usually
     * follow this practice, when we are not sure about the type of incoming
     * request to the servlet. So the actual processing is being done in the
     * processRequest().
     */

    protected void processRequest(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html");
        PrintWriter out = response.getWriter();
        out.println("<html>");
        out.println("<body>");
        out.println("<h1>Start of include request </h1>");
        out.flush();
// getting the object of ServletContext, that will be used to
// obtain the object of RequestDispacther
        ServletContext context = getServletContext();
// getting the object of RequestDispatcher by passing the path
// of included resource as a parameter
        RequestDispatcher rd =
                context.getRequestDispatcher("/includeservlet");
// calling include method of RequestDispatcher by passing
// request and response objects as parameters. This will execute
//the second servlet and include its output in the first servlet
        rd.include(request, response);
        /*
         * the statements below will be executed after including the output of
         * the /includeservlet
         */
        out.println("<h1>End of include request </h1>");
        out.println("</body>");
        out.println("</html>");
// closing PrintWriter stream
        out.close();
    }
// This method only calls processRequest()
    protected void doGet(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }
// This method only calls processRequest()
    protected void doPost(HttpServletRequest request,
            HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }
} // end MyServlet