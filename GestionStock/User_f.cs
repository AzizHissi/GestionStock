using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionStock
{
    public partial class User_f : Form
    {
        StockEntities data = new StockEntities();
        byte[] byteImage;
        public User_f()
        {
            InitializeComponent();
        }

        private void User_f_Load(object sender, EventArgs e)
        {
            try
            {
                cb_role.Items.AddRange(new String[] { "Adminitrateur", "Vendeur" });
                if (Form1.status == "Modifier")
                {
                    User u = data.Users.Find(Form1.code);
                    txt_login.Text = u.login;
                    cb_role.Text = u.User_Type;
                    txt_nom.Text =u.Nom_Complet;
                    txt_pwd.Text = u.Mot_de_passe;
                  
                    byteImage = u.Profil;
                    if (byteImage != null)
                    {
                        var stream = new MemoryStream(byteImage);
                        pic_usr.Image = Image.FromStream(stream);
                    }
                    groupBox2.Text = "MODIFIER UN USER :";
                    btn_add.Text = "ENREGISTRER";
                    txt_login.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_add_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btn_add.Text == "AJOUTER")
                {
                    Ajouter();
                    Form1 master = (Form1)Application.OpenForms["Form1"];
                    master.bunifuImageButton5_Click(sender, e);
                }
                else if (btn_add.Text == "ENREGISTRER")
                {
                    Modifier();
                    Form1 master = (Form1)Application.OpenForms["Form1"];
                    master.bunifuImageButton5_Click(sender, e);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
           
        }

        private void Ajouter()
        {
            if (txt_login.Text != "" && txt_nom.Text != ""  && txt_pwd.Text != "")
            {
                if (data.Users.Find(txt_login.Text) == null)
                {
                    User usr = new User()
                    {
                        login = txt_login.Text,
                        Nom_Complet = txt_nom.Text,
                        User_Type = cb_role.Text,
                        Mot_de_passe = txt_pwd.Text,
                        Profil = byteImage
                    };
                    data.Users.Add(usr);
                    data.SaveChanges();
                    Vider(this);
                    MessageBox.Show("User ajouter avec success ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login existe deja", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Modifier()
        {
            if (txt_login.Text != "" && txt_nom.Text != "" && txt_pwd.Text != "")
            {
                if (data.Users.Find(txt_login.Text) != null)
                {
                    User usr = data.Users.Find(txt_login.Text);

                    usr.login = txt_login.Text;
                    usr.Nom_Complet = txt_nom.Text;
                    usr.User_Type = cb_role.Text;
                    usr.Mot_de_passe = txt_pwd.Text;
                    usr.Profil = byteImage;

                    data.SaveChanges();
                    MessageBox.Show("User Modifier avec success ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_img_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Images Files|*.JPG; *.PNG; *.GIF; *.BMP";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pic_usr.Image = Image.FromFile(op.FileName);
                    MemoryStream ms = new MemoryStream();
                    pic_usr.Image.Save(ms, pic_usr.Image.RawFormat);
                    byteImage = ms.ToArray();
                }

            }
            catch (Exception ex)
            {

            }
        }
        void Vider(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                if (c is MaskedTextBox) ((MaskedTextBox)c).Clear();
                if (c is ComboBox) ((ComboBox)c).SelectedIndex = 0;
                if (c is PictureBox) ((PictureBox)c).ImageLocation = "";
                if (c.Controls.Count != 0) Vider(c);
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 master = (Form1)Application.OpenForms["Form1"];
            master.bunifuImageButton5_Click(sender, e);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 master = (Form1)Application.OpenForms["Form1"];
            master.bunifuImageButton5_Click(sender, e);
        }

       
    }
}
