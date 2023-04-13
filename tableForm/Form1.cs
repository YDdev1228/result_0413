using MySql.Data.MySqlClient;

namespace tableForm
{
    public partial class Form1 : Form
    {
        MySqlConnection cn = null;
        MySqlCommand cm = null;
        MySqlDataReader rdr = null;
        Class1 clscon = new Class1();
        string _id, _lname, _fname, _mname, _bdate, _gender, _address, _contact;
        public Form1()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbConnect());
            LoadRecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName == "colUpdate")
            {
                inputForm frm = new inputForm(this);
                frm.modeUpdate(_id, _lname, _fname, _mname, _bdate, _gender, _address, _contact);
            }
            else if(colName == "colDelete")
            {
                if(MessageBox.Show("Are you sure you want to delete this record?",
                    "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {
                        cn.Open();
                        Console.WriteLine(cn.ToString());
                        cm = new MySqlCommand("delete from tblemployee_yd where employeeno = '" + _id + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been successfully deleted.", "Delete Record",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRecords();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        private void inputFormShow_Click(object sender, EventArgs e)
        {
            inputForm frm = new inputForm(this);
            frm.modeReset();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from tblemployee_yd order by lname, fname, mname", cn);
            rdr = cm.ExecuteReader();
            while (rdr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(),
                    rdr[7].ToString());
            }
            rdr.Close();
            cn.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _id = dataGridView1[1, i].Value.ToString();
            _lname = dataGridView1[2, i].Value.ToString();
            _fname = dataGridView1[3, i].Value.ToString();
            _mname = dataGridView1[4, i].Value.ToString();
            _bdate = dataGridView1[5, i].Value.ToString();
            _gender = dataGridView1[6, i].Value.ToString();
            _address = dataGridView1[7, i].Value.ToString();
            _contact = dataGridView1[8, i].Value.ToString();
        }
    }
}