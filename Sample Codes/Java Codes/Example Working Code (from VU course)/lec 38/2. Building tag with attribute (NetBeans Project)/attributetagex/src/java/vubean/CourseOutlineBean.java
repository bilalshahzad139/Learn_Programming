package vubean;

import java.io.*;

public class CourseOutlineBean implements Serializable {

    private int sessionNo;
    private String topic;
    private String assignment;
// no argument constructor
    public CourseOutlineBean() {
        sessionNo = 0;
        topic = "";
        assignment = "";
    }
// setters
    public void setSessionNo(int s) {
        sessionNo = s;
    }

    public void setTopic(String t) {
        topic = t;
    }

    public void setAssignment(String a) {
        assignment = a;
    }

// getters
    public int getSessionNo() {
        return sessionNo;
    }

    public String getTopic() {
        return topic;
    }

    public String getAssignment() {
        return assignment;
    }
} // end class