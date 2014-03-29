/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package vutag;
import vubean.*;
import vu.*;

import java.util.*;
import javax.servlet.jsp.*;
import javax.servlet.jsp.tagext.*;


/**
 *
 * @author Administrator
 */
public class MyTagHandler extends SimpleTagSupport {
    private String pageName;

    /**
     * Called by the container to invoke this tag. The implementation of this
     * method is provided by the tag library developer, and handles all tag
     * processing, body iteration, etc.
     */
    @Override
    public void doTag() throws JspException {
        CourseDAO courseDAO = new CourseDAO();
ArrayList courseList = courseDAO.retrieveCourseList(pageName);
// to display course outline in tabular form, this method is
// used – define below
display(courseList);
    }

    public void setPageName(String pageName) {
        this.pageName = pageName;
    }
    
    /**
* display method used to print courseoutline in tabular form
*/
private void display(ArrayList courseList)throws JspException{
PageContext pc = (PageContext)getJspContext();
JspWriter out = pc.getOut();
try{
// displaying table headers
out.print("<TABLE BORDER=1 >");
out.print("<TR>");
out.print("<TH> Session No </TH>");
out.print("<TH> Topic </TH>");
out.print("<TH> Assignment </TH>");
out.print("</TR>");
// loop to iterate over courseList
for (int i=0; i<courseList.size(); i++){
CourseOutlineBean courseBean =
(CourseOutlineBean)courseList.get(i);
// displaying one row
out.print("<TR>");
out.print("<TD>" + courseBean.getSessionNo() + "</TD>");
out.print("<TD>" + courseBean.getTopic() + "</TD>");
out.print("<TD>" + courseBean.getAssignment() + "</TD>");
out.print("</TR>");
}
out.print("</TABLE>");
}catch(java.io.IOException ex){
throw new JspException(ex.getMessage());
}
}
}
