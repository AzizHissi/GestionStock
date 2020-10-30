using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MetroFramework.Forms;

namespace GestionStock
{
    public partial class Client_F : Form
    {
        StockEntities db1 = new StockEntities();
        public Client_F()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 master = (Form1)Application.OpenForms["Form1"];
            master.bunifuImageButton5_Click(sender, e);
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 master = (Form1)Application.OpenForms["Form1"];
            master.bunifuImageButton5_Click(sender, e);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (button2.Text == "AJOUTER")
                {
                    Ajouter();
                    Form1 master = (Form1)Application.OpenForms["Form1"];
                    master.bunifuImageButton5_Click(sender, e);
                }
                else if (button2.Text == "ENREGISTRER")
                {
                    Modifier();
                    Form1 master = (Form1)Application.OpenForms["Form1"];
                    master.bunifuImageButton5_Click(sender, e);
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ajouter()
        {
            if (txt_num.Text != "" && txt_nom.Text != "" && txt_tel.Text != "" && txt_mail.Text != "")
            {
                if (db1.Clients.Find(txt_num.Text) == null)
                {

                    Client client = new Client()
                    {
                        ID = txt_num.Text,
                        Nom_Client = txt_nom.Text,
                        Telephone = txt_tel.Text,
                        E_mail = txt_mail.Text,
                        ville_id = cb_ville.SelectedValue + ""

                    };
                    db1.Clients.Add(client);
                    db1.SaveChanges();
                   
                    Vider(this);
                    MessageBox.Show("Client Ajoutee avec succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Numero Client existe deja", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Modifier()
        {
            if (txt_num.Text != "" && txt_nom.Text != "" && txt_tel.Text != "" && txt_mail.Text != "")
            {
                if (db1.Clients.Find(txt_num.Text) != null)
                {

                    Client client = db1.Clients.Find(txt_num.Text);
                    client.Nom_Client = txt_nom.Text;
                        client.Telephone = txt_tel.Text;
                        client.E_mail = txt_mail.Text;
                        client.ville_id = cb_ville.SelectedValue + "";
                    db1.SaveChanges();
                    
                    this.Close();
                    MessageBox.Show("Client Modifier avec succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Numero Client n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Client_F_Load(object sender, EventArgs e)
        {
            try
            {
                if(Form1.status == "Modifier")
                {
                    Client clt = db1.Clients.Find(Form1.code);
                    txt_num.Text = clt.ID;
                     txt_nom.Text = clt.Nom_Client;
                    txt_tel.Text = clt.Telephone;
                    txt_mail.Text = clt.E_mail;
                    cb_ville.SelectedValue = clt.ville_id;
                    txt_num.Enabled = false;
                    groupBox2.Text = "MODIFIER LES INFOS DU CLIENT :";
                    button2.Text = "ENREGISTRER";
                }
                else if (Form1.status == "Ajouter")
                {
                    Vider(this);
                }
                cb_ville.DataSource = db1.Villes.Select(v => new {v.id , v.Nom }).ToList();
                cb_ville.DisplayMember = "Nom";
                cb_ville.ValueMember = "id";
                

            }
            catch(Exception ex)
            {

            }
        }
        void Vider(Control control)
        {
            foreach(Control c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                if (c is MaskedTextBox) ((MaskedTextBox)c).Clear();
                if (c is ComboBox) ((ComboBox)c).SelectedIndex = 0;
                if (c.Controls.Count != 0) Vider(c);
            }
        }
    }
}
