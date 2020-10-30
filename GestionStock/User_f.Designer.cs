namespace GestionStock
{
    partial class User_f
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_img = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.pic_usr = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_add = new System.Windows.Forms.Button();
            this.bunifuCards1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_usr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.btn_add);
            this.bunifuCards1.Controls.Add(this.btn_cancel);
            this.bunifuCards1.Controls.Add(this.groupBox2);
            this.bunifuCards1.Controls.Add(this.bunifuImageButton2);
            this.bunifuCards1.Controls.Add(this.bunifuImageButton1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(726, 416);
            this.bunifuCards1.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(438, 362);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(137, 36);
            this.btn_cancel.TabIndex = 35;
            this.btn_cancel.Text = "ANNULER";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btn_img);
            this.groupBox2.Controls.Add(this.pic_usr);
            this.groupBox2.Controls.Add(this.txt_pwd);
            this.groupBox2.Controls.Add(this.cb_role);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_nom);
            this.groupBox2.Controls.Add(this.txt_login);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 305);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AJOUTER UN USER :";
            // 
            // btn_img
            // 
            this.btn_img.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_img.FlatAppearance.BorderSize = 0;
            this.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_img.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_img.ForeColor = System.Drawing.Color.White;
            this.btn_img.Location = new System.Drawing.Point(461, 236);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(163, 36);
            this.btn_img.TabIndex = 37;
            this.btn_img.Text = "Ajouter Image";
            this.btn_img.UseVisualStyleBackColor = false;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_pwd.Location = new System.Drawing.Point(147, 198);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(219, 32);
            this.txt_pwd.TabIndex = 25;
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(147, 146);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(219, 32);
            this.cb_role.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(79, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Login :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(80, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Role  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(84, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mot de passe :";
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_nom.Location = new System.Drawing.Point(147, 94);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(219, 32);
            this.txt_nom.TabIndex = 8;
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_login.Location = new System.Drawing.Point(147, 42);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(219, 32);
            this.txt_login.TabIndex = 5;
            // 
            // pic_usr
            // 
            this.pic_usr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_usr.Location = new System.Drawing.Point(440, 42);
            this.pic_usr.Name = "pic_usr";
            this.pic_usr.Size = new System.Drawing.Size(218, 188);
            this.pic_usr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_usr.TabIndex = 26;
            this.pic_usr.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::GestionStock.Properties.Resources.baseline_minimize_black_18dp;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(650, 10);
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
            this.bunifuImageButton1.Image = global::GestionStock.Properties.Resources.twotone_close_black_18dp;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(682, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(152, 362);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(137, 36);
            this.btn_add.TabIndex = 38;
            this.btn_add.Text = "AJOUTER";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // User_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 416);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_f";
            this.Text = "User_f";
            this.Load += new System.EventHandler(this.User_f_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_usr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.PictureBox pic_usr;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_login;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button btn_add;
    }
}