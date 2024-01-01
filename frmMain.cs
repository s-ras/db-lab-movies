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
using Stimulsoft.Base;
using Stimulsoft.Report;

namespace db_lab_movies
{
    public partial class frmMain : Form
    {
        public SqlDataAdapter da;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Exit_Menu_Item_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Refresh_Grid(string tblName)
        {
            using (var db = new moviesEntities())
            {
                if (tblName == "persons_info")
                {
                    dtgView.DataSource = (from p in db.persons_info select new { p.person_name }).ToList();
                }
                else if (tblName == "movies_info")
                {
                    dtgView.DataSource = (from m in db.movies_info
                                          select new
                                          {
                                              m.title,
                                              m.Director_Name,
                                              m.Production_Company,
                                              m.release_date,
                                              m.budget,
                                              m.runtime,
                                              m.Movie_Genere,
                                              m.Movie_Original_Language
                                          }).ToList();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Refresh_Grid("persons_info");
        }

        private void txtSearchPerson_TextBoxTextChanged(object sender, EventArgs e)
        {
            using (var db = new moviesEntities())
            {
                dtgView.DataSource = (from p in db.persons_info
                                      where p.person_name.Contains(txtSearchPerson.TextBoxText)
                                      select new { p.person_name }).ToList();
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmPerson fp = new frmPerson(this, "Add");
            fp.ShowDialog();
        }

        private int Find_Person_ID(string name)
        {
            using (var db = new moviesEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter pid =
                    new System.Data.Entity.Core.Objects.ObjectParameter("p_id", typeof(Int32));
                db.sp_find_person_id(name, pid);
                return Convert.ToInt32(pid.Value);
            }
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (dtgView.SelectedRows.Count > 0)
            {
                string name = dtgView.SelectedRows[0].Cells[0].Value.ToString();
                int person_id = Find_Person_ID(name);
                DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var db = new moviesEntities())
                    {
                        person deleted_person = db.people.Single(p => p.person_id == person_id);
                        db.people.Remove(deleted_person);
                        db.SaveChanges();
                        MessageBox.Show("The deletion was done successfully...");
                        txtSearchPerson.TextBoxText = string.Empty;
                    }
                }
            }
            else
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
            }
            else
            {
                MessageBox.Show("Please select a row of grid to Update...");
            }
        }

        private void Backup_Menu_Item_Click(object sender, EventArgs e)
        {
            backupFileDialog.ShowDialog();
            SqlConnection conn = new SqlConnection("Data Source = .//SQLEXPRESS; Initial Catalog = master; Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("BACKUP DATABASE movies TO DISK = '" + backupFileDialog.FileName + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Database Backup has been created successfully...");
            conn.Close();
        }

        private void Restore_Menu_Item_Click(object sender, EventArgs e)
        {
            restoreFileDialog.ShowDialog();
            SqlConnection conn = new SqlConnection("Data Source = .//SQLEXPRESS; Initial Catalog = master; Integrated Security = True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("RESTORE DATABASE movies FROM DISK '" + restoreFileDialog.FileName + "' WITH REPLACE", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Database backup file has been Restore successfully...");
            conn.Close();
            DbConnection c = new DbConnection();
            da = new SqlDataAdapter("SELECT * FROM persons_info", c.cnn);
            Refresh_Grid("persons_info");
            c.Disconnect();
        }

        private void btnPrintPerson_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load("PersonReport.mrt");
            ((Stimulsoft.Report.Dictionary.StiSqlSource)report.Dictionary.DataSources.Items[0]).SqlCommand = "SELECT person_name FROM persons_info WHERE upper(person_name) like upper('%" + txtSearchPerson.TextBoxText + "%')";
            report.Compile();
            report.Show();
        }

        private void rbnMain_ActiveTabChanged(object sender, EventArgs e)
        {
            if (person_tab.Selected)
            {
                Refresh_Grid("persons_info");
            }
            else if (movie_tab.Selected)
            {
                Refresh_Grid("movies_info");
            }
        }
    }
}
