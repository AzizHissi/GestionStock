using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Ventes_f : Form
    {
        StockEntities stock = new StockEntities();
        BindingSource bs = new BindingSource();
        public static string code_product;
        double prix_product;
    
        public Ventes_f()
        {
            InitializeComponent();
        }
        
        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_img_Click(object sender, EventArgs e)
        {
            Liste_Product ls = new Liste_Product();
            ls.Owner = this;
            ls.ShowDialog();
        }
        public void Remplir(string code)
        {
            Produit p = stock.Produits.Find(code);
            dataGridView1.Rows[0].Cells[0].Value = p.Id_Produit ;
            code_product = p.Id_Produit;
            dataGridView1.Rows[0].Cells[1].Value = p.Prix;
            prix_product = (double)p.Prix;

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Quantite")
            {
                dataGridView1.Rows[0].Cells[3].Value = int.Parse(dataGridView1.Rows[0].Cells[1].Value + "") * float.Parse(dataGridView1.Rows[0].Cells[2].Value + "");

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Taux")
            {
                dataGridView1.Rows[0].Cells[5].Value = 
                    float.Parse(dataGridView1.Rows[0].Cells[3].Value + "") - (float.Parse(dataGridView1.Rows[0].Cells[4].Value + "") / 100 * float.Parse(dataGridView1.Rows[0].Cells[3].Value + ""));


            }

        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void Ventes_f_Load(object sender, EventArgs e)
        {
            //try
            //{
                int numCom;
                bs.DataSource = (from c in stock.Clients join v in stock.Villes on c.ville_id equals v.id select new { c.ID, c.Nom_Client, v.Nom }).ToList();
                cb_client.DataSource = bs;
                cb_client.DisplayMember = "ID";
                cb_client.ValueMember = "ID";
                txt_clt.DataBindings.Add("Text", bs, "Nom_Client");
                txt_vllie.DataBindings.Add("Text", bs, "Nom");
                dataGridView1.Rows.Add("", "", "", "", "", "");
                if (int.TryParse(stock.Commandes.Select(c => new { c.Id_commande }).ToList().Last().Id_commande, out numCom))
                {
                    txt_id.Text = (numCom + 1) + "";
                }
                else txt_id.Text = "1";


                txt_id.Enabled = false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (stock.Commandes.Find(txt_id.Text) == null)
                {
                Commande cmd = new Commande()
                {
                    Id_commande = txt_id.Text,
                    Id_Client = cb_client.SelectedValue + "",
                    DES_Commande = txt_desc.Text,
                    Date_Commande = dt_cmd.Value,
                    Nom_Vendeur = Form1.user
                    };
                    stock.Commandes.Add(cmd);
                    stock.SaveChanges();
                }
                if (stock.Detail_Commande.Find(dataGridView1.Rows[0].Cells[0].Value, txt_id.Text) == null)
                {
                    Detail_Commande dt = new Detail_Commande()
                    {
                        Id_commande = txt_id.Text,
                        Id_Produit = code_product,
                        Prix = prix_product,
                        Quantite = int.Parse(dataGridView1.Rows[0].Cells[2].Value + ""),
                        Montant = double.Parse(dataGridView1.Rows[0].Cells[3].Value + ""),
                        réduction = double.Parse(dataGridView1.Rows[0].Cells[4].Value + ""),
                        Montant_total = double.Parse(dataGridView1.Rows[0].Cells[5].Value + "")
                    };
                    stock.Detail_Commande.Add(dt);
                    stock.SaveChanges();
                }
                else
                {
                    Detail_Commande dt = stock.Detail_Commande.Find(dataGridView1.Rows[0].Cells[0].Value, txt_id.Text);
                    dt.Quantite = int.Parse(dataGridView1.Rows[0].Cells[2].Value + "");
                    dt.Montant = double.Parse(dataGridView1.Rows[0].Cells[3].Value + "");
                    dt.réduction = double.Parse(dataGridView1.Rows[0].Cells[4].Value + "");
                    dt.Montant_total = double.Parse(dataGridView1.Rows[0].Cells[5].Value + "");
                    stock.SaveChanges();
                }

                gridView.DataSource = stock.Detail_Commande.ToList();
            //}
            //catch
            //{

            //}
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            Report_Viewer rp = new Report_Viewer();
            rp.ShowDialog();
        }
    }
}
