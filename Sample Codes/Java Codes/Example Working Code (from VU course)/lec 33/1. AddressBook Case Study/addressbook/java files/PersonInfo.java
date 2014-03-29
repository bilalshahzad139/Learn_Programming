//File: PerosnInfo.java
public class PersonInfo {
String name;
String address;
String phoneNum;
public PersonInfo(String n, String a, String pn) {
name = n;
address = a;
phoneNum = pn;
}
public String toString( ){
return "Name: " + name + " Address: " + address +
" Phone No: " + phoneNum;
}
}// end class PersonInfo