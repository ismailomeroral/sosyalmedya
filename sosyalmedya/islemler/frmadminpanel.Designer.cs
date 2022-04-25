namespace sosyalmedya.islemler
{
    partial class frmadminpanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlyanmenu = new System.Windows.Forms.Panel();
            this.lblsaat = new System.Windows.Forms.Label();
            this.btngeribildirm = new System.Windows.Forms.Button();
            this.pnlkullaniciliste = new System.Windows.Forms.Panel();
            this.btnadminkullist = new System.Windows.Forms.Button();
            this.btnwhitekullist = new System.Windows.Forms.Button();
            this.btnblackkullist = new System.Windows.Forms.Button();
            this.btnallkullist = new System.Windows.Forms.Button();
            this.btnkulliste = new System.Windows.Forms.Button();
            this.dataGridViewkullist = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbkullist = new System.Windows.Forms.GroupBox();
            this.btnyetki = new System.Windows.Forms.Button();
            this.btnban = new System.Windows.Forms.Button();
            this.btbybkaldır = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gboxgeribildirim = new System.Windows.Forms.GroupBox();
            this.btneski = new System.Windows.Forms.Button();
            this.btnyeni = new System.Windows.Forms.Button();
            this.btnhespsi = new System.Windows.Forms.Button();
            this.txtmesaj = new System.Windows.Forms.RichTextBox();
            this.lbltip = new System.Windows.Forms.Label();
            this.dataGridViewgeribildirim = new System.Windows.Forms.DataGridView();
            this.gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanicid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnoku = new System.Windows.Forms.Button();
            this.tmrsaat = new System.Windows.Forms.Timer(this.components);
            this.pnlgerilist = new System.Windows.Forms.Panel();
            this.btntoneri = new System.Windows.Forms.Button();
            this.btnthata = new System.Windows.Forms.Button();
            this.btntsikayet = new System.Windows.Forms.Button();
            this.btnthepsi = new System.Windows.Forms.Button();
            this.lbluyesayı = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlyanmenu.SuspendLayout();
            this.pnlkullaniciliste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkullist)).BeginInit();
            this.gbkullist.SuspendLayout();
            this.gboxgeribildirim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewgeribildirim)).BeginInit();
            this.pnlgerilist.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 31);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sosyalmedya.Properties.Resources.administrator_male_30px;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin Panel";
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblexit.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.Red;
            this.lblexit.Location = new System.Drawing.Point(997, 3);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(24, 25);
            this.lblexit.TabIndex = 2;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 2);
            this.panel2.TabIndex = 1;
            // 
            // pnlyanmenu
            // 
            this.pnlyanmenu.Controls.Add(this.pnlgerilist);
            this.pnlyanmenu.Controls.Add(this.lblsaat);
            this.pnlyanmenu.Controls.Add(this.btngeribildirm);
            this.pnlyanmenu.Controls.Add(this.pnlkullaniciliste);
            this.pnlyanmenu.Controls.Add(this.btnkulliste);
            this.pnlyanmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlyanmenu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlyanmenu.Location = new System.Drawing.Point(0, 33);
            this.pnlyanmenu.Name = "pnlyanmenu";
            this.pnlyanmenu.Size = new System.Drawing.Size(171, 543);
            this.pnlyanmenu.TabIndex = 2;
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.BackColor = System.Drawing.Color.Gainsboro;
            this.lblsaat.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaat.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblsaat.Location = new System.Drawing.Point(51, 513);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(28, 21);
            this.lblsaat.TabIndex = 16;
            this.lblsaat.Text = "00";
            // 
            // btngeribildirm
            // 
            this.btngeribildirm.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btngeribildirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngeribildirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeribildirm.Location = new System.Drawing.Point(0, 216);
            this.btngeribildirm.Name = "btngeribildirm";
            this.btngeribildirm.Size = new System.Drawing.Size(171, 42);
            this.btngeribildirm.TabIndex = 4;
            this.btngeribildirm.Text = "Geri Bildirimler";
            this.btngeribildirm.UseVisualStyleBackColor = false;
            this.btngeribildirm.Click += new System.EventHandler(this.btngeribildirm_Click);
            // 
            // pnlkullaniciliste
            // 
            this.pnlkullaniciliste.Controls.Add(this.btnadminkullist);
            this.pnlkullaniciliste.Controls.Add(this.btnwhitekullist);
            this.pnlkullaniciliste.Controls.Add(this.btnblackkullist);
            this.pnlkullaniciliste.Controls.Add(this.btnallkullist);
            this.pnlkullaniciliste.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlkullaniciliste.Location = new System.Drawing.Point(0, 42);
            this.pnlkullaniciliste.Name = "pnlkullaniciliste";
            this.pnlkullaniciliste.Size = new System.Drawing.Size(171, 174);
            this.pnlkullaniciliste.TabIndex = 1;
            // 
            // btnadminkullist
            // 
            this.btnadminkullist.BackColor = System.Drawing.Color.SpringGreen;
            this.btnadminkullist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnadminkullist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadminkullist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnadminkullist.Location = new System.Drawing.Point(0, 129);
            this.btnadminkullist.Name = "btnadminkullist";
            this.btnadminkullist.Size = new System.Drawing.Size(171, 45);
            this.btnadminkullist.TabIndex = 4;
            this.btnadminkullist.Text = "Admin Liste";
            this.btnadminkullist.UseVisualStyleBackColor = false;
            this.btnadminkullist.Click += new System.EventHandler(this.btnadminkullist_Click);
            // 
            // btnwhitekullist
            // 
            this.btnwhitekullist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnwhitekullist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnwhitekullist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwhitekullist.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnwhitekullist.Location = new System.Drawing.Point(0, 87);
            this.btnwhitekullist.Name = "btnwhitekullist";
            this.btnwhitekullist.Size = new System.Drawing.Size(171, 42);
            this.btnwhitekullist.TabIndex = 3;
            this.btnwhitekullist.Text = "Beyaz Liste";
            this.btnwhitekullist.UseVisualStyleBackColor = false;
            this.btnwhitekullist.Click += new System.EventHandler(this.btnwhitekullist_Click);
            // 
            // btnblackkullist
            // 
            this.btnblackkullist.BackColor = System.Drawing.Color.SpringGreen;
            this.btnblackkullist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnblackkullist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnblackkullist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnblackkullist.Location = new System.Drawing.Point(0, 42);
            this.btnblackkullist.Name = "btnblackkullist";
            this.btnblackkullist.Size = new System.Drawing.Size(171, 45);
            this.btnblackkullist.TabIndex = 2;
            this.btnblackkullist.Text = "Kara Liste";
            this.btnblackkullist.UseVisualStyleBackColor = false;
            this.btnblackkullist.Click += new System.EventHandler(this.btnblackkullist_Click);
            // 
            // btnallkullist
            // 
            this.btnallkullist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnallkullist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnallkullist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnallkullist.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnallkullist.Location = new System.Drawing.Point(0, 0);
            this.btnallkullist.Name = "btnallkullist";
            this.btnallkullist.Size = new System.Drawing.Size(171, 42);
            this.btnallkullist.TabIndex = 1;
            this.btnallkullist.Text = "Tüm Kullanıcılar";
            this.btnallkullist.UseVisualStyleBackColor = false;
            this.btnallkullist.Click += new System.EventHandler(this.btnallkullist_Click);
            // 
            // btnkulliste
            // 
            this.btnkulliste.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnkulliste.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnkulliste.Enabled = false;
            this.btnkulliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkulliste.Location = new System.Drawing.Point(0, 0);
            this.btnkulliste.Name = "btnkulliste";
            this.btnkulliste.Size = new System.Drawing.Size(171, 42);
            this.btnkulliste.TabIndex = 0;
            this.btnkulliste.Text = "Kullanıcı Listeleri";
            this.btnkulliste.UseVisualStyleBackColor = false;
            this.btnkulliste.Click += new System.EventHandler(this.btnkulliste_Click);
            // 
            // dataGridViewkullist
            // 
            this.dataGridViewkullist.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridViewkullist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewkullist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewkullist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewkullist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkullist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ad,
            this.sifre,
            this.eposta,
            this.silid});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewkullist.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewkullist.EnableHeadersVisualStyles = false;
            this.dataGridViewkullist.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewkullist.Name = "dataGridViewkullist";
            this.dataGridViewkullist.RowHeadersVisible = false;
            this.dataGridViewkullist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewkullist.Size = new System.Drawing.Size(449, 418);
            this.dataGridViewkullist.TabIndex = 3;
            this.dataGridViewkullist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewkullist_CellContentClick);
            this.dataGridViewkullist.Click += new System.EventHandler(this.dataGridViewkullist_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // ad
            // 
            this.ad.HeaderText = "ad";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            this.ad.Width = 146;
            // 
            // sifre
            // 
            this.sifre.HeaderText = "Şifre";
            this.sifre.Name = "sifre";
            this.sifre.ReadOnly = true;
            this.sifre.Width = 80;
            // 
            // eposta
            // 
            this.eposta.HeaderText = "Eposta";
            this.eposta.Name = "eposta";
            this.eposta.ReadOnly = true;
            this.eposta.Width = 183;
            // 
            // silid
            // 
            this.silid.HeaderText = "Sil_id";
            this.silid.Name = "silid";
            this.silid.ReadOnly = true;
            this.silid.Visible = false;
            // 
            // gbkullist
            // 
            this.gbkullist.Controls.Add(this.label1);
            this.gbkullist.Controls.Add(this.lbluyesayı);
            this.gbkullist.Controls.Add(this.dataGridViewkullist);
            this.gbkullist.Controls.Add(this.btnyetki);
            this.gbkullist.Controls.Add(this.btnban);
            this.gbkullist.Controls.Add(this.btbybkaldır);
            this.gbkullist.Location = new System.Drawing.Point(197, 86);
            this.gbkullist.Name = "gbkullist";
            this.gbkullist.Size = new System.Drawing.Size(683, 455);
            this.gbkullist.TabIndex = 5;
            this.gbkullist.TabStop = false;
            this.gbkullist.Text = "Kullanici Listeleri";
            // 
            // btnyetki
            // 
            this.btnyetki.BackColor = System.Drawing.Color.SpringGreen;
            this.btnyetki.Enabled = false;
            this.btnyetki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyetki.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnyetki.Location = new System.Drawing.Point(482, 227);
            this.btnyetki.Name = "btnyetki";
            this.btnyetki.Size = new System.Drawing.Size(171, 45);
            this.btnyetki.TabIndex = 10;
            this.btnyetki.Text = "Yetki Ver";
            this.btnyetki.UseVisualStyleBackColor = false;
            this.btnyetki.Click += new System.EventHandler(this.btnyetki_Click);
            // 
            // btnban
            // 
            this.btnban.BackColor = System.Drawing.Color.SpringGreen;
            this.btnban.Enabled = false;
            this.btnban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnban.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnban.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnban.Location = new System.Drawing.Point(482, 160);
            this.btnban.Name = "btnban";
            this.btnban.Size = new System.Drawing.Size(171, 45);
            this.btnban.TabIndex = 9;
            this.btnban.Text = "Ban";
            this.btnban.UseVisualStyleBackColor = false;
            this.btnban.Click += new System.EventHandler(this.btnban_Click);
            // 
            // btbybkaldır
            // 
            this.btbybkaldır.BackColor = System.Drawing.Color.SpringGreen;
            this.btbybkaldır.Enabled = false;
            this.btbybkaldır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbybkaldır.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btbybkaldır.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btbybkaldır.Location = new System.Drawing.Point(482, 95);
            this.btbybkaldır.Name = "btbybkaldır";
            this.btbybkaldır.Size = new System.Drawing.Size(171, 45);
            this.btbybkaldır.TabIndex = 8;
            this.btbybkaldır.Text = "Yetkilerini ve Ban Kaldır ";
            this.btbybkaldır.UseVisualStyleBackColor = false;
            this.btbybkaldır.Click += new System.EventHandler(this.btbybkaldır_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(807, 41);
            this.dateTimePicker1.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1880, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 25);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // gboxgeribildirim
            // 
            this.gboxgeribildirim.Controls.Add(this.btneski);
            this.gboxgeribildirim.Controls.Add(this.btnyeni);
            this.gboxgeribildirim.Controls.Add(this.btnhespsi);
            this.gboxgeribildirim.Controls.Add(this.txtmesaj);
            this.gboxgeribildirim.Controls.Add(this.lbltip);
            this.gboxgeribildirim.Controls.Add(this.dataGridViewgeribildirim);
            this.gboxgeribildirim.Controls.Add(this.btnoku);
            this.gboxgeribildirim.Location = new System.Drawing.Point(197, 86);
            this.gboxgeribildirim.Name = "gboxgeribildirim";
            this.gboxgeribildirim.Size = new System.Drawing.Size(683, 455);
            this.gboxgeribildirim.TabIndex = 11;
            this.gboxgeribildirim.TabStop = false;
            this.gboxgeribildirim.Text = "Geri Bildirim";
            this.gboxgeribildirim.Visible = false;
            // 
            // btneski
            // 
            this.btneski.BackColor = System.Drawing.Color.SpringGreen;
            this.btneski.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneski.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneski.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btneski.Location = new System.Drawing.Point(322, 21);
            this.btneski.Name = "btneski";
            this.btneski.Size = new System.Drawing.Size(133, 24);
            this.btneski.TabIndex = 15;
            this.btneski.Text = "Okunmuş";
            this.btneski.UseVisualStyleBackColor = false;
            this.btneski.Click += new System.EventHandler(this.btneski_Click);
            // 
            // btnyeni
            // 
            this.btnyeni.BackColor = System.Drawing.Color.SpringGreen;
            this.btnyeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyeni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnyeni.Location = new System.Drawing.Point(164, 21);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(133, 24);
            this.btnyeni.TabIndex = 15;
            this.btnyeni.Text = "Yeni";
            this.btnyeni.UseVisualStyleBackColor = false;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // btnhespsi
            // 
            this.btnhespsi.BackColor = System.Drawing.Color.SpringGreen;
            this.btnhespsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhespsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhespsi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnhespsi.Location = new System.Drawing.Point(6, 21);
            this.btnhespsi.Name = "btnhespsi";
            this.btnhespsi.Size = new System.Drawing.Size(133, 24);
            this.btnhespsi.TabIndex = 14;
            this.btnhespsi.Text = "Hepsi";
            this.btnhespsi.UseVisualStyleBackColor = false;
            this.btnhespsi.Click += new System.EventHandler(this.btnhespsi_Click);
            // 
            // txtmesaj
            // 
            this.txtmesaj.BackColor = System.Drawing.Color.PaleGreen;
            this.txtmesaj.Enabled = false;
            this.txtmesaj.Location = new System.Drawing.Point(20, 331);
            this.txtmesaj.MaxLength = 200;
            this.txtmesaj.Name = "txtmesaj";
            this.txtmesaj.Size = new System.Drawing.Size(327, 108);
            this.txtmesaj.TabIndex = 13;
            this.txtmesaj.Text = "";
            // 
            // lbltip
            // 
            this.lbltip.AutoSize = true;
            this.lbltip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltip.Location = new System.Drawing.Point(26, 310);
            this.lbltip.Name = "lbltip";
            this.lbltip.Size = new System.Drawing.Size(43, 18);
            this.lbltip.TabIndex = 12;
            this.lbltip.Text = "Konu";
            // 
            // dataGridViewgeribildirim
            // 
            this.dataGridViewgeribildirim.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridViewgeribildirim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewgeribildirim.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewgeribildirim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewgeribildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewgeribildirim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gid,
            this.tik,
            this.kullanicid,
            this.tip,
            this.mesaj});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewgeribildirim.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewgeribildirim.EnableHeadersVisualStyles = false;
            this.dataGridViewgeribildirim.Location = new System.Drawing.Point(6, 60);
            this.dataGridViewgeribildirim.Name = "dataGridViewgeribildirim";
            this.dataGridViewgeribildirim.RowHeadersVisible = false;
            this.dataGridViewgeribildirim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewgeribildirim.Size = new System.Drawing.Size(449, 221);
            this.dataGridViewgeribildirim.TabIndex = 3;
            // 
            // gid
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.gid.DefaultCellStyle = dataGridViewCellStyle14;
            this.gid.HeaderText = "id";
            this.gid.Name = "gid";
            this.gid.ReadOnly = true;
            this.gid.Width = 40;
            // 
            // tik
            // 
            this.tik.HeaderText = "✓/X";
            this.tik.Name = "tik";
            this.tik.ReadOnly = true;
            this.tik.Width = 40;
            // 
            // kullanicid
            // 
            this.kullanicid.HeaderText = "Gönderen";
            this.kullanicid.Name = "kullanicid";
            // 
            // tip
            // 
            this.tip.HeaderText = "Tip";
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.Width = 80;
            // 
            // mesaj
            // 
            this.mesaj.HeaderText = "mesaj";
            this.mesaj.Name = "mesaj";
            this.mesaj.ReadOnly = true;
            this.mesaj.Width = 189;
            // 
            // btnoku
            // 
            this.btnoku.BackColor = System.Drawing.Color.SpringGreen;
            this.btnoku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnoku.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnoku.Location = new System.Drawing.Point(482, 111);
            this.btnoku.Name = "btnoku";
            this.btnoku.Size = new System.Drawing.Size(171, 45);
            this.btnoku.TabIndex = 10;
            this.btnoku.Text = "Oku";
            this.btnoku.UseVisualStyleBackColor = false;
            this.btnoku.Click += new System.EventHandler(this.btnoku_Click);
            // 
            // tmrsaat
            // 
            this.tmrsaat.Interval = 1;
            this.tmrsaat.Tick += new System.EventHandler(this.tmrsaat_Tick);
            // 
            // pnlgerilist
            // 
            this.pnlgerilist.Controls.Add(this.btntoneri);
            this.pnlgerilist.Controls.Add(this.btnthata);
            this.pnlgerilist.Controls.Add(this.btntsikayet);
            this.pnlgerilist.Controls.Add(this.btnthepsi);
            this.pnlgerilist.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlgerilist.Location = new System.Drawing.Point(0, 258);
            this.pnlgerilist.Name = "pnlgerilist";
            this.pnlgerilist.Size = new System.Drawing.Size(171, 173);
            this.pnlgerilist.TabIndex = 18;
            this.pnlgerilist.Visible = false;
            // 
            // btntoneri
            // 
            this.btntoneri.BackColor = System.Drawing.Color.SpringGreen;
            this.btntoneri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntoneri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntoneri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btntoneri.Location = new System.Drawing.Point(0, 129);
            this.btntoneri.Name = "btntoneri";
            this.btntoneri.Size = new System.Drawing.Size(171, 42);
            this.btntoneri.TabIndex = 4;
            this.btntoneri.Text = "Öneri";
            this.btntoneri.UseVisualStyleBackColor = false;
            this.btntoneri.Click += new System.EventHandler(this.btntoneri_Click);
            // 
            // btnthata
            // 
            this.btnthata.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnthata.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnthata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthata.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnthata.Location = new System.Drawing.Point(0, 87);
            this.btnthata.Name = "btnthata";
            this.btnthata.Size = new System.Drawing.Size(171, 42);
            this.btnthata.TabIndex = 3;
            this.btnthata.Text = "Hata";
            this.btnthata.UseVisualStyleBackColor = false;
            this.btnthata.Click += new System.EventHandler(this.btnthata_Click);
            // 
            // btntsikayet
            // 
            this.btntsikayet.BackColor = System.Drawing.Color.SpringGreen;
            this.btntsikayet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntsikayet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntsikayet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btntsikayet.Location = new System.Drawing.Point(0, 42);
            this.btntsikayet.Name = "btntsikayet";
            this.btntsikayet.Size = new System.Drawing.Size(171, 45);
            this.btntsikayet.TabIndex = 2;
            this.btntsikayet.Text = "Şikayet";
            this.btntsikayet.UseVisualStyleBackColor = false;
            this.btntsikayet.Click += new System.EventHandler(this.btntsikayet_Click);
            // 
            // btnthepsi
            // 
            this.btnthepsi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnthepsi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnthepsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthepsi.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnthepsi.Location = new System.Drawing.Point(0, 0);
            this.btnthepsi.Name = "btnthepsi";
            this.btnthepsi.Size = new System.Drawing.Size(171, 42);
            this.btnthepsi.TabIndex = 1;
            this.btnthepsi.Text = "Hepsi";
            this.btnthepsi.UseVisualStyleBackColor = false;
            this.btnthepsi.Click += new System.EventHandler(this.btnthepsi_Click);
            // 
            // lbluyesayı
            // 
            this.lbluyesayı.AutoSize = true;
            this.lbluyesayı.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluyesayı.Location = new System.Drawing.Point(618, 44);
            this.lbluyesayı.Name = "lbluyesayı";
            this.lbluyesayı.Size = new System.Drawing.Size(17, 19);
            this.lbluyesayı.TabIndex = 11;
            this.lbluyesayı.Text = "0";
            this.lbluyesayı.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(592, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Üye Sayısı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmadminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.gboxgeribildirim);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbkullist);
            this.Controls.Add(this.pnlyanmenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmadminpanel";
            this.Text = "frmadminpanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlyanmenu.ResumeLayout(false);
            this.pnlyanmenu.PerformLayout();
            this.pnlkullaniciliste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkullist)).EndInit();
            this.gbkullist.ResumeLayout(false);
            this.gbkullist.PerformLayout();
            this.gboxgeribildirim.ResumeLayout(false);
            this.gboxgeribildirim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewgeribildirim)).EndInit();
            this.pnlgerilist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlyanmenu;
        private System.Windows.Forms.DataGridView dataGridViewkullist;
        private System.Windows.Forms.GroupBox gbkullist;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngeribildirm;
        private System.Windows.Forms.Panel pnlkullaniciliste;
        private System.Windows.Forms.Button btnwhitekullist;
        private System.Windows.Forms.Button btnblackkullist;
        private System.Windows.Forms.Button btnkulliste;
        private System.Windows.Forms.Button btnadminkullist;
        private System.Windows.Forms.Button btnallkullist;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btbybkaldır;
        private System.Windows.Forms.Button btnban;
        private System.Windows.Forms.Button btnyetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn silid;
        private System.Windows.Forms.GroupBox gboxgeribildirim;
        private System.Windows.Forms.RichTextBox txtmesaj;
        private System.Windows.Forms.Label lbltip;
        private System.Windows.Forms.DataGridView dataGridViewgeribildirim;
        private System.Windows.Forms.Button btnoku;
        private System.Windows.Forms.Button btneski;
        private System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.Button btnhespsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tik;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanicid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesaj;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Timer tmrsaat;
        private System.Windows.Forms.Panel pnlgerilist;
        private System.Windows.Forms.Button btntoneri;
        private System.Windows.Forms.Button btnthata;
        private System.Windows.Forms.Button btntsikayet;
        private System.Windows.Forms.Button btnthepsi;
        private System.Windows.Forms.Label lbluyesayı;
        private System.Windows.Forms.Label label1;
    }
}