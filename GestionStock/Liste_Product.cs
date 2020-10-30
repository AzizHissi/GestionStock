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
    public partial class Liste_Product : Form
    {
        StockEntities stock = new StockEntities();
        public static string codep ;
        public Liste_Product()
        {
            InitializeComponent();
        }

        private void Liste_Product_Load(object sender, EventArgs e)
        {
            gridView.DataSource = (from p in stock.Produits
                                   join c in stock.Categories
                                    on p.ID_Categorie equals c.ID_Categorie
                                   where p.Quantite > 0
                                   select new { p.Id_Produit, p.Nom_Produit, c.Des_Categorie, p.Prix, p.Quantite}).ToList();
        }

        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (gridView.Rows.Count != 0)
            {
               
                Ventes_f master = (Ventes_f)Application.OpenForms["Ventes_f"];
                codep = gridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                master.Remplir(codep);
                this.Close();
            }
        }
    }
}
