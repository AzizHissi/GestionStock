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
    public partial class Login_f : Form
    {
        StockEntities se = new StockEntities();
        public static string user;
        public Login_f()
        {
            InitializeComponent();
        }

        private void Login_f_Load(object sender, EventArgs e)
        {
            txt_login.Text = "Login ...";
            txt_pwd.Text = "Mot de passe ...";
        }

        private void txt_login_Leave(object sender, EventArgs e)
        {
            if (txt_login.Text == "") txt_login.Text = "Login ...";
   
        }

        private void txt_login_Enter(object sender, EventArgs e)
        {
            if (txt_login.Text == "Login ...")  txt_login.Text = "";
    
        }
        private void txt_pwd_Leave(object sender, EventArgs e)
        {
            if (txt_pwd.Text == "") txt_pwd.Text = "Mot de passe ...";

        }

        private void txt_pwd_Enter(object sender, EventArgs e)
        {
            if (txt_pwd.Text == "Mot de passe ...") txt_pwd.Text = "";

        }

        private void btn_clt_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_login.Text != "Login ..." && txt_pwd.Text != "Mot de passe ...")
                {
                    if(se.Users.Where(u=>u.login.Equals(txt_login.Text) && u.Mot_de_passe.Equals(txt_pwd.Text)).ToList().Count != 0)
                    {
                        user = se.Users.Find(txt_login.Text).login;
                        Form1 master = (Form1)Application.OpenForms["Form1"];
                        master.Enable_Control();
                       
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login ou mot de passe incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Entrer Login et mot de passe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            btn_log.Checked = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
