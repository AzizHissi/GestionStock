namespace GestionStock
{
    partial class Ventes_f
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant_toatl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_img = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vllie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_clt = new System.Windows.Forms.TextBox();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_cmd = new System.Windows.Forms.DateTimePicker();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuCards1.Controls.Add(this.groupBox4);
            this.bunifuCards1.Controls.Add(this.groupBox2);
            this.bunifuCards1.Controls.Add(this.bunifuImageButton2);
            this.bunifuCards1.Controls.Add(this.bunifuImageButton1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1018, 669);
            this.bunifuCards1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.gridView);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox4.Location = new System.Drawing.Point(12, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(994, 316);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PRODUIT ";
            // 
            // gridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.gridView.Location = new System.Drawing.Point(12, 155);
            this.gridView.Margin = new System.Windows.Forms.Padding(15);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(976, 148);
            this.gridView.TabIndex = 35;
            this.gridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.gridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.gridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.gridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.gridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridView.ThemeStyle.HeaderStyle.Height = 21;
            this.gridView.ThemeStyle.ReadOnly = false;
            this.gridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.gridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.gridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridView.ThemeStyle.RowsStyle.Height = 22;
            this.gridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.gridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Controls.Add(this.btn_img);
            this.groupBox6.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.groupBox6.Location = new System.Drawing.Point(6, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(982, 120);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "COMMANDE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(887, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 54);
            this.button1.TabIndex = 40;
            this.button1.Text = "Ajouter ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Produit,
            this.Prix,
            this.Quantite,
            this.Montant,
            this.Taux,
            this.Montant_toatl});
            this.dataGridView1.Location = new System.Drawing.Point(6, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(875, 54);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // ID_Produit
            // 
            this.ID_Produit.HeaderText = "ID Prodiut";
            this.ID_Produit.Name = "ID_Produit";
            this.ID_Produit.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.FillWeight = 80F;
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            // 
            // Montant
            // 
            this.Montant.FillWeight = 110F;
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            this.Montant.ReadOnly = true;
            // 
            // Taux
            // 
            this.Taux.FillWeight = 130F;
            this.Taux.HeaderText = "Remise %";
            this.Taux.Name = "Taux";
            // 
            // Montant_toatl
            // 
            this.Montant_toatl.FillWeight = 120F;
            this.Montant_toatl.HeaderText = "Montant Total";
            this.Montant_toatl.Name = "Montant_toatl";
            this.Montant_toatl.ReadOnly = true;
            // 
            // btn_img
            // 
            this.btn_img.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_img.FlatAppearance.BorderSize = 0;
            this.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_img.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.btn_img.ForeColor = System.Drawing.Color.White;
            this.btn_img.Location = new System.Drawing.Point(6, 27);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(130, 33);
            this.btn_img.TabIndex = 38;
            this.btn_img.Text = "Choisir Produit";
            this.btn_img.UseVisualStyleBackColor = false;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 232);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFOS COMMANDE ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_vllie);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_clt);
            this.groupBox3.Controls.Add(this.cb_client);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(510, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 186);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CLIENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(151, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ville  :";
            // 
            // txt_vllie
            // 
            this.txt_vllie.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_vllie.Location = new System.Drawing.Point(218, 94);
            this.txt_vllie.Name = "txt_vllie";
            this.txt_vllie.Size = new System.Drawing.Size(219, 28);
            this.txt_vllie.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(91, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nom Client :";
            // 
            // txt_clt
            // 
            this.txt_clt.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_clt.Location = new System.Drawing.Point(218, 63);
            this.txt_clt.Name = "txt_clt";
            this.txt_clt.Size = new System.Drawing.Size(219, 28);
            this.txt_clt.TabIndex = 36;
            // 
            // cb_client
            // 
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(218, 26);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(219, 28);
            this.cb_client.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(117, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "ID Client :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dt_cmd);
            this.groupBox1.Controls.Add(this.txt_desc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(20, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 190);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMMANDE";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_id.Location = new System.Drawing.Point(180, 27);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(219, 28);
            this.txt_id.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "ID Commande :";
            // 
            // dt_cmd
            // 
            this.dt_cmd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_cmd.Location = new System.Drawing.Point(180, 61);
            this.dt_cmd.Name = "dt_cmd";
            this.dt_cmd.Size = new System.Drawing.Size(219, 28);
            this.dt_cmd.TabIndex = 40;
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txt_desc.Location = new System.Drawing.Point(180, 95);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(219, 78);
            this.txt_desc.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Date Commande :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(60, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "Description :";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::GestionStock.Properties.Resources.baseline_minimize_black_18dp;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(948, 7);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 7;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::GestionStock.Properties.Resources.twotone_close_black_18dp;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(980, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "ENREGISTRER ET IMPRIMER";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::GestionStock.Properties.Resources.icons8_print_48px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(395, 609);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(256, 48);
            this.bunifuFlatButton1.TabIndex = 37;
            this.bunifuFlatButton1.Text = "ENREGISTRER ET IMPRIMER";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Ventes_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 669);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventes_f";
            this.Text = "Ventes_f";
            this.Load += new System.EventHandler(this.Ventes_f_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vllie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_clt;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_cmd;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView gridView;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taux;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant_toatl;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}