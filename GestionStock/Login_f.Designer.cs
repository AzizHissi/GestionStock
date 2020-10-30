namespace GestionStock
{
    partial class Login_f
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_f));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_log = new Guna.UI2.WinForms.Guna2Button();
            this.txt_pwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_log);
            this.panel1.Controls.Add(this.txt_pwd);
            this.panel1.Controls.Add(this.txt_login);
            this.panel1.Location = new System.Drawing.Point(97, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 326);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionStock.Properties.Resources.img_01;
            this.pictureBox1.Location = new System.Drawing.Point(62, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.Color.Transparent;
            this.btn_log.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_log.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_log.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_log.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_log.CheckedState.Parent = this.btn_log;
            this.btn_log.CustomImages.Parent = this.btn_log;
            this.btn_log.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(180)))), ((int)(((byte)(85)))));
            this.btn_log.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.ForeColor = System.Drawing.Color.White;
            this.btn_log.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(180)))), ((int)(((byte)(85)))));
            this.btn_log.HoverState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_log.HoverState.Parent = this.btn_log;
            this.btn_log.Location = new System.Drawing.Point(302, 218);
            this.btn_log.Name = "btn_log";
            this.btn_log.ShadowDecoration.Parent = this.btn_log;
            this.btn_log.Size = new System.Drawing.Size(200, 36);
            this.btn_log.TabIndex = 1;
            this.btn_log.Text = "Login ";
            this.btn_log.UseTransparentBackground = true;
            this.btn_log.Click += new System.EventHandler(this.btn_clt_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.BorderColor = System.Drawing.Color.White;
            this.txt_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pwd.DefaultText = "";
            this.txt_pwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pwd.DisabledState.Parent = this.txt_pwd;
            this.txt_pwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pwd.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txt_pwd.FocusedState.Parent = this.txt_pwd;
            this.txt_pwd.HoverState.BorderColor = System.Drawing.Color.White;
            this.txt_pwd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_pwd.HoverState.Parent = this.txt_pwd;
            this.txt_pwd.Location = new System.Drawing.Point(302, 136);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '\0';
            this.txt_pwd.PlaceholderText = "";
            this.txt_pwd.SelectedText = "";
            this.txt_pwd.ShadowDecoration.Parent = this.txt_pwd;
            this.txt_pwd.Size = new System.Drawing.Size(200, 36);
            this.txt_pwd.TabIndex = 3;
            this.txt_pwd.UseSystemPasswordChar = true;
            this.txt_pwd.Enter += new System.EventHandler(this.txt_pwd_Enter);
            this.txt_pwd.Leave += new System.EventHandler(this.txt_pwd_Leave);
            // 
            // txt_login
            // 
            this.txt_login.BorderColor = System.Drawing.Color.White;
            this.txt_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_login.DefaultText = "";
            this.txt_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_login.DisabledState.Parent = this.txt_login;
            this.txt_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_login.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txt_login.FocusedState.Parent = this.txt_login;
            this.txt_login.HoverState.BorderColor = System.Drawing.Color.White;
            this.txt_login.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_login.HoverState.Parent = this.txt_login;
            this.txt_login.Location = new System.Drawing.Point(302, 85);
            this.txt_login.Name = "txt_login";
            this.txt_login.PasswordChar = '\0';
            this.txt_login.PlaceholderText = "";
            this.txt_login.SelectedText = "";
            this.txt_login.ShadowDecoration.Parent = this.txt_login;
            this.txt_login.Size = new System.Drawing.Size(200, 36);
            this.txt_login.TabIndex = 2;
            this.txt_login.Enter += new System.EventHandler(this.txt_login_Enter);
            this.txt_login.Leave += new System.EventHandler(this.txt_login_Leave);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this.txt_login;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(96)))), ((int)(((byte)(250)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(818, 449);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::GestionStock.Properties.Resources.baseline_minimize_white_18dp;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(757, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 5;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::GestionStock.Properties.Resources.baseline_close_white_18dp;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(789, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 25;
            this.bunifuElipse4.TargetControl = this.txt_pwd;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 26;
            this.bunifuElipse5.TargetControl = this.btn_log;
            // 
            // Login_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 449);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_f";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_f";
            this.Load += new System.EventHandler(this.Login_f_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Guna.UI2.WinForms.Guna2TextBox txt_login;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox txt_pwd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Guna.UI2.WinForms.Guna2Button btn_log;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}