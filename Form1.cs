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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Exit_Menu_Item_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public SqlDataAdapter da;
        public void Refresh_Grid(string tblName)
        {
            DataSet ds = new DataSet();
            da.Fill(ds, tblName);
            dtgView.DataBindings.Clear();
            dtgView.DataBindings.Add("datasource", ds, tblName);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DbConnection c = new DbConnection();
            da = new SqlDataAdapter("SELECT * FROM persons_info", c.cnn);
            Refresh_Grid("persons_info");
        }

        private void txtSearchPerson_TextBoxTextChanged(object sender, EventArgs e)
        {
            DbConnection c = new DbConnection();
            SqlCommand cmd = new SqlCommand("sp_search_person", c.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;
            param = cmd.Parameters.Add("@inp", SqlDbType.VarChar, 500);
            param.Value = txtSearchPerson.TextBoxText;
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            Refresh_Grid("persons_info");
            c.Disconnect();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmPerson fp = new frmPerson(this, "Add");
            fp.ShowDialog();
        }

        private int Find_Person_ID(string name)
        {
            DbConnection c = new DbConnection();
            SqlCommand cmd = new SqlCommand("sp_find_person_id", c.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;
            param = cmd.Parameters.Add("@inp", SqlDbType.VarChar, 500);
            param.Value = name;
            param = cmd.Parameters.Add("@p_id", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            return Int32.Parse(cmd.Parameters["@p_id"].Value.ToString()); 
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (dtgView.SelectedRows.Count > 0)
            {
                string name = dtgView.SelectedRows[0].Cells[0].Value.ToString();
                DbConnection c = new DbConnection();
                DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM person WHERE person_id = " + Find_Person_ID(name).ToString();
                    cmd.Connection = c.cnn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The deletion was done successfully...");
                }
                c.Disconnect();
            } else
            {
                MessageBox.Show("Please select a row of grid to delete...");
            }
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            if (dtgView.SelectedRows.Count > 0)
            {
                string person_name = dtgView.SelectedRows[0].Cells[0].Value.ToString();
                frmPerson fp = new frmPerson(this, "Update");
                fp.id = Find_Person_ID(person_name);
                fp.name = person_name;
                fp.ShowDialog();
            } else
            {
                MessageBox.Show("Please select a row of grid to Update...");
            }
        }
    }
}
