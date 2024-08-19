using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace CTeacherMaker
{
    public partial class ZTM : Form
    {

        public ZTM()
        {
            InitializeComponent();

            List<DataView> list = new List<DataView>();
            list.Add(new DataView(false, "Si³a", 30, 5));
            list.Add(new DataView(false, "Zrêcznoœæ", 30, 5));
            list.Add(new DataView(false, "HP", 100, 5));
            list.Add(new DataView(false, "MP", 100, 5));
            list.Add(new DataView(false, "Br. Jednor.", 40, 5));
            list.Add(new DataView(false, "Br. Dwurecz.", 40, 5));
            list.Add(new DataView(false, "£uk", 40, 5));
            list.Add(new DataView(false, "Kusza", 40, 5));
            dg_Selector.DataSource = list;

            dg_Selector.RowHeadersVisible = false;
            dg_Selector.SelectionMode =
              DataGridViewSelectionMode.FullRowSelect;


            // Set column names:
            dg_Selector.AllowUserToAddRows = false;
            dg_Selector.Columns[0].Width = 100;
            dg_Selector.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg_Selector.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg_Selector.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dg_Selector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg_Selector.Columns[0].HeaderText = "Aktywne";
            dg_Selector.Columns[1].HeaderText = "Talent";
            dg_Selector.Columns[2].HeaderText = "Maksimum";
            dg_Selector.Columns[3].HeaderText = "Mno¿nik ceny";
            dg_Selector.BackgroundColor = Color.White;


            UpdateRowParams();
        }


        private void Build_FileData()
        {
            string txt_description = tb_Description.Text;

            // Set default value
            if (string.IsNullOrEmpty(txt_description))
                txt_description = "\"Ucz mnie!\"";


            string outputText = "#INSTANCE = " + tb_Instance.Text.ToUpper() + ";\n";
            outputText += "#NPC = " + tb_Npc.Text.ToUpper() + ";\n";
            outputText += "#DESCRIPTION = \"" + txt_description + "\";\n";
            outputText += "#NR = " + nb_Nr.Value + ";\n";
            if (!string.IsNullOrEmpty(tb_Condition.Text))
                outputText += "#CONDITION = " + tb_Condition.Text + ";\n";


            int tal_counter = 0;
            foreach (DataGridViewRow row in dg_Selector.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    outputText += "#TEACH_" + Get_Talent_ByID(tal_counter) + " = " + Convert.ToInt16(row.Cells[2].Value) + ", " + Convert.ToInt16(row.Cells[3].Value) + ";\n";

                tal_counter++;
            }

            File.WriteAllText("tmp.ztf", outputText);
        }

        private void OnSaveClick(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tb_Instance.Text))
            {
                MessageBox.Show("Pole INSTANCJA nie mo¿e byæ puste!", "B£¥D!");
                return;
            }
            if (string.IsNullOrEmpty(tb_Npc.Text))
            {
                MessageBox.Show("Pole NPC nie mo¿e byæ puste!", "B£¥D!");
                return;
            }
            // Check vars:
            SaveFileDialog save_Daedalus_File_Dialog = new SaveFileDialog();

            save_Daedalus_File_Dialog.Filter = "Daedalus script file (*.d)|*.d|All files (*.*)|*.*";
            save_Daedalus_File_Dialog.RestoreDirectory = true;

            if (save_Daedalus_File_Dialog.ShowDialog() == DialogResult.OK)
            {
                Build_FileData();

                var parserArgs = "-f tmp.ztf -s " + save_Daedalus_File_Dialog.FileName;
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        WindowStyle = ProcessWindowStyle.Hidden,
                        FileName = "CTeacherParser.exe",
                        Arguments = parserArgs
                    }
                };
                process.Start();
                process.WaitForExit();

                if (File.Exists("tmp.ztf"))
                    File.Delete("tmp.ztf");
            }
        }

        void UpdateQuickView(int id, object a, object b, bool is_Active)
        {
            System.Drawing.Color col = is_Active ? Color.Black : Color.Gray;
            int multipler;


            if (!int.TryParse(Convert.ToString(b), out multipler))
                multipler = -1;
            multipler *= 50; // ToDo: Add .cfg file!

            string build = "(5PN, " + Convert.ToString(multipler) + " szt. z³ota)";
            switch (id)
            {
                case 0: lb_STR_HLP.ForeColor = col; lb_STR_TEXT.ForeColor = col; lb_STR_HLP.Text = build; break; // str
                case 1: lb_DEX_HLP.ForeColor = col; lb_DEX_TEXT.ForeColor = col; lb_DEX_HLP.Text = build; break;
                case 2: lb_HP_HLP.ForeColor = col; lb_HP_TEXT.ForeColor = col; lb_HP_HLP.Text = build; break; // hp
                case 3: lb_MP_HLP.ForeColor = col; lb_MP_TEXT.ForeColor = col; lb_MP_HLP.Text = build; break; // mp
                case 4: lb_1H_HLP.ForeColor = col; lb_1H_TEXT.ForeColor = col; lb_1H_HLP.Text = build; break; // 1h
                case 5: lb_2H_HLP.ForeColor = col; lb_2H_TEXT.ForeColor = col; lb_2H_HLP.Text = build; break; // 2h
                case 6: lb_BOW_HLP.ForeColor = col; lb_BOW_TEXT.ForeColor = col; lb_BOW_HLP.Text = build; break; // bow
                case 7: lb_CBOW_HLP.ForeColor = col; lb_CBOW_TEXT.ForeColor = col; lb_CBOW_HLP.Text = build; break; // cbow
            }
        }
        void UpdateRowParams()
        {
            bool is_Active = false;
            foreach (DataGridViewRow row in dg_Selector.Rows)
            {
                is_Active = Convert.ToBoolean(row.Cells[0].Value);
                if (is_Active)
                    row.DefaultCellStyle.BackColor = Color.Gold;
                else
                    row.DefaultCellStyle.BackColor = Color.LightGray;

                row.Cells[1].ReadOnly = true;           // ID_TOKEN
                row.Cells[2].ReadOnly = !is_Active;     // MAX_VAL
                row.Cells[3].ReadOnly = !is_Active;     // MULTIPLER

                UpdateQuickView(row.Index, row.Cells[2].Value, row.Cells[3].Value, is_Active);
            }
        }

        private string Get_Talent_ByID(int id)
        {
            switch (id)
            {
                case 0: return "STR";
                case 1: return "DEX";
                case 2: return "HP";
                case 3: return "MP";
                case 4: return "1H";
                case 5: return "2H";
                case 6: return "BOW";
                case 7: return "CBOW";
            }
            return "ERR";
        }

        #region HelperEvents
        private void onCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dg_Selector.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void onCellValueChange(object sender, DataGridViewCellEventArgs e)
        {
            UpdateRowParams();
        }

        private void onChangeSelection(object sender, EventArgs e)
        {
            dg_Selector.ClearSelection();
        }

        private void onCellFormat(object sender, DataGridViewCellFormattingEventArgs e)
        {
            UpdateRowParams();
        }

        private void onEditControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Columns_KeyPress);
            if (dg_Selector.CurrentCell.ColumnIndex >= 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Columns_KeyPress);
                }
            }
        }
        private void Columns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}