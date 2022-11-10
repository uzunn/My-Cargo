namespace My_Kargo
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cboxIl = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxIlce = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxMahalle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxSemt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxYuklemeResmi = new System.Windows.Forms.PictureBox();
            this.groupBoxAliciAdresi = new System.Windows.Forms.GroupBox();
            this.tbxEkAdres = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxPostaKodu = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBoxGonderici = new System.Windows.Forms.GroupBox();
            this.tbxGondericiTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxGondericiEPosta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxGondericiKimlikNO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxGondericiSoyIsim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxGondericiIsim = new System.Windows.Forms.TextBox();
            this.groupBoxAlici = new System.Windows.Forms.GroupBox();
            this.tbxAliciTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxAliciEPosta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxAliciKimlikNO = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxAliciSoyIsim = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxAliciIsim = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxUrunBilgileri = new System.Windows.Forms.GroupBox();
            this.tbxYukseklik = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbxBoy = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbxEn = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbxAgirlik = new System.Windows.Forms.TextBox();
            this.cboxTur = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYuklemeResmi)).BeginInit();
            this.groupBoxAliciAdresi.SuspendLayout();
            this.groupBoxGonderici.SuspendLayout();
            this.groupBoxAlici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBoxUrunBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxIl
            // 
            this.cboxIl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxIl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxIl.FormattingEnabled = true;
            this.cboxIl.Location = new System.Drawing.Point(68, 31);
            this.cboxIl.Margin = new System.Windows.Forms.Padding(2);
            this.cboxIl.Name = "cboxIl";
            this.cboxIl.Size = new System.Drawing.Size(120, 21);
            this.cboxIl.TabIndex = 0;
            this.cboxIl.SelectedIndexChanged += new System.EventHandler(this.cboxIl_SelectedIndexChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(61, 7);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şehir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İlçe:";
            // 
            // cboxIlce
            // 
            this.cboxIlce.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxIlce.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxIlce.FormattingEnabled = true;
            this.cboxIlce.Location = new System.Drawing.Point(68, 63);
            this.cboxIlce.Margin = new System.Windows.Forms.Padding(2);
            this.cboxIlce.Name = "cboxIlce";
            this.cboxIlce.Size = new System.Drawing.Size(120, 21);
            this.cboxIlce.TabIndex = 1;
            this.cboxIlce.SelectedIndexChanged += new System.EventHandler(this.cboxIlce_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mahalle:";
            // 
            // cboxMahalle
            // 
            this.cboxMahalle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxMahalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxMahalle.FormattingEnabled = true;
            this.cboxMahalle.Location = new System.Drawing.Point(68, 128);
            this.cboxMahalle.Margin = new System.Windows.Forms.Padding(2);
            this.cboxMahalle.Name = "cboxMahalle";
            this.cboxMahalle.Size = new System.Drawing.Size(120, 21);
            this.cboxMahalle.TabIndex = 3;
            this.cboxMahalle.SelectedIndexChanged += new System.EventHandler(this.cboxMahalle_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Semt:";
            // 
            // cboxSemt
            // 
            this.cboxSemt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxSemt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxSemt.FormattingEnabled = true;
            this.cboxSemt.Location = new System.Drawing.Point(68, 96);
            this.cboxSemt.Margin = new System.Windows.Forms.Padding(2);
            this.cboxSemt.Name = "cboxSemt";
            this.cboxSemt.Size = new System.Drawing.Size(120, 21);
            this.cboxSemt.TabIndex = 2;
            this.cboxSemt.SelectedIndexChanged += new System.EventHandler(this.cboxSemt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoşgeldin,";
            // 
            // pictureBoxYuklemeResmi
            // 
            this.pictureBoxYuklemeResmi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxYuklemeResmi.Image")));
            this.pictureBoxYuklemeResmi.Location = new System.Drawing.Point(103, -12);
            this.pictureBoxYuklemeResmi.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxYuklemeResmi.Name = "pictureBoxYuklemeResmi";
            this.pictureBoxYuklemeResmi.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxYuklemeResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxYuklemeResmi.TabIndex = 10;
            this.pictureBoxYuklemeResmi.TabStop = false;
            // 
            // groupBoxAliciAdresi
            // 
            this.groupBoxAliciAdresi.Controls.Add(this.tbxEkAdres);
            this.groupBoxAliciAdresi.Controls.Add(this.label17);
            this.groupBoxAliciAdresi.Controls.Add(this.tbxPostaKodu);
            this.groupBoxAliciAdresi.Controls.Add(this.label16);
            this.groupBoxAliciAdresi.Controls.Add(this.label5);
            this.groupBoxAliciAdresi.Controls.Add(this.cboxIl);
            this.groupBoxAliciAdresi.Controls.Add(this.label4);
            this.groupBoxAliciAdresi.Controls.Add(this.label2);
            this.groupBoxAliciAdresi.Controls.Add(this.cboxMahalle);
            this.groupBoxAliciAdresi.Controls.Add(this.cboxIlce);
            this.groupBoxAliciAdresi.Controls.Add(this.label3);
            this.groupBoxAliciAdresi.Controls.Add(this.cboxSemt);
            this.groupBoxAliciAdresi.Location = new System.Drawing.Point(11, 193);
            this.groupBoxAliciAdresi.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAliciAdresi.Name = "groupBoxAliciAdresi";
            this.groupBoxAliciAdresi.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAliciAdresi.Size = new System.Drawing.Size(218, 247);
            this.groupBoxAliciAdresi.TabIndex = 11;
            this.groupBoxAliciAdresi.TabStop = false;
            this.groupBoxAliciAdresi.Text = "Alıcı Adresi";
            // 
            // tbxEkAdres
            // 
            this.tbxEkAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEkAdres.Location = new System.Drawing.Point(68, 193);
            this.tbxEkAdres.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEkAdres.Name = "tbxEkAdres";
            this.tbxEkAdres.Size = new System.Drawing.Size(120, 50);
            this.tbxEkAdres.TabIndex = 4;
            this.tbxEkAdres.Text = "";
            this.tbxEkAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEkAdres_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 195);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Ek:";
            // 
            // tbxPostaKodu
            // 
            this.tbxPostaKodu.Enabled = false;
            this.tbxPostaKodu.Location = new System.Drawing.Point(68, 161);
            this.tbxPostaKodu.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPostaKodu.Name = "tbxPostaKodu";
            this.tbxPostaKodu.Size = new System.Drawing.Size(120, 20);
            this.tbxPostaKodu.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 163);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Posta Kodu:";
            // 
            // groupBoxGonderici
            // 
            this.groupBoxGonderici.Controls.Add(this.tbxGondericiTelefon);
            this.groupBoxGonderici.Controls.Add(this.label10);
            this.groupBoxGonderici.Controls.Add(this.tbxGondericiEPosta);
            this.groupBoxGonderici.Controls.Add(this.label9);
            this.groupBoxGonderici.Controls.Add(this.label8);
            this.groupBoxGonderici.Controls.Add(this.tbxGondericiKimlikNO);
            this.groupBoxGonderici.Controls.Add(this.label7);
            this.groupBoxGonderici.Controls.Add(this.tbxGondericiSoyIsim);
            this.groupBoxGonderici.Controls.Add(this.label6);
            this.groupBoxGonderici.Controls.Add(this.tbxGondericiIsim);
            this.groupBoxGonderici.Location = new System.Drawing.Point(11, 35);
            this.groupBoxGonderici.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxGonderici.Name = "groupBoxGonderici";
            this.groupBoxGonderici.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxGonderici.Size = new System.Drawing.Size(218, 153);
            this.groupBoxGonderici.TabIndex = 10;
            this.groupBoxGonderici.TabStop = false;
            this.groupBoxGonderici.Text = "Gönderici Bilgileri";
            // 
            // tbxGondericiTelefon
            // 
            this.tbxGondericiTelefon.Location = new System.Drawing.Point(68, 90);
            this.tbxGondericiTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGondericiTelefon.Mask = "(999) 000-0000";
            this.tbxGondericiTelefon.Name = "tbxGondericiTelefon";
            this.tbxGondericiTelefon.Size = new System.Drawing.Size(120, 20);
            this.tbxGondericiTelefon.TabIndex = 3;
            this.tbxGondericiTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGondericiTelefon_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "E-Posta:";
            // 
            // tbxGondericiEPosta
            // 
            this.tbxGondericiEPosta.Location = new System.Drawing.Point(68, 115);
            this.tbxGondericiEPosta.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGondericiEPosta.Name = "tbxGondericiEPosta";
            this.tbxGondericiEPosta.Size = new System.Drawing.Size(120, 20);
            this.tbxGondericiEPosta.TabIndex = 4;
            this.tbxGondericiEPosta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGondericiEPosta_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Telefon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kimlik No:";
            // 
            // tbxGondericiKimlikNO
            // 
            this.tbxGondericiKimlikNO.Location = new System.Drawing.Point(68, 66);
            this.tbxGondericiKimlikNO.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGondericiKimlikNO.Name = "tbxGondericiKimlikNO";
            this.tbxGondericiKimlikNO.Size = new System.Drawing.Size(120, 20);
            this.tbxGondericiKimlikNO.TabIndex = 2;
            this.tbxGondericiKimlikNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGondericiKimlikNO_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Soy Isim:";
            // 
            // tbxGondericiSoyIsim
            // 
            this.tbxGondericiSoyIsim.Location = new System.Drawing.Point(68, 41);
            this.tbxGondericiSoyIsim.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGondericiSoyIsim.Name = "tbxGondericiSoyIsim";
            this.tbxGondericiSoyIsim.Size = new System.Drawing.Size(120, 20);
            this.tbxGondericiSoyIsim.TabIndex = 1;
            this.tbxGondericiSoyIsim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGondericiSoyIsim_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Isim:";
            // 
            // tbxGondericiIsim
            // 
            this.tbxGondericiIsim.Location = new System.Drawing.Point(68, 17);
            this.tbxGondericiIsim.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGondericiIsim.Name = "tbxGondericiIsim";
            this.tbxGondericiIsim.Size = new System.Drawing.Size(120, 20);
            this.tbxGondericiIsim.TabIndex = 0;
            this.tbxGondericiIsim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGondericisim_KeyPress);
            // 
            // groupBoxAlici
            // 
            this.groupBoxAlici.Controls.Add(this.tbxAliciTelefon);
            this.groupBoxAlici.Controls.Add(this.label11);
            this.groupBoxAlici.Controls.Add(this.tbxAliciEPosta);
            this.groupBoxAlici.Controls.Add(this.label12);
            this.groupBoxAlici.Controls.Add(this.label13);
            this.groupBoxAlici.Controls.Add(this.tbxAliciKimlikNO);
            this.groupBoxAlici.Controls.Add(this.label14);
            this.groupBoxAlici.Controls.Add(this.tbxAliciSoyIsim);
            this.groupBoxAlici.Controls.Add(this.label15);
            this.groupBoxAlici.Controls.Add(this.tbxAliciIsim);
            this.groupBoxAlici.Location = new System.Drawing.Point(233, 35);
            this.groupBoxAlici.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAlici.Name = "groupBoxAlici";
            this.groupBoxAlici.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAlici.Size = new System.Drawing.Size(218, 153);
            this.groupBoxAlici.TabIndex = 11;
            this.groupBoxAlici.TabStop = false;
            this.groupBoxAlici.Text = "Alıcı Bilgileri";
            // 
            // tbxAliciTelefon
            // 
            this.tbxAliciTelefon.Location = new System.Drawing.Point(68, 90);
            this.tbxAliciTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAliciTelefon.Mask = "(999) 000-0000";
            this.tbxAliciTelefon.Name = "tbxAliciTelefon";
            this.tbxAliciTelefon.Size = new System.Drawing.Size(120, 20);
            this.tbxAliciTelefon.TabIndex = 3;
            this.tbxAliciTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAliciTelefon_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "E-Posta:";
            // 
            // tbxAliciEPosta
            // 
            this.tbxAliciEPosta.Location = new System.Drawing.Point(68, 115);
            this.tbxAliciEPosta.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAliciEPosta.Name = "tbxAliciEPosta";
            this.tbxAliciEPosta.Size = new System.Drawing.Size(120, 20);
            this.tbxAliciEPosta.TabIndex = 4;
            this.tbxAliciEPosta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAliciEPosta_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 93);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Telefon:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Kimlik No:";
            // 
            // tbxAliciKimlikNO
            // 
            this.tbxAliciKimlikNO.Location = new System.Drawing.Point(68, 66);
            this.tbxAliciKimlikNO.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAliciKimlikNO.Name = "tbxAliciKimlikNO";
            this.tbxAliciKimlikNO.Size = new System.Drawing.Size(120, 20);
            this.tbxAliciKimlikNO.TabIndex = 2;
            this.tbxAliciKimlikNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAliciKimlikNO_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 44);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Soy Isim:";
            // 
            // tbxAliciSoyIsim
            // 
            this.tbxAliciSoyIsim.Location = new System.Drawing.Point(68, 41);
            this.tbxAliciSoyIsim.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAliciSoyIsim.Name = "tbxAliciSoyIsim";
            this.tbxAliciSoyIsim.Size = new System.Drawing.Size(120, 20);
            this.tbxAliciSoyIsim.TabIndex = 1;
            this.tbxAliciSoyIsim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAliciSoyIsim_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 20);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Isim:";
            // 
            // tbxAliciIsim
            // 
            this.tbxAliciIsim.Location = new System.Drawing.Point(68, 17);
            this.tbxAliciIsim.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAliciIsim.Name = "tbxAliciIsim";
            this.tbxAliciIsim.Size = new System.Drawing.Size(120, 20);
            this.tbxAliciIsim.TabIndex = 0;
            this.tbxAliciIsim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAlicisim_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBoxUrunBilgileri
            // 
            this.groupBoxUrunBilgileri.Controls.Add(this.tbxYukseklik);
            this.groupBoxUrunBilgileri.Controls.Add(this.label22);
            this.groupBoxUrunBilgileri.Controls.Add(this.tbxBoy);
            this.groupBoxUrunBilgileri.Controls.Add(this.label21);
            this.groupBoxUrunBilgileri.Controls.Add(this.tbxEn);
            this.groupBoxUrunBilgileri.Controls.Add(this.label20);
            this.groupBoxUrunBilgileri.Controls.Add(this.tbxAgirlik);
            this.groupBoxUrunBilgileri.Controls.Add(this.cboxTur);
            this.groupBoxUrunBilgileri.Controls.Add(this.label19);
            this.groupBoxUrunBilgileri.Controls.Add(this.label18);
            this.groupBoxUrunBilgileri.Location = new System.Drawing.Point(233, 194);
            this.groupBoxUrunBilgileri.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxUrunBilgileri.Name = "groupBoxUrunBilgileri";
            this.groupBoxUrunBilgileri.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxUrunBilgileri.Size = new System.Drawing.Size(218, 245);
            this.groupBoxUrunBilgileri.TabIndex = 12;
            this.groupBoxUrunBilgileri.TabStop = false;
            this.groupBoxUrunBilgileri.Text = "Ürün Bilgileri";
            // 
            // tbxYukseklik
            // 
            this.tbxYukseklik.Enabled = false;
            this.tbxYukseklik.Location = new System.Drawing.Point(69, 161);
            this.tbxYukseklik.Margin = new System.Windows.Forms.Padding(2);
            this.tbxYukseklik.Name = "tbxYukseklik";
            this.tbxYukseklik.Size = new System.Drawing.Size(120, 20);
            this.tbxYukseklik.TabIndex = 4;
            this.tbxYukseklik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxYukseklik_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 163);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Yükseklik:";
            // 
            // tbxBoy
            // 
            this.tbxBoy.Enabled = false;
            this.tbxBoy.Location = new System.Drawing.Point(68, 128);
            this.tbxBoy.Margin = new System.Windows.Forms.Padding(2);
            this.tbxBoy.Name = "tbxBoy";
            this.tbxBoy.Size = new System.Drawing.Size(120, 20);
            this.tbxBoy.TabIndex = 3;
            this.tbxBoy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBoy_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 131);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Boy:";
            // 
            // tbxEn
            // 
            this.tbxEn.Enabled = false;
            this.tbxEn.Location = new System.Drawing.Point(69, 96);
            this.tbxEn.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEn.Name = "tbxEn";
            this.tbxEn.Size = new System.Drawing.Size(120, 20);
            this.tbxEn.TabIndex = 2;
            this.tbxEn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEn_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 98);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "En:";
            // 
            // tbxAgirlik
            // 
            this.tbxAgirlik.Location = new System.Drawing.Point(68, 63);
            this.tbxAgirlik.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAgirlik.Name = "tbxAgirlik";
            this.tbxAgirlik.Size = new System.Drawing.Size(120, 20);
            this.tbxAgirlik.TabIndex = 1;
            this.tbxAgirlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAgirlik_KeyPress);
            // 
            // cboxTur
            // 
            this.cboxTur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxTur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTur.FormattingEnabled = true;
            this.cboxTur.Items.AddRange(new object[] {
            "Zarf",
            "Koli"});
            this.cboxTur.Location = new System.Drawing.Point(68, 31);
            this.cboxTur.Margin = new System.Windows.Forms.Padding(2);
            this.cboxTur.Name = "cboxTur";
            this.cboxTur.Size = new System.Drawing.Size(120, 21);
            this.cboxTur.TabIndex = 0;
            this.cboxTur.SelectedIndexChanged += new System.EventHandler(this.cboxTur_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 66);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Ağırlık(gr):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 33);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Tür:";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(11, 444);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(2);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(440, 28);
            this.btnGonder.TabIndex = 13;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(459, 482);
            this.Controls.Add(this.pictureBoxYuklemeResmi);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.groupBoxUrunBilgileri);
            this.Controls.Add(this.groupBoxAlici);
            this.Controls.Add(this.groupBoxGonderici);
            this.Controls.Add(this.groupBoxAliciAdresi);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYuklemeResmi)).EndInit();
            this.groupBoxAliciAdresi.ResumeLayout(false);
            this.groupBoxAliciAdresi.PerformLayout();
            this.groupBoxGonderici.ResumeLayout(false);
            this.groupBoxGonderici.PerformLayout();
            this.groupBoxAlici.ResumeLayout(false);
            this.groupBoxAlici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBoxUrunBilgileri.ResumeLayout(false);
            this.groupBoxUrunBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxIl;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxIlce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxMahalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxSemt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxYuklemeResmi;
        private System.Windows.Forms.GroupBox groupBoxAliciAdresi;
        private System.Windows.Forms.GroupBox groupBoxGonderici;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxGondericiKimlikNO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxGondericiSoyIsim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxGondericiIsim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxGondericiEPosta;
        private System.Windows.Forms.GroupBox groupBoxAlici;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxAliciEPosta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxAliciKimlikNO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxAliciSoyIsim;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxAliciIsim;
        private System.Windows.Forms.TextBox tbxPostaKodu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBoxUrunBilgileri;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox tbxEkAdres;
        private System.Windows.Forms.MaskedTextBox tbxGondericiTelefon;
        private System.Windows.Forms.MaskedTextBox tbxAliciTelefon;
        private System.Windows.Forms.ComboBox cboxTur;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxAgirlik;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxEn;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbxYukseklik;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbxBoy;
        private System.Windows.Forms.Label label21;
    }
}

