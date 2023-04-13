using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Notice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace tableForm
{
    public partial class inputForm : Form
    {
        MySqlConnection cn = null;
        MySqlCommand cm = null;
        MySqlDataReader rdr = null;
        Class1 clscon = new Class1();
        Form1 f1 = null;
        public inputForm(Form1 fm1)
        {
            InitializeComponent();
            f1 = fm1;
            cn = new MySqlConnection(clscon.dbConnect());
        }

        public void dataClear()
        {
            txtAddress.Clear();
            txtContact.Clear();
            txtEmpId.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtMName.Clear();
            cboGender.Text = string.Empty;
            dtBdate.Value = DateTime.Now;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        public void modeUpdate(string _id, string _lname, string _fname, string _mname,
            string _bdate, string _gender, string _address, string _contact)
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            txtEmpId.Enabled = false;
            txtEmpId.Text = _id;
            txtLName.Text = _lname;
            txtFName.Text = _fname;
            txtMName.Text = _mname;
            cboGender.Text = _gender;
            txtAddress.Text = _address;
            txtContact.Text = _contact;
            dtBdate.Value = DateTime.Parse(_bdate);
            ShowDialog();
        }

        public void modeReset()
        {
            txtEmpId.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            ShowDialog();
        }

        private void showWarning(Exception ex)
        {
            cn.Close();
            MessageBox.Show("Warning: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool isTxtEmpty()
        {
            if ((txtAddress.Text == string.Empty) || (txtContact.Text == string.Empty)
                        || (txtEmpId.Text == string.Empty) || (txtFName.Text == string.Empty)
                        || (txtLName.Text == string.Empty) || (txtMName.Text == string.Empty))
            {
                MessageBox.Show("Warning: Required empty filed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void disposeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isTxtEmpty())
                {
                    return;
                }
                string sdate = dtBdate.Value.ToString("yyyy-MM-dd");
                cn.Open();
                cm = new MySqlCommand("update tblemployee_yd set " +
                    "                  lname = '" + txtLName.Text + "', fname = '" +
                                       txtFName.Text + "', mname = '" + txtMName.Text +
                    "                  ', bdate = '" + sdate + "', gender = '" +
                                       cboGender.Text + "', address = '" + txtAddress.Text +
                    "                  ', contactno = '" + txtContact.Text + "'" +
                    "                  where employeeno = '" + txtEmpId.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved", "Employee Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataClear();
                f1.LoadRecords();
                this.Dispose();
            }
            catch (Exception ex)
            {
                showWarning(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isTxtEmpty())
                {
                    return;
                }
                string sdate = dtBdate.Value.ToString("yyyy-MM-dd");
                cn.Open();
                cm = new MySqlCommand("insert into tblemployee_yd(employeeno, lname," +
                    "                  fname, mname, bdate, gender, address, contactno)" +
                    "                  values('" + txtEmpId.Text + "','" + txtLName.Text + "','" + txtFName.Text + "'," +
                    "                  '" + txtMName.Text + "','" + sdate + "','" + cboGender.Text + "','" +
                                       txtAddress.Text + "','" + txtContact.Text + "')", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved", "Employee Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataClear();
                f1.LoadRecords();
            }
            catch (Exception ex)
            {
                showWarning(ex);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataClear();
        }
    }
}
