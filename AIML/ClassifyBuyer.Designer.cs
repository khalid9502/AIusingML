namespace AI_using_ML
{
    partial class ClassifyBuyer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRefresh_customerDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tcBuyer = new System.Windows.Forms.TabControl();
            this.tpTraining = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSamples = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.btnLoadTrainingData = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvLearningSource = new System.Windows.Forms.DataGridView();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.graphInput = new ZedGraph.ZedGraphControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEstimateSig = new System.Windows.Forms.Button();
            this.btnEstimateLaplacian = new System.Windows.Forms.Button();
            this.btnEstimateGaussian = new System.Windows.Forms.Button();
            this.btnEstimateC = new System.Windows.Forms.Button();
            this.btnSampleRunAnalysis = new System.Windows.Forms.Button();
            this.numT = new System.Windows.Forms.NumericUpDown();
            this.rbGaussian = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSigB = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numSigAlpha = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numNegativeWeight = new System.Windows.Forms.NumericUpDown();
            this.numPositiveWeight = new System.Windows.Forms.NumericUpDown();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.numPolyConstant = new System.Windows.Forms.NumericUpDown();
            this.numDegree = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSigmoid = new System.Windows.Forms.RadioButton();
            this.rbLaplacian = new System.Windows.Forms.RadioButton();
            this.rbPolynomial = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numLaplacianSigma = new System.Windows.Forms.NumericUpDown();
            this.numSigma = new System.Windows.Forms.NumericUpDown();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTestingSource = new System.Windows.Forms.DataGridView();
            this.btnTestingRun = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvPerformance = new System.Windows.Forms.DataGridView();
            this.TruePositives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FalseNegatives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrueNegatives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FalsePositives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sensitivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specificity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efficiency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcClassify = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvNegative = new System.Windows.Forms.DataGridView();
            this.CustomerID_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPositive = new System.Windows.Forms.DataGridView();
            this.CustomerID_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositiveCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NegativeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnSaveClassification = new System.Windows.Forms.Button();
            this.btnClassify = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgvCustomersDetails = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgUseDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InactivityPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneySpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcAnalyze = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.cmbYaxis = new System.Windows.Forms.ComboBox();
            this.cmbXaxis = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zedGraphAnalysis = new ZedGraph.ZedGraphControl();
            this.menuStrip1.SuspendLayout();
            this.tcBuyer.SuspendLayout();
            this.tpTraining.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearningSource)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNegativeWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPositiveWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolyConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLaplacianSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigma)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestingSource)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).BeginInit();
            this.tcClassify.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositive)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersDetails)).BeginInit();
            this.tcAnalyze.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(889, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRefresh_customerDetails});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            // 
            // miRefresh_customerDetails
            // 
            this.miRefresh_customerDetails.Name = "miRefresh_customerDetails";
            this.miRefresh_customerDetails.Size = new System.Drawing.Size(164, 22);
            this.miRefresh_customerDetails.Text = "&Customer Details";
            this.miRefresh_customerDetails.Click += new System.EventHandler(this.miRefresh_customerDetails_Click);
            // 
            // tcBuyer
            // 
            this.tcBuyer.Controls.Add(this.tpTraining);
            this.tcBuyer.Controls.Add(this.tcClassify);
            this.tcBuyer.Controls.Add(this.tcAnalyze);
            this.tcBuyer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBuyer.Location = new System.Drawing.Point(0, 24);
            this.tcBuyer.Name = "tcBuyer";
            this.tcBuyer.SelectedIndex = 0;
            this.tcBuyer.Size = new System.Drawing.Size(889, 494);
            this.tcBuyer.TabIndex = 2;
            // 
            // tpTraining
            // 
            this.tpTraining.Controls.Add(this.tabControl);
            this.tpTraining.Location = new System.Drawing.Point(4, 22);
            this.tpTraining.Name = "tpTraining";
            this.tpTraining.Padding = new System.Windows.Forms.Padding(3);
            this.tpTraining.Size = new System.Drawing.Size(881, 468);
            this.tpTraining.TabIndex = 0;
            this.tpTraining.Text = "Algorithm Training";
            this.tpTraining.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSamples);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(875, 462);
            this.tabControl.TabIndex = 17;
            // 
            // tabSamples
            // 
            this.tabSamples.Controls.Add(this.splitContainer7);
            this.tabSamples.Location = new System.Drawing.Point(4, 22);
            this.tabSamples.Name = "tabSamples";
            this.tabSamples.Padding = new System.Windows.Forms.Padding(3);
            this.tabSamples.Size = new System.Drawing.Size(867, 436);
            this.tabSamples.TabIndex = 0;
            this.tabSamples.Text = "Samples (Input)";
            this.tabSamples.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.btnLoadTrainingData);
            this.splitContainer7.Panel1.Controls.Add(this.groupBox7);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.groupBox15);
            this.splitContainer7.Size = new System.Drawing.Size(861, 430);
            this.splitContainer7.SplitterDistance = 291;
            this.splitContainer7.TabIndex = 9;
            // 
            // btnLoadTrainingData
            // 
            this.btnLoadTrainingData.Location = new System.Drawing.Point(3, 372);
            this.btnLoadTrainingData.Name = "btnLoadTrainingData";
            this.btnLoadTrainingData.Size = new System.Drawing.Size(282, 51);
            this.btnLoadTrainingData.TabIndex = 7;
            this.btnLoadTrainingData.Text = "Load Training Data";
            this.btnLoadTrainingData.UseVisualStyleBackColor = true;
            this.btnLoadTrainingData.Click += new System.EventHandler(this.btnLoadTrainingData_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvLearningSource);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(285, 363);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Training data";
            // 
            // dgvLearningSource
            // 
            this.dgvLearningSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLearningSource.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLearningSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLearningSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLearningSource.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLearningSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLearningSource.Location = new System.Drawing.Point(3, 16);
            this.dgvLearningSource.Name = "dgvLearningSource";
            this.dgvLearningSource.Size = new System.Drawing.Size(279, 344);
            this.dgvLearningSource.TabIndex = 5;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.graphInput);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Location = new System.Drawing.Point(0, 0);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(566, 430);
            this.groupBox15.TabIndex = 7;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Scatter Plot";
            // 
            // graphInput
            // 
            this.graphInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphInput.Location = new System.Drawing.Point(3, 16);
            this.graphInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graphInput.Name = "graphInput";
            this.graphInput.ScrollGrace = 0D;
            this.graphInput.ScrollMaxX = 0D;
            this.graphInput.ScrollMaxY = 0D;
            this.graphInput.ScrollMaxY2 = 0D;
            this.graphInput.ScrollMinX = 0D;
            this.graphInput.ScrollMinY = 0D;
            this.graphInput.ScrollMinY2 = 0D;
            this.graphInput.Size = new System.Drawing.Size(560, 411);
            this.graphInput.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(867, 436);
            this.tabPage4.TabIndex = 13;
            this.tabPage4.Text = "Machine Creation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.zedGraphControl2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(268, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(596, 430);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Visualization";
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl2.Location = new System.Drawing.Point(3, 16);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(590, 411);
            this.zedGraphControl2.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEstimateSig);
            this.groupBox3.Controls.Add(this.btnEstimateLaplacian);
            this.groupBox3.Controls.Add(this.btnEstimateGaussian);
            this.groupBox3.Controls.Add(this.btnEstimateC);
            this.groupBox3.Controls.Add(this.btnSampleRunAnalysis);
            this.groupBox3.Controls.Add(this.numT);
            this.groupBox3.Controls.Add(this.rbGaussian);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numSigB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numSigAlpha);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numNegativeWeight);
            this.groupBox3.Controls.Add(this.numPositiveWeight);
            this.groupBox3.Controls.Add(this.numC);
            this.groupBox3.Controls.Add(this.numPolyConstant);
            this.groupBox3.Controls.Add(this.numDegree);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rbSigmoid);
            this.groupBox3.Controls.Add(this.rbLaplacian);
            this.groupBox3.Controls.Add(this.rbPolynomial);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.numLaplacianSigma);
            this.groupBox3.Controls.Add(this.numSigma);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 430);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // btnEstimateSig
            // 
            this.btnEstimateSig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstimateSig.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimateSig.Location = new System.Drawing.Point(194, 237);
            this.btnEstimateSig.Name = "btnEstimateSig";
            this.btnEstimateSig.Size = new System.Drawing.Size(65, 48);
            this.btnEstimateSig.TabIndex = 1;
            this.btnEstimateSig.Text = "Estimate";
            this.btnEstimateSig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstimateSig.UseVisualStyleBackColor = true;
            this.btnEstimateSig.Click += new System.EventHandler(this.btnEstimateSig_Click);
            // 
            // btnEstimateLaplacian
            // 
            this.btnEstimateLaplacian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstimateLaplacian.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimateLaplacian.Location = new System.Drawing.Point(194, 180);
            this.btnEstimateLaplacian.Name = "btnEstimateLaplacian";
            this.btnEstimateLaplacian.Size = new System.Drawing.Size(65, 21);
            this.btnEstimateLaplacian.TabIndex = 1;
            this.btnEstimateLaplacian.Text = "Estimate";
            this.btnEstimateLaplacian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstimateLaplacian.UseVisualStyleBackColor = true;
            this.btnEstimateLaplacian.Click += new System.EventHandler(this.btnEstimateLaplacian_Click);
            // 
            // btnEstimateGaussian
            // 
            this.btnEstimateGaussian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstimateGaussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimateGaussian.Location = new System.Drawing.Point(194, 42);
            this.btnEstimateGaussian.Name = "btnEstimateGaussian";
            this.btnEstimateGaussian.Size = new System.Drawing.Size(65, 21);
            this.btnEstimateGaussian.TabIndex = 1;
            this.btnEstimateGaussian.Text = "Estimate";
            this.btnEstimateGaussian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstimateGaussian.UseVisualStyleBackColor = true;
            this.btnEstimateGaussian.Click += new System.EventHandler(this.btnEstimateGaussian_Click);
            // 
            // btnEstimateC
            // 
            this.btnEstimateC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstimateC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimateC.Location = new System.Drawing.Point(202, 307);
            this.btnEstimateC.Name = "btnEstimateC";
            this.btnEstimateC.Size = new System.Drawing.Size(57, 21);
            this.btnEstimateC.TabIndex = 1;
            this.btnEstimateC.Text = "Estimate";
            this.btnEstimateC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstimateC.UseVisualStyleBackColor = true;
            this.btnEstimateC.Click += new System.EventHandler(this.btnEstimateC_Click);
            // 
            // btnSampleRunAnalysis
            // 
            this.btnSampleRunAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSampleRunAnalysis.Location = new System.Drawing.Point(6, 383);
            this.btnSampleRunAnalysis.Name = "btnSampleRunAnalysis";
            this.btnSampleRunAnalysis.Size = new System.Drawing.Size(253, 40);
            this.btnSampleRunAnalysis.TabIndex = 1;
            this.btnSampleRunAnalysis.Text = "Create Machine";
            this.btnSampleRunAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSampleRunAnalysis.UseVisualStyleBackColor = true;
            this.btnSampleRunAnalysis.Click += new System.EventHandler(this.btnSampleRunAnalysis_Click);
            // 
            // numT
            // 
            this.numT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numT.DecimalPlaces = 7;
            this.numT.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numT.Location = new System.Drawing.Point(94, 360);
            this.numT.Name = "numT";
            this.numT.Size = new System.Drawing.Size(165, 20);
            this.numT.TabIndex = 7;
            this.numT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numT.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // rbGaussian
            // 
            this.rbGaussian.AutoSize = true;
            this.rbGaussian.Checked = true;
            this.rbGaussian.Location = new System.Drawing.Point(19, 19);
            this.rbGaussian.Name = "rbGaussian";
            this.rbGaussian.Size = new System.Drawing.Size(102, 17);
            this.rbGaussian.TabIndex = 6;
            this.rbGaussian.TabStop = true;
            this.rbGaussian.Text = "Gaussian Kernel";
            this.rbGaussian.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sigma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sigma:";
            // 
            // numSigB
            // 
            this.numSigB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSigB.DecimalPlaces = 6;
            this.numSigB.Location = new System.Drawing.Point(96, 265);
            this.numSigB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numSigB.Name = "numSigB";
            this.numSigB.Size = new System.Drawing.Size(92, 20);
            this.numSigB.TabIndex = 7;
            this.numSigB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Alpha";
            // 
            // numSigAlpha
            // 
            this.numSigAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSigAlpha.DecimalPlaces = 7;
            this.numSigAlpha.Location = new System.Drawing.Point(96, 238);
            this.numSigAlpha.Name = "numSigAlpha";
            this.numSigAlpha.Size = new System.Drawing.Size(92, 20);
            this.numSigAlpha.TabIndex = 7;
            this.numSigAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Constant:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Degree:";
            // 
            // numNegativeWeight
            // 
            this.numNegativeWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNegativeWeight.DecimalPlaces = 7;
            this.numNegativeWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numNegativeWeight.Location = new System.Drawing.Point(178, 334);
            this.numNegativeWeight.Name = "numNegativeWeight";
            this.numNegativeWeight.Size = new System.Drawing.Size(81, 20);
            this.numNegativeWeight.TabIndex = 7;
            this.numNegativeWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNegativeWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPositiveWeight
            // 
            this.numPositiveWeight.DecimalPlaces = 7;
            this.numPositiveWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPositiveWeight.Location = new System.Drawing.Point(94, 334);
            this.numPositiveWeight.Name = "numPositiveWeight";
            this.numPositiveWeight.Size = new System.Drawing.Size(78, 20);
            this.numPositiveWeight.TabIndex = 7;
            this.numPositiveWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPositiveWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numC
            // 
            this.numC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numC.DecimalPlaces = 7;
            this.numC.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numC.Location = new System.Drawing.Point(94, 307);
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(102, 20);
            this.numC.TabIndex = 7;
            this.numC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPolyConstant
            // 
            this.numPolyConstant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPolyConstant.DecimalPlaces = 7;
            this.numPolyConstant.Location = new System.Drawing.Point(90, 125);
            this.numPolyConstant.Name = "numPolyConstant";
            this.numPolyConstant.Size = new System.Drawing.Size(94, 20);
            this.numPolyConstant.TabIndex = 7;
            this.numPolyConstant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPolyConstant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDegree
            // 
            this.numDegree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numDegree.Location = new System.Drawing.Point(90, 99);
            this.numDegree.Name = "numDegree";
            this.numDegree.Size = new System.Drawing.Size(94, 20);
            this.numDegree.TabIndex = 7;
            this.numDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDegree.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Constant:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Complexity";
            // 
            // rbSigmoid
            // 
            this.rbSigmoid.AutoSize = true;
            this.rbSigmoid.Location = new System.Drawing.Point(19, 215);
            this.rbSigmoid.Name = "rbSigmoid";
            this.rbSigmoid.Size = new System.Drawing.Size(95, 17);
            this.rbSigmoid.TabIndex = 6;
            this.rbSigmoid.TabStop = true;
            this.rbSigmoid.Text = "Sigmoid Kernel";
            this.rbSigmoid.UseVisualStyleBackColor = true;
            // 
            // rbLaplacian
            // 
            this.rbLaplacian.AutoSize = true;
            this.rbLaplacian.Location = new System.Drawing.Point(19, 160);
            this.rbLaplacian.Name = "rbLaplacian";
            this.rbLaplacian.Size = new System.Drawing.Size(104, 17);
            this.rbLaplacian.TabIndex = 6;
            this.rbLaplacian.TabStop = true;
            this.rbLaplacian.Text = "Laplacian Kernel";
            this.rbLaplacian.UseVisualStyleBackColor = true;
            // 
            // rbPolynomial
            // 
            this.rbPolynomial.AutoSize = true;
            this.rbPolynomial.Location = new System.Drawing.Point(19, 76);
            this.rbPolynomial.Name = "rbPolynomial";
            this.rbPolynomial.Size = new System.Drawing.Size(108, 17);
            this.rbPolynomial.TabIndex = 6;
            this.rbPolynomial.TabStop = true;
            this.rbPolynomial.Text = "Polynomial Kernel";
            this.rbPolynomial.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Cost Ratio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tolerance";
            // 
            // numLaplacianSigma
            // 
            this.numLaplacianSigma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numLaplacianSigma.DecimalPlaces = 7;
            this.numLaplacianSigma.Location = new System.Drawing.Point(90, 180);
            this.numLaplacianSigma.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLaplacianSigma.Name = "numLaplacianSigma";
            this.numLaplacianSigma.Size = new System.Drawing.Size(98, 20);
            this.numLaplacianSigma.TabIndex = 7;
            this.numLaplacianSigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLaplacianSigma.Value = new decimal(new int[] {
            12236,
            0,
            0,
            262144});
            // 
            // numSigma
            // 
            this.numSigma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSigma.DecimalPlaces = 7;
            this.numSigma.Location = new System.Drawing.Point(90, 43);
            this.numSigma.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSigma.Name = "numSigma";
            this.numSigma.Size = new System.Drawing.Size(98, 20);
            this.numSigma.TabIndex = 7;
            this.numSigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSigma.Value = new decimal(new int[] {
            12236,
            0,
            0,
            262144});
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(867, 436);
            this.tabPage5.TabIndex = 12;
            this.tabPage5.Text = "Model Testing";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btnTestingRun);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox11);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Size = new System.Drawing.Size(861, 430);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTestingSource);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 369);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testing data";
            // 
            // dgvTestingSource
            // 
            this.dgvTestingSource.AllowUserToAddRows = false;
            this.dgvTestingSource.AllowUserToDeleteRows = false;
            this.dgvTestingSource.AllowUserToResizeRows = false;
            this.dgvTestingSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestingSource.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestingSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestingSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTestingSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestingSource.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestingSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTestingSource.Location = new System.Drawing.Point(3, 16);
            this.dgvTestingSource.Name = "dgvTestingSource";
            this.dgvTestingSource.ReadOnly = true;
            this.dgvTestingSource.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTestingSource.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTestingSource.Size = new System.Drawing.Size(266, 350);
            this.dgvTestingSource.TabIndex = 1;
            // 
            // btnTestingRun
            // 
            this.btnTestingRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTestingRun.Location = new System.Drawing.Point(0, 369);
            this.btnTestingRun.Name = "btnTestingRun";
            this.btnTestingRun.Size = new System.Drawing.Size(272, 61);
            this.btnTestingRun.TabIndex = 3;
            this.btnTestingRun.Text = "Run";
            this.btnTestingRun.UseVisualStyleBackColor = true;
            this.btnTestingRun.Click += new System.EventHandler(this.btnTestingRun_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.zedGraphControl1);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(0, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(585, 344);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Visualization";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 16);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(579, 325);
            this.zedGraphControl1.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvPerformance);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(0, 344);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(585, 86);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Performance Measures";
            // 
            // dgvPerformance
            // 
            this.dgvPerformance.AllowUserToAddRows = false;
            this.dgvPerformance.AllowUserToDeleteRows = false;
            this.dgvPerformance.AllowUserToResizeRows = false;
            this.dgvPerformance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerformance.BackgroundColor = System.Drawing.Color.White;
            this.dgvPerformance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerformance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerformance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TruePositives,
            this.FalseNegatives,
            this.TrueNegatives,
            this.FalsePositives,
            this.Sensitivity,
            this.Specificity,
            this.Efficiency,
            this.Accuracy});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerformance.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerformance.Location = new System.Drawing.Point(3, 16);
            this.dgvPerformance.Name = "dgvPerformance";
            this.dgvPerformance.ReadOnly = true;
            this.dgvPerformance.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPerformance.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPerformance.Size = new System.Drawing.Size(579, 67);
            this.dgvPerformance.TabIndex = 3;
            // 
            // TruePositives
            // 
            this.TruePositives.DataPropertyName = "TruePositives";
            this.TruePositives.HeaderText = "True Positives";
            this.TruePositives.Name = "TruePositives";
            this.TruePositives.ReadOnly = true;
            this.TruePositives.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FalseNegatives
            // 
            this.FalseNegatives.DataPropertyName = "FalseNegatives";
            this.FalseNegatives.HeaderText = "False Negatives";
            this.FalseNegatives.Name = "FalseNegatives";
            this.FalseNegatives.ReadOnly = true;
            this.FalseNegatives.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TrueNegatives
            // 
            this.TrueNegatives.DataPropertyName = "TrueNegatives";
            this.TrueNegatives.HeaderText = "True Negatives";
            this.TrueNegatives.Name = "TrueNegatives";
            this.TrueNegatives.ReadOnly = true;
            this.TrueNegatives.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FalsePositives
            // 
            this.FalsePositives.DataPropertyName = "FalsePositives";
            this.FalsePositives.HeaderText = "False Positives";
            this.FalsePositives.Name = "FalsePositives";
            this.FalsePositives.ReadOnly = true;
            this.FalsePositives.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Sensitivity
            // 
            this.Sensitivity.DataPropertyName = "Sensitivity";
            this.Sensitivity.HeaderText = "Sensitivity";
            this.Sensitivity.Name = "Sensitivity";
            this.Sensitivity.ReadOnly = true;
            this.Sensitivity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Specificity
            // 
            this.Specificity.DataPropertyName = "Specificity";
            this.Specificity.HeaderText = "Specificity";
            this.Specificity.Name = "Specificity";
            this.Specificity.ReadOnly = true;
            this.Specificity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Efficiency
            // 
            this.Efficiency.DataPropertyName = "Efficiency";
            this.Efficiency.HeaderText = "Efficiency";
            this.Efficiency.Name = "Efficiency";
            this.Efficiency.ReadOnly = true;
            this.Efficiency.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Accuracy
            // 
            this.Accuracy.DataPropertyName = "Accuracy";
            this.Accuracy.HeaderText = "Accuracy";
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.ReadOnly = true;
            this.Accuracy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tcClassify
            // 
            this.tcClassify.Controls.Add(this.groupBox9);
            this.tcClassify.Controls.Add(this.groupBox10);
            this.tcClassify.Controls.Add(this.groupBox12);
            this.tcClassify.Controls.Add(this.groupBox8);
            this.tcClassify.Location = new System.Drawing.Point(4, 22);
            this.tcClassify.Name = "tcClassify";
            this.tcClassify.Padding = new System.Windows.Forms.Padding(3);
            this.tcClassify.Size = new System.Drawing.Size(881, 468);
            this.tcClassify.TabIndex = 1;
            this.tcClassify.Text = "Classify Customers";
            this.tcClassify.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.dgvNegative);
            this.groupBox9.Controls.Add(this.dgvPositive);
            this.groupBox9.Location = new System.Drawing.Point(6, 215);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(361, 247);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Classification";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Positive";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(170, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Negative";
            // 
            // dgvNegative
            // 
            this.dgvNegative.AllowUserToAddRows = false;
            this.dgvNegative.AllowUserToDeleteRows = false;
            this.dgvNegative.BackgroundColor = System.Drawing.Color.White;
            this.dgvNegative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNegative.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID_N});
            this.dgvNegative.Location = new System.Drawing.Point(173, 31);
            this.dgvNegative.Name = "dgvNegative";
            this.dgvNegative.ReadOnly = true;
            this.dgvNegative.Size = new System.Drawing.Size(170, 213);
            this.dgvNegative.TabIndex = 2;
            // 
            // CustomerID_N
            // 
            this.CustomerID_N.HeaderText = "CustomerID";
            this.CustomerID_N.Name = "CustomerID_N";
            this.CustomerID_N.ReadOnly = true;
            this.CustomerID_N.Width = 125;
            // 
            // dgvPositive
            // 
            this.dgvPositive.AllowUserToAddRows = false;
            this.dgvPositive.AllowUserToDeleteRows = false;
            this.dgvPositive.BackgroundColor = System.Drawing.Color.White;
            this.dgvPositive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID_P});
            this.dgvPositive.Location = new System.Drawing.Point(5, 31);
            this.dgvPositive.Name = "dgvPositive";
            this.dgvPositive.ReadOnly = true;
            this.dgvPositive.Size = new System.Drawing.Size(162, 213);
            this.dgvPositive.TabIndex = 1;
            // 
            // CustomerID_P
            // 
            this.CustomerID_P.HeaderText = "CustomerID";
            this.CustomerID_P.Name = "CustomerID_P";
            this.CustomerID_P.ReadOnly = true;
            this.CustomerID_P.Width = 119;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dgvDetails);
            this.groupBox10.Location = new System.Drawing.Point(373, 311);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(500, 151);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Details";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AllowUserToResizeRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Percentage,
            this.Ratio,
            this.PositiveCount,
            this.NegativeCount,
            this.Total});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(3, 16);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDetails.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetails.Size = new System.Drawing.Size(494, 132);
            this.dgvDetails.TabIndex = 3;
            // 
            // Percentage
            // 
            this.Percentage.DataPropertyName = "TruePositives";
            this.Percentage.HeaderText = "Percentage";
            this.Percentage.Name = "Percentage";
            this.Percentage.ReadOnly = true;
            // 
            // Ratio
            // 
            this.Ratio.DataPropertyName = "FalseNegatives";
            this.Ratio.HeaderText = "Ratio";
            this.Ratio.Name = "Ratio";
            this.Ratio.ReadOnly = true;
            // 
            // PositiveCount
            // 
            this.PositiveCount.DataPropertyName = "TrueNegatives";
            this.PositiveCount.HeaderText = "Positive Count";
            this.PositiveCount.Name = "PositiveCount";
            this.PositiveCount.ReadOnly = true;
            // 
            // NegativeCount
            // 
            this.NegativeCount.DataPropertyName = "FalsePositives";
            this.NegativeCount.HeaderText = "Negative Count";
            this.NegativeCount.Name = "NegativeCount";
            this.NegativeCount.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Sensitivity";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnSaveClassification);
            this.groupBox12.Controls.Add(this.btnClassify);
            this.groupBox12.Location = new System.Drawing.Point(373, 215);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(500, 90);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Classify";
            // 
            // btnSaveClassification
            // 
            this.btnSaveClassification.Enabled = false;
            this.btnSaveClassification.Location = new System.Drawing.Point(247, 19);
            this.btnSaveClassification.Name = "btnSaveClassification";
            this.btnSaveClassification.Size = new System.Drawing.Size(247, 53);
            this.btnSaveClassification.TabIndex = 1;
            this.btnSaveClassification.Text = "Save Classification";
            this.btnSaveClassification.UseVisualStyleBackColor = true;
            this.btnSaveClassification.Click += new System.EventHandler(this.btnSaveClassification_Click);
            // 
            // btnClassify
            // 
            this.btnClassify.Location = new System.Drawing.Point(6, 19);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(235, 53);
            this.btnClassify.TabIndex = 0;
            this.btnClassify.Text = "Classify";
            this.btnClassify.UseVisualStyleBackColor = true;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dgvCustomersDetails);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(867, 203);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Customer Details";
            // 
            // dgvCustomersDetails
            // 
            this.dgvCustomersDetails.AllowUserToAddRows = false;
            this.dgvCustomersDetails.AllowUserToDeleteRows = false;
            this.dgvCustomersDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomersDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.AccessCount,
            this.AvgUseDuration,
            this.Age,
            this.InactivityPeriod,
            this.MoneySpent,
            this.Buyer});
            this.dgvCustomersDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomersDetails.Location = new System.Drawing.Point(3, 16);
            this.dgvCustomersDetails.Name = "dgvCustomersDetails";
            this.dgvCustomersDetails.ReadOnly = true;
            this.dgvCustomersDetails.Size = new System.Drawing.Size(861, 184);
            this.dgvCustomersDetails.TabIndex = 1;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // AccessCount
            // 
            this.AccessCount.HeaderText = "Access Count";
            this.AccessCount.Name = "AccessCount";
            this.AccessCount.ReadOnly = true;
            // 
            // AvgUseDuration
            // 
            this.AvgUseDuration.HeaderText = "Average Use Duration";
            this.AvgUseDuration.Name = "AvgUseDuration";
            this.AvgUseDuration.ReadOnly = true;
            this.AvgUseDuration.Width = 180;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // InactivityPeriod
            // 
            this.InactivityPeriod.HeaderText = "Inactivity Period";
            this.InactivityPeriod.Name = "InactivityPeriod";
            this.InactivityPeriod.ReadOnly = true;
            this.InactivityPeriod.Width = 130;
            // 
            // MoneySpent
            // 
            this.MoneySpent.HeaderText = "Money Spent";
            this.MoneySpent.Name = "MoneySpent";
            this.MoneySpent.ReadOnly = true;
            this.MoneySpent.Width = 120;
            // 
            // Buyer
            // 
            this.Buyer.HeaderText = "Buyer";
            this.Buyer.Name = "Buyer";
            this.Buyer.ReadOnly = true;
            // 
            // tcAnalyze
            // 
            this.tcAnalyze.Controls.Add(this.groupBox5);
            this.tcAnalyze.Controls.Add(this.groupBox1);
            this.tcAnalyze.Location = new System.Drawing.Point(4, 22);
            this.tcAnalyze.Name = "tcAnalyze";
            this.tcAnalyze.Padding = new System.Windows.Forms.Padding(3);
            this.tcAnalyze.Size = new System.Drawing.Size(881, 468);
            this.tcAnalyze.TabIndex = 2;
            this.tcAnalyze.Text = "Analyze Customers";
            this.tcAnalyze.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAnalyze);
            this.groupBox5.Controls.Add(this.cmbYaxis);
            this.groupBox5.Controls.Add(this.cmbXaxis);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 459);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Set Dimensions";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(3, 142);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(226, 52);
            this.btnAnalyze.TabIndex = 5;
            this.btnAnalyze.Text = "Create Analysis Graph";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // cmbYaxis
            // 
            this.cmbYaxis.FormattingEnabled = true;
            this.cmbYaxis.Items.AddRange(new object[] {
            "AccessCount",
            "AvgUseDuration",
            "Age",
            "InactivityPeriod",
            "MoneySpent"});
            this.cmbYaxis.Location = new System.Drawing.Point(67, 88);
            this.cmbYaxis.Name = "cmbYaxis";
            this.cmbYaxis.Size = new System.Drawing.Size(121, 21);
            this.cmbYaxis.TabIndex = 4;
            this.cmbYaxis.SelectedIndexChanged += new System.EventHandler(this.cmbYaxis_SelectedIndexChanged);
            // 
            // cmbXaxis
            // 
            this.cmbXaxis.FormattingEnabled = true;
            this.cmbXaxis.Items.AddRange(new object[] {
            "AccessCount",
            "AvgUseDuration",
            "Age",
            "InactivityPeriod",
            "MoneySpent"});
            this.cmbXaxis.Location = new System.Drawing.Point(67, 54);
            this.cmbXaxis.Name = "cmbXaxis";
            this.cmbXaxis.Size = new System.Drawing.Size(121, 21);
            this.cmbXaxis.TabIndex = 3;
            this.cmbXaxis.SelectedIndexChanged += new System.EventHandler(this.cmbXaxis_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zedGraphAnalysis);
            this.groupBox1.Location = new System.Drawing.Point(242, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analyze Buyers";
            // 
            // zedGraphAnalysis
            // 
            this.zedGraphAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphAnalysis.Location = new System.Drawing.Point(3, 16);
            this.zedGraphAnalysis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphAnalysis.Name = "zedGraphAnalysis";
            this.zedGraphAnalysis.ScrollGrace = 0D;
            this.zedGraphAnalysis.ScrollMaxX = 0D;
            this.zedGraphAnalysis.ScrollMaxY = 0D;
            this.zedGraphAnalysis.ScrollMaxY2 = 0D;
            this.zedGraphAnalysis.ScrollMinX = 0D;
            this.zedGraphAnalysis.ScrollMinY = 0D;
            this.zedGraphAnalysis.ScrollMinY2 = 0D;
            this.zedGraphAnalysis.Size = new System.Drawing.Size(625, 440);
            this.zedGraphAnalysis.TabIndex = 5;
            // 
            // ClassifyBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 540);
            this.Controls.Add(this.tcBuyer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClassifyBuyer";
            this.Text = "Buyers Classifier";
            this.Load += new System.EventHandler(this.Classifier_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcBuyer.ResumeLayout(false);
            this.tpTraining.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabSamples.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearningSource)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNegativeWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPositiveWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolyConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLaplacianSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigma)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestingSource)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).EndInit();
            this.tcClassify.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositive)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersDetails)).EndInit();
            this.tcAnalyze.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabControl tcBuyer;
        private System.Windows.Forms.TabPage tpTraining;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSamples;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvLearningSource;
        private System.Windows.Forms.GroupBox groupBox15;
        private ZedGraph.ZedGraphControl graphInput;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEstimateSig;
        private System.Windows.Forms.Button btnEstimateLaplacian;
        private System.Windows.Forms.Button btnEstimateGaussian;
        private System.Windows.Forms.Button btnEstimateC;
        private System.Windows.Forms.Button btnSampleRunAnalysis;
        private System.Windows.Forms.NumericUpDown numT;
        private System.Windows.Forms.RadioButton rbGaussian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSigB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSigAlpha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numNegativeWeight;
        private System.Windows.Forms.NumericUpDown numPositiveWeight;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.NumericUpDown numPolyConstant;
        private System.Windows.Forms.NumericUpDown numDegree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSigmoid;
        private System.Windows.Forms.RadioButton rbLaplacian;
        private System.Windows.Forms.RadioButton rbPolynomial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numLaplacianSigma;
        private System.Windows.Forms.NumericUpDown numSigma;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTestingSource;
        private System.Windows.Forms.Button btnTestingRun;
        private System.Windows.Forms.GroupBox groupBox11;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabPage tcClassify;
        private System.Windows.Forms.TabPage tcAnalyze;
        private System.Windows.Forms.Button btnLoadTrainingData;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dgvNegative;
        private System.Windows.Forms.DataGridView dgvPositive;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSaveClassification;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID_N;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID_P;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridView dgvCustomersDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgUseDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn InactivityPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneySpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buyer;
        private System.Windows.Forms.DataGridView dgvPerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruePositives;
        private System.Windows.Forms.DataGridViewTextBoxColumn FalseNegatives;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrueNegatives;
        private System.Windows.Forms.DataGridViewTextBoxColumn FalsePositives;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sensitivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specificity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efficiency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accuracy;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRefresh_customerDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositiveCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn NegativeCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private ZedGraph.ZedGraphControl zedGraphAnalysis;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.ComboBox cmbYaxis;
        private System.Windows.Forms.ComboBox cmbXaxis;
        private System.Windows.Forms.Label label11;
    }
}