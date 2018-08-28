using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CSDAL
{
    public class DBAccessor
    {

        string connectionString;
        SqlDataAdapter adapter;


        public DBAccessor()
        {
            connectionString = "Server=tcp:myaiserver.database.windows.net,1433;Initial Catalog=ArtificialIntelligence;Persist Security Info=False;User ID=khalid;Password=JasimaGulam17;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        public void ApplicationLoad(string LoginID, DataSet DataSet)
        {
            string commandString = "select ApplicationID,ApplicationName,ApplicationType,ReleaseDate,CustomerCount from Applications where  LoginID = " + "'" + LoginID + "'";
            adapter = new SqlDataAdapter(commandString, connectionString);
            adapter.Fill(DataSet, "Application");
           
        }

        public void ApplicationDatasetSync(DataSet Dataset)
        {
            string commandString = "select * from Applications";
            adapter = new SqlDataAdapter(commandString, connectionString);
            adapter.Update(Dataset, "Application");
            Dataset.AcceptChanges();


        }

        public void CustomerLoad(int ApplicationID, DataSet DataSet)
        {
            string commandString = "select CustomerID,AccessCount,AvgUseDuration,Age,InactivityPeriod,MoneySpent from Customer where ApplicationID = " + "'" + ApplicationID.ToString() + "'";
            adapter = new SqlDataAdapter(commandString, connectionString);
            adapter.Fill(DataSet, "Customer");
        }

        public void ApplicationAdd(App app)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
               
                    using(SqlCommand command = new SqlCommand("Insert into Applications values('" + app.LoginID + "','" + app.ApplicationID.ToString() + "','" 
                        + app.ApplicationName + "','" + app.ApplicationType + "','" + app.ReleaseDate.ToString() + "','" + app.CustomerCount.ToString() + "')", con))
                    {
                        command.ExecuteNonQuery();
                    }
               
                
            }
        }
        
        
        public void ApplicationUpdate(App app)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("Update Applications set ApplicationName = '" + app.ApplicationName + 
                    "', ApplicationType = '" + app.ApplicationType + "',ReleaseDate = '" + app.ReleaseDate.ToString() + "' where ApplicationID = '" 
                    + app.ApplicationID.ToString() +"'" , con))
                {
                    command.ExecuteNonQuery();
                }
                

            }
        }

        public Boolean ApplicationID_Exists(int Appid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("select ApplicationID from Applications where ApplicationID = " + "'" + Appid.ToString() + "'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("exception at ApplicationID_Exists");
                }

                return true;
            }
        }

    }
}
