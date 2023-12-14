namespace Sae_2._3_Réseau
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.lbl_SousTitre_IPV4 = new System.Windows.Forms.Label();
            this.lbl_Dec = new System.Windows.Forms.Label();
            this.lbl_Bin = new System.Windows.Forms.Label();
            this.lbl_Hex = new System.Windows.Forms.Label();
            this.lbl_SousTitre_Masque = new System.Windows.Forms.Label();
            this.lbl_CIDR = new System.Windows.Forms.Label();
            this.lbl_Stdr = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbl_AdrNet = new System.Windows.Forms.Label();
            this.lbl_AdrBroad = new System.Windows.Forms.Label();
            this.lbl_1ereIP = new System.Windows.Forms.Label();
            this.lbl_DerIP = new System.Windows.Forms.Label();
            this.lbl_Classe_B1 = new System.Windows.Forms.Label();
            this.lbl_Classe = new System.Windows.Forms.Label();
            this.lbl_NbIP_B1 = new System.Windows.Forms.Label();
            this.lbl_NbIP = new System.Windows.Forms.Label();
            this.lbl_NbMachine_B1 = new System.Windows.Forms.Label();
            this.lbl_NbMachine = new System.Windows.Forms.Label();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.txt_dec_B1 = new System.Windows.Forms.TextBox();
            this.txt_dec_B4 = new System.Windows.Forms.TextBox();
            this.txt_dec_B3 = new System.Windows.Forms.TextBox();
            this.txt_dec_B2 = new System.Windows.Forms.TextBox();
            this.txt_bin_B2 = new System.Windows.Forms.TextBox();
            this.txt_bin_B3 = new System.Windows.Forms.TextBox();
            this.txt_bin_B4 = new System.Windows.Forms.TextBox();
            this.txt_bin_B1 = new System.Windows.Forms.TextBox();
            this.txt_hex_B2 = new System.Windows.Forms.TextBox();
            this.txt_hex_B3 = new System.Windows.Forms.TextBox();
            this.txt_hex_B4 = new System.Windows.Forms.TextBox();
            this.txt_hex_B1 = new System.Windows.Forms.TextBox();
            this.txt_Stdr_B2 = new System.Windows.Forms.TextBox();
            this.txt_Stdr_B3 = new System.Windows.Forms.TextBox();
            this.txt_Stdr_B4 = new System.Windows.Forms.TextBox();
            this.txt_Stdr_B1 = new System.Windows.Forms.TextBox();
            this.lbl_AdrNet_B1 = new System.Windows.Forms.Label();
            this.lbl_AdrNet_B2 = new System.Windows.Forms.Label();
            this.lbl_AdrNet_B4 = new System.Windows.Forms.Label();
            this.lbl_AdrNet_B3 = new System.Windows.Forms.Label();
            this.lbl_AdrBroad_B1 = new System.Windows.Forms.Label();
            this.lbl_AdrBroad_B2 = new System.Windows.Forms.Label();
            this.lbl_AdrBroad_B4 = new System.Windows.Forms.Label();
            this.lbl_AdrBroad_B3 = new System.Windows.Forms.Label();
            this.lbl_1ereIP_B1 = new System.Windows.Forms.Label();
            this.lbl_1ereIP_B2 = new System.Windows.Forms.Label();
            this.lbl_1ereIP_B4 = new System.Windows.Forms.Label();
            this.lbl_1ereIP_B3 = new System.Windows.Forms.Label();
            this.lbl_DerIP_B1 = new System.Windows.Forms.Label();
            this.lbl_DerIP_B2 = new System.Windows.Forms.Label();
            this.lbl_DerIP_B3 = new System.Windows.Forms.Label();
            this.lbl_DerIP_B4 = new System.Windows.Forms.Label();
            this.txt_CIDR_B1 = new System.Windows.Forms.TextBox();
            this.lbl_Erreur = new System.Windows.Forms.Label();
            this.btn_Aide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titre.Location = new System.Drawing.Point(243, 9);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(168, 21);
            this.lbl_Titre.TabIndex = 0;
            this.lbl_Titre.Text = "Calculateur de masque";
            // 
            // lbl_SousTitre_IPV4
            // 
            this.lbl_SousTitre_IPV4.AutoSize = true;
            this.lbl_SousTitre_IPV4.Location = new System.Drawing.Point(10, 23);
            this.lbl_SousTitre_IPV4.Name = "lbl_SousTitre_IPV4";
            this.lbl_SousTitre_IPV4.Size = new System.Drawing.Size(74, 15);
            this.lbl_SousTitre_IPV4.TabIndex = 1;
            this.lbl_SousTitre_IPV4.Text = "Adresse IPV4";
            // 
            // lbl_Dec
            // 
            this.lbl_Dec.AutoSize = true;
            this.lbl_Dec.Location = new System.Drawing.Point(79, 50);
            this.lbl_Dec.Name = "lbl_Dec";
            this.lbl_Dec.Size = new System.Drawing.Size(33, 15);
            this.lbl_Dec.TabIndex = 2;
            this.lbl_Dec.Text = "Déc :";
            // 
            // lbl_Bin
            // 
            this.lbl_Bin.AutoSize = true;
            this.lbl_Bin.Location = new System.Drawing.Point(83, 76);
            this.lbl_Bin.Name = "lbl_Bin";
            this.lbl_Bin.Size = new System.Drawing.Size(30, 15);
            this.lbl_Bin.TabIndex = 3;
            this.lbl_Bin.Text = "Bin :";
            // 
            // lbl_Hex
            // 
            this.lbl_Hex.AutoSize = true;
            this.lbl_Hex.Location = new System.Drawing.Point(79, 103);
            this.lbl_Hex.Name = "lbl_Hex";
            this.lbl_Hex.Size = new System.Drawing.Size(34, 15);
            this.lbl_Hex.TabIndex = 4;
            this.lbl_Hex.Text = "Héx :";
            // 
            // lbl_SousTitre_Masque
            // 
            this.lbl_SousTitre_Masque.AutoSize = true;
            this.lbl_SousTitre_Masque.Location = new System.Drawing.Point(18, 131);
            this.lbl_SousTitre_Masque.Name = "lbl_SousTitre_Masque";
            this.lbl_SousTitre_Masque.Size = new System.Drawing.Size(49, 15);
            this.lbl_SousTitre_Masque.TabIndex = 20;
            this.lbl_SousTitre_Masque.Text = "Masque";
            // 
            // lbl_CIDR
            // 
            this.lbl_CIDR.AutoSize = true;
            this.lbl_CIDR.Location = new System.Drawing.Point(73, 151);
            this.lbl_CIDR.Name = "lbl_CIDR";
            this.lbl_CIDR.Size = new System.Drawing.Size(39, 15);
            this.lbl_CIDR.TabIndex = 21;
            this.lbl_CIDR.Text = "CIDR :";
            // 
            // lbl_Stdr
            // 
            this.lbl_Stdr.AutoSize = true;
            this.lbl_Stdr.Location = new System.Drawing.Point(78, 179);
            this.lbl_Stdr.Name = "lbl_Stdr";
            this.lbl_Stdr.Size = new System.Drawing.Size(34, 15);
            this.lbl_Stdr.TabIndex = 23;
            this.lbl_Stdr.Text = "Stdr :";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label26.Location = new System.Drawing.Point(-7, 246);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(632, 12);
            this.label26.TabIndex = 28;
            // 
            // lbl_AdrNet
            // 
            this.lbl_AdrNet.AutoSize = true;
            this.lbl_AdrNet.Location = new System.Drawing.Point(33, 276);
            this.lbl_AdrNet.Name = "lbl_AdrNet";
            this.lbl_AdrNet.Size = new System.Drawing.Size(76, 15);
            this.lbl_AdrNet.TabIndex = 29;
            this.lbl_AdrNet.Text = "Adresse Net :";
            // 
            // lbl_AdrBroad
            // 
            this.lbl_AdrBroad.AutoSize = true;
            this.lbl_AdrBroad.Location = new System.Drawing.Point(19, 305);
            this.lbl_AdrBroad.Name = "lbl_AdrBroad";
            this.lbl_AdrBroad.Size = new System.Drawing.Size(88, 15);
            this.lbl_AdrBroad.TabIndex = 34;
            this.lbl_AdrBroad.Text = "Adresse Broad :";
            // 
            // lbl_1ereIP
            // 
            this.lbl_1ereIP.AutoSize = true;
            this.lbl_1ereIP.Location = new System.Drawing.Point(64, 335);
            this.lbl_1ereIP.Name = "lbl_1ereIP";
            this.lbl_1ereIP.Size = new System.Drawing.Size(48, 15);
            this.lbl_1ereIP.TabIndex = 39;
            this.lbl_1ereIP.Text = "1ère IP :";
            // 
            // lbl_DerIP
            // 
            this.lbl_DerIP.AutoSize = true;
            this.lbl_DerIP.Location = new System.Drawing.Point(39, 364);
            this.lbl_DerIP.Name = "lbl_DerIP";
            this.lbl_DerIP.Size = new System.Drawing.Size(70, 15);
            this.lbl_DerIP.TabIndex = 44;
            this.lbl_DerIP.Text = "Dernière IP :";
            // 
            // lbl_Classe_B1
            // 
            this.lbl_Classe_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_Classe_B1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Classe_B1.Location = new System.Drawing.Point(182, 422);
            this.lbl_Classe_B1.Name = "lbl_Classe_B1";
            this.lbl_Classe_B1.Size = new System.Drawing.Size(77, 19);
            this.lbl_Classe_B1.TabIndex = 50;
            this.lbl_Classe_B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Classe
            // 
            this.lbl_Classe.AutoSize = true;
            this.lbl_Classe.Location = new System.Drawing.Point(196, 399);
            this.lbl_Classe.Name = "lbl_Classe";
            this.lbl_Classe.Size = new System.Drawing.Size(46, 15);
            this.lbl_Classe.TabIndex = 49;
            this.lbl_Classe.Text = "Classe :";
            // 
            // lbl_NbIP_B1
            // 
            this.lbl_NbIP_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_NbIP_B1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_NbIP_B1.Location = new System.Drawing.Point(283, 422);
            this.lbl_NbIP_B1.Name = "lbl_NbIP_B1";
            this.lbl_NbIP_B1.Size = new System.Drawing.Size(87, 19);
            this.lbl_NbIP_B1.TabIndex = 52;
            this.lbl_NbIP_B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NbIP
            // 
            this.lbl_NbIP.AutoSize = true;
            this.lbl_NbIP.Location = new System.Drawing.Point(288, 399);
            this.lbl_NbIP.Name = "lbl_NbIP";
            this.lbl_NbIP.Size = new System.Drawing.Size(80, 15);
            this.lbl_NbIP.TabIndex = 51;
            this.lbl_NbIP.Text = "Nombre d\'IP :";
            // 
            // lbl_NbMachine_B1
            // 
            this.lbl_NbMachine_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_NbMachine_B1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_NbMachine_B1.Location = new System.Drawing.Point(400, 422);
            this.lbl_NbMachine_B1.Name = "lbl_NbMachine_B1";
            this.lbl_NbMachine_B1.Size = new System.Drawing.Size(77, 19);
            this.lbl_NbMachine_B1.TabIndex = 54;
            this.lbl_NbMachine_B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NbMachine
            // 
            this.lbl_NbMachine.AutoSize = true;
            this.lbl_NbMachine.Location = new System.Drawing.Point(386, 399);
            this.lbl_NbMachine.Name = "lbl_NbMachine";
            this.lbl_NbMachine.Size = new System.Drawing.Size(122, 15);
            this.lbl_NbMachine.TabIndex = 53;
            this.lbl_NbMachine.Text = "Nombre de machine :";
            // 
            // btn_Valider
            // 
            this.btn_Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(114)))));
            this.btn_Valider.Location = new System.Drawing.Point(261, 213);
            this.btn_Valider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(107, 22);
            this.btn_Valider.TabIndex = 73;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = false;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // txt_dec_B1
            // 
            this.txt_dec_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_dec_B1.Location = new System.Drawing.Point(134, 47);
            this.txt_dec_B1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dec_B1.Name = "txt_dec_B1";
            this.txt_dec_B1.Size = new System.Drawing.Size(77, 23);
            this.txt_dec_B1.TabIndex = 56;
            this.txt_dec_B1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dec_B1.TextChanged += new System.EventHandler(this.txt_dec_B1_TextChanged);
            // 
            // txt_dec_B4
            // 
            this.txt_dec_B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_dec_B4.Location = new System.Drawing.Point(446, 47);
            this.txt_dec_B4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dec_B4.Name = "txt_dec_B4";
            this.txt_dec_B4.Size = new System.Drawing.Size(77, 23);
            this.txt_dec_B4.TabIndex = 59;
            this.txt_dec_B4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dec_B4.TextChanged += new System.EventHandler(this.txt_dec_B4_TextChanged);
            // 
            // txt_dec_B3
            // 
            this.txt_dec_B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_dec_B3.Location = new System.Drawing.Point(341, 47);
            this.txt_dec_B3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dec_B3.Name = "txt_dec_B3";
            this.txt_dec_B3.Size = new System.Drawing.Size(77, 23);
            this.txt_dec_B3.TabIndex = 58;
            this.txt_dec_B3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dec_B3.TextChanged += new System.EventHandler(this.txt_dec_B3_TextChanged);
            // 
            // txt_dec_B2
            // 
            this.txt_dec_B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_dec_B2.Location = new System.Drawing.Point(237, 47);
            this.txt_dec_B2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dec_B2.Name = "txt_dec_B2";
            this.txt_dec_B2.Size = new System.Drawing.Size(77, 23);
            this.txt_dec_B2.TabIndex = 57;
            this.txt_dec_B2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dec_B2.TextChanged += new System.EventHandler(this.txt_dec_B2_TextChanged);
            // 
            // txt_bin_B2
            // 
            this.txt_bin_B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_bin_B2.Location = new System.Drawing.Point(237, 74);
            this.txt_bin_B2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bin_B2.Name = "txt_bin_B2";
            this.txt_bin_B2.Size = new System.Drawing.Size(77, 23);
            this.txt_bin_B2.TabIndex = 61;
            this.txt_bin_B2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bin_B2.TextChanged += new System.EventHandler(this.txt_bin_B2_TextChanged);
            // 
            // txt_bin_B3
            // 
            this.txt_bin_B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_bin_B3.Location = new System.Drawing.Point(341, 74);
            this.txt_bin_B3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bin_B3.Name = "txt_bin_B3";
            this.txt_bin_B3.Size = new System.Drawing.Size(77, 23);
            this.txt_bin_B3.TabIndex = 62;
            this.txt_bin_B3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bin_B3.TextChanged += new System.EventHandler(this.txt_bin_B3_TextChanged);
            // 
            // txt_bin_B4
            // 
            this.txt_bin_B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_bin_B4.Location = new System.Drawing.Point(446, 74);
            this.txt_bin_B4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bin_B4.Name = "txt_bin_B4";
            this.txt_bin_B4.Size = new System.Drawing.Size(77, 23);
            this.txt_bin_B4.TabIndex = 63;
            this.txt_bin_B4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bin_B4.TextChanged += new System.EventHandler(this.txt_bin_B4_TextChanged);
            // 
            // txt_bin_B1
            // 
            this.txt_bin_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_bin_B1.Location = new System.Drawing.Point(134, 74);
            this.txt_bin_B1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bin_B1.Name = "txt_bin_B1";
            this.txt_bin_B1.Size = new System.Drawing.Size(77, 23);
            this.txt_bin_B1.TabIndex = 60;
            this.txt_bin_B1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bin_B1.TextChanged += new System.EventHandler(this.txt_bin_B1_TextChanged);
            // 
            // txt_hex_B2
            // 
            this.txt_hex_B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_hex_B2.Location = new System.Drawing.Point(237, 100);
            this.txt_hex_B2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hex_B2.Name = "txt_hex_B2";
            this.txt_hex_B2.Size = new System.Drawing.Size(77, 23);
            this.txt_hex_B2.TabIndex = 65;
            this.txt_hex_B2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hex_B2.TextChanged += new System.EventHandler(this.txt_hex_B2_TextChanged);
            // 
            // txt_hex_B3
            // 
            this.txt_hex_B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_hex_B3.Location = new System.Drawing.Point(341, 100);
            this.txt_hex_B3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hex_B3.Name = "txt_hex_B3";
            this.txt_hex_B3.Size = new System.Drawing.Size(77, 23);
            this.txt_hex_B3.TabIndex = 66;
            this.txt_hex_B3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hex_B3.TextChanged += new System.EventHandler(this.txt_hex_B3_TextChanged);
            // 
            // txt_hex_B4
            // 
            this.txt_hex_B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_hex_B4.Location = new System.Drawing.Point(446, 100);
            this.txt_hex_B4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hex_B4.Name = "txt_hex_B4";
            this.txt_hex_B4.Size = new System.Drawing.Size(77, 23);
            this.txt_hex_B4.TabIndex = 67;
            this.txt_hex_B4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hex_B4.TextChanged += new System.EventHandler(this.txt_hex_B4_TextChanged);
            // 
            // txt_hex_B1
            // 
            this.txt_hex_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_hex_B1.Location = new System.Drawing.Point(134, 100);
            this.txt_hex_B1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hex_B1.Name = "txt_hex_B1";
            this.txt_hex_B1.Size = new System.Drawing.Size(77, 23);
            this.txt_hex_B1.TabIndex = 64;
            this.txt_hex_B1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hex_B1.TextChanged += new System.EventHandler(this.txt_hex_B1_TextChanged);
            // 
            // txt_Stdr_B2
            // 
            this.txt_Stdr_B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_Stdr_B2.Location = new System.Drawing.Point(237, 177);
            this.txt_Stdr_B2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stdr_B2.Name = "txt_Stdr_B2";
            this.txt_Stdr_B2.Size = new System.Drawing.Size(77, 23);
            this.txt_Stdr_B2.TabIndex = 70;
            this.txt_Stdr_B2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Stdr_B2.TextChanged += new System.EventHandler(this.txt_Stdr_B2_TextChanged);
            // 
            // txt_Stdr_B3
            // 
            this.txt_Stdr_B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_Stdr_B3.Location = new System.Drawing.Point(341, 177);
            this.txt_Stdr_B3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stdr_B3.Name = "txt_Stdr_B3";
            this.txt_Stdr_B3.Size = new System.Drawing.Size(77, 23);
            this.txt_Stdr_B3.TabIndex = 71;
            this.txt_Stdr_B3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Stdr_B3.TextChanged += new System.EventHandler(this.txt_Stdr_B3_TextChanged);
            // 
            // txt_Stdr_B4
            // 
            this.txt_Stdr_B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_Stdr_B4.Location = new System.Drawing.Point(446, 177);
            this.txt_Stdr_B4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stdr_B4.Name = "txt_Stdr_B4";
            this.txt_Stdr_B4.Size = new System.Drawing.Size(77, 23);
            this.txt_Stdr_B4.TabIndex = 72;
            this.txt_Stdr_B4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Stdr_B4.TextChanged += new System.EventHandler(this.txt_Stdr_B4_TextChanged);
            // 
            // txt_Stdr_B1
            // 
            this.txt_Stdr_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_Stdr_B1.Location = new System.Drawing.Point(134, 177);
            this.txt_Stdr_B1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stdr_B1.Name = "txt_Stdr_B1";
            this.txt_Stdr_B1.Size = new System.Drawing.Size(77, 23);
            this.txt_Stdr_B1.TabIndex = 69;
            this.txt_Stdr_B1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Stdr_B1.TextChanged += new System.EventHandler(this.txt_Stdr_B1_TextChanged);
            // 
            // lbl_AdrNet_B1
            // 
            this.lbl_AdrNet_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_AdrNet_B1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AdrNet_B1.Location = new System.Drawing.Point(134, 274);
            this.lbl_AdrNet_B1.Name = "lbl_AdrNet_B1";
            this.lbl_AdrNet_B1.Size = new System.Drawing.Size(77, 19);
            this.lbl_AdrNet_B1.TabIndex = 30;
            this.lbl_AdrNet_B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AdrNet_B2
            // 
            this.lbl_AdrNet_B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_AdrNet_B2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AdrNet_B2.Location = new System.Drawing.Point(237, 274);
            this.lbl_AdrNet_B2.Name = "lbl_AdrNet_B2";
            this.lbl_AdrNet_B2.Size = new System.Drawing.Size(77, 19);
            this.lbl_AdrNet_B2.TabIndex = 31;
            this.lbl_AdrNet_B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AdrNet_B4
            // 
            this.lbl_AdrNet_B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_AdrNet_B4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AdrNet_B4.Location = new System.Drawing.Point(446, 274);
            this.lbl_AdrNet_B4.Name = "lbl_AdrNet_B4";
            this.lbl_AdrNet_B4.Size = new System.Drawing.Size(77, 19);
            this.lbl_AdrNet_B4.TabIndex = 32;
            this.lbl_AdrNet_B4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AdrNet_B3
            // 
            this.lbl_AdrNet_B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_AdrNet_B3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AdrNet_B3.Location = new System.Drawing.Point(341, 274);
            this.lbl_AdrNet_B3.Name = "lbl_AdrNet_B3";
            this.lbl_AdrNet_B3.Size = new System.Drawing.Size(77, 19);
            this.lbl_AdrNet_B3.TabIndex = 33;
            this.lbl_AdrNet_B3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AdrBroad_B1
            // 
            this.lbl_AdrBroad_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_AdrBroad_B1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AdrBroad_B1.Location = new System.Drawing.Point(134, 304);
            this.lbl_AdrBroad_B1.Name = "lbl_AdrBroad_B1";
            this.lbl_AdrBroad_B1.Size = new System.Drawing.Size(77, 19);
            this.lbl_AdrBroad_B1.TabIndex = 35;
            this.lbl_AdrBroad_B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AdrBroad_B2
            // 
            this.lbl_AdrBroad_B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_AdrBroad_B2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AdrBroad_B2.Location = new System.Drawing.Point(237, 304);
            this.lbl_AdrBroad_B2.Name = "lbl_AdrBroad_B2";
            this.lbl_AdrBroad_B2.Size = new System.Drawing.Size(77, 19);
            this.lbl_AdrBroad_B2.TabIndex = 36;
            this.lbl_AdrBroad_B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AdrBroad_B4
            // 
            this.lbl_AdrBroad_B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_AdrBroad_B4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AdrBroad_B4.Location = new System.Drawing.Point(446, 304);
            this.lbl_AdrBroad_B4.Name = "lbl_AdrBroad_B4";
            this.lbl_AdrBroad_B4.Size = new System.Drawing.Size(77, 19);
            this.lbl_AdrBroad_B4.TabIndex = 37;
            this.lbl_AdrBroad_B4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AdrBroad_B3
            // 
            this.lbl_AdrBroad_B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_AdrBroad_B3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AdrBroad_B3.Location = new System.Drawing.Point(341, 304);
            this.lbl_AdrBroad_B3.Name = "lbl_AdrBroad_B3";
            this.lbl_AdrBroad_B3.Size = new System.Drawing.Size(77, 19);
            this.lbl_AdrBroad_B3.TabIndex = 38;
            this.lbl_AdrBroad_B3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_1ereIP_B1
            // 
            this.lbl_1ereIP_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_1ereIP_B1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_1ereIP_B1.Location = new System.Drawing.Point(134, 334);
            this.lbl_1ereIP_B1.Name = "lbl_1ereIP_B1";
            this.lbl_1ereIP_B1.Size = new System.Drawing.Size(77, 19);
            this.lbl_1ereIP_B1.TabIndex = 40;
            this.lbl_1ereIP_B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_1ereIP_B2
            // 
            this.lbl_1ereIP_B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_1ereIP_B2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_1ereIP_B2.Location = new System.Drawing.Point(237, 334);
            this.lbl_1ereIP_B2.Name = "lbl_1ereIP_B2";
            this.lbl_1ereIP_B2.Size = new System.Drawing.Size(77, 19);
            this.lbl_1ereIP_B2.TabIndex = 41;
            this.lbl_1ereIP_B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_1ereIP_B4
            // 
            this.lbl_1ereIP_B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_1ereIP_B4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_1ereIP_B4.Location = new System.Drawing.Point(446, 334);
            this.lbl_1ereIP_B4.Name = "lbl_1ereIP_B4";
            this.lbl_1ereIP_B4.Size = new System.Drawing.Size(77, 19);
            this.lbl_1ereIP_B4.TabIndex = 42;
            this.lbl_1ereIP_B4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_1ereIP_B3
            // 
            this.lbl_1ereIP_B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_1ereIP_B3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_1ereIP_B3.Location = new System.Drawing.Point(341, 334);
            this.lbl_1ereIP_B3.Name = "lbl_1ereIP_B3";
            this.lbl_1ereIP_B3.Size = new System.Drawing.Size(77, 19);
            this.lbl_1ereIP_B3.TabIndex = 43;
            this.lbl_1ereIP_B3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DerIP_B1
            // 
            this.lbl_DerIP_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_DerIP_B1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DerIP_B1.Location = new System.Drawing.Point(134, 363);
            this.lbl_DerIP_B1.Name = "lbl_DerIP_B1";
            this.lbl_DerIP_B1.Size = new System.Drawing.Size(77, 19);
            this.lbl_DerIP_B1.TabIndex = 45;
            this.lbl_DerIP_B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DerIP_B2
            // 
            this.lbl_DerIP_B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_DerIP_B2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DerIP_B2.Location = new System.Drawing.Point(237, 363);
            this.lbl_DerIP_B2.Name = "lbl_DerIP_B2";
            this.lbl_DerIP_B2.Size = new System.Drawing.Size(77, 19);
            this.lbl_DerIP_B2.TabIndex = 46;
            this.lbl_DerIP_B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DerIP_B3
            // 
            this.lbl_DerIP_B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_DerIP_B3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DerIP_B3.Location = new System.Drawing.Point(341, 363);
            this.lbl_DerIP_B3.Name = "lbl_DerIP_B3";
            this.lbl_DerIP_B3.Size = new System.Drawing.Size(77, 19);
            this.lbl_DerIP_B3.TabIndex = 48;
            this.lbl_DerIP_B3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DerIP_B4
            // 
            this.lbl_DerIP_B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(209)))), ((int)(((byte)(228)))));
            this.lbl_DerIP_B4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DerIP_B4.Location = new System.Drawing.Point(446, 363);
            this.lbl_DerIP_B4.Name = "lbl_DerIP_B4";
            this.lbl_DerIP_B4.Size = new System.Drawing.Size(77, 19);
            this.lbl_DerIP_B4.TabIndex = 47;
            this.lbl_DerIP_B4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_CIDR_B1
            // 
            this.txt_CIDR_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(167)))), ((int)(((byte)(135)))));
            this.txt_CIDR_B1.Location = new System.Drawing.Point(134, 148);
            this.txt_CIDR_B1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CIDR_B1.Name = "txt_CIDR_B1";
            this.txt_CIDR_B1.Size = new System.Drawing.Size(77, 23);
            this.txt_CIDR_B1.TabIndex = 68;
            this.txt_CIDR_B1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CIDR_B1.TextChanged += new System.EventHandler(this.txt_CIDR_B1_TextChanged);
            // 
            // lbl_Erreur
            // 
            this.lbl_Erreur.AutoSize = true;
            this.lbl_Erreur.Location = new System.Drawing.Point(18, 217);
            this.lbl_Erreur.Name = "lbl_Erreur";
            this.lbl_Erreur.Size = new System.Drawing.Size(0, 15);
            this.lbl_Erreur.TabIndex = 73;
            // 
            // btn_Aide
            // 
            this.btn_Aide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(114)))));
            this.btn_Aide.Location = new System.Drawing.Point(535, 9);
            this.btn_Aide.Name = "btn_Aide";
            this.btn_Aide.Size = new System.Drawing.Size(43, 23);
            this.btn_Aide.TabIndex = 77;
            this.btn_Aide.Text = "Aide";
            this.btn_Aide.UseVisualStyleBackColor = false;
            this.btn_Aide.Click += new System.EventHandler(this.btn_Aide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 30);
            this.label1.TabIndex = 75;
            this.label1.Text = "2023 - SAE 2.3 : Calculateur de masque : Créé par\r\nNina Coiffin, Uriel D\'Almeida," +
    " Thomas Normand, Gaëtan Muchembled, Quentin Petit, Souchere Jules\r\n";
            // 
            // btn_rea
            // 
            this.btn_rea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(114)))));
            this.btn_rea.Location = new System.Drawing.Point(402, 214);
            this.btn_rea.Name = "btn_rea";
            this.btn_rea.Size = new System.Drawing.Size(106, 23);
            this.btn_rea.TabIndex = 76;
            this.btn_rea.Text = "Réinitialiser";
            this.btn_rea.UseVisualStyleBackColor = false;
            this.btn_rea.Click += new System.EventHandler(this.btn_rea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(592, 502);
            this.Controls.Add(this.btn_rea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Aide);
            this.Controls.Add(this.lbl_Erreur);
            this.Controls.Add(this.txt_CIDR_B1);
            this.Controls.Add(this.txt_Stdr_B2);
            this.Controls.Add(this.txt_Stdr_B3);
            this.Controls.Add(this.txt_Stdr_B4);
            this.Controls.Add(this.txt_Stdr_B1);
            this.Controls.Add(this.txt_hex_B2);
            this.Controls.Add(this.txt_hex_B3);
            this.Controls.Add(this.txt_hex_B4);
            this.Controls.Add(this.txt_hex_B1);
            this.Controls.Add(this.txt_bin_B2);
            this.Controls.Add(this.txt_bin_B3);
            this.Controls.Add(this.txt_bin_B4);
            this.Controls.Add(this.txt_bin_B1);
            this.Controls.Add(this.txt_dec_B2);
            this.Controls.Add(this.txt_dec_B3);
            this.Controls.Add(this.txt_dec_B4);
            this.Controls.Add(this.txt_dec_B1);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.lbl_NbMachine_B1);
            this.Controls.Add(this.lbl_NbMachine);
            this.Controls.Add(this.lbl_NbIP_B1);
            this.Controls.Add(this.lbl_NbIP);
            this.Controls.Add(this.lbl_Classe_B1);
            this.Controls.Add(this.lbl_Classe);
            this.Controls.Add(this.lbl_DerIP_B3);
            this.Controls.Add(this.lbl_DerIP_B4);
            this.Controls.Add(this.lbl_DerIP_B2);
            this.Controls.Add(this.lbl_DerIP_B1);
            this.Controls.Add(this.lbl_DerIP);
            this.Controls.Add(this.lbl_1ereIP_B3);
            this.Controls.Add(this.lbl_1ereIP_B4);
            this.Controls.Add(this.lbl_1ereIP_B2);
            this.Controls.Add(this.lbl_1ereIP_B1);
            this.Controls.Add(this.lbl_1ereIP);
            this.Controls.Add(this.lbl_AdrBroad_B3);
            this.Controls.Add(this.lbl_AdrBroad_B4);
            this.Controls.Add(this.lbl_AdrBroad_B2);
            this.Controls.Add(this.lbl_AdrBroad_B1);
            this.Controls.Add(this.lbl_AdrBroad);
            this.Controls.Add(this.lbl_AdrNet_B3);
            this.Controls.Add(this.lbl_AdrNet_B4);
            this.Controls.Add(this.lbl_AdrNet_B2);
            this.Controls.Add(this.lbl_AdrNet_B1);
            this.Controls.Add(this.lbl_AdrNet);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lbl_Stdr);
            this.Controls.Add(this.lbl_CIDR);
            this.Controls.Add(this.lbl_SousTitre_Masque);
            this.Controls.Add(this.lbl_Hex);
            this.Controls.Add(this.lbl_Bin);
            this.Controls.Add(this.lbl_Dec);
            this.Controls.Add(this.lbl_SousTitre_IPV4);
            this.Controls.Add(this.lbl_Titre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Calculo-Maskauto 2000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Titre;
        private Label lbl_SousTitre_IPV4;
        private Label lbl_Dec;
        private Label lbl_Bin;
        private Label lbl_Hex;
        private Label lbl_SousTitre_Masque;
        private Label lbl_CIDR;
        private Label lbl_Stdr;
        private Label label26;
        private Label lbl_AdrNet;
        private Label lbl_AdrBroad;
        private Label lbl_1ereIP;
        private Label lbl_DerIP;
        private Label lbl_Classe_B1;
        private Label lbl_Classe;
        private Label lbl_NbIP_B1;
        private Label lbl_NbIP;
        private Label lbl_NbMachine_B1;
        private Label lbl_NbMachine;
        private Button btn_Valider;
        private TextBox txt_dec_B1;
        private TextBox txt_dec_B4;
        private TextBox txt_dec_B3;
        private TextBox txt_dec_B2;
        private TextBox txt_bin_B2;
        private TextBox txt_bin_B3;
        private TextBox txt_bin_B4;
        private TextBox txt_bin_B1;
        private TextBox txt_hex_B2;
        private TextBox txt_hex_B3;
        private TextBox txt_hex_B4;
        private TextBox txt_hex_B1;
        private TextBox txt_Stdr_B2;
        private TextBox txt_Stdr_B3;
        private TextBox txt_Stdr_B4;
        private TextBox txt_Stdr_B1;
        private Label lbl_AdrNet_B1;
        private Label lbl_AdrNet_B2;
        private Label lbl_AdrNet_B4;
        private Label lbl_AdrNet_B3;
        private Label lbl_AdrBroad_B1;
        private Label lbl_AdrBroad_B2;
        private Label lbl_AdrBroad_B4;
        private Label lbl_AdrBroad_B3;
        private Label lbl_1ereIP_B1;
        private Label lbl_1ereIP_B2;
        private Label lbl_1ereIP_B4;
        private Label lbl_1ereIP_B3;
        private Label lbl_DerIP_B1;
        private Label lbl_DerIP_B2;
        private Label lbl_DerIP_B3;
        private Label lbl_DerIP_B4;
        private TextBox txt_CIDR_B1;
        private Label lbl_Erreur;
        private Button btn_Aide;
        private Label label1;
        private Button btn_rea;
    }
}