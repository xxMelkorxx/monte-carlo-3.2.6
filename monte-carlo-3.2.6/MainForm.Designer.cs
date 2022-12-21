namespace monte_carlo
{
    partial class MainForm
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
			System.Windows.Forms.GroupBox groupBox_paramsModel;
			System.Windows.Forms.Label label_Rl;
			System.Windows.Forms.Label label_No;
			System.Windows.Forms.GroupBox groupBox_paramsSimulation;
			System.Windows.Forms.Label label_intervalTimer;
			System.Windows.Forms.Label label_mks;
			System.Windows.Forms.Label label_Pd;
			System.Windows.Forms.Label label_Pa;
			System.Windows.Forms.GroupBox groupBox_outputData;
			System.Windows.Forms.Label label_countParticles;
			System.Windows.Forms.Label label_countStep;
			System.Windows.Forms.Label label_countAbsorbedParticles;
			System.Windows.Forms.Label label_countEjectedParticles;
			System.Windows.Forms.Label label_countBoom;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.GroupBox gB_chartParticles;
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.GroupBox groupBox2;
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.nud_Rl = new System.Windows.Forms.NumericUpDown();
			this.nud_No = new System.Windows.Forms.NumericUpDown();
			this.checkBox_addCond = new System.Windows.Forms.CheckBox();
			this.nud_intervalTimer = new System.Windows.Forms.NumericUpDown();
			this.nud_mks = new System.Windows.Forms.NumericUpDown();
			this.nud_Pd = new System.Windows.Forms.NumericUpDown();
			this.nud_Pa = new System.Windows.Forms.NumericUpDown();
			this.tB_countParticles = new System.Windows.Forms.TextBox();
			this.tB_countStep = new System.Windows.Forms.TextBox();
			this.tB_countAbsorbedParticles = new System.Windows.Forms.TextBox();
			this.tB_countEjectedParticles = new System.Windows.Forms.TextBox();
			this.chart_сountParticles = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart_countEjectedParticles = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart_countAbsorbedParticles = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.pB_model = new System.Windows.Forms.PictureBox();
			this.button_start = new System.Windows.Forms.Button();
			this.timer_mks = new System.Windows.Forms.Timer(this.components);
			this.button_createModel = new System.Windows.Forms.Button();
			this.groupBox_statusReactor = new System.Windows.Forms.GroupBox();
			this.label_statusReactor = new System.Windows.Forms.Label();
			this.progressBar_statusReactor = new System.Windows.Forms.ProgressBar();
			this.nud_countBoom = new System.Windows.Forms.NumericUpDown();
			this.button_saveData = new System.Windows.Forms.Button();
			groupBox_paramsModel = new System.Windows.Forms.GroupBox();
			label_Rl = new System.Windows.Forms.Label();
			label_No = new System.Windows.Forms.Label();
			groupBox_paramsSimulation = new System.Windows.Forms.GroupBox();
			label_intervalTimer = new System.Windows.Forms.Label();
			label_mks = new System.Windows.Forms.Label();
			label_Pd = new System.Windows.Forms.Label();
			label_Pa = new System.Windows.Forms.Label();
			groupBox_outputData = new System.Windows.Forms.GroupBox();
			label_countParticles = new System.Windows.Forms.Label();
			label_countStep = new System.Windows.Forms.Label();
			label_countAbsorbedParticles = new System.Windows.Forms.Label();
			label_countEjectedParticles = new System.Windows.Forms.Label();
			label_countBoom = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			gB_chartParticles = new System.Windows.Forms.GroupBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			groupBox2 = new System.Windows.Forms.GroupBox();
			groupBox_paramsModel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_Rl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_No)).BeginInit();
			groupBox_paramsSimulation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_intervalTimer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_mks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Pd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Pa)).BeginInit();
			groupBox_outputData.SuspendLayout();
			gB_chartParticles.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart_сountParticles)).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart_countEjectedParticles)).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart_countAbsorbedParticles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_model)).BeginInit();
			this.groupBox_statusReactor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_countBoom)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox_paramsModel
			// 
			groupBox_paramsModel.Controls.Add(label_Rl);
			groupBox_paramsModel.Controls.Add(this.nud_Rl);
			groupBox_paramsModel.Controls.Add(label_No);
			groupBox_paramsModel.Controls.Add(this.nud_No);
			groupBox_paramsModel.Location = new System.Drawing.Point(623, 16);
			groupBox_paramsModel.Name = "groupBox_paramsModel";
			groupBox_paramsModel.Size = new System.Drawing.Size(322, 83);
			groupBox_paramsModel.TabIndex = 2;
			groupBox_paramsModel.TabStop = false;
			groupBox_paramsModel.Text = "Параметры системы";
			// 
			// label_Rl
			// 
			label_Rl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_Rl.Location = new System.Drawing.Point(6, 53);
			label_Rl.Name = "label_Rl";
			label_Rl.Size = new System.Drawing.Size(229, 25);
			label_Rl.TabIndex = 3;
			label_Rl.Text = "Отношение радиус/пробег, R/λ:";
			label_Rl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_Rl
			// 
			this.nud_Rl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nud_Rl.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nud_Rl.Location = new System.Drawing.Point(241, 53);
			this.nud_Rl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nud_Rl.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nud_Rl.Name = "nud_Rl";
			this.nud_Rl.Size = new System.Drawing.Size(75, 25);
			this.nud_Rl.TabIndex = 2;
			this.nud_Rl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nud_Rl.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label_No
			// 
			label_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_No.Location = new System.Drawing.Point(6, 22);
			label_No.Name = "label_No";
			label_No.Size = new System.Drawing.Size(229, 25);
			label_No.TabIndex = 1;
			label_No.Text = "Начальное число частиц N₀:";
			label_No.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_No
			// 
			this.nud_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nud_No.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nud_No.Location = new System.Drawing.Point(241, 22);
			this.nud_No.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nud_No.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_No.Name = "nud_No";
			this.nud_No.Size = new System.Drawing.Size(75, 25);
			this.nud_No.TabIndex = 0;
			this.nud_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nud_No.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// groupBox_paramsSimulation
			// 
			groupBox_paramsSimulation.Controls.Add(this.checkBox_addCond);
			groupBox_paramsSimulation.Controls.Add(label_intervalTimer);
			groupBox_paramsSimulation.Controls.Add(this.nud_intervalTimer);
			groupBox_paramsSimulation.Controls.Add(label_mks);
			groupBox_paramsSimulation.Controls.Add(this.nud_mks);
			groupBox_paramsSimulation.Controls.Add(label_Pd);
			groupBox_paramsSimulation.Controls.Add(this.nud_Pd);
			groupBox_paramsSimulation.Controls.Add(label_Pa);
			groupBox_paramsSimulation.Controls.Add(this.nud_Pa);
			groupBox_paramsSimulation.Location = new System.Drawing.Point(623, 105);
			groupBox_paramsSimulation.Name = "groupBox_paramsSimulation";
			groupBox_paramsSimulation.Size = new System.Drawing.Size(322, 172);
			groupBox_paramsSimulation.TabIndex = 3;
			groupBox_paramsSimulation.TabStop = false;
			groupBox_paramsSimulation.Text = "Параметры симуляции";
			// 
			// checkBox_addCond
			// 
			this.checkBox_addCond.AutoSize = true;
			this.checkBox_addCond.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox_addCond.Location = new System.Drawing.Point(17, 148);
			this.checkBox_addCond.Name = "checkBox_addCond";
			this.checkBox_addCond.Size = new System.Drawing.Size(299, 21);
			this.checkBox_addCond.TabIndex = 12;
			this.checkBox_addCond.Text = "Дополнительное условие при делении";
			this.checkBox_addCond.UseVisualStyleBackColor = true;
			// 
			// label_intervalTimer
			// 
			label_intervalTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_intervalTimer.Location = new System.Drawing.Point(6, 117);
			label_intervalTimer.Name = "label_intervalTimer";
			label_intervalTimer.Size = new System.Drawing.Size(229, 25);
			label_intervalTimer.TabIndex = 11;
			label_intervalTimer.Text = "Интервал тика (мск):";
			label_intervalTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_intervalTimer
			// 
			this.nud_intervalTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nud_intervalTimer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nud_intervalTimer.Location = new System.Drawing.Point(241, 117);
			this.nud_intervalTimer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nud_intervalTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_intervalTimer.Name = "nud_intervalTimer";
			this.nud_intervalTimer.Size = new System.Drawing.Size(75, 25);
			this.nud_intervalTimer.TabIndex = 10;
			this.nud_intervalTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nud_intervalTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label_mks
			// 
			label_mks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_mks.Location = new System.Drawing.Point(6, 86);
			label_mks.Name = "label_mks";
			label_mks.Size = new System.Drawing.Size(229, 25);
			label_mks.TabIndex = 9;
			label_mks.Text = "Число МКШ:";
			label_mks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_mks
			// 
			this.nud_mks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nud_mks.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nud_mks.Location = new System.Drawing.Point(241, 86);
			this.nud_mks.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.nud_mks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_mks.Name = "nud_mks";
			this.nud_mks.Size = new System.Drawing.Size(75, 25);
			this.nud_mks.TabIndex = 8;
			this.nud_mks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nud_mks.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// label_Pd
			// 
			label_Pd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_Pd.Location = new System.Drawing.Point(6, 55);
			label_Pd.Name = "label_Pd";
			label_Pd.Size = new System.Drawing.Size(229, 25);
			label_Pd.TabIndex = 7;
			label_Pd.Text = "Вероятность деления:";
			label_Pd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_Pd
			// 
			this.nud_Pd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nud_Pd.DecimalPlaces = 3;
			this.nud_Pd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.nud_Pd.Location = new System.Drawing.Point(241, 55);
			this.nud_Pd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_Pd.Name = "nud_Pd";
			this.nud_Pd.Size = new System.Drawing.Size(75, 25);
			this.nud_Pd.TabIndex = 6;
			this.nud_Pd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nud_Pd.Value = new decimal(new int[] {
            22,
            0,
            0,
            196608});
			// 
			// label_Pa
			// 
			label_Pa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_Pa.Location = new System.Drawing.Point(6, 24);
			label_Pa.Name = "label_Pa";
			label_Pa.Size = new System.Drawing.Size(229, 25);
			label_Pa.TabIndex = 5;
			label_Pa.Text = "Вероятность поглощения:";
			label_Pa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_Pa
			// 
			this.nud_Pa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nud_Pa.DecimalPlaces = 3;
			this.nud_Pa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.nud_Pa.Location = new System.Drawing.Point(241, 24);
			this.nud_Pa.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_Pa.Name = "nud_Pa";
			this.nud_Pa.Size = new System.Drawing.Size(75, 25);
			this.nud_Pa.TabIndex = 4;
			this.nud_Pa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nud_Pa.Value = new decimal(new int[] {
            15,
            0,
            0,
            196608});
			// 
			// groupBox_outputData
			// 
			groupBox_outputData.Controls.Add(label_countParticles);
			groupBox_outputData.Controls.Add(this.tB_countParticles);
			groupBox_outputData.Controls.Add(label_countStep);
			groupBox_outputData.Controls.Add(this.tB_countStep);
			groupBox_outputData.Controls.Add(label_countAbsorbedParticles);
			groupBox_outputData.Controls.Add(this.tB_countAbsorbedParticles);
			groupBox_outputData.Controls.Add(label_countEjectedParticles);
			groupBox_outputData.Controls.Add(this.tB_countEjectedParticles);
			groupBox_outputData.Location = new System.Drawing.Point(12, 624);
			groupBox_outputData.Name = "groupBox_outputData";
			groupBox_outputData.Size = new System.Drawing.Size(604, 115);
			groupBox_outputData.TabIndex = 4;
			groupBox_outputData.TabStop = false;
			groupBox_outputData.Text = "Выходные данные";
			// 
			// label_countParticles
			// 
			label_countParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_countParticles.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			label_countParticles.Location = new System.Drawing.Point(288, 18);
			label_countParticles.Name = "label_countParticles";
			label_countParticles.Size = new System.Drawing.Size(229, 25);
			label_countParticles.TabIndex = 16;
			label_countParticles.Text = "Число частиц в реакторе:";
			label_countParticles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tB_countParticles
			// 
			this.tB_countParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tB_countParticles.Location = new System.Drawing.Point(523, 18);
			this.tB_countParticles.Name = "tB_countParticles";
			this.tB_countParticles.ReadOnly = true;
			this.tB_countParticles.Size = new System.Drawing.Size(75, 25);
			this.tB_countParticles.TabIndex = 15;
			this.tB_countParticles.Text = "0";
			this.tB_countParticles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tB_countParticles.WordWrap = false;
			// 
			// label_countStep
			// 
			label_countStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_countStep.Location = new System.Drawing.Point(6, 18);
			label_countStep.Name = "label_countStep";
			label_countStep.Size = new System.Drawing.Size(195, 25);
			label_countStep.TabIndex = 14;
			label_countStep.Text = "Номер шага:";
			label_countStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tB_countStep
			// 
			this.tB_countStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tB_countStep.Location = new System.Drawing.Point(207, 18);
			this.tB_countStep.Name = "tB_countStep";
			this.tB_countStep.ReadOnly = true;
			this.tB_countStep.Size = new System.Drawing.Size(75, 25);
			this.tB_countStep.TabIndex = 13;
			this.tB_countStep.Text = "0";
			this.tB_countStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tB_countStep.WordWrap = false;
			// 
			// label_countAbsorbedParticles
			// 
			label_countAbsorbedParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_countAbsorbedParticles.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			label_countAbsorbedParticles.Location = new System.Drawing.Point(288, 79);
			label_countAbsorbedParticles.Name = "label_countAbsorbedParticles";
			label_countAbsorbedParticles.Size = new System.Drawing.Size(229, 25);
			label_countAbsorbedParticles.TabIndex = 12;
			label_countAbsorbedParticles.Text = "Число поглощённых частиц:";
			label_countAbsorbedParticles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tB_countAbsorbedParticles
			// 
			this.tB_countAbsorbedParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tB_countAbsorbedParticles.Location = new System.Drawing.Point(523, 80);
			this.tB_countAbsorbedParticles.Name = "tB_countAbsorbedParticles";
			this.tB_countAbsorbedParticles.ReadOnly = true;
			this.tB_countAbsorbedParticles.Size = new System.Drawing.Size(75, 25);
			this.tB_countAbsorbedParticles.TabIndex = 11;
			this.tB_countAbsorbedParticles.Text = "0";
			this.tB_countAbsorbedParticles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tB_countAbsorbedParticles.WordWrap = false;
			// 
			// label_countEjectedParticles
			// 
			label_countEjectedParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_countEjectedParticles.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			label_countEjectedParticles.Location = new System.Drawing.Point(288, 49);
			label_countEjectedParticles.Name = "label_countEjectedParticles";
			label_countEjectedParticles.Size = new System.Drawing.Size(229, 25);
			label_countEjectedParticles.TabIndex = 10;
			label_countEjectedParticles.Text = "Число вылетевших частиц:";
			label_countEjectedParticles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tB_countEjectedParticles
			// 
			this.tB_countEjectedParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tB_countEjectedParticles.Location = new System.Drawing.Point(523, 49);
			this.tB_countEjectedParticles.Name = "tB_countEjectedParticles";
			this.tB_countEjectedParticles.ReadOnly = true;
			this.tB_countEjectedParticles.Size = new System.Drawing.Size(75, 25);
			this.tB_countEjectedParticles.TabIndex = 0;
			this.tB_countEjectedParticles.Text = "0";
			this.tB_countEjectedParticles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tB_countEjectedParticles.WordWrap = false;
			// 
			// label_countBoom
			// 
			label_countBoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_countBoom.Location = new System.Drawing.Point(6, 49);
			label_countBoom.Name = "label_countBoom";
			label_countBoom.Size = new System.Drawing.Size(229, 25);
			label_countBoom.TabIndex = 13;
			label_countBoom.Text = "Частиц больше, n * N₀:";
			label_countBoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label2.Location = new System.Drawing.Point(87, 21);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(229, 25);
			label2.TabIndex = 14;
			label2.Text = "Условие взрыва реактора:";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gB_chartParticles
			// 
			gB_chartParticles.Controls.Add(this.chart_сountParticles);
			gB_chartParticles.Location = new System.Drawing.Point(951, 16);
			gB_chartParticles.Name = "gB_chartParticles";
			gB_chartParticles.Size = new System.Drawing.Size(501, 237);
			gB_chartParticles.TabIndex = 8;
			gB_chartParticles.TabStop = false;
			gB_chartParticles.Text = "Число частиц от числа МКШ";
			// 
			// chart_сountParticles
			// 
			this.chart_сountParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.AxisX.Title = "МКШ";
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
			chartArea1.AxisY.Minimum = 0D;
			chartArea1.AxisY.Title = "Число атомов";
			chartArea1.AxisY.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.Name = "ChartArea1";
			this.chart_сountParticles.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.DockedToChartArea = "ChartArea1";
			legend1.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			legend1.IsTextAutoFit = false;
			legend1.Name = "Legend1";
			legend1.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chart_сountParticles.Legends.Add(legend1);
			this.chart_сountParticles.Location = new System.Drawing.Point(6, 24);
			this.chart_сountParticles.Name = "chart_сountParticles";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
			series1.Color = System.Drawing.Color.Red;
			series1.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series1.Legend = "Legend1";
			series1.LegendText = "Число частиц";
			series1.Name = "CountParticles";
			series1.YValuesPerPoint = 4;
			this.chart_сountParticles.Series.Add(series1);
			this.chart_сountParticles.Size = new System.Drawing.Size(489, 207);
			this.chart_сountParticles.TabIndex = 8;
			this.chart_сountParticles.Text = "chart_countParticles";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(this.chart_countEjectedParticles);
			groupBox1.Location = new System.Drawing.Point(951, 259);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(501, 237);
			groupBox1.TabIndex = 9;
			groupBox1.TabStop = false;
			groupBox1.Text = "Число вылетевших из реактора частиц от числа МКШ";
			// 
			// chart_countEjectedParticles
			// 
			this.chart_countEjectedParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
			chartArea2.AxisX.Minimum = 0D;
			chartArea2.AxisX.Title = "МКШ";
			chartArea2.AxisX.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
			chartArea2.AxisY.Minimum = 0D;
			chartArea2.AxisY.Title = "Число атомов";
			chartArea2.AxisY.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea2.Name = "ChartArea1";
			this.chart_countEjectedParticles.ChartAreas.Add(chartArea2);
			legend2.BackColor = System.Drawing.Color.Transparent;
			legend2.DockedToChartArea = "ChartArea1";
			legend2.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			legend2.IsTextAutoFit = false;
			legend2.Name = "Legend1";
			legend2.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chart_countEjectedParticles.Legends.Add(legend2);
			this.chart_countEjectedParticles.Location = new System.Drawing.Point(6, 24);
			this.chart_countEjectedParticles.Name = "chart_countEjectedParticles";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
			series2.Color = System.Drawing.Color.Red;
			series2.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series2.Legend = "Legend1";
			series2.LegendText = "Число частиц";
			series2.Name = "CountParticles";
			series2.YValuesPerPoint = 4;
			this.chart_countEjectedParticles.Series.Add(series2);
			this.chart_countEjectedParticles.Size = new System.Drawing.Size(489, 207);
			this.chart_countEjectedParticles.TabIndex = 8;
			this.chart_countEjectedParticles.Text = "chart_countEjectedParticles";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(this.chart_countAbsorbedParticles);
			groupBox2.Location = new System.Drawing.Point(951, 502);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(501, 237);
			groupBox2.TabIndex = 10;
			groupBox2.TabStop = false;
			groupBox2.Text = "Число поглощённых частиц от числа МКШ";
			// 
			// chart_countAbsorbedParticles
			// 
			this.chart_countAbsorbedParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
			chartArea3.AxisX.Minimum = 0D;
			chartArea3.AxisX.Title = "МКШ";
			chartArea3.AxisX.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
			chartArea3.AxisY.Minimum = 0D;
			chartArea3.AxisY.Title = "Число атомов";
			chartArea3.AxisY.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea3.Name = "ChartArea1";
			this.chart_countAbsorbedParticles.ChartAreas.Add(chartArea3);
			legend3.BackColor = System.Drawing.Color.Transparent;
			legend3.DockedToChartArea = "ChartArea1";
			legend3.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			legend3.IsTextAutoFit = false;
			legend3.Name = "Legend1";
			legend3.TitleFont = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chart_countAbsorbedParticles.Legends.Add(legend3);
			this.chart_countAbsorbedParticles.Location = new System.Drawing.Point(6, 24);
			this.chart_countAbsorbedParticles.Name = "chart_countAbsorbedParticles";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
			series3.Color = System.Drawing.Color.Red;
			series3.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			series3.Legend = "Legend1";
			series3.LegendText = "Число частиц";
			series3.Name = "CountParticles";
			series3.YValuesPerPoint = 4;
			this.chart_countAbsorbedParticles.Series.Add(series3);
			this.chart_countAbsorbedParticles.Size = new System.Drawing.Size(489, 207);
			this.chart_countAbsorbedParticles.TabIndex = 8;
			this.chart_countAbsorbedParticles.Text = "chart_countAbsorbedParticles";
			// 
			// pB_model
			// 
			this.pB_model.BackColor = System.Drawing.Color.White;
			this.pB_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pB_model.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pB_model.ErrorImage")));
			this.pB_model.Location = new System.Drawing.Point(16, 16);
			this.pB_model.Margin = new System.Windows.Forms.Padding(4);
			this.pB_model.Name = "pB_model";
			this.pB_model.Size = new System.Drawing.Size(600, 600);
			this.pB_model.TabIndex = 0;
			this.pB_model.TabStop = false;
			// 
			// button_start
			// 
			this.button_start.Enabled = false;
			this.button_start.Location = new System.Drawing.Point(622, 673);
			this.button_start.Margin = new System.Windows.Forms.Padding(4);
			this.button_start.Name = "button_start";
			this.button_start.Size = new System.Drawing.Size(322, 30);
			this.button_start.TabIndex = 1;
			this.button_start.Text = "Старт";
			this.button_start.UseVisualStyleBackColor = true;
			this.button_start.Click += new System.EventHandler(this.OnClickButtonStart);
			// 
			// timer_mks
			// 
			this.timer_mks.Tick += new System.EventHandler(this.OnTickTimerMKS);
			// 
			// button_createModel
			// 
			this.button_createModel.Location = new System.Drawing.Point(622, 635);
			this.button_createModel.Margin = new System.Windows.Forms.Padding(4);
			this.button_createModel.Name = "button_createModel";
			this.button_createModel.Size = new System.Drawing.Size(322, 30);
			this.button_createModel.TabIndex = 5;
			this.button_createModel.Text = "Создать модель";
			this.button_createModel.UseVisualStyleBackColor = true;
			this.button_createModel.Click += new System.EventHandler(this.OnClickButtonCreateModel);
			// 
			// groupBox_statusReactor
			// 
			this.groupBox_statusReactor.Controls.Add(this.label_statusReactor);
			this.groupBox_statusReactor.Controls.Add(this.progressBar_statusReactor);
			this.groupBox_statusReactor.Controls.Add(label2);
			this.groupBox_statusReactor.Controls.Add(label_countBoom);
			this.groupBox_statusReactor.Controls.Add(this.nud_countBoom);
			this.groupBox_statusReactor.Location = new System.Drawing.Point(623, 283);
			this.groupBox_statusReactor.Name = "groupBox_statusReactor";
			this.groupBox_statusReactor.Size = new System.Drawing.Size(322, 137);
			this.groupBox_statusReactor.TabIndex = 6;
			this.groupBox_statusReactor.TabStop = false;
			this.groupBox_statusReactor.Text = "Состояние реактора";
			// 
			// label_statusReactor
			// 
			this.label_statusReactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_statusReactor.BackColor = System.Drawing.Color.Black;
			this.label_statusReactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_statusReactor.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_statusReactor.ForeColor = System.Drawing.Color.Lime;
			this.label_statusReactor.Location = new System.Drawing.Point(6, 77);
			this.label_statusReactor.Name = "label_statusReactor";
			this.label_statusReactor.Size = new System.Drawing.Size(310, 25);
			this.label_statusReactor.TabIndex = 17;
			this.label_statusReactor.Text = "В норме";
			this.label_statusReactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// progressBar_statusReactor
			// 
			this.progressBar_statusReactor.BackColor = System.Drawing.Color.Black;
			this.progressBar_statusReactor.ForeColor = System.Drawing.Color.Red;
			this.progressBar_statusReactor.Location = new System.Drawing.Point(6, 105);
			this.progressBar_statusReactor.Name = "progressBar_statusReactor";
			this.progressBar_statusReactor.Size = new System.Drawing.Size(310, 25);
			this.progressBar_statusReactor.TabIndex = 16;
			// 
			// nud_countBoom
			// 
			this.nud_countBoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nud_countBoom.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nud_countBoom.Location = new System.Drawing.Point(241, 49);
			this.nud_countBoom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nud_countBoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_countBoom.Name = "nud_countBoom";
			this.nud_countBoom.Size = new System.Drawing.Size(75, 25);
			this.nud_countBoom.TabIndex = 12;
			this.nud_countBoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nud_countBoom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nud_countBoom.ValueChanged += new System.EventHandler(this.OnValueChangedCountBoom);
			// 
			// button_saveData
			// 
			this.button_saveData.Location = new System.Drawing.Point(622, 709);
			this.button_saveData.Margin = new System.Windows.Forms.Padding(4);
			this.button_saveData.Name = "button_saveData";
			this.button_saveData.Size = new System.Drawing.Size(322, 30);
			this.button_saveData.TabIndex = 11;
			this.button_saveData.Text = "Сохранить данные в файл";
			this.button_saveData.UseVisualStyleBackColor = true;
			this.button_saveData.Click += new System.EventHandler(this.OnClickButtomSaveData);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1464, 745);
			this.Controls.Add(this.button_saveData);
			this.Controls.Add(groupBox2);
			this.Controls.Add(groupBox1);
			this.Controls.Add(gB_chartParticles);
			this.Controls.Add(this.groupBox_statusReactor);
			this.Controls.Add(this.button_createModel);
			this.Controls.Add(groupBox_outputData);
			this.Controls.Add(groupBox_paramsSimulation);
			this.Controls.Add(groupBox_paramsModel);
			this.Controls.Add(this.button_start);
			this.Controls.Add(this.pB_model);
			this.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "ИСИТ ННГУ | Двумерный ядерный реактор";
			groupBox_paramsModel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nud_Rl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_No)).EndInit();
			groupBox_paramsSimulation.ResumeLayout(false);
			groupBox_paramsSimulation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_intervalTimer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_mks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Pd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Pa)).EndInit();
			groupBox_outputData.ResumeLayout(false);
			groupBox_outputData.PerformLayout();
			gB_chartParticles.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart_сountParticles)).EndInit();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart_countEjectedParticles)).EndInit();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart_countAbsorbedParticles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_model)).EndInit();
			this.groupBox_statusReactor.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nud_countBoom)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_model;
        private System.Windows.Forms.Button button_start;
		private System.Windows.Forms.Timer timer_mks;
		private System.Windows.Forms.NumericUpDown nud_No;
		private System.Windows.Forms.NumericUpDown nud_Rl;
		private System.Windows.Forms.NumericUpDown nud_Pd;
		private System.Windows.Forms.NumericUpDown nud_Pa;
		private System.Windows.Forms.NumericUpDown nud_mks;
		private System.Windows.Forms.TextBox tB_countAbsorbedParticles;
		private System.Windows.Forms.TextBox tB_countEjectedParticles;
		private System.Windows.Forms.Button button_createModel;
		private System.Windows.Forms.TextBox tB_countStep;
		private System.Windows.Forms.NumericUpDown nud_intervalTimer;
		private System.Windows.Forms.TextBox tB_countParticles;
		private System.Windows.Forms.GroupBox groupBox_statusReactor;
		private System.Windows.Forms.NumericUpDown nud_countBoom;
		private System.Windows.Forms.Label label_statusReactor;
		private System.Windows.Forms.ProgressBar progressBar_statusReactor;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart_сountParticles;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart_countEjectedParticles;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart_countAbsorbedParticles;
		private System.Windows.Forms.CheckBox checkBox_addCond;
		private System.Windows.Forms.Button button_saveData;
	}
}