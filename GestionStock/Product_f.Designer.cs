namespace GestionStock
{
    partial class Product_f
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_img = new System.Windows.Forms.Button();
            this.txt_prix = new System.Windows.Forms.TextBox();
            this.txt_qnt = new System.Windows.Forms.TextBox();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pic_prod = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
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
            this.bunifuCards1.Size = new System.Drawing.Size(833, 504);
            this.bunifuCards1.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(201, 455);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(137, 36);
            this.btn_add.TabIndex = 37;
            this.btn_add.Text = "AJOUTER";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(487, 455);
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
            this.groupBox2.Controls.Add(this.txt_prix);
            this.groupBox2.Controls.Add(this.pic_prod);
            this.groupBox2.Controls.Add(this.txt_qnt);
            this.groupBox2.Controls.Add(this.cb_cat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_nom);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 363);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AJOUTER UN PRODUIT :";
            // 
            // btn_img
            // 
            this.btn_img.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_img.FlatAppearance.BorderSize = 0;
            this.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_img.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_img.ForeColor = System.Drawing.Color.White;
            this.btn_img.Location = new System.Drawing.Point(542, 307);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(163, 36);
            this.btn_img.TabIndex = 37;
            this.btn_img.Text = "Ajouter Image";
            this.btn_img.UseVisualStyleBackColor = false;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            // 
            // txt_prix
            // 
            this.txt_prix.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_prix.Location = new System.Drawing.Point(194, 269);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(219, 32);
            this.txt_prix.TabIndex = 27;
            // 
            // txt_qnt
            // 
            this.txt_qnt.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_qnt.Location = new System.Drawing.Point(194, 217);
            this.txt_qnt.Name = "txt_qnt";
            this.txt_qnt.Size = new System.Drawing.Size(219, 32);
            this.txt_qnt.TabIndex = 25;
            // 
            // cb_cat
            // 
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(194, 165);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(219, 32);
            this.cb_cat.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(76, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID Produit :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(78, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Categorie  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(62, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nom Produit :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(18, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quantite en Stock :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(125, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Prix  :";
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_nom.Location = new System.Drawing.Point(194, 113);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(219, 32);
            this.txt_nom.TabIndex = 8;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_id.Location = new System.Drawing.Point(194, 61);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(219, 32);
            this.txt_id.TabIndex = 5;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.bunifuCards1;
            // 
            // pic_prod
            // 
            this.pic_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_prod.Location = new System.Drawing.Point(487, 61);
            this.pic_prod.Name = "pic_prod";
            this.pic_prod.Size = new System.Drawing.Size(273, 240);
            this.pic_prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_prod.TabIndex = 26;
            this.pic_prod.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::GestionStock.Properties.Resources.baseline_minimize_black_18dp;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(768, 9);
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(800, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Product_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 504);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_f";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_f";
            this.Load += new System.EventHandler(this.Product_f_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.TextBox txt_prix;
        private System.Windows.Forms.PictureBox pic_prod;
        private System.Windows.Forms.TextBox txt_qnt;
        private System.Windows.Forms.ComboBox cb_cat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_id;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}