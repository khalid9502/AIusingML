using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CSDAL;




namespace AI_using_ML
{
    

    public partial class CustomerSegmentation : Form
    {
        public string LoginID;
        public int AppID = 0;
        public DataSet DataSet;
        public DBAccessor Accessor;
        public DBConnector Connector;


        public CustomerSegmentation(string Loginid)
        {

            Accessor = new DBAccessor();

            LoginID = Loginid;

            Connector = new DBConnector(LoginID,1);

            DataSet = new DataSet();
            
            InitializeComponent();

            AppLoad();

            

        }

        

        private void CustomerSegmentation_Load(object sender, EventArgs e)
        {
            

        }




        #region ApplicationMethods

        public void AppLoad()
        {
            DGApplications.Rows.Clear();
            
            Connector.ApplicationLoad(DataSet);
            DataTable Applications = DataSet.Tables["Application"];

            int i = 0;
            foreach (DataRow Row in Applications.Rows)
            {
                DGApplications.Rows.Add();
                DGApplications.Rows[i].Cells["ApplicationID"].Value = Row["ApplicationID"];
                DGApplications.Rows[i].Cells["ApplicationName"].Value = Row["ApplicationName"];
                DGApplications.Rows[i].Cells["ApplicationType"].Value = Row["ApplicationType"];
                DGApplications.Rows[i].Cells["ReleaseDate"].Value = Row["ReleaseDate"];
                DGApplications.Rows[i].Cells["CustomerCount"].Value = Row["CustomerCount"];
                i++;

            }


        }

        public void AppRefresh()
        {
            DGApplications.Rows.Clear();
            
            DataTable Applications = DataSet.Tables["Application"];

            int i = 0;
            foreach (DataRow Row in Applications.Rows)
            {
                DGApplications.Rows.Add();
                DGApplications.Rows[i].Cells["ApplicationID"].Value = Row["ApplicationID"];
                DGApplications.Rows[i].Cells["ApplicationName"].Value = Row["ApplicationName"];
                DGApplications.Rows[i].Cells["ApplicationType"].Value = Row["ApplicationType"];
                DGApplications.Rows[i].Cells["ReleaseDate"].Value = Row["ReleaseDate"];
                DGApplications.Rows[i].Cells["CustomerCount"].Value = Row["CustomerCount"];
                i++;

            }


        }


        public void CustomerLoad()
        {
            DGCustomers.Rows.Clear();

            if(DataSet.Tables["Customer"] != null)
            {
                DataSet.Tables["Customer"].Clear();
            }

            Connector.CustomerLoad(AppID, DataSet);
            DataTable Customers = DataSet.Tables["Customer"];

            int i = 0;
            foreach (DataRow Row in Customers.Rows)
            {

                DGCustomers.Rows.Add();
                DGCustomers.Rows[i].Cells["CustomerID"].Value = Row["CustomerID"];
                DGCustomers.Rows[i].Cells["AccessCount"].Value = Row["AccessCount"];
                DGCustomers.Rows[i].Cells["AvgUseDuration"].Value = Row["AvgUseDuration"];
                DGCustomers.Rows[i].Cells["Age"].Value = Row["Age"];
                DGCustomers.Rows[i].Cells["InactivityPeriod"].Value = Row["InactivityPeriod"];
                DGCustomers.Rows[i].Cells["MoneySpent"].Value = Row["MoneySpent"];

                i++;

            }
        }

        private void BtnApplicationAdd_Click(object sender, EventArgs e)
        {
            if (CheckApplicationDetails())
            {
                string loginid = LoginID;
                int appid = Convert.ToInt32(txtAppID.Text);
                string appName = txtAppName.Text;
                string apptype = cmbAppType.Text;
                DateTime releasedate = Convert.ToDateTime(dtpreleaseDate.Text);
                int customercount = 0;

                App application = new App(loginid, appid, appName, apptype, releasedate, customercount);

                Connector.ApplicationAdd(application, DataSet);

                AppRefresh();
                
            }
            
            
        }
        

        private void BtnApplicationUpdate_Click(object sender, EventArgs e)
        {

            if (CheckApplicationID())
            {
                string loginid = LoginID;
                int appid = Convert.ToInt32(txtAppID.Text);
                string appName = txtAppName.Text;
                string apptype = cmbAppType.Text;
                DateTime releasedate = Convert.ToDateTime(dtpreleaseDate.Text);
                int customercount = 0;

                App application = new App(loginid, appid, appName, apptype, releasedate, customercount);

                int row = 0;
                DataTable dataTable = DataSet.Tables["Application"];

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    if(Convert.ToInt32(dataRow["ApplicationID"]) == appid)
                    {
                        break;
                    }


                    row++;
                }
                
                Connector.ApplicationUpdate(application, DataSet, row);

                AppRefresh();
            }
           
        }



        #endregion

       
        private void DGApplications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellindex = DGApplications.SelectedCells[0].RowIndex;
            //var cellcollection = DGApplications.Rows[cellindex].Cells["ApplicationID"];

            AppID = Convert.ToInt32(DGApplications.Rows[cellindex].Cells["ApplicationID"].Value);

            txtAppID.Text = DGApplications.Rows[cellindex].Cells["ApplicationID"].Value.ToString();
            txtAppName.Text = DGApplications.Rows[cellindex].Cells["ApplicationName"].Value.ToString();

            string appType = DGApplications.Rows[cellindex].Cells["ApplicationType"].Value.ToString();

            for(int i= 0; i < cmbAppType.Items.Count; i++)
            {
                if(appType == cmbAppType.Items[i].ToString())
                {
                    cmbAppType.SelectedIndex = i;
                    break;
                }
            }



            dtpreleaseDate.Value = Convert.ToDateTime(DGApplications.Rows[cellindex].Cells["ReleaseDate"].Value);

            CustomerLoad();
        }

        private Boolean AppDetailIsEmpty()
        {
            if (txtAppID.Text == "" && txtAppName.Text == "" && cmbAppType.Text == "")
            {
                return true;
            }
            else
                return false;
            
        }

        private Boolean CheckApplicationDetails()
        {
            if (AppDetailIsEmpty())
            {
                MessageBox.Show("Please Enter Proper details");
                return false;
            }
            int appid = 1;
            try
            {
                appid = Convert.ToInt32(txtAppID.Text);
            }
            catch
            {
                MessageBox.Show("ApplicationID must be a valid number");
                return false;
            }

            if (Accessor.ApplicationID_Exists(appid))
            {
                MessageBox.Show("ApplicationID Already Exists");
                return false;
            }

            return true;

        }

        private Boolean CheckApplicationID()
        {
            
            int appid = 1;
            try
            {
                appid = Convert.ToInt32(txtAppID.Text);
            }
            catch
            {
                MessageBox.Show("ApplicationID must be a valid number");
                return false;
            }

            if (!Accessor.ApplicationID_Exists(appid))
            {
                MessageBox.Show("ApplicationID does not exist");
                return false;
            }

            return true;

        }

        private void menuItem_Buyers_Click(object sender, EventArgs e)
        {
            if(AppID != 0)
            {
                ClassifyBuyer cb = new ClassifyBuyer(LoginID, AppID);
                cb.Show();
            }
            else
            {
                MessageBox.Show("Please select an Application");
            }
            
        }

        private void menuItem_Interested_Click(object sender, EventArgs e)
        {
            if (AppID != 0)
            {
                ClassifyInterested ci = new ClassifyInterested(LoginID, AppID);
                ci.Show();
            }
            else
            {
                MessageBox.Show("Please select an Application");
            }
        }
    }
}




