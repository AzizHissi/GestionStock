using MetroFramework.Forms;
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
    public partial class Report_Viewer : MetroForm
    {
        List_Client_R List_Client_R = new List_Client_R();
        Liste_Produit_R Liste_Produit_R = new Liste_Produit_R();
        Llist_Commande_R llist_Commande_R = new Llist_Commande_R();
        facture facture = new facture();
        public Report_Viewer()
        {
            InitializeComponent();
        }

        private void Report_Viewer_Load(object sender, EventArgs e)
        {
            if (Ventes_f.code_product !=null)
            {
                facture c = new facture();
                c.SetParameterValue("Code_Commande", Ventes_f.code_product);
                crystalReportViewer1.ReportSource = c;
            }
            if(Form1.btn == "Client")
            {
                crystalReportViewer1.ReportSource = List_Client_R;
            }
            else if(Form1.btn == "Produit")
            {
                crystalReportViewer1.ReportSource = Liste_Produit_R;
            }
            else if (Form1.btn == "Commande")
            {
                crystalReportViewer1.ReportSource = llist_Commande_R;
            }
        }
    }
}
