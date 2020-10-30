using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GestionStock
{
    public partial class Form1 : Form
    {
        

        StockEntities db = new StockEntities();
        BindingSource bs = new BindingSource();
        List<String> lc = new List<string>() {"Tout","Id Client" , "Nom Client" , "Ville" };
        List<String> lu = new List<string>() { "Tout", "Login", "Nom User", "Role" };
        List<String> lp = new List<string>() { "Tout", "Id Produit", "Nom Produit", "Categorie","Prix" };
        List<String> lcm = new List<string>() { "Tout", "Id Commande", "Nom Client", "Id Client", "Date Commande","Nom Vendeur"};
        public static string status;
        public static string code;
        public static string user;
        public static string btn;
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }
      
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + b.Width -35 , b.Location.Y -25);
            imgSlide.SendToBack();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_clt.Checked)
            { 
            Client_F clt = new Client_F();
            
            clt.ShowDialog();
                status = "Ajouter";
            }
            else if (btn_prd.Checked)
            {
                Product_f p = new Product_f();

                p.ShowDialog();
                status = "Ajouter";
            }
            else if (btn_usr.Checked)
            {
                User_f u = new User_f();

                u.ShowDialog();
                status = "Ajouter";
            }
            else if (btn_cmd.Checked)
            {
                Ventes_f v = new Ventes_f();

                v.ShowDialog();
                status = "Ajouter";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (btn_clt.Checked)
            {
                gridView_SelectionChanged( sender,e);
                status = "Modifier";
                Client_F clt = new Client_F();
                clt.ShowDialog();
            }
            if (btn_prd.Checked)
            {
                gridView_SelectionChanged(sender, e);
                status = "Modifier";
                Product_f p = new Product_f();
                p.ShowDialog();
            }
            if (btn_usr.Checked)
            {
                gridView_SelectionChanged(sender, e);
                status = "Modifier";
                User_f u = new User_f();
                u.ShowDialog();
            }
        }
        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button2_Click( sender, e);
        }
        internal void guna2Button1_Click(object sender, EventArgs e)
        {
            bs.DataSource = (from c in db.Clients join v in db.Villes on c.ville_id equals v.id select new {c.ID,c.Nom_Client,c.Telephone,c.E_mail,v.Nom }).ToList();
            comboBox1.DataSource = lc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridView.DataSource = bs;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bs.DataSource = (from p in db.Produits join c in db.Categories on p.ID_Categorie equals c.ID_Categorie select new { p.Id_Produit,p.Nom_Produit, c.Des_Categorie,p.Quantite,p.Prix}).ToList();
            comboBox1.DataSource = lp;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            bs.DataSource = (from cmd in db.Commandes join clt in db.Clients on cmd.Id_Client equals clt.ID join usr in db.Users on cmd.Nom_Vendeur equals usr.login select new { cmd.Id_commande,clt.Nom_Client,cmd.Date_Commande ,cmd.DES_Commande,usr.login}).ToList();
            comboBox1.DataSource = lcm;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        internal void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            
            if (btn_clt.Checked) guna2Button1_Click(sender,e);
            if (btn_prd.Checked) guna2Button2_Click(sender,e);
            if (btn_cmd.Checked) guna2Button3_Click(sender,e);
            if (btn_usr.Checked) btn_usr_Click(sender, e);
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
            status = null;
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (btn_clt.Checked)
            {
                if (comboBox1.SelectedValue.ToString() == "Tout")
                {
                    bs.DataSource = (from c in db.Clients join v in db.Villes on c.ville_id equals v.id where c.ID.Contains(textBox2.Text) || c.Nom_Client.Contains(textBox2.Text) || v.Nom.Contains(textBox2.Text) select new { c.ID, c.Nom_Client, c.Telephone, c.E_mail, v.Nom }).ToList();
                }

                else if (comboBox1.SelectedValue.ToString() == "Id Client")
                {
                    bs.DataSource = (from c in db.Clients join v in db.Villes on c.ville_id equals v.id where c.ID.Contains(textBox2.Text) select new { c.ID, c.Nom_Client, c.Telephone, c.E_mail, v.Nom }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Nom Client")
                {
                    bs.DataSource = (from c in db.Clients join v in db.Villes on c.ville_id equals v.id where c.Nom_Client.Contains(textBox2.Text) select new { c.ID, c.Nom_Client, c.Telephone, c.E_mail, v.Nom }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Ville")
                {
                    bs.DataSource = (from c in db.Clients join v in db.Villes on c.ville_id equals v.id where v.Nom.Contains(textBox2.Text) select new { c.ID, c.Nom_Client, c.Telephone, c.E_mail, v.Nom }).ToList();
                }

            }
            else if (btn_prd.Checked )
            {
                float prix; float.TryParse(textBox2.Text,out prix);
                if (comboBox1.SelectedValue.ToString() == "Tout")
                {
                    bs.DataSource = (from p in db.Produits join c in db.Categories on p.ID_Categorie equals c.ID_Categorie where p.Id_Produit.Contains(textBox2.Text) || p.Nom_Produit.Contains(textBox2.Text) || p.Prix == prix select new { p.Id_Produit, p.Nom_Produit, c.Des_Categorie, p.Quantite, p.Prix }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Id Produit")
                {
                    bs.DataSource = (from p in db.Produits join c in db.Categories on p.ID_Categorie equals c.ID_Categorie where p.Id_Produit.Contains(textBox2.Text) select new { p.Id_Produit, p.Nom_Produit, c.Des_Categorie, p.Quantite, p.Prix }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Nom Produit")
                {
                    bs.DataSource = (from p in db.Produits join c in db.Categories on p.ID_Categorie equals c.ID_Categorie where p.Nom_Produit.Contains(textBox2.Text) select new { p.Id_Produit, p.Nom_Produit, c.Des_Categorie, p.Quantite, p.Prix }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Prix" )
                {
                    
                    bs.DataSource = (from p in db.Produits join c in db.Categories on p.ID_Categorie equals c.ID_Categorie where p.Prix == prix select new { p.Id_Produit, p.Nom_Produit, c.Des_Categorie, p.Quantite, p.Prix }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Categorie")
                {
                    
                    bs.DataSource = (from p in db.Produits join c in db.Categories on p.ID_Categorie equals c.ID_Categorie where c.Des_Categorie.Contains(textBox2.Text) select new { p.Id_Produit, p.Nom_Produit, c.Des_Categorie, p.Quantite, p.Prix }).ToList();
                }
            }
            else if (btn_cmd.Checked)
            {
                if (comboBox1.SelectedValue.ToString() == "Tout")
                {
                    bs.DataSource = (from cmd in db.Commandes join clt in db.Clients on cmd.Id_Client equals clt.ID join usr in db.Users on cmd.Nom_Vendeur equals usr.login where cmd.Id_commande.Contains(textBox2.Text) || clt.Nom_Client.Contains(textBox2.Text) || cmd.Id_Client.Contains(textBox2.Text)  || usr.Nom_Complet.Contains(textBox2.Text)  select new { cmd.Id_commande, clt.Nom_Client, cmd.Date_Commande, cmd.DES_Commande, usr.login }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Id Commande")
                {
                    bs.DataSource = (from cmd in db.Commandes join clt in db.Clients on cmd.Id_Client equals clt.ID join usr in db.Users on cmd.Nom_Vendeur equals usr.login where cmd.Id_commande.Contains(textBox2.Text)  select new { cmd.Id_commande, clt.Nom_Client, cmd.Date_Commande, cmd.DES_Commande, usr.login }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Nom Client")
                {
                    bs.DataSource = (from cmd in db.Commandes join clt in db.Clients on cmd.Id_Client equals clt.ID join usr in db.Users on cmd.Nom_Vendeur equals usr.login where clt.Nom_Client.Contains(textBox2.Text) select new { cmd.Id_commande, clt.Nom_Client, cmd.Date_Commande, cmd.DES_Commande, usr.login }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Id Client")
                {
                    bs.DataSource = (from cmd in db.Commandes join clt in db.Clients on cmd.Id_Client equals clt.ID join usr in db.Users on cmd.Nom_Vendeur equals usr.login where cmd.Id_Client.Contains(textBox2.Text) select new { cmd.Id_commande, clt.Nom_Client, cmd.Date_Commande, cmd.DES_Commande, usr.login }).ToList();
                }
               
                else if (comboBox1.SelectedValue.ToString() == "Nom Vendeur")
                {
                    bs.DataSource = (from cmd in db.Commandes join clt in db.Clients on cmd.Id_Client equals clt.ID join usr in db.Users on cmd.Nom_Vendeur equals usr.login where usr.Nom_Complet.Contains(textBox2.Text) select new { cmd.Id_commande, clt.Nom_Client, cmd.Date_Commande, cmd.DES_Commande, usr.login }).ToList();
                }

            }
            else if (btn_usr.Checked)
            {
                if (comboBox1.SelectedValue.ToString() == "Tout")
                {
                    bs.DataSource = (from u in db.Users where u.login.Contains(textBox2.Text) || u.Nom_Complet.Contains(textBox2.Text)  || u.User_Type.Contains(textBox2.Text)  select new { u.login, u.Nom_Complet, u.User_Type, u.Mot_de_passe }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Login")
                {
                    bs.DataSource = (from u in db.Users where u.login.Contains(textBox2.Text)  select new { u.login, u.Nom_Complet, u.User_Type, u.Mot_de_passe }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Nom User")
                {
                    bs.DataSource = (from u in db.Users where u.Nom_Complet.Contains(textBox2.Text) select new { u.login, u.Nom_Complet, u.User_Type, u.Mot_de_passe }).ToList();
                }
                else if (comboBox1.SelectedValue.ToString() == "Role")
                {
                    bs.DataSource = (from u in db.Users where u.User_Type.Contains(textBox2.Text) select new { u.login, u.Nom_Complet, u.User_Type, u.Mot_de_passe }).ToList();
                }

              

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                if (gridView.Rows.Count > 0) {
                     code = gridView.SelectedRows[0].Cells[0].Value.ToString();
                    if (btn_clt.Checked)
                {
                    if(MessageBox.Show("Voulez-vous vraimant supprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (db.Clients.Find(code) != null)
                        {
                            db.Clients.Remove(db.Clients.Find(code));
                            db.SaveChanges();
                            bunifuImageButton5_Click(sender, e);
                            MessageBox.Show("Client selectionne est supprimer avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Numero de client n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }


                    }
                    else
                    {
                        MessageBox.Show("Operation annulee", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                }
                else if (btn_prd.Checked)
                {
                    if (MessageBox.Show("Voulez-vous vraimant supprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (db.Produits.Find(code) != null)
                        {
                            db.Produits.Remove(db.Produits.Find(code));
                            db.SaveChanges();
                            bunifuImageButton5_Click(sender, e);
                            MessageBox.Show("Produit selectionne est supprimer avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Numero de Produit n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Operation annulee", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else if (btn_cmd.Checked)
                {
                     if (MessageBox.Show("Voulez-vous vraimant supprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (db.Commandes.Find(code) != null)
                            {
                                db.Commandes.Remove(db.Commandes.Find(code));
                                db.SaveChanges();
                                bunifuImageButton5_Click(sender, e);
                                MessageBox.Show("Commande selectionne est supprimer avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Numero de Commande n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Operation annulee", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                }
                    if (btn_usr.Checked)
                    {
                        if (MessageBox.Show("Voulez-vous vraimant supprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (db.Users.Find(code) != null)
                            {
                                db.Users.Remove(db.Users.Find(code));
                                db.SaveChanges();
                                bunifuImageButton5_Click(sender, e);
                                MessageBox.Show("User selectionne est supprimer avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Login  n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }


                        }
                        else
                        {
                            MessageBox.Show("Operation annulee", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }


                    }
                }
                else
                {
                    MessageBox.Show("aucun élément selectionné", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            if(gridView.Rows.Count != 0)
            {
                code = gridView.CurrentRow.Cells[0].Value.ToString();
            }
            
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!etat)
            {
                Login_f login_F = new Login_f();
                login_F.Owner = this;
                login_F.ShowDialog();
            }
            else
            {
                Disable_Control();
            }
           
        }
        byte[] byteImage;
        bool etat = false;
        public void Enable_Control()
        {
            etat = true;
            btn_clt.Enabled = true;
            btn_cmd.Enabled = true;
            btn_prd.Enabled = true;
            btn_usr.Enabled = true;
            panel2.Enabled = true;
            user = Login_f.user;
            btn_connect.Text = "Deconnecter";
            User us = db.Users.Find(user);
            label_user.Text = us.Nom_Complet;
            label_role.Text = us.User_Type;
            byteImage = us.Profil;
            if (byteImage != null)
            {
                var stream = new MemoryStream(byteImage);
                pic_user.Image = Image.FromStream(stream);
            }
            if (us.User_Type == "Adminitrateur") btn_usr.Visible = true; 
        }
        public void Disable_Control()
        {
            etat = false;
            btn_clt.Enabled = false;
            btn_cmd.Enabled = false;
            btn_prd.Enabled = false;
            btn_usr.Enabled = false;
            panel2.Enabled = false;
            user = Login_f.user;
            btn_connect.Text = "Connecter";
            User us = db.Users.Find(user);
            label_user.Text = "";
            label_role.Text = "";
            byteImage = us.Profil;
            btn_usr.Visible = false;
            pic_user.Image = null;
          
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (btn_clt.Checked)
            {
                btn = "Client";
                Report_Viewer rpt = new Report_Viewer();
                rpt.ShowDialog();
            }
            if (btn_prd.Checked)
            {
                btn = "Produit";
                Report_Viewer p = new Report_Viewer();
                p.ShowDialog();
            }
            if (btn_cmd.Checked)
            {
                btn = "Commande";
                Report_Viewer p = new Report_Viewer();
                p.ShowDialog();
            }
        }

        private void btn_usr_Click(object sender, EventArgs e)
        {
            bs.DataSource = (from u in db.Users  select new { u.login,u.Nom_Complet,u.User_Type,u.Mot_de_passe }).ToList();
            comboBox1.DataSource = lu;
        }
    }
}
