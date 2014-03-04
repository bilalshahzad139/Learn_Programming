using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public static class DegreesDAL
    {
        private static String connStr = "Server=TRGTECH-BILAL\\MSSQLSERVER2008;Database=Waqas;User Id=sa;Password=P@ssword123;";

        public static int SaveDegree(Degree degObj)
        {
            SqlConnection conn = null;
            int rId = 0;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                String query = "";

                if (degObj.DegreeID > 0)
                {
                    query = "Update dbo.Degrees SET DegreeName='{0}', MinCrHourRequired={1}, MinCGPARequired={2} WHERE DegreeID = {3}";
                    query = String.Format(query, degObj.DegreeName, degObj.MinCrHourRequired, degObj.MinCGPARequired,degObj.DegreeID);
                }
                else
                {
                    query = "INSERT INTO dbo.Degrees(DegreeName, MinCrHourRequired, MinCGPARequired) VALUES('{0}',{1},{2})";
                    query = String.Format(query, degObj.DegreeName, degObj.MinCrHourRequired, degObj.MinCGPARequired);
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
        }//End of SaveDegree

        public static List<Degree> GetAllDegress()
        {
            SqlConnection conn = null;
            int rId = 0;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                String query = "Select DegreeID, DegreeName, MinCrHourRequired, MinCGPARequired from dbo.Degrees";

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                List<Degree> listDegree = new List<Degree>();

                while (reader.Read() == true)
                {
                    Degree degObj = new Degree();

                    degObj.DegreeID = reader.GetInt32(0); //DegreeID
                    degObj.DegreeName = reader.GetString(1); //DegreeName;
                    degObj.MinCrHourRequired = reader.GetInt32(2);
                    degObj.MinCGPARequired =(float) reader.GetDouble(3);

                    listDegree.Add(degObj);
                }

                return listDegree;
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

        public static Degree GetDegreeByID(int did)
        {
            SqlConnection conn = null;
            int rId = 0;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                String query = "Select DegreeID, DegreeName, MinCrHourRequired, MinCGPARequired from dbo.Degrees Where DegreeID={0}";
                query = String.Format(query, did);

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                Degree degObj = null;
                if (reader.Read() == true)
                {
                    degObj = new Degree();
                    
                    degObj.DegreeID = reader.GetInt32(0); //DegreeID
                    degObj.DegreeName = reader.GetString(1); //DegreeName;
                    degObj.MinCrHourRequired = reader.GetInt32(2);
                    degObj.MinCGPARequired = (float)reader.GetDouble(3);

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

        public static Boolean DeleteDegree(int did)
        {
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                String query = "DELETE from dbo.Degrees Where DegreeID={0}";
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
