//File: SearchPersonServlet.java
import java.io.*;
import java.net.*;
import javax.servlet.*;
import javax.servlet.http.*;
public class SearchPersonServlet extends HttpServlet {
	protected void processRequest(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		out.println("<html>" +
		"<body>" +
		"<h1> Address Book </h1>" +
		"<form action=showperson >" + // showperson is alias or

		// url pattern of
		// ShowPersonServlet
		"<h2> Enter name to search </h2> <br/>" +
		"<input type=text name=pName /> <br/>" +
		"<input type=submit value=Search Person />" +
		"</form>" +
		"</body>" +
		"</html>");
		out.close();
	}

	// Handles the HTTP GET method.
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		processRequest(request, response);
	}

	// Handles the HTTP POST method.
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		processRequest(request, response);
	}
}