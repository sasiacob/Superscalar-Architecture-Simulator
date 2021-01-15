namespace Simulator
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.FR = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IR_max = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IBS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Latenta = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Memory = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.NrRegistri = new System.Windows.Forms.ComboBox();
            this.param_Simulator = new System.Windows.Forms.GroupBox();
            this.param_Cache = new System.Windows.Forms.GroupBox();
            this.param_DC = new System.Windows.Forms.GroupBox();
            this.block_size = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeDC = new System.Windows.Forms.ComboBox();
            this.param_IC = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.size_ic = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SizeBloc = new System.Windows.Forms.ComboBox();
            this.TipCacheB = new System.Windows.Forms.RadioButton();
            this.TipCacheU = new System.Windows.Forms.RadioButton();
            this.file_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.NrInstructiuni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NrLoad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Branch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Ciclu = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NumeFisier = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.instruct_box = new System.Windows.Forms.GroupBox();
            this.results_box = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Latenta)).BeginInit();
            this.param_Simulator.SuspendLayout();
            this.param_Cache.SuspendLayout();
            this.param_DC.SuspendLayout();
            this.param_IC.SuspendLayout();
            this.instruct_box.SuspendLayout();
            this.results_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fetch Rate (FR):";
            // 
            // FR
            // 
            this.FR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FR.FormattingEnabled = true;
            this.FR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FR.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.FR.Location = new System.Drawing.Point(185, 18);
            this.FR.Name = "FR";
            this.FR.Size = new System.Drawing.Size(42, 24);
            this.FR.TabIndex = 2;
            this.FR.SelectedIndexChanged += new System.EventHandler(this.FR_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Issue Rate Maxim (IRmax):";
            // 
            // IR_max
            // 
            this.IR_max.DisplayMember = "1";
            this.IR_max.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IR_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IR_max.FormattingEnabled = true;
            this.IR_max.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.IR_max.Location = new System.Drawing.Point(185, 46);
            this.IR_max.MaxDropDownItems = 4;
            this.IR_max.Name = "IR_max";
            this.IR_max.Size = new System.Drawing.Size(42, 24);
            this.IR_max.TabIndex = 4;
            this.IR_max.SelectedIndexChanged += new System.EventHandler(this.IR_max_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instruction Buffer Size (IBS):";
            // 
            // IBS
            // 
            this.IBS.DisplayMember = "4";
            this.IBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBS.FormattingEnabled = true;
            this.IBS.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32"});
            this.IBS.Location = new System.Drawing.Point(185, 75);
            this.IBS.Name = "IBS";
            this.IBS.Size = new System.Drawing.Size(42, 24);
            this.IBS.TabIndex = 6;
            this.IBS.SelectedIndexChanged += new System.EventHandler(this.IBS_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Latenta (for hit in cache):";
            // 
            // Latenta
            // 
            this.Latenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latenta.Location = new System.Drawing.Point(185, 103);
            this.Latenta.Name = "Latenta";
            this.Latenta.Size = new System.Drawing.Size(42, 22);
            this.Latenta.TabIndex = 8;
            this.Latenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "N_PEN (miss in cache):";
            // 
            // Memory
            // 
            this.Memory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memory.FormattingEnabled = true;
            this.Memory.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.Memory.Location = new System.Drawing.Point(185, 131);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(42, 24);
            this.Memory.TabIndex = 10;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(13, 167);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 16);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Nr. Set Registri:";
            // 
            // NrRegistri
            // 
            this.NrRegistri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NrRegistri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrRegistri.FormattingEnabled = true;
            this.NrRegistri.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.NrRegistri.Location = new System.Drawing.Point(185, 162);
            this.NrRegistri.Name = "NrRegistri";
            this.NrRegistri.Size = new System.Drawing.Size(42, 24);
            this.NrRegistri.TabIndex = 12;
            // 
            // param_Simulator
            // 
            this.param_Simulator.Controls.Add(this.NrRegistri);
            this.param_Simulator.Controls.Add(this.Label7);
            this.param_Simulator.Controls.Add(this.Memory);
            this.param_Simulator.Controls.Add(this.label6);
            this.param_Simulator.Controls.Add(this.Latenta);
            this.param_Simulator.Controls.Add(this.label5);
            this.param_Simulator.Controls.Add(this.IBS);
            this.param_Simulator.Controls.Add(this.label4);
            this.param_Simulator.Controls.Add(this.IR_max);
            this.param_Simulator.Controls.Add(this.label3);
            this.param_Simulator.Controls.Add(this.FR);
            this.param_Simulator.Controls.Add(this.label2);
            this.param_Simulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param_Simulator.Location = new System.Drawing.Point(10, 15);
            this.param_Simulator.Name = "param_Simulator";
            this.param_Simulator.Size = new System.Drawing.Size(238, 192);
            this.param_Simulator.TabIndex = 13;
            this.param_Simulator.TabStop = false;
            this.param_Simulator.Text = "Parametri Simulator";
            // 
            // param_Cache
            // 
            this.param_Cache.Controls.Add(this.param_DC);
            this.param_Cache.Controls.Add(this.param_IC);
            this.param_Cache.Controls.Add(this.TipCacheB);
            this.param_Cache.Controls.Add(this.TipCacheU);
            this.param_Cache.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param_Cache.Location = new System.Drawing.Point(254, 15);
            this.param_Cache.Name = "param_Cache";
            this.param_Cache.Size = new System.Drawing.Size(388, 192);
            this.param_Cache.TabIndex = 14;
            this.param_Cache.TabStop = false;
            this.param_Cache.Text = "Parametri Cache ( Mapare Directa)";
            // 
            // param_DC
            // 
            this.param_DC.Controls.Add(this.block_size);
            this.param_DC.Controls.Add(this.label20);
            this.param_DC.Controls.Add(this.label1);
            this.param_DC.Controls.Add(this.SizeDC);
            this.param_DC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param_DC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.param_DC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.param_DC.Location = new System.Drawing.Point(230, 18);
            this.param_DC.Name = "param_DC";
            this.param_DC.Size = new System.Drawing.Size(168, 111);
            this.param_DC.TabIndex = 1;
            this.param_DC.TabStop = false;
            this.param_DC.Text = "Data Cache";
            // 
            // block_size
            // 
            this.block_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.block_size.FormattingEnabled = true;
            this.block_size.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.block_size.Location = new System.Drawing.Point(88, 20);
            this.block_size.Name = "block_size";
            this.block_size.Size = new System.Drawing.Size(59, 24);
            this.block_size.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 16);
            this.label20.TabIndex = 3;
            this.label20.Text = "Block Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size_DC:";
            // 
            // SizeDC
            // 
            this.SizeDC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeDC.FormattingEnabled = true;
            this.SizeDC.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            ""});
            this.SizeDC.Location = new System.Drawing.Point(88, 51);
            this.SizeDC.Name = "SizeDC";
            this.SizeDC.Size = new System.Drawing.Size(59, 24);
            this.SizeDC.TabIndex = 1;
            // 
            // param_IC
            // 
            this.param_IC.Controls.Add(this.label10);
            this.param_IC.Controls.Add(this.label21);
            this.param_IC.Controls.Add(this.size_ic);
            this.param_IC.Controls.Add(this.label19);
            this.param_IC.Controls.Add(this.SizeBloc);
            this.param_IC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param_IC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.param_IC.Location = new System.Drawing.Point(33, 18);
            this.param_IC.Name = "param_IC";
            this.param_IC.Size = new System.Drawing.Size(191, 111);
            this.param_IC.TabIndex = 0;
            this.param_IC.TabStop = false;
            this.param_IC.Text = "Instruction Cache";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Block Size:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(149, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 16);
            this.label21.TabIndex = 8;
            this.label21.Text = "= FR";
            // 
            // size_ic
            // 
            this.size_ic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size_ic.FormattingEnabled = true;
            this.size_ic.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192"});
            this.size_ic.Location = new System.Drawing.Point(84, 51);
            this.size_ic.Name = "size_ic";
            this.size_ic.Size = new System.Drawing.Size(59, 24);
            this.size_ic.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 16);
            this.label19.TabIndex = 6;
            this.label19.Text = "Size_IC: ";
            // 
            // SizeBloc
            // 
            this.SizeBloc.Enabled = false;
            this.SizeBloc.FormattingEnabled = true;
            this.SizeBloc.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.SizeBloc.Location = new System.Drawing.Point(84, 21);
            this.SizeBloc.Name = "SizeBloc";
            this.SizeBloc.Size = new System.Drawing.Size(59, 24);
            this.SizeBloc.TabIndex = 3;
            this.SizeBloc.Text = "4";
            this.SizeBloc.SelectedIndexChanged += new System.EventHandler(this.SizeBloc_SelectedIndexChanged);
            // 
            // TipCacheB
            // 
            this.TipCacheB.AutoSize = true;
            this.TipCacheB.Location = new System.Drawing.Point(10, 162);
            this.TipCacheB.Name = "TipCacheB";
            this.TipCacheB.Size = new System.Drawing.Size(67, 20);
            this.TipCacheB.TabIndex = 5;
            this.TipCacheB.TabStop = true;
            this.TipCacheB.Text = "Biport";
            this.TipCacheB.UseVisualStyleBackColor = true;
            // 
            // TipCacheU
            // 
            this.TipCacheU.AutoSize = true;
            this.TipCacheU.Checked = true;
            this.TipCacheU.Location = new System.Drawing.Point(10, 135);
            this.TipCacheU.Name = "TipCacheU";
            this.TipCacheU.Size = new System.Drawing.Size(76, 20);
            this.TipCacheU.TabIndex = 4;
            this.TipCacheU.TabStop = true;
            this.TipCacheU.Text = "Uniport";
            this.TipCacheU.UseVisualStyleBackColor = true;
            // 
            // file_btn
            // 
            this.file_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_btn.Location = new System.Drawing.Point(10, 224);
            this.file_btn.Name = "file_btn";
            this.file_btn.Size = new System.Drawing.Size(91, 31);
            this.file_btn.TabIndex = 15;
            this.file_btn.Text = "Alege fisier";
            this.file_btn.UseVisualStyleBackColor = true;
            this.file_btn.Click += new System.EventHandler(this.file_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(10, 355);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(91, 29);
            this.exit_btn.TabIndex = 16;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Enabled = false;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(10, 291);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(91, 52);
            this.start_btn.TabIndex = 17;
            this.start_btn.Text = "Start Simulare";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // NrInstructiuni
            // 
            this.NrInstructiuni.Location = new System.Drawing.Point(108, 122);
            this.NrInstructiuni.Name = "NrInstructiuni";
            this.NrInstructiuni.ReadOnly = true;
            this.NrInstructiuni.Size = new System.Drawing.Size(64, 21);
            this.NrInstructiuni.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Issue Rate:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(74, 21);
            this.textBox3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Load:";
            // 
            // NrLoad
            // 
            this.NrLoad.Location = new System.Drawing.Point(108, 28);
            this.NrLoad.Name = "NrLoad";
            this.NrLoad.ReadOnly = true;
            this.NrLoad.Size = new System.Drawing.Size(64, 21);
            this.NrLoad.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(47, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Store:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(108, 60);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(64, 21);
            this.textBox5.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(43, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Branch:";
            // 
            // Branch
            // 
            this.Branch.Location = new System.Drawing.Point(108, 91);
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            this.Branch.Size = new System.Drawing.Size(64, 21);
            this.Branch.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "One-Cycle:";
            // 
            // Ciclu
            // 
            this.Ciclu.Location = new System.Drawing.Point(95, 28);
            this.Ciclu.Name = "Ciclu";
            this.Ciclu.ReadOnly = true;
            this.Ciclu.Size = new System.Drawing.Size(72, 21);
            this.Ciclu.TabIndex = 31;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NumeFisier
            // 
            this.NumeFisier.Location = new System.Drawing.Point(10, 261);
            this.NumeFisier.Name = "NumeFisier";
            this.NumeFisier.ReadOnly = true;
            this.NumeFisier.Size = new System.Drawing.Size(91, 20);
            this.NumeFisier.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(74, 21);
            this.textBox1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ticks:";
            // 
            // instruct_box
            // 
            this.instruct_box.Controls.Add(this.label9);
            this.instruct_box.Controls.Add(this.label14);
            this.instruct_box.Controls.Add(this.Branch);
            this.instruct_box.Controls.Add(this.label13);
            this.instruct_box.Controls.Add(this.textBox5);
            this.instruct_box.Controls.Add(this.label12);
            this.instruct_box.Controls.Add(this.NrLoad);
            this.instruct_box.Controls.Add(this.NrInstructiuni);
            this.instruct_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruct_box.Location = new System.Drawing.Point(208, 224);
            this.instruct_box.Name = "instruct_box";
            this.instruct_box.Size = new System.Drawing.Size(215, 160);
            this.instruct_box.TabIndex = 14;
            this.instruct_box.TabStop = false;
            this.instruct_box.Text = "Instructiuni";
            // 
            // results_box
            // 
            this.results_box.Controls.Add(this.textBox1);
            this.results_box.Controls.Add(this.label8);
            this.results_box.Controls.Add(this.label15);
            this.results_box.Controls.Add(this.label11);
            this.results_box.Controls.Add(this.Ciclu);
            this.results_box.Controls.Add(this.textBox3);
            this.results_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_box.Location = new System.Drawing.Point(429, 224);
            this.results_box.Name = "results_box";
            this.results_box.Size = new System.Drawing.Size(213, 160);
            this.results_box.TabIndex = 29;
            this.results_box.TabStop = false;
            this.results_box.Text = "Rezultate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 402);
            this.Controls.Add(this.NumeFisier);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.file_btn);
            this.Controls.Add(this.param_Cache);
            this.Controls.Add(this.param_Simulator);
            this.Controls.Add(this.instruct_box);
            this.Controls.Add(this.results_box);
            this.Name = "Form1";
            this.Text = "Simulator Cache";
            ((System.ComponentModel.ISupportInitialize)(this.Latenta)).EndInit();
            this.param_Simulator.ResumeLayout(false);
            this.param_Simulator.PerformLayout();
            this.param_Cache.ResumeLayout(false);
            this.param_Cache.PerformLayout();
            this.param_DC.ResumeLayout(false);
            this.param_DC.PerformLayout();
            this.param_IC.ResumeLayout(false);
            this.param_IC.PerformLayout();
            this.instruct_box.ResumeLayout(false);
            this.instruct_box.PerformLayout();
            this.results_box.ResumeLayout(false);
            this.results_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IR_max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox IBS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Latenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Memory;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.ComboBox NrRegistri;
        private System.Windows.Forms.GroupBox param_Simulator;
        private System.Windows.Forms.GroupBox param_Cache;
        private System.Windows.Forms.GroupBox param_IC;
        private System.Windows.Forms.ComboBox SizeBloc;
        private System.Windows.Forms.ComboBox SizeDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button file_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox NrInstructiuni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NrLoad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Branch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Ciclu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox NumeFisier;
        private System.Windows.Forms.RadioButton TipCacheB;
        private System.Windows.Forms.RadioButton TipCacheU;
        private System.Windows.Forms.ComboBox size_ic;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox param_DC;
        private System.Windows.Forms.ComboBox block_size;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox instruct_box;
        private System.Windows.Forms.GroupBox results_box;
        private System.Windows.Forms.Label label10;
    }
}

