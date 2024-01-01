using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_lab_movies
{
    public partial class frmPerson : Form
    {

        public int id { get; set; }
        public string name { get; set; }
        private frmMain fmain { get; set; }

        public frmPerson(frmMain f, string btn_text)
        {
            InitializeComponent();
            fmain = f;
            btnPerson.Text = btn_text;
        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            txtPersonName.Text = name;
        }

        private void Update_Person()
        {
            DbConnection c = new DbConnection();
            DialogResult result = MessageBox.Show("Are you sure>", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE person SET person_name = @name WHERE person_id = " + id.ToString();
                cmd.Connection = c.cnn;
                cmd.Parameters.AddWithValue("@name", txtPersonName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The updation was done successfully...");
                fmain.Refresh_Grid("persons_info");
                this.Close();
            }
            c.Disconnect();
        }

        private void Add_Person()
        {
            DbConnection c = new DbConnection();
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO PERSON (person_name) VALUES (@name)";
                cmd.Connection = c.cnn;
                cmd.Parameters.AddWithValue("@name", txtPersonName.Text);
                cmd.ExecuteNonQuery();
                txtPersonName.Text = string.Empty;
                fmain.Refresh_Grid("persons_info");
                this.Close();
            }
            c.Disconnect();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            if (btnPerson.Text == "Add")
            {
                Add_Person();
            }
            if (btnPerson.Text == "Update")
            {
                Update_Person();
            }
        }
    }
}
