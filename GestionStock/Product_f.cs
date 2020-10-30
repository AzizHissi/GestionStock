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
    public partial class Product_f : Form
    {
        StockEntities data = new StockEntities();
        byte[] byteImage;
        public Product_f()
        {
            InitializeComponent();
        }

        private void Product_f_Load(object sender, EventArgs e)
        {
            try
            {
                cb_cat.DataSource = data.Categories.ToList();
                cb_cat.DisplayMember = "Des_Categorie";
                cb_cat.ValueMember = "ID_Categorie";
                if (Form1.status == "Modifier")
                {
                    Produit p = data.Produits.Find(Form1.code);
                    txt_id.Text = p.Id_Produit;
                    cb_cat.SelectedValue = p.ID_Categorie;
                    txt_nom.Text = p.Nom_Produit;
                    txt_qnt.Text = p.Quantite + "";
                    txt_prix.Text = p.Prix + "";
                    byteImage = p.Image_Produit;
                  if(byteImage != null)
                {
                    var stream = new MemoryStream(byteImage);
                    pic_prod.Image = Image.FromStream(stream);
                }
                    groupBox2.Text = "MODIFIER UN PRODUIT :";
                    btn_add.Text = "ENREGISTRER";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(btn_add.Text == "AJOUTER")
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

        private void Ajouter()
        {
            if (txt_id.Text != "" && txt_nom.Text != "" && txt_prix.Text != "" && txt_qnt.Text != "")
            {
                if (data.Produits.Find(txt_id.Text) == null)
                {
                    Produit produit = new Produit()
                    {
                        Id_Produit = txt_id.Text,
                        ID_Categorie = cb_cat.SelectedValue + "",
                        Nom_Produit = txt_nom.Text,
                        Quantite = int.Parse(txt_qnt.Text),
                        Prix = double.Parse(txt_prix.Text),
                        Image_Produit = byteImage
                    };
                    data.Produits.Add(produit);
                    data.SaveChanges();
                    Vider(this);
                    MessageBox.Show("Produit ajouter avec success ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Id produit existe deja", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Modifier()
        {
            if (txt_id.Text != "" && txt_nom.Text != "" && txt_prix.Text != "" && txt_qnt.Text != "")
            {
                if (data.Produits.Find(txt_id.Text) != null)
                {
                    Produit produit = data.Produits.Find(txt_id.Text);

                        produit.ID_Categorie = cb_cat.SelectedValue + "";
                        produit.Nom_Produit = txt_nom.Text;
                        produit.Quantite = int.Parse(txt_qnt.Text);
                        produit.Prix = double.Parse(txt_prix.Text);
                        produit.Image_Produit = byteImage;
                
                    data.SaveChanges();
                    MessageBox.Show("Produit ajouter avec success ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Id produit n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    pic_prod.Image = Image.FromFile(op.FileName);
                    MemoryStream ms = new MemoryStream();
                    pic_prod.Image.Save(ms, pic_prod.Image.RawFormat);
                    byteImage = ms.ToArray();
                }

            }
            catch(Exception ex)
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
