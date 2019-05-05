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

using Accord;
using Accord.Controls;
using Accord.IO;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics;
using Accord.Statistics.Analysis;
using Accord.Statistics.Kernels;
using ZedGraph;
using System.IO;
using System.Numerics;

namespace AI_using_ML
{
    public partial class ClassifyLoosingInterest : Form
    {
        DecisionTree tree;
        string[] columnNames;

        string Xaxis;
        string Yaxis;

        public string LoginID;
        public int AppID;
        public bool isTrainingDataLoaded = false;


        DataSet DataSet;
        DataSet TrainingData;

        public Arithmetic Arithmetic;
        public DBConnector Connector;

        public ClassifyLoosingInterest(string loginID, int appID)
        {
            LoginID = loginID;
            AppID = appID;

            Arithmetic = new Arithmetic();
            Connector = new DBConnector(LoginID, 4);

            DataSet = new DataSet();
            TrainingData = new DataSet();


            InitializeComponent();
        }

        private void LoosingInterest_Load(object sender, EventArgs e)
        {
            //load customer Details in in dgvcustomers
            dgvCustomersDetails.Rows.Clear();

            Connector.CustomerLoad_ML_LoosingInterest(AppID, DataSet, TrainingData);
            DataTable Customers = DataSet.Tables["Customer"];

            int i = 0;
            foreach (DataRow Row in Customers.Rows)
            {

                dgvCustomersDetails.Rows.Add();
                dgvCustomersDetails.Rows[i].Cells["CustomerID"].Value = Row["CustomerID"];
                dgvCustomersDetails.Rows[i].Cells["AccessCount"].Value = Row["AccessCount"];
                dgvCustomersDetails.Rows[i].Cells["AvgUseDuration"].Value = Row["AvgUseDuration"];
                dgvCustomersDetails.Rows[i].Cells["Age"].Value = Row["Age"];
                dgvCustomersDetails.Rows[i].Cells["InactivityPeriod"].Value = Row["InactivityPeriod"];
                dgvCustomersDetails.Rows[i].Cells["MoneySpent"].Value = Row["MoneySpent"];
                dgvCustomersDetails.Rows[i].Cells["LoosingInterest"].Value = Row["LoosingInterest"];

                i++;

            }
        }


        #region Scatter plot and Graph creation

        public void CreateScatterplot(ZedGraphControl zgc, double[,] graph, DataTable DataTable)
        {
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            // Set the titles
            myPane.Title.IsVisible = false;
            myPane.XAxis.Title.Text = columnNames[0];
            myPane.YAxis.Title.Text = columnNames[1];


            // Classification problem
            PointPairList list1 = new PointPairList(); // Z = -1
            PointPairList list2 = new PointPairList(); // Z = +1

            int j = 0;
            foreach (DataRow row in DataTable.Rows)
            {
                if (Convert.ToBoolean(row["Interested"]) == false)
                    list1.Add(graph[j, 0], graph[j, 1]);
                if (Convert.ToBoolean(row["Interested"]) == true)
                    list2.Add(graph[j, 0], graph[j, 1]);

                j++;
            }

            // Add the curve
            LineItem myCurve = myPane.AddCurve("Negative", list1, Color.Red, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Red);

            myCurve = myPane.AddCurve("Positive", list2, Color.Green, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Green);


            // Fill the background of the chart rect and pane
            //myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);
            //myPane.Fill = new Fill(Color.White, Color.SlateGray, 45.0f);
            myPane.Fill = new Fill(Color.WhiteSmoke);

            zgc.AxisChange();
            zgc.Invalidate();
        }

        public void CreateAnalysisScatterplot(ZedGraphControl zgc, double[,] graph, DataTable DataTable)
        {
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            // Set the titles
            myPane.Title.IsVisible = false;
            myPane.XAxis.Title.Text = Xaxis;
            myPane.YAxis.Title.Text = Yaxis;


            // Classification problem
            PointPairList list1 = new PointPairList(); // Z = -1
            PointPairList list2 = new PointPairList(); // Z = +1

            int j = 0;
            foreach (DataRow row in DataTable.Rows)
            {
                if (Convert.ToBoolean(row["Interested"]) == false)
                    list1.Add(graph[j, 0], graph[j, 1]);
                if (Convert.ToBoolean(row["Interested"]) == true)
                    list2.Add(graph[j, 0], graph[j, 1]);

                j++;
            }

            // Add the curve
            LineItem myCurve = myPane.AddCurve("Negative", list1, Color.Red, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Red);

            myCurve = myPane.AddCurve("Positive", list2, Color.Green, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Green);


            // Fill the background of the chart rect and pane
            //myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);
            //myPane.Fill = new Fill(Color.White, Color.SlateGray, 45.0f);
            myPane.Fill = new Fill(Color.WhiteSmoke);

            zgc.AxisChange();
            zgc.Invalidate();
        }

        public void CreateSurfaceScatterplot(ZedGraphControl zgc, double[,] graph)
        {
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            // Set the titles
            myPane.Title.IsVisible = false;
            myPane.XAxis.Title.Text = columnNames[0];
            myPane.YAxis.Title.Text = columnNames[1];


            // Classification problem
            PointPairList list1 = new PointPairList(); // Z = -1
            PointPairList list2 = new PointPairList(); // Z = +1
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[i, 2] == -1)
                    list1.Add(graph[i, 0], graph[i, 1]);
                if (graph[i, 2] == 1)
                    list2.Add(graph[i, 0], graph[i, 1]);
            }

            // Add the curve
            LineItem myCurve = myPane.AddCurve("Negative", list1, Color.Red, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Red);

            myCurve = myPane.AddCurve("Positive", list2, Color.Green, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Green);


            // Fill the background of the chart rect and pane
            //myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);
            //myPane.Fill = new Fill(Color.White, Color.SlateGray, 45.0f);
            myPane.Fill = new Fill(Color.WhiteSmoke);

            zgc.AxisChange();
            zgc.Invalidate();
        }

        public void CreateResultScatterplot(ZedGraphControl zgc, double[][] inputs, double[] expected, double[] output)
        {
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            // Set the titles
            myPane.Title.IsVisible = false;
            myPane.XAxis.Title.Text = columnNames[0];
            myPane.YAxis.Title.Text = columnNames[1];



            // Classification problem
            PointPairList list1 = new PointPairList(); // Z = -1, OK
            PointPairList list2 = new PointPairList(); // Z = +1, OK
            PointPairList list3 = new PointPairList(); // Z = -1, Error
            PointPairList list4 = new PointPairList(); // Z = +1, Error
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == -1)
                {
                    if (expected[i] == -1)
                        list1.Add(inputs[i][0], inputs[i][1]);
                    if (expected[i] == 1)
                        list3.Add(inputs[i][0], inputs[i][1]);
                }
                else
                {
                    if (expected[i] == -1)
                        list4.Add(inputs[i][0], inputs[i][1]);
                    if (expected[i] == 1)
                        list2.Add(inputs[i][0], inputs[i][1]);
                }
            }

            // Add the curve
            LineItem
            myCurve = myPane.AddCurve("Negative and Correct", list1, Color.Red, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Red);

            myCurve = myPane.AddCurve("Positve and Correct", list2, Color.Green, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Green);

            myCurve = myPane.AddCurve("Positive but Incorrect", list3, Color.Green, SymbolType.XCross);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = true;
            myCurve.Symbol.Fill = new Fill(Color.Green);

            myCurve = myPane.AddCurve("Negative but Incorrect", list4, Color.Red, SymbolType.XCross);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = true;
            myCurve.Symbol.Fill = new Fill(Color.Red);


            // Fill the background of the chart rect and pane
            //myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);
            //myPane.Fill = new Fill(Color.White, Color.SlateGray, 45.0f);
            myPane.Fill = new Fill(Color.WhiteSmoke);

            zgc.AxisChange();
            zgc.Invalidate();
        }
        #endregion

       
        public double[][] ConvertDataTableToMatrix(DataTable dt)
        {
            double[][] matrix = new double[dt.Rows.Count][];
            Converter<object, double> converter = Convert.ToDouble;

            for (int row = 0; row < dt.Rows.Count; row++)
            {
                matrix[row] = Array.ConvertAll(dt.Rows[row].ItemArray, converter);
            }

            return matrix;
        }



        private void btnSampleRunAnalysis_Click(object sender, EventArgs e)
        {
            if (!isTrainingDataLoaded)
            {
                MessageBox.Show("Please load your training data first");
                return;
            }

            // Creates a matrix from the entire source data table
            double[,] table = (dgvLearningSource.DataSource as DataTable).ToMatrix(out columnNames);

            // Get only the input vector values (in the first two columns)
            double[][] inputs = ConvertDataTableToMatrix(TrainingData.Tables["InterestedTrainingDataValues"]);

            // Get only the output labels (last column)
            int[] outputs = table.GetColumn(2).ToInt32();


            // Creates a new instance of the SMO learning algorithm
            DecisionVariable[] variables =
             {
                new DecisionVariable("x", DecisionVariableKind.Continuous),
                new DecisionVariable("y", DecisionVariableKind.Continuous),
            };


            // Create the C4.5 learning algorithm
            var c45 = new C45Learning(variables);

            // Learn the decision tree using C4.5
            tree = c45.Learn(inputs, outputs);

            // Show the learned tree in the view
            decisionTreeView1.TreeSource = tree;


            // Get the ranges for each variable (X and Y)
            DoubleRange[] ranges = table.GetRange(0);

            // Generate a Cartesian coordinate system
            double[][] map = Matrix.Cartesian(
                Vector.Interval(ranges[0], 0.05),
                Vector.Interval(ranges[1], 0.05));

            // Classify each point in the Cartesian coordinate system
            double[] result = map.Apply(tree.Compute).ToDouble();
            double[,] surface = map.ToMatrix().InsertColumn(result);
            
            MessageBox.Show("Training Complete");

        }

        private void btnTestingRun_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            isTrainingDataLoaded = true;

            DataTable trainingData = TrainingData.Tables["InterestedTrainingData"];

            double[,] sourceMatrix = trainingData.ToMatrix(out columnNames);

            this.dgvLearningSource.DataSource = trainingData;
            this.dgvTestingSource.DataSource = trainingData.Copy();


            CreateScatterplot(graphInput, sourceMatrix, trainingData);
        }

        public double[,] TwoDPointList(DataTable Table)
        {
            double[,] pointlist = new double[Table.Rows.Count, 1];

            int i = 0;

            foreach (DataRow Row in Table.Rows)
            {
                pointlist[i, 0] = Convert.ToDouble(Row[Xaxis]);
                i++;
            }
            //double[,] pointlist = pl.ToMatrix();

            return pointlist;
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            btnSaveClassification.Enabled = true;

            int positiveCount = 0;
            int NegativeCount = 0;

            if (svm != null)
            {
                btnSaveClassification.Enabled = true;

                //DataTable TempData = DataSet.Tables["TempCustomer"];

                double[][] inputs = ConvertDataTableToMatrix(DataSet.Tables["InterestedData"]);
                bool[] Classification = svm.Decide(inputs);

                int i = 0;
                foreach (DataRow Row in DataSet.Tables["TempCustomer"].Rows)
                {
                    Row["Interested"] = Classification[i];

                    i++;
                }

                dgvCustomersDetails.Rows.Clear();

                i = 0;
                foreach (DataRow Row in DataSet.Tables["TempCustomer"].Rows)
                {

                    dgvCustomersDetails.Rows.Add();
                    dgvCustomersDetails.Rows[i].Cells["CustomerID"].Value = Row["CustomerID"];
                    dgvCustomersDetails.Rows[i].Cells["AccessCount"].Value = Row["AccessCount"];
                    dgvCustomersDetails.Rows[i].Cells["AvgUseDuration"].Value = Row["AvgUseDuration"];
                    dgvCustomersDetails.Rows[i].Cells["Age"].Value = Row["Age"];
                    dgvCustomersDetails.Rows[i].Cells["InactivityPeriod"].Value = Row["InactivityPeriod"];
                    dgvCustomersDetails.Rows[i].Cells["MoneySpent"].Value = Row["MoneySpent"];
                    dgvCustomersDetails.Rows[i].Cells["Interested"].Value = Row["Interested"];

                    i++;

                }

                dgvPositive.Rows.Clear();

                i = 0;
                foreach (DataRow Row in DataSet.Tables["TempCustomer"].Rows)
                {

                    if (Convert.ToBoolean(Row["Interested"]) == true)
                    {
                        dgvPositive.Rows.Add();
                        dgvPositive.Rows[i].Cells["CustomerID_P"].Value = Row["CustomerID"];

                        i++;
                        positiveCount++;
                    }

                }

                dgvNegative.Rows.Clear();

                i = 0;
                foreach (DataRow Row in DataSet.Tables["TempCustomer"].Rows)
                {

                    if (Convert.ToBoolean(Row["Interested"]) == false)
                    {
                        dgvNegative.Rows.Add();
                        dgvNegative.Rows[i].Cells["CustomerID_N"].Value = Row["CustomerID"];

                        i++;
                        NegativeCount++;
                    }

                }

                dgvDetails.Rows.Clear();

                dgvDetails.Rows.Add();
                dgvDetails.Rows[0].Cells["Percentage"].Value = Arithmetic.Percentage(positiveCount, positiveCount + NegativeCount);
                dgvDetails.Rows[0].Cells["Ratio"].Value = Arithmetic.ratio(positiveCount, NegativeCount);
                dgvDetails.Rows[0].Cells["PositiveCount"].Value = positiveCount;
                dgvDetails.Rows[0].Cells["NegativeCount"].Value = NegativeCount;
                dgvDetails.Rows[0].Cells["Total"].Value = positiveCount + NegativeCount;


            }
            else
            {
                MessageBox.Show("Please Train your algorithm first");
            }

        }

        private void btnSaveClassification_Click(object sender, EventArgs e)
        {
            btnSaveClassification.Enabled = false;

            Connector.InterestedUpdateDataSet(DataSet);
            MessageBox.Show("Your classification has been saved");
        }

        private void miRefresh_customerDetails_Click(object sender, EventArgs e)
        {
            dgvDetails.Rows.Clear();
            dgvPositive.Rows.Clear();
            dgvNegative.Rows.Clear();
            dgvCustomersDetails.Rows.Clear();

            DataTable Customers = DataSet.Tables["Customer"];

            int i = 0;
            foreach (DataRow Row in Customers.Rows)
            {

                dgvCustomersDetails.Rows.Add();
                dgvCustomersDetails.Rows[i].Cells["CustomerID"].Value = Row["CustomerID"];
                dgvCustomersDetails.Rows[i].Cells["AccessCount"].Value = Row["AccessCount"];
                dgvCustomersDetails.Rows[i].Cells["AvgUseDuration"].Value = Row["AvgUseDuration"];
                dgvCustomersDetails.Rows[i].Cells["Age"].Value = Row["Age"];
                dgvCustomersDetails.Rows[i].Cells["InactivityPeriod"].Value = Row["InactivityPeriod"];
                dgvCustomersDetails.Rows[i].Cells["MoneySpent"].Value = Row["MoneySpent"];
                dgvCustomersDetails.Rows[i].Cells["Interested"].Value = Row["Interested"];

                i++;
            }

        private void cmbXaxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = cmbXaxis.SelectedItem.ToString();
            Xaxis = SelectedItem;

            cmbYaxis.Items.Clear();

            if (SelectedItem != "AccessCount")
                cmbYaxis.Items.Add("AccessCount");

            if (SelectedItem != "AvgUseDuration")
                cmbYaxis.Items.Add("AvgUseDuration");

            if (SelectedItem != "Age")
                cmbYaxis.Items.Add("Age");

            if (SelectedItem != "InactivityPeriod")
                cmbYaxis.Items.Add("InactivityPeriod");

            if (SelectedItem != "MoneySpent")
                cmbYaxis.Items.Add("MoneySpent");
        }

        private void cmbYaxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = cmbYaxis.SelectedItem.ToString();
            Yaxis = SelectedItem;

            cmbXaxis.Items.Clear();

            if (SelectedItem != "AccessCount")
                cmbXaxis.Items.Add("AccessCount");

            if (SelectedItem != "AvgUseDuration")
                cmbXaxis.Items.Add("AvgUseDuration");

            if (SelectedItem != "Age")
                cmbXaxis.Items.Add("Age");

            if (SelectedItem != "InactivityPeriod")
                cmbXaxis.Items.Add("InactivityPeriod");

            if (SelectedItem != "MoneySpent")
                cmbXaxis.Items.Add("MoneySpent");
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            DataTable table = DataSet.Tables["Customer"];
            double[,] graph = TwoDPointList(table);
            CreateAnalysisScatterplot(zedGraphAnalysis, graph, table);
        }
    }
}
