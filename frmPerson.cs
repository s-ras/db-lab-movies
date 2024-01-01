using Stimulsoft.Report.Components;
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
            DialogResult result = MessageBox.Show("Are you sure>", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var db = new moviesEntities())
                {
                    person updated_person = db.people.Single(p => p.person_id == id);
                    updated_person.person_name = txtPersonName.Text;
                    db.SaveChanges();
                    MessageBox.Show("The updation was done successfully...");
                    fmain.Refresh_Grid("persons_info");
                    this.Close();
                }
            }
        }

        private void Add_Person()
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var db = new moviesEntities())
                {
                    person new_person = new person();
                    new_person.person_name = txtPersonName.Text;
                    db.people.Add(new_person);
                    db.SaveChanges();
                }
                txtPersonName.Text = string.Empty;
                fmain.Refresh_Grid("persons_info");
            }
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
