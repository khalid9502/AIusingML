using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CSDAL
{
    public class DBConnector
    {
        public int FormNumber;
        public SqlConnection ApplicationConnection;
        public SqlCommand ApplicationCommand;

        public SqlConnection CustomerConnection;
        public SqlCommand CustomerCommand;
        
        public SqlDataAdapter ApplicationAdapter;
        public SqlDataAdapter CustomerAdapter;
        //public SqlDataAdapter TempCustomerAdapter;
        //public SqlDataAdapter BuyerTrainingAdapter;

        public string loginID;

        public DBConnector(string LoginID,int Form)
        {
            loginID = LoginID;
            string connectionString = "Server=tcp:myaiserver.database.windows.net,1433;Initial Catalog=ArtificialIntelligence;Persist Security Info=False;User ID=khalid;Password=JasimaGulam17;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            ApplicationConnection = new SqlConnection(connectionString);
            ApplicationConnection.Open();
            ApplicationCommand = new SqlCommand();
            ApplicationCommand.Connection = ApplicationConnection;
            ApplicationCommand.CommandText = "select * from Applications where  LoginID = " + "'" + loginID + "'";
            

            CustomerConnection = new SqlConnection(connectionString);
            CustomerConnection.Open();
            CustomerCommand = new SqlCommand();
            CustomerCommand.Connection = CustomerConnection;
            CustomerCommand.CommandText = "select * from Customer where  LoginID = " + "'" + loginID + "'";

            FormNumber = Form;

            //Application
            ApplicationAdapter = new SqlDataAdapter();
            ApplicationAdapter.SelectCommand = ApplicationCommand;
            Application_InitializeCommands();

            //Customer
            CustomerAdapter = new SqlDataAdapter();
            CustomerAdapter.SelectCommand = CustomerCommand;
            Customer_InitializeCommands();

            ////TempCustomer
            //TempCustomerAdapter = new SqlDataAdapter();
            
            ////Buyer
            //BuyerTrainingAdapter = new SqlDataAdapter();
        }

        public void AddParms(SqlCommand cmd, params string[] cols)
        {
            foreach (string column in cols)
            {
                cmd.Parameters.Add("@" + column, SqlDbType.Char, 0, column);
            }
        }


        public void Application_InitializeCommands()
        {
            SqlConnection connection = (SqlConnection)ApplicationAdapter.SelectCommand.Connection;

            //create an explicit and reusable insert command
            ApplicationAdapter.InsertCommand = connection.CreateCommand();
            ApplicationAdapter.InsertCommand.CommandText = "Insert into Applications(LoginID, ApplicationID, ApplicationName, ApplicationType, ReleaseDate, CustomerCount) values(@LoginID, @ApplicationID, @ApplicationName, @ApplicationType, @ReleaseDate, @CustomerCount)";
            AddParms(ApplicationAdapter.InsertCommand, "LoginID", "ApplicationID", "ApplicationName", "ApplicationType", "ReleaseDate", "CustomerCount");
            

            //create an explicit update command
            ApplicationAdapter.UpdateCommand = connection.CreateCommand();
            ApplicationAdapter.UpdateCommand.CommandText = "update Applications set ApplicationName = @ApplicationName, ApplicationType = @ApplicationType, ReleaseDate = @ReleaseDate where ApplicationID = @ApplicationID";
            AddParms(ApplicationAdapter.UpdateCommand, "ApplicationName", "ApplicationType", "ReleaseDate", "ApplicationID");


        }

        public void Customer_InitializeCommands()
        {
            SqlConnection connection = (SqlConnection)CustomerAdapter.SelectCommand.Connection;
            
            //create an explicit update command
            CustomerAdapter.UpdateCommand = connection.CreateCommand();

            if(FormNumber == 2)
            {
                CustomerAdapter.UpdateCommand.CommandText = "update Customer set Buyer = @Buyer Where ApplicationID = @ApplicationID and CustomerID = @CustomerID";
                AddParms(CustomerAdapter.UpdateCommand, "Buyer", "ApplicationID", "CustomerID");
            }
            if (FormNumber == 3)
            {
                CustomerAdapter.UpdateCommand.CommandText = "update Customer set Interested = @Interested Where ApplicationID = @ApplicationID and CustomerID = @CustomerID";
                AddParms(CustomerAdapter.UpdateCommand, "Interested", "ApplicationID", "CustomerID");
            }
            if (FormNumber == 4)
            {
                CustomerAdapter.UpdateCommand.CommandText = "update Customer set LoosingInterest = @LoosingInterest Where ApplicationID = @ApplicationID and CustomerID = @CustomerID";
                AddParms(CustomerAdapter.UpdateCommand, "LoosingInterest", "ApplicationID", "CustomerID");
            }


        }

        #region Application

        public void ApplicationLoad(DataSet DataSet)
        {
            
            this.ApplicationAdapter.Fill(DataSet, "Application");

        }

        public void ApplicationAdd(App app, DataSet dataset)
        {
            DataTable dataTable = dataset.Tables["Application"];
            DataRow newRow = dataTable.NewRow();

            

            newRow["LoginID"] = loginID;
            newRow["ApplicationID"] = app.ApplicationID;
            newRow["ApplicationName"] = app.ApplicationName;
            newRow["ApplicationType"] = app.ApplicationType;
            newRow["ReleaseDate"] = app.ReleaseDate;
            newRow["CustomerCount"] = app.CustomerCount;

            dataTable.Rows.Add(newRow);
            this.ApplicationAdapter.Update(dataset, "Application");
            dataset.AcceptChanges();


        }

        public void ApplicationUpdate(App app, DataSet dataset, int row)
        {
            DataTable dataTable = dataset.Tables["Application"];
            DataRow targetRow = dataTable.Rows[row];

            

            targetRow.BeginEdit();
            targetRow["ApplicationName"] = app.ApplicationName;
            targetRow["ApplicationType"] = app.ApplicationType;
            targetRow["ReleaseDate"] = app.ReleaseDate;
            targetRow.EndEdit();

            DataSet dataSetChanged = dataset.GetChanges(DataRowState.Modified);

            bool okayflag = true;
            if (dataSetChanged.HasErrors)
            {
                okayflag = false;
            }
            if (okayflag)
            {
                this.ApplicationAdapter.Update(dataSetChanged, "Application");
                dataset.AcceptChanges();
            }
            else
            {
                dataset.RejectChanges();
            }


        }
        #endregion

        #region Customer
        public void CustomerLoad(int ApplicationID, DataSet DataSet)
        {
            CustomerCommand.CommandText = "select * from Customer where ApplicationID = " + "'" + ApplicationID.ToString() + "'";

            this.CustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(DataSet, "Customer");
        }
        #endregion
        //-----------------------------------------Buyer
        public void CustomerLoad_ML_Buyer(int ApplicationID, DataSet DataSet, DataSet TrainingData)
        {
            CustomerCommand.CommandText = "select * from Customer where ApplicationID = " + "'" + ApplicationID.ToString() + "'";

            this.CustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(DataSet, "Customer");

            //this.TempCustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(DataSet, "TempCustomer");

            CustomerCommand.CommandText = "select Age,MoneySpent from Customer where ApplicationID = " + "'" + ApplicationID.ToString() + "'";
            this.CustomerAdapter.Fill(DataSet, "BuyerData");


            //this part is taken from BuyerTrainingLoad
            CustomerCommand.CommandText = "select Age,MoneySpent,Buyer from TrainingData where ApplicationID = " + "'" + ApplicationID.ToString() + "'";//im using the data table instead of the training data table this must be changed

            this.CustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(TrainingData, "BuyerTrainingData");

            CustomerCommand.CommandText = "select Age,MoneySpent from TrainingData where ApplicationID = " + "'" + ApplicationID.ToString() + "'";//im using the data table instead of the training data table this must be changed
            this.CustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(TrainingData, "BuyerTrainingDataValues");
            //till here
        }



        public void BuyerUpdateDataSet(DataSet DataSet)
        {
            DataTable dataTable = DataSet.Tables["Customer"];
            DataTable tempDataTable = DataSet.Tables["TempCustomer"];

           

            int i = 0;
            foreach(DataRow row in tempDataTable.Rows)
            {

                DataRow targetRow = dataTable.Rows[i];

                targetRow.BeginEdit();
                targetRow["Buyer"] = row["Buyer"];
                targetRow.EndEdit();
                
                i++;
            }

            DataSet dataSetChanged = DataSet.GetChanges(DataRowState.Modified);

            bool okayflag = true;
            if (dataSetChanged.HasErrors)
            {
                okayflag = false;
            }
            if (okayflag)
            {

                this.CustomerAdapter.Update(dataSetChanged, "Customer");
                DataSet.AcceptChanges();
            }
            else
            {
                DataSet.RejectChanges();
            }


        }

        //-----------------------------------------Interested
        public void CustomerLoad_ML_Interested(int ApplicationID, DataSet DataSet, DataSet TrainingData)
        {
            CustomerCommand.CommandText = "select * from Customer where ApplicationID = " + "'" + ApplicationID.ToString() + "'";

            this.CustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(DataSet, "Customer");

            //this.TempCustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(DataSet, "TempCustomer");

            CustomerCommand.CommandText = "select AccessCount,AvgUseDuration from Customer where ApplicationID = " + "'" + ApplicationID.ToString() + "'";
            this.CustomerAdapter.Fill(DataSet, "InterestedData");


            //this part is taken from BuyerTrainingLoad
            CustomerCommand.CommandText = "select AccessCount,AvgUseDuration,Interested from TrainingData where ApplicationID = " + "'" + ApplicationID.ToString() + "'";//im using the data table instead of the training data table this must be changed

            this.CustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(TrainingData, "InterestedTrainingData");

            CustomerCommand.CommandText = "select AccessCount,AvgUseDuration from TrainingData where ApplicationID = " + "'" + ApplicationID.ToString() + "'";//im using the data table instead of the training data table this must be changed
            this.CustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(TrainingData, "InterestedTrainingDataValues");
            //till here
        }



        public void InterestedUpdateDataSet(DataSet DataSet)
        {
            DataTable dataTable = DataSet.Tables["Customer"];
            DataTable tempDataTable = DataSet.Tables["TempCustomer"];



            int i = 0;
            foreach (DataRow row in tempDataTable.Rows)
            {

                DataRow targetRow = dataTable.Rows[i];

                targetRow.BeginEdit();
                targetRow["Interested"] = row["Interested"];
                targetRow.EndEdit();

                i++;
            }

            DataSet dataSetChanged = DataSet.GetChanges(DataRowState.Modified);

            bool okayflag = true;
            if (dataSetChanged.HasErrors)
            {
                okayflag = false;
            }
            if (okayflag)
            {

                this.CustomerAdapter.Update(dataSetChanged, "Customer");
                DataSet.AcceptChanges();
            }
            else
            {
                DataSet.RejectChanges();
            }


        }
        
        //-----------------------------------------Interested

        public void CustomerLoad_ML_LoosingInterest(int ApplicationID, DataSet DataSet, DataSet TrainingData)
        {
            CustomerCommand.CommandText = "select * from Customer where ApplicationID = " + "'" + ApplicationID.ToString() + "' " + "and Interested = 'true'";

            this.CustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(DataSet, "Customer");

            //this.TempCustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(DataSet, "TempCustomer");

            CustomerCommand.CommandText = "select AvgUseDUration,InactivityPeriod from Customer where ApplicationID = " + "'" + ApplicationID.ToString() + "' " + "and Interested = 'true'";
            this.CustomerAdapter.Fill(DataSet, "LoosingInterestData");


            //this part is taken from BuyerTrainingLoad
            CustomerCommand.CommandText = "select AvgUseDUration,InactivityPeriod,LoosingInterest from TrainingData where ApplicationID = " + "'" + ApplicationID.ToString() + "'";//im using the data table instead of the training data table this must be changed

            this.CustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(TrainingData, "LoosingInterestTrainingData");

            CustomerCommand.CommandText = "select AvgUseDuration,InactivityPeriod from TrainingData where ApplicationID = " + "'" + ApplicationID.ToString() + "'";//im using the data table instead of the training data table this must be changed
            this.CustomerAdapter.SelectCommand = CustomerCommand;
            this.CustomerAdapter.Fill(TrainingData, "LoosingInterestTrainingDataValues");
            //till here
        }



        public void LoosingInterestUpdateDataSet(DataSet DataSet)
        {
            DataTable dataTable = DataSet.Tables["Customer"];
            DataTable tempDataTable = DataSet.Tables["TempCustomer"];



            int i = 0;
            foreach (DataRow row in tempDataTable.Rows)
            {

                DataRow targetRow = dataTable.Rows[i];

                targetRow.BeginEdit();
                targetRow["LoosingInterest"] = row["LoosingInterest"];
                targetRow.EndEdit();

                i++;
            }

            DataSet dataSetChanged = DataSet.GetChanges(DataRowState.Modified);

            bool okayflag = true;
            if (dataSetChanged.HasErrors)
            {
                okayflag = false;
            }
            if (okayflag)
            {

                this.CustomerAdapter.Update(dataSetChanged, "Customer");
                DataSet.AcceptChanges();
            }
            else
            {
                DataSet.RejectChanges();
            }


        }


    }
}
