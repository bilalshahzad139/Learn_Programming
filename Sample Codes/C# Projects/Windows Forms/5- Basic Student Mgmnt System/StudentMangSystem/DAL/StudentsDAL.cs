using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public static class StudentsDAL
    {
        private static String connStr = "Server=TRGTECH-BILAL\\MSSQLSERVER2008;Database=Waqas;User Id=sa;Password=P@ssword123;";

        public static int SaveStudent(Student degObj)
        {
            SqlConnection conn = null;
            int rId = 0;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                String query = "";

                if (degObj.StudentID > 0)
                {
                    query = "Update dbo.Students SET Name='{0}', NIC='{1}', Gender='{2}', FavSports='{3}', MobileNo='{4}', HomeNo='{5}', DegreeID={6}, CurrentSemesterNo={7} WHERE StudentID = {8}";
                    query = String.Format(query, degObj.Name, degObj.NIC, degObj.Gender, degObj.FavSports, degObj.MobileNo, degObj.HomeNo, degObj.DegreeID, degObj.CurrentSemesterNo,degObj.StudentID);
                }
                else
                {
                    query = "INSERT INTO dbo.Students(Name, NIC, Gender, FavSports, MobileNo, HomeNo, DegreeID, CurrentSemesterNo) VALUES('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7})";
                    query = String.Format(query, degObj.Name, degObj.NIC, degObj.Gender, degObj.FavSports, degObj.MobileNo, degObj.HomeNo, degObj.DegreeID, degObj.CurrentSemesterNo);
                }
                

                SqlCommand command = new SqlCommand(query, conn);

                rId = command.ExecuteNonQuery();

                return rId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }//End of SaveStudent

        public static List<Student> GetAllStudents()
        {
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                String query = "Select StudentID, Name, NIC, Gender, FavSports, MobileNo, HomeNo, DegreeID, CurrentSemesterNo from dbo.Students";

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                List<Student> listStudent = new List<Student>();

                while (reader.Read() == true)
                {
                    Student degObj = new Student();

                    degObj.StudentID = reader.GetInt32(0);
                    degObj.Name = reader.GetString(1);
                    degObj.NIC = reader.GetString(2);
                    degObj.Gender = reader.GetString(3);
                    degObj.FavSports = reader.GetString(4);
                    degObj.MobileNo = reader.GetString(5);
                    degObj.HomeNo = reader.GetString(6);
                    degObj.DegreeID = reader.GetInt32(7);
                    degObj.CurrentSemesterNo = reader.GetInt32(8);

                    listStudent.Add(degObj);
                }

                return listStudent;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public static Student GetStudentByID(int did)
        {
            SqlConnection conn = null;
            int rId = 0;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                String query = "Select StudentID, Name, NIC, Gender, FavSports, MobileNo, HomeNo, DegreeID, CurrentSemesterNo from dbo.Students Where StudentID={0}";
                query = String.Format(query, did);

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                Student degObj = null;
                if (reader.Read() == true)
                {
                    degObj = new Student();

                    degObj.StudentID = reader.GetInt32(0);
                    degObj.Name = reader.GetString(1);
                    degObj.NIC = reader.GetString(2);
                    degObj.Gender = reader.GetString(3);
                    degObj.FavSports = reader.GetString(4);
                    degObj.MobileNo = reader.GetString(5);
                    degObj.HomeNo = reader.GetString(6);
                    degObj.DegreeID = reader.GetInt32(7);
                    degObj.CurrentSemesterNo = reader.GetInt32(8);

                }

                return degObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public static Boolean DeleteStudent(int did)
        {
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                String query = "DELETE from dbo.Students Where StudentID={0}";
                query = String.Format(query, did);

                SqlCommand command = new SqlCommand(query, conn);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                    return true;
                else
                    return false;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

    }
}
