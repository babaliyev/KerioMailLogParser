using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EldarMailLogParse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            loadSettings();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.Filter = "log files (*.log)|*.log|All files (*.*)|*.*";
            fd.DefaultExt = "log";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = fd.FileName;
            }

            clearDataTables();
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            saveSettings();

            try
            {
                string localFileName = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"log.txt");
                File.Copy(textBoxFilePath.Text, localFileName, true);

                string fileContent = File.ReadAllText(localFileName);

                string f1 = @"\[(?<datetime>(\d{1,2})/(Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec)/(\d{2,4})\s+(([0-1]?[0-9])|([2][0-3])):([0-5]?[0-9])(:([0-5]?[0-9])))\][^\[\]]+?From:\s+<(?<from>\S+?)>[\s\S]+?To:\s+<(?<to>\S+?)>";

                Regex R = new Regex(f1, RegexOptions.IgnoreCase);

                dateTimePickerFrom.Value = dateTimePickerFrom.MinDate;
                dateTimePickerTo.Value = dateTimePickerTo.MinDate;

                bool isMain = true;

                string _from = "";
                string _to = "";
                DateTime _emailDate = DateTime.MinValue;

                string from = "";
                string to = "";
                DateTime emailDate = DateTime.MinValue;

                //clear data table before fill
                dataSetMain.DataTableLogEmail.Clear();

                foreach (Match match in R.Matches(fileContent))
                {
                    
                    from = match.Groups["from"].ToString().Trim();
                    to =  match.Groups["to"].ToString().Trim();
                    emailDate = DateTime.ParseExact(match.Groups["datetime"].ToString(), "dd/MMM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                    isMain = _from != from || _emailDate != emailDate;

                    dataSetMain.DataTableLogEmail.AddDataTableLogEmailRow(from,to, emailDate,isMain);

                    _from = from;
                    _to = to;
                    _emailDate = emailDate;

                    if (dateTimePickerFrom.Value == dateTimePickerFrom.MinDate || dateTimePickerFrom.Value > emailDate)
                        dateTimePickerFrom.Value = emailDate;

                    if (dateTimePickerTo.Value == dateTimePickerTo.MinDate || dateTimePickerTo.Value < emailDate)
                        dateTimePickerTo.Value = emailDate;
                }

                //fill filter comboboxes by data table data
                comboBoxFromMailToAddList.DataSource = dataSetMain.DataTableLogEmail.DefaultView.ToTable(true, "From");
                comboBoxFromMailToAddList.DisplayMember = "From";

                comboBoxToMailToAddList.DataSource = dataSetMain.DataTableLogEmail.DefaultView.ToTable(true, "To");
                comboBoxToMailToAddList.DisplayMember = "To";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clearDataTables()
        {

        }

        private void buttonAddFrom_Click(object sender, EventArgs e)
        {
            listBoxFromList.Items.Add( comboBoxFromMailToAddList.Text.Trim() + " # " + numericUpDownIntervalFrom.Value.ToString() );
            saveSettings();
        }

        private void buttonAddTo_Click(object sender, EventArgs e)
        {
            listBoxToList.Items.Add(comboBoxToMailToAddList.Text.Trim() + " # " + numericUpDownIntervalTo.Value.ToString());
            saveSettings();
        }

        private void buttonDellFrom_Click(object sender, EventArgs e)
        {
            if (listBoxFromList.SelectedIndex == -1)
            {
                MessageBox.Show( "Select an item before delete", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listBoxFromList.Items.RemoveAt(listBoxFromList.SelectedIndex);
            saveSettings();
        }

        private void buttonDellTo_Click(object sender, EventArgs e)
        {
            if (listBoxToList.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item before delete", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listBoxToList.Items.RemoveAt(listBoxToList.SelectedIndex);
            saveSettings();
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            listBoxFromList.Items.Clear();
            listBoxToList.Items.Clear();
            dataSetMain.CheckResult.Clear();
            saveSettings();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            check(1);
        }

        private void check(int type)
        {
            dataSetMain.CheckResult.Clear();

            List<String> fromControl = new List<string>();
            List<String> toControl = new List<string>();

            switch (type)
            {
                case 1:
                    foreach (var iFrom in listBoxFromList.Items)
                        fromControl.Add(iFrom.ToString());
                    foreach (DataRow iTo in dataSetMain.DataTableLogEmail.DefaultView.ToTable(true, "To").Rows)
                        toControl.Add(iTo["To"].ToString());
                    break;
                case 2:
                    foreach (DataRow iFrom in dataSetMain.DataTableLogEmail.DefaultView.ToTable(true, "From").Rows)
                        fromControl.Add(iFrom["From"].ToString());
                    foreach (string iTo in listBoxToList.Items)
                        toControl.Add(iTo.ToString());
                    break;
                case 3:
                    foreach (var iFrom in listBoxFromList.Items)
                        fromControl.Add(iFrom.ToString());
                    foreach (string iTo in listBoxToList.Items)
                        toControl.Add(iTo.ToString());
                    break;
            }

            foreach (var iFrom in fromControl)
            {
                //split by #
                string[] itemFromWithDateTime = iFrom.ToString().Split(new char[] { '#', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Double controlTime = 0;

                foreach (string iTo in toControl)
                {
                    string[] itemToWithDateTime = iTo.ToString().Split(new char[] { '#', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    switch (type)
                    {
                        case 1:
                            controlTime = Double.Parse(itemFromWithDateTime[1]);
                            break;
                        case 2:
                            controlTime = Double.Parse(itemToWithDateTime[1]);
                            break;
                        case 3:
                            controlTime = Double.Parse(itemFromWithDateTime[1]) < Double.Parse(itemToWithDateTime[1]) ?
                                (Double.Parse(itemFromWithDateTime[1]) == 0 ? Double.Parse(itemToWithDateTime[1]) : Double.Parse(itemFromWithDateTime[1])) :
                                (Double.Parse(itemToWithDateTime[1]) == 0 ? Double.Parse(itemFromWithDateTime[1]) : Double.Parse(itemToWithDateTime[1]));
                            break;
                    }
                   

                    bool startCalculatingTime = false;
                    DateTime sendTime = DateTime.MinValue;

                    foreach (DataSetMain.DataTableLogEmailRow dr in dataSetMain.DataTableLogEmail.Select("(From = '" + itemFromWithDateTime[0] + "' AND To = '" + itemToWithDateTime[0] + "' OR From = '" + itemToWithDateTime[0] + "' AND To = '" + itemFromWithDateTime[0] + "')"
                        + " AND Date >= '" + dateTimePickerFrom.Value.ToString("dd/MMM/yyyy HH:mm:ss") + "' AND Date <='" + dateTimePickerTo.Value.ToString("dd/MMM/yyyy HH:mm:ss") + "'"
                        + (!checkBoxIncludeCC.Checked ? " AND IsMain=1" : ""), "Date ASC"))
                    {
                        if(startCalculatingTime == true)
                        {
                            if (dr["From"].ToString() == itemToWithDateTime[0].ToString())
                            {
                                startCalculatingTime = false;

                                //check if the answer is too late
                                Double lateDuration = Math.Round((DateTime.Parse(dr["Date"].ToString()).TimeOfDay.TotalHours - sendTime.TimeOfDay.TotalHours), 2);
                                if (lateDuration > controlTime)
                                {
                                    dataSetMain.CheckResult.AddCheckResultRow(itemFromWithDateTime[0], sendTime, itemToWithDateTime[0], DateTime.Parse(dr["Date"].ToString()), "too late", lateDuration);
                                }
                            }
                            else
                            {
                                dataSetMain.CheckResult.AddCheckResultRow(itemFromWithDateTime[0], sendTime, itemToWithDateTime[0], DateTime.MinValue, "not answered", 0);
                            }

                            startCalculatingTime = false;
                        }

                        if (dr["From"].ToString() == itemFromWithDateTime[0].ToString() && startCalculatingTime == false)
                        {
                            startCalculatingTime = true;
                            sendTime = DateTime.Parse(dr["Date"].ToString());
                        }      
                    }

                    //check if not answered at all
                    if (startCalculatingTime == true)
                    {
                        dataSetMain.CheckResult.AddCheckResultRow(itemFromWithDateTime[0], Convert.ToDateTime(sendTime), itemToWithDateTime[0], DateTime.MinValue, "not answered", 0);
                    }
                }
            }
        }

        private void buttonCheckTo_Click(object sender, EventArgs e)
        {
            check(2);
        }

        private void buttonCheckFromTo_Click(object sender, EventArgs e)
        {
            check(3);
        }

        private void buttonExportResult_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(checkResultDataGridView, sfd.FileName); // Here dataGridview1 is your grid view name 
            }  
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        public void saveSettings()
        {
            Properties.Settings.Default.fromControl = new StringCollection();
            Properties.Settings.Default.toControl = new StringCollection();

            foreach (var iFrom in listBoxFromList.Items)
                Properties.Settings.Default.fromControl.Add(iFrom.ToString());

            foreach (var iTo in listBoxToList.Items)
                Properties.Settings.Default.toControl.Add(iTo.ToString());

            Properties.Settings.Default.logPath = textBoxFilePath.Text;

            Properties.Settings.Default.Save();
        }

        public void loadSettings()
        {
            textBoxFilePath.Text = Properties.Settings.Default.logPath;

            listBoxFromList.Items.Clear();
            listBoxToList.Items.Clear();

            if (Properties.Settings.Default.fromControl != null) 
            foreach (var iFrom in Properties.Settings.Default.fromControl)
                 listBoxFromList.Items.Add(iFrom.ToString());

            if (Properties.Settings.Default.toControl != null) 
            foreach (var iTo in Properties.Settings.Default.toControl)
                listBoxToList.Items.Add(iTo.ToString());

        }
    }
}
