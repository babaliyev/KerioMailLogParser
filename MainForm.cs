using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                

                MatchCollection mc = R.Matches(fileContent);
                


                foreach (Match match in mc)
                {

                    from = match.Groups["from"].ToString().Trim().ToLower().Replace("'","");
                    to = match.Groups["to"].ToString().Trim().ToLower().Replace("'", "");
                    emailDate = DateTime.ParseExact(match.Groups["datetime"].ToString(), "dd/MMM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                    isMain = _from != from || _emailDate != emailDate;

                    dataSetMain.DataTableLogEmail.AddDataTableLogEmailRow(from,to, emailDate,isMain,0,"");

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
            DataSetMain.DataTableLogEmailDataTable logDataTable = new DataSetMain.DataTableLogEmailDataTable();
            DataSetMain.DataTableLogEmailRow[] drsTemp = (DataSetMain.DataTableLogEmailRow[])dataSetMain.DataTableLogEmail.Select("Date >= '" + dateTimePickerFrom.Value.ToString("dd/MMM/yyyy") + " 00:00:00' AND Date<='" + dateTimePickerTo.Value.ToString("dd/MMM/yyyy") + " 23:59:59'", "Date ASC");

            foreach (DataSetMain.DataTableLogEmailRow r in drsTemp)
                logDataTable.AddDataTableLogEmailRow(r.From, r.To, r.Date, r.IsMain, r.ID, r.IsTitleNull()?" ":r.Title);

            dataSetMain.CheckResult.Clear();

            List<String> fromControl = new List<string>();
            List<String> toControl = new List<string>();

            switch (type)
            {
                case 1:
                    foreach (var iFrom in listBoxFromList.Items)
                        fromControl.Add(iFrom.ToString());
                    foreach (DataRow iTo in logDataTable.DefaultView.ToTable(true, "To").Rows)
                        toControl.Add(iTo["To"].ToString());
                    break;
                case 2:
                    foreach (DataRow iFrom in logDataTable.DefaultView.ToTable(true, "From").Rows)
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
                    decimal idFrom = 0;
                    string title = "";

                    DataSetMain.DataTableLogEmailRow[] drs = (DataSetMain.DataTableLogEmailRow[])logDataTable.Select("(From = '" + itemFromWithDateTime[0] + "' AND To = '" + itemToWithDateTime[0] + "'"+((!checkBoxIncludeCC.Checked ? " AND IsMain=1" : "") +
                        " OR From = '" + itemToWithDateTime[0] + "' AND To = '" + itemFromWithDateTime[0] + "'" +  ")"
                        ), "Date ASC");

                    


                    foreach (DataSetMain.DataTableLogEmailRow dr in drs)
                    {

                        if(startCalculatingTime == true)
                        {
                            if (dr["From"].ToString() == itemToWithDateTime[0].ToString())
                            {
                                startCalculatingTime = false;

                                //check if the answer is too late
                                TimeSpan lateDuration =DateTime.Parse(dr["Date"].ToString()) - sendTime;
                                if (lateDuration.TotalHours > controlTime)
                                {
                                    dataSetMain.CheckResult.AddCheckResultRow(itemFromWithDateTime[0], sendTime, itemToWithDateTime[0], DateTime.Parse(dr["Date"].ToString()), "too late",  Math.Round(lateDuration.TotalHours,2),dr.ID, idFrom, title);
                                }
                            }
                            else
                            {
                                dataSetMain.CheckResult.AddCheckResultRow(itemFromWithDateTime[0], sendTime, itemToWithDateTime[0], DateTime.MinValue, "not answered", 0,0, dr.ID, title);
                            }

                            startCalculatingTime = false;
                        }

                        if (dr["From"].ToString() == itemFromWithDateTime[0].ToString() && startCalculatingTime == false)
                        {
                            startCalculatingTime = true;
                            sendTime = DateTime.Parse(dr["Date"].ToString());
                            idFrom = dr.ID;
                            title = dr.IsTitleNull()?"":dr.Title;
                        }      
                    }

                    //check if not answered at all
                    if (startCalculatingTime == true)
                    {
                        dataSetMain.CheckResult.AddCheckResultRow(itemFromWithDateTime[0], Convert.ToDateTime(sendTime), itemToWithDateTime[0], DateTime.MinValue, "not answered", 0,0,idFrom,title);
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
            for (int i = 0; i < dGV.RowCount; i++)
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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            saveSettings();

            //clear data table before fill
            dataSetMain.DataTableLogEmail.Clear();

            using (SqlConnection connection = new SqlConnection())
            {
                try
                {

                    connection.ConnectionString = "Data Source=" + textBoxDBHost.Text +
                       ";Initial Catalog=" + textBoxDBName.Text +
                       ";Persist Security Info=True;User ID=" + textBoxDBLogin.Text +
                       ";Password=" + textBoxDBPassword.Text + ";Connection Timeout=15";

                    connection.Open();

                    SqlCommand loadCmd = new SqlCommand(@"SELECT   mails.id AS ID,
                                                                mails.sender_email AS [from],
                                                                mail_recievers.email AS [to],
                                                                mails.sendtime AS [Date], 
                                                                ~ mail_recievers.cc AS isMain,
                                                                mails.[title]
                                                     FROM    mail_recievers INNER JOIN
                                                             mails ON dbo.mail_recievers.mail_id = dbo.mails.id
                                                    where mail_recievers.[email] is not null and mail_recievers.[email]<>''"
                        , connection);

                    SqlDataReader reader = loadCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DataSetMain.DataTableLogEmailRow row = dataSetMain.DataTableLogEmail.NewDataTableLogEmailRow();

                        row["ID"] = reader["ID"];
                        row["from"] = reader["from"].ToString().Replace("'","").Replace(" ","").ToLower();
                        row["to"] = reader["to"].ToString().Replace("'", "").Replace(" ", "").ToLower();
                        row["Date"] = reader["Date"];
                        row["isMain"] = reader["isMain"];
                        row["title"] = reader["title"];

                        dataSetMain.DataTableLogEmail.AddDataTableLogEmailRow(row);
                    }

                    //fill filter comboboxes by data table data
                    comboBoxFromMailToAddList.DataSource = dataSetMain.DataTableLogEmail.DefaultView.ToTable(true, "From");
                    comboBoxFromMailToAddList.DisplayMember = "From";

                    comboBoxToMailToAddList.DataSource = dataSetMain.DataTableLogEmail.DefaultView.ToTable(true, "To");
                    comboBoxToMailToAddList.DisplayMember = "To";

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void showMail(decimal id)
        {
            if (id > 0)
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    try
                    {

                        connection.ConnectionString = "Data Source=" + textBoxDBHost.Text +
                           ";Initial Catalog=" + textBoxDBName.Text +
                           ";Persist Security Info=True;User ID=" + textBoxDBLogin.Text +
                           ";Password=" + textBoxDBPassword.Text + ";Connection Timeout=15";

                        connection.Open();

                        SqlCommand cmd = new SqlCommand("SELECT [raw]  FROM [dbo].[mails] where ID="+id.ToString(), connection);

                        Object raw = cmd.ExecuteScalar();

                        String fileName = Path.Combine(Path.GetTempPath(),id.ToString()+".eml");
                        File.WriteAllBytes(fileName, (byte[])raw);
                        System.Diagnostics.Process.Start(fileName);

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void checkResultDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal id = 0;

            switch (checkResultDataGridView.Columns[e.ColumnIndex].DataPropertyName)
            {
                case "FromMail":
                case "FromTime":
                    id = (decimal) checkResultDataGridView.Rows[e.RowIndex].Cells["FromMailID"].Value;
                    break;
                case "AnsweredMail":
                case "AnswerTime":
                    id = (decimal) checkResultDataGridView.Rows[e.RowIndex].Cells["AnsweredMailID"].Value;
                    break;

            }            

            showMail(id);
        }

        private void populateListFromFile(string filePath, ListBox lb)
        {
            lb.Items.Clear();
            using (StreamReader r = new StreamReader(filePath))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    lb.Items.Add(line);
                }
            }
        }

        private void saveListToFile(string filePath, ListBox lb)
        {
            using (FileStream S = File.Open(filePath, FileMode.CreateNew))
            using (StreamWriter st = new StreamWriter(S))
                foreach (string aa in lb.Items)
                    st.WriteLine(aa);
        }

        private void buttonSaveFrom_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                saveListToFile(sf.FileName, listBoxFromList);
        }

        private void buttonLoadFrom_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                populateListFromFile(of.FileName, listBoxFromList);
        }

        private void buttonSaveTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                saveListToFile(sf.FileName, listBoxToList);
        }

        private void buttonLoadTo_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                populateListFromFile(of.FileName, listBoxToList);
        }

        private void saveComboBoxToCsV(ComboBox cb, String fileName)
        {
            string stOutput = "";

            
            // Export data.
            for (int i = 0; i < cb.Items.Count; i++)
            {
                stOutput += ((DataRowView)cb.Items[i]).Row[0].ToString() + "\t\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void buttonExportFrom_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "exportFromList.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                saveComboBoxToCsV(comboBoxFromMailToAddList, sfd.FileName);
            } 
        }

        private void buttonExportTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "exportToList.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                saveComboBoxToCsV(comboBoxToMailToAddList, sfd.FileName);
            } 
        }


    }
}
