using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ex_5_21_03_DataView
{
    public partial class Form1 : Form
    {
        //pour sqlclient
        SqlDataAdapter dtads;
        SqlConnection conns;
        SqlCommand cmds;
        DataSet dss;

        public Form1()
        {
            InitializeComponent();
            conns = new SqlConnection();
            cmds = new SqlCommand();


            conns.ConnectionString = Properties.Settings.Default.SQL;
            try
            {
                conns.Open();
                if (conns.State == ConnectionState.Open)
                {
                    //connexion réussie
                    MessageBox.Show("connexion réussie");

                }
                else
                {
                    //connexion râtée
                    MessageBox.Show("connexion râtée");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCreation_Click(object sender, EventArgs e)
        {
            lbAge.Visible = true;
            lbDomaine.Visible = true;
            lbID.Visible = true;
            lbNom.Visible = true;

            tbAge.Visible = true;
            tbDomaine.Visible = true;
            tbID.Visible = true;
            tbNom.Visible = true;

            btCreation.Enabled = false;

            dss = new DataSet();

            DataTable dt = new DataTable("Directeur");

            DataColumn dcID = new DataColumn("ID");
            DataColumn dcNom = new DataColumn("Nom");
            DataColumn dcDomaine = new DataColumn("Domaine");
            DataColumn dcAge = new DataColumn("Age");

            dt.Columns.Add(dcID);
            dt.Columns.Add(dcNom);
            dt.Columns.Add(dcDomaine);
            dt.Columns.Add(dcAge);

            dss.Tables.Add(dt);
            

            
        }

        private void btAjout_Click(object sender, EventArgs e)
        {
            dss.Tables["Directeur"].Rows[0].SetField(1, tbID);

        }  

        private void btAffichage_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(dss.Tables["Directeur"].Rows[0].ItemArray.GetValue(0).ToString());
        }
    }
}
