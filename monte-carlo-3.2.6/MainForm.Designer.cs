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
			this.nud_Rl = new System.Windows.Forms.NumericUpDown();
			this.nud_No = new System.Windows.Forms.NumericUpDown();
			this.nud_intervalTimer = new System.Windows.Forms.NumericUpDown();
			this.nud_mks = new System.Windows.Forms.NumericUpDown();
			this.nud_Pd = new System.Windows.Forms.NumericUpDown();
			this.nud_Pa = new System.Windows.Forms.NumericUpDown();
			this.tB_countParticles = new System.Windows.Forms.TextBox();
			this.tB_countStep = new System.Windows.Forms.TextBox();
			this.tB_countAbsorbedParticles = new System.Windows.Forms.TextBox();
			this.tB_countEjectedParticles = new System.Windows.Forms.TextBox();
			this.pB_model = new System.Windows.Forms.PictureBox();
			this.button_start = new System.Windows.Forms.Button();
			this.timer_mks = new System.Windows.Forms.Timer(this.components);
			this.button_createModel = new System.Windows.Forms.Button();
			this.groupBox_statusReactor = new System.Windows.Forms.GroupBox();
			this.label_statusReactor = new System.Windows.Forms.Label();
			this.nud_countBoom = new System.Windows.Forms.NumericUpDown();
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
			groupBox_paramsModel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_Rl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_No)).BeginInit();
			groupBox_paramsSimulation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_intervalTimer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_mks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Pd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Pa)).BeginInit();
			groupBox_outputData.SuspendLayout();
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
			groupBox_paramsModel.Size = new System.Drawing.Size(322, 89);
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
			groupBox_paramsSimulation.Controls.Add(label_intervalTimer);
			groupBox_paramsSimulation.Controls.Add(this.nud_intervalTimer);
			groupBox_paramsSimulation.Controls.Add(label_mks);
			groupBox_paramsSimulation.Controls.Add(this.nud_mks);
			groupBox_paramsSimulation.Controls.Add(label_Pd);
			groupBox_paramsSimulation.Controls.Add(this.nud_Pd);
			groupBox_paramsSimulation.Controls.Add(label_Pa);
			groupBox_paramsSimulation.Controls.Add(this.nud_Pa);
			groupBox_paramsSimulation.Location = new System.Drawing.Point(623, 111);
			groupBox_paramsSimulation.Name = "groupBox_paramsSimulation";
			groupBox_paramsSimulation.Size = new System.Drawing.Size(322, 148);
			groupBox_paramsSimulation.TabIndex = 3;
			groupBox_paramsSimulation.TabStop = false;
			groupBox_paramsSimulation.Text = "Параметры симуляции";
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
			groupBox_outputData.Location = new System.Drawing.Point(623, 265);
			groupBox_outputData.Name = "groupBox_outputData";
			groupBox_outputData.Size = new System.Drawing.Size(322, 155);
			groupBox_outputData.TabIndex = 4;
			groupBox_outputData.TabStop = false;
			groupBox_outputData.Text = "Выходные данные";
			// 
			// label_countParticles
			// 
			label_countParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			label_countParticles.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			label_countParticles.Location = new System.Drawing.Point(6, 55);
			label_countParticles.Name = "label_countParticles";
			label_countParticles.Size = new System.Drawing.Size(229, 25);
			label_countParticles.TabIndex = 16;
			label_countParticles.Text = "Число частиц в реакторе:";
			label_countParticles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tB_countParticles
			// 
			this.tB_countParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tB_countParticles.Location = new System.Drawing.Point(241, 55);
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
			label_countStep.Location = new System.Drawing.Point(6, 24);
			label_countStep.Name = "label_countStep";
			label_countStep.Size = new System.Drawing.Size(229, 25);
			label_countStep.TabIndex = 14;
			label_countStep.Text = "Номер шага:";
			label_countStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tB_countStep
			// 
			this.tB_countStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tB_countStep.Location = new System.Drawing.Point(241, 24);
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
			label_countAbsorbedParticles.Location = new System.Drawing.Point(6, 121);
			label_countAbsorbedParticles.Name = "label_countAbsorbedParticles";
			label_countAbsorbedParticles.Size = new System.Drawing.Size(229, 25);
			label_countAbsorbedParticles.TabIndex = 12;
			label_countAbsorbedParticles.Text = "Число поглощённых частиц:";
			label_countAbsorbedParticles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tB_countAbsorbedParticles
			// 
			this.tB_countAbsorbedParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tB_countAbsorbedParticles.Location = new System.Drawing.Point(241, 121);
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
			label_countEjectedParticles.Location = new System.Drawing.Point(6, 86);
			label_countEjectedParticles.Name = "label_countEjectedParticles";
			label_countEjectedParticles.Size = new System.Drawing.Size(229, 25);
			label_countEjectedParticles.TabIndex = 10;
			label_countEjectedParticles.Text = "Число вылетевших частиц:";
			label_countEjectedParticles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tB_countEjectedParticles
			// 
			this.tB_countEjectedParticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tB_countEjectedParticles.Location = new System.Drawing.Point(241, 86);
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
			// pB_model
			// 
			this.pB_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pB_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
			this.button_start.Location = new System.Drawing.Point(623, 586);
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
			this.button_createModel.Location = new System.Drawing.Point(623, 548);
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
			this.groupBox_statusReactor.Controls.Add(label2);
			this.groupBox_statusReactor.Controls.Add(label_countBoom);
			this.groupBox_statusReactor.Controls.Add(this.nud_countBoom);
			this.groupBox_statusReactor.Location = new System.Drawing.Point(623, 426);
			this.groupBox_statusReactor.Name = "groupBox_statusReactor";
			this.groupBox_statusReactor.Size = new System.Drawing.Size(322, 115);
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
			this.label_statusReactor.Location = new System.Drawing.Point(9, 77);
			this.label_statusReactor.Name = "label_statusReactor";
			this.label_statusReactor.Size = new System.Drawing.Size(307, 25);
			this.label_statusReactor.TabIndex = 15;
			this.label_statusReactor.Text = "В норме";
			this.label_statusReactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(957, 623);
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
			((System.ComponentModel.ISupportInitialize)(this.nud_intervalTimer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_mks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Pd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Pa)).EndInit();
			groupBox_outputData.ResumeLayout(false);
			groupBox_outputData.PerformLayout();
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
	}
}