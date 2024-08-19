namespace CTeacherMaker
{
    partial class ZTM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZTM));
            dg_Selector = new DataGridView();
            groupBox_InstanceInfo = new GroupBox();
            tb_Description = new TextBox();
            nb_Nr = new NumericUpDown();
            tb_Npc = new TextBox();
            tb_Condition = new TextBox();
            lb_info_description = new Label();
            lb_info_nr = new Label();
            lb_info_npc = new Label();
            lb_info_condition = new Label();
            lb_info_instance = new Label();
            tb_Instance = new TextBox();
            gb_QuickWatch = new GroupBox();
            lb_CBOW_HLP = new Label();
            lb_BOW_HLP = new Label();
            lb_2H_HLP = new Label();
            lb_1H_HLP = new Label();
            lb_MP_HLP = new Label();
            lb_HP_HLP = new Label();
            lb_DEX_HLP = new Label();
            lb_STR_HLP = new Label();
            lb_CBOW_TEXT = new Label();
            lb_BOW_TEXT = new Label();
            lb_2H_TEXT = new Label();
            lb_1H_TEXT = new Label();
            lb_MP_TEXT = new Label();
            lb_HP_TEXT = new Label();
            lb_DEX_TEXT = new Label();
            lb_STR_TEXT = new Label();
            btSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_Selector).BeginInit();
            groupBox_InstanceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nb_Nr).BeginInit();
            gb_QuickWatch.SuspendLayout();
            SuspendLayout();
            // 
            // dg_Selector
            // 
            dg_Selector.AllowUserToAddRows = false;
            dg_Selector.AllowUserToDeleteRows = false;
            dg_Selector.AllowUserToResizeColumns = false;
            dg_Selector.AllowUserToResizeRows = false;
            dg_Selector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Selector.Location = new Point(8, 265);
            dg_Selector.Name = "dg_Selector";
            dg_Selector.RowHeadersWidth = 30;
            dg_Selector.RowTemplate.Height = 25;
            dg_Selector.RowTemplate.Resizable = DataGridViewTriState.False;
            dg_Selector.Size = new Size(635, 175);
            dg_Selector.TabIndex = 0;
            dg_Selector.CellContentClick += onCellContentClick;
            dg_Selector.CellFormatting += onCellFormat;
            dg_Selector.CellValueChanged += onCellValueChange;
            dg_Selector.EditingControlShowing += onEditControlShowing;
            dg_Selector.SelectionChanged += onChangeSelection;
            // 
            // groupBox_InstanceInfo
            // 
            groupBox_InstanceInfo.Controls.Add(tb_Description);
            groupBox_InstanceInfo.Controls.Add(nb_Nr);
            groupBox_InstanceInfo.Controls.Add(tb_Npc);
            groupBox_InstanceInfo.Controls.Add(tb_Condition);
            groupBox_InstanceInfo.Controls.Add(lb_info_description);
            groupBox_InstanceInfo.Controls.Add(lb_info_nr);
            groupBox_InstanceInfo.Controls.Add(lb_info_npc);
            groupBox_InstanceInfo.Controls.Add(lb_info_condition);
            groupBox_InstanceInfo.Controls.Add(lb_info_instance);
            groupBox_InstanceInfo.Controls.Add(tb_Instance);
            groupBox_InstanceInfo.Location = new Point(12, 12);
            groupBox_InstanceInfo.Name = "groupBox_InstanceInfo";
            groupBox_InstanceInfo.Size = new Size(320, 195);
            groupBox_InstanceInfo.TabIndex = 1;
            groupBox_InstanceInfo.TabStop = false;
            groupBox_InstanceInfo.Tag = "                row.Cells[1].Style.";
            groupBox_InstanceInfo.Text = "Informacje o NPC";
            // 
            // tb_Description
            // 
            tb_Description.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Description.Location = new Point(100, 160);
            tb_Description.Name = "tb_Description";
            tb_Description.Size = new Size(200, 24);
            tb_Description.TabIndex = 9;
            tb_Description.Text = "Ucz mnie!";
            // 
            // nb_Nr
            // 
            nb_Nr.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nb_Nr.Location = new Point(100, 125);
            nb_Nr.Name = "nb_Nr";
            nb_Nr.Size = new Size(200, 24);
            nb_Nr.TabIndex = 8;
            // 
            // tb_Npc
            // 
            tb_Npc.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Npc.Location = new Point(100, 90);
            tb_Npc.Name = "tb_Npc";
            tb_Npc.Size = new Size(200, 24);
            tb_Npc.TabIndex = 7;
            // 
            // tb_Condition
            // 
            tb_Condition.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Condition.Location = new Point(100, 55);
            tb_Condition.Name = "tb_Condition";
            tb_Condition.Size = new Size(200, 24);
            tb_Condition.TabIndex = 6;
            // 
            // lb_info_description
            // 
            lb_info_description.AutoSize = true;
            lb_info_description.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_info_description.Location = new Point(10, 165);
            lb_info_description.Name = "lb_info_description";
            lb_info_description.Size = new Size(37, 14);
            lb_info_description.TabIndex = 5;
            lb_info_description.Text = "OPIS";
            // 
            // lb_info_nr
            // 
            lb_info_nr.AutoSize = true;
            lb_info_nr.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_info_nr.Location = new Point(10, 130);
            lb_info_nr.Name = "lb_info_nr";
            lb_info_nr.Size = new Size(24, 14);
            lb_info_nr.TabIndex = 4;
            lb_info_nr.Text = "NR";
            // 
            // lb_info_npc
            // 
            lb_info_npc.AutoSize = true;
            lb_info_npc.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_info_npc.Location = new Point(10, 95);
            lb_info_npc.Name = "lb_info_npc";
            lb_info_npc.Size = new Size(31, 14);
            lb_info_npc.TabIndex = 3;
            lb_info_npc.Text = "NPC";
            // 
            // lb_info_condition
            // 
            lb_info_condition.AutoSize = true;
            lb_info_condition.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_info_condition.Location = new Point(10, 60);
            lb_info_condition.Name = "lb_info_condition";
            lb_info_condition.Size = new Size(68, 14);
            lb_info_condition.TabIndex = 2;
            lb_info_condition.Text = "WARUNEK";
            // 
            // lb_info_instance
            // 
            lb_info_instance.AutoSize = true;
            lb_info_instance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_info_instance.Location = new Point(10, 25);
            lb_info_instance.Name = "lb_info_instance";
            lb_info_instance.Size = new Size(75, 14);
            lb_info_instance.TabIndex = 1;
            lb_info_instance.Text = "INSTANCJA";
            // 
            // tb_Instance
            // 
            tb_Instance.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Instance.Location = new Point(100, 20);
            tb_Instance.Name = "tb_Instance";
            tb_Instance.Size = new Size(200, 24);
            tb_Instance.TabIndex = 0;
            // 
            // gb_QuickWatch
            // 
            gb_QuickWatch.Controls.Add(lb_CBOW_HLP);
            gb_QuickWatch.Controls.Add(lb_BOW_HLP);
            gb_QuickWatch.Controls.Add(lb_2H_HLP);
            gb_QuickWatch.Controls.Add(lb_1H_HLP);
            gb_QuickWatch.Controls.Add(lb_MP_HLP);
            gb_QuickWatch.Controls.Add(lb_HP_HLP);
            gb_QuickWatch.Controls.Add(lb_DEX_HLP);
            gb_QuickWatch.Controls.Add(lb_STR_HLP);
            gb_QuickWatch.Controls.Add(lb_CBOW_TEXT);
            gb_QuickWatch.Controls.Add(lb_BOW_TEXT);
            gb_QuickWatch.Controls.Add(lb_2H_TEXT);
            gb_QuickWatch.Controls.Add(lb_1H_TEXT);
            gb_QuickWatch.Controls.Add(lb_MP_TEXT);
            gb_QuickWatch.Controls.Add(lb_HP_TEXT);
            gb_QuickWatch.Controls.Add(lb_DEX_TEXT);
            gb_QuickWatch.Controls.Add(lb_STR_TEXT);
            gb_QuickWatch.Location = new Point(351, 12);
            gb_QuickWatch.Name = "gb_QuickWatch";
            gb_QuickWatch.Size = new Size(291, 195);
            gb_QuickWatch.TabIndex = 2;
            gb_QuickWatch.TabStop = false;
            gb_QuickWatch.Text = "Szybki podgląd";
            // 
            // lb_CBOW_HLP
            // 
            lb_CBOW_HLP.AutoSize = true;
            lb_CBOW_HLP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_CBOW_HLP.Location = new Point(145, 165);
            lb_CBOW_HLP.Name = "lb_CBOW_HLP";
            lb_CBOW_HLP.Size = new Size(138, 19);
            lb_CBOW_HLP.TabIndex = 15;
            lb_CBOW_HLP.Text = "(5PN, 250szt. złota)";
            // 
            // lb_BOW_HLP
            // 
            lb_BOW_HLP.AutoSize = true;
            lb_BOW_HLP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_BOW_HLP.Location = new Point(145, 145);
            lb_BOW_HLP.Name = "lb_BOW_HLP";
            lb_BOW_HLP.Size = new Size(138, 19);
            lb_BOW_HLP.TabIndex = 14;
            lb_BOW_HLP.Text = "(5PN, 250szt. złota)";
            // 
            // lb_2H_HLP
            // 
            lb_2H_HLP.AutoSize = true;
            lb_2H_HLP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_2H_HLP.Location = new Point(145, 125);
            lb_2H_HLP.Name = "lb_2H_HLP";
            lb_2H_HLP.Size = new Size(138, 19);
            lb_2H_HLP.TabIndex = 13;
            lb_2H_HLP.Text = "(5PN, 250szt. złota)";
            // 
            // lb_1H_HLP
            // 
            lb_1H_HLP.AutoSize = true;
            lb_1H_HLP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_1H_HLP.Location = new Point(145, 105);
            lb_1H_HLP.Name = "lb_1H_HLP";
            lb_1H_HLP.Size = new Size(138, 19);
            lb_1H_HLP.TabIndex = 12;
            lb_1H_HLP.Text = "(5PN, 250szt. złota)";
            // 
            // lb_MP_HLP
            // 
            lb_MP_HLP.AutoSize = true;
            lb_MP_HLP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_MP_HLP.Location = new Point(145, 85);
            lb_MP_HLP.Name = "lb_MP_HLP";
            lb_MP_HLP.Size = new Size(138, 19);
            lb_MP_HLP.TabIndex = 11;
            lb_MP_HLP.Text = "(5PN, 250szt. złota)";
            // 
            // lb_HP_HLP
            // 
            lb_HP_HLP.AutoSize = true;
            lb_HP_HLP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_HP_HLP.Location = new Point(145, 65);
            lb_HP_HLP.Name = "lb_HP_HLP";
            lb_HP_HLP.Size = new Size(138, 19);
            lb_HP_HLP.TabIndex = 10;
            lb_HP_HLP.Text = "(5PN, 250szt. złota)";
            // 
            // lb_DEX_HLP
            // 
            lb_DEX_HLP.AutoSize = true;
            lb_DEX_HLP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_DEX_HLP.Location = new Point(145, 45);
            lb_DEX_HLP.Name = "lb_DEX_HLP";
            lb_DEX_HLP.Size = new Size(138, 19);
            lb_DEX_HLP.TabIndex = 9;
            lb_DEX_HLP.Text = "(5PN, 250szt. złota)";
            // 
            // lb_STR_HLP
            // 
            lb_STR_HLP.AutoSize = true;
            lb_STR_HLP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_STR_HLP.Location = new Point(145, 25);
            lb_STR_HLP.Name = "lb_STR_HLP";
            lb_STR_HLP.Size = new Size(138, 19);
            lb_STR_HLP.TabIndex = 8;
            lb_STR_HLP.Text = "(5PN, 250szt. złota)";
            // 
            // lb_CBOW_TEXT
            // 
            lb_CBOW_TEXT.AutoSize = true;
            lb_CBOW_TEXT.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_CBOW_TEXT.Location = new Point(5, 165);
            lb_CBOW_TEXT.Name = "lb_CBOW_TEXT";
            lb_CBOW_TEXT.Size = new Size(73, 19);
            lb_CBOW_TEXT.TabIndex = 7;
            lb_CBOW_TEXT.Text = "Kusza + 5";
            // 
            // lb_BOW_TEXT
            // 
            lb_BOW_TEXT.AutoSize = true;
            lb_BOW_TEXT.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_BOW_TEXT.Location = new Point(5, 145);
            lb_BOW_TEXT.Name = "lb_BOW_TEXT";
            lb_BOW_TEXT.Size = new Size(58, 19);
            lb_BOW_TEXT.TabIndex = 6;
            lb_BOW_TEXT.Text = "Łuk + 5";
            // 
            // lb_2H_TEXT
            // 
            lb_2H_TEXT.AutoSize = true;
            lb_2H_TEXT.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_2H_TEXT.Location = new Point(5, 125);
            lb_2H_TEXT.Name = "lb_2H_TEXT";
            lb_2H_TEXT.Size = new Size(130, 19);
            lb_2H_TEXT.TabIndex = 5;
            lb_2H_TEXT.Text = "Br. Dwuręczna + 5";
            // 
            // lb_1H_TEXT
            // 
            lb_1H_TEXT.AutoSize = true;
            lb_1H_TEXT.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_1H_TEXT.Location = new Point(5, 105);
            lb_1H_TEXT.Name = "lb_1H_TEXT";
            lb_1H_TEXT.Size = new Size(141, 19);
            lb_1H_TEXT.TabIndex = 4;
            lb_1H_TEXT.Text = "Br. Jednoręczna + 5";
            // 
            // lb_MP_TEXT
            // 
            lb_MP_TEXT.AutoSize = true;
            lb_MP_TEXT.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_MP_TEXT.Location = new Point(5, 85);
            lb_MP_TEXT.Name = "lb_MP_TEXT";
            lb_MP_TEXT.Size = new Size(57, 19);
            lb_MP_TEXT.TabIndex = 3;
            lb_MP_TEXT.Text = "MP + 5";
            // 
            // lb_HP_TEXT
            // 
            lb_HP_TEXT.AutoSize = true;
            lb_HP_TEXT.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_HP_TEXT.Location = new Point(5, 65);
            lb_HP_TEXT.Name = "lb_HP_TEXT";
            lb_HP_TEXT.Size = new Size(63, 19);
            lb_HP_TEXT.TabIndex = 2;
            lb_HP_TEXT.Text = "HP + 25";
            // 
            // lb_DEX_TEXT
            // 
            lb_DEX_TEXT.AutoSize = true;
            lb_DEX_TEXT.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_DEX_TEXT.Location = new Point(5, 45);
            lb_DEX_TEXT.Name = "lb_DEX_TEXT";
            lb_DEX_TEXT.Size = new Size(102, 19);
            lb_DEX_TEXT.TabIndex = 1;
            lb_DEX_TEXT.Text = "Zręczność + 5";
            // 
            // lb_STR_TEXT
            // 
            lb_STR_TEXT.AutoSize = true;
            lb_STR_TEXT.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_STR_TEXT.Location = new Point(5, 25);
            lb_STR_TEXT.Name = "lb_STR_TEXT";
            lb_STR_TEXT.Size = new Size(63, 19);
            lb_STR_TEXT.TabIndex = 0;
            lb_STR_TEXT.Text = "Siła + 5 ";
            // 
            // btSave
            // 
            btSave.Location = new Point(8, 213);
            btSave.Name = "btSave";
            btSave.Size = new Size(635, 46);
            btSave.TabIndex = 3;
            btSave.Text = "Generuj!";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += OnSaveClick;
            // 
            // ZTM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 451);
            Controls.Add(btSave);
            Controls.Add(gb_QuickWatch);
            Controls.Add(groupBox_InstanceInfo);
            Controls.Add(dg_Selector);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ZTM";
            Text = "Zengine Easy Teacher";
            ((System.ComponentModel.ISupportInitialize)dg_Selector).EndInit();
            groupBox_InstanceInfo.ResumeLayout(false);
            groupBox_InstanceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nb_Nr).EndInit();
            gb_QuickWatch.ResumeLayout(false);
            gb_QuickWatch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg_Selector;
        private GroupBox groupBox_InstanceInfo;
        private Label lb_info_instance;
        private TextBox tb_Instance;
        private NumericUpDown nb_Nr;
        private TextBox tb_Npc;
        private TextBox tb_Condition;
        private Label lb_info_description;
        private Label lb_info_nr;
        private Label lb_info_npc;
        private Label lb_info_condition;
        private GroupBox gb_QuickWatch;
        private Label lb_CBOW_HLP;
        private Label lb_BOW_HLP;
        private Label lb_2H_HLP;
        private Label lb_1H_HLP;
        private Label lb_MP_HLP;
        private Label lb_HP_HLP;
        private Label lb_DEX_HLP;
        private Label lb_STR_HLP;
        private Label lb_CBOW_TEXT;
        private Label lb_BOW_TEXT;
        private Label lb_2H_TEXT;
        private Label lb_1H_TEXT;
        private Label lb_MP_TEXT;
        private Label lb_HP_TEXT;
        private Label lb_DEX_TEXT;
        private Label lb_STR_TEXT;
        private Button btSave;
        public TextBox tb_Description;
    }
}