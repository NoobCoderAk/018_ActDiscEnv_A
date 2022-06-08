using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedEnvironment
{
    public partial class Form1 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public Form1()
        {
            InitializeComponent();

            //--------
            this.pembimbing_AkademikTableAdapter.Fill(this.prodiTIDataSet.Pembimbing_Akademik);
            //---------
            this.pembimbing_AkademikTableAdapter.Fill(this.prodiTIDataSet.Pembimbing_Akademik);
            txtNIK.Enabled = false;
            txtName.Enabled = false;
            cbKeahlian.Enabled = false;
            txtStatus.Enabled = false;
            txtTes.Enabled = false;
            cbKeahlian.Items.Add("Programming");
            cbKeahlian.Items.Add("Database");
            cbKeahlian.Items.Add("Networking");
            cbKeahlian.Items.Add("UI/UX");
            cmdSave.Enabled = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Pembimbing_Akademik' table. You can move, or remove it, as needed.
            this.pembimbing_AkademikTableAdapter.Fill(this.prodiTIDataSet.Pembimbing_Akademik);

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
            txtName.Enabled = true;
            cbKeahlian.Enabled = true;
            txtStatus.Enabled = true;
            txtTes.Enabled = true;

            txtName.Text = "";
            cbKeahlian.Text = "";
            txtStatus.Text = "";
            txtTes.Text = "";

            int ctr, len;
            string codeval;
            dt = prodiTIDataSet.Tables["Pembimbing_Akademik"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["NIK"].ToString();
            codeval = code.Substring(0, 2);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                txtNIK.Text = "a" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 99))
            {
                ctr = ctr + 1;
                txtNIK.Text = "b" + ctr;
            }
            else if (ctr >= 90)
            {
                ctr = ctr + 1;
                txtNIK.Text = "c" + ctr;
            }

            cmdAdd.Enabled = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            dt =prodiTIDataSet.Tables["Pembimbing_Akademik"];
            dr = dt.NewRow();
            dr[0] = txtNIK.Text;
            dr[1] = txtName.Text;
            dr[2] = cbKeahlian.SelectedItem;
            dr[3] = txtStatus.Text;
            dr[4] = txtTes.Text;
            dt.Rows.Add(dr);

            txtNIK.Text= System.Convert.ToString(dr[0]);
            txtNIK.Enabled = false;
            txtName.Enabled = false;
            cbKeahlian.Enabled = false;
            txtStatus.Enabled = false;
            txtTes.Enabled = false;

            this.pembimbing_AkademikTableAdapter.Fill(this.prodiTIDataSet.Pembimbing_Akademik);
            cmdAdd.Enabled = true;
            cmdSave.Enabled = false;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            string code;
            code = txtNIK.Text;
            dr = prodiTIDataSet.Tables["Pembimbing_Akademik"].Rows.Find(code);
            dr.Delete();
            pembimbing_AkademikTableAdapter.Update(prodiTIDataSet);
        }
    }
}
