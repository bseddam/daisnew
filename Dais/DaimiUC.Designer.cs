namespace Dais
{
    partial class DaimiUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlall = new System.Windows.Forms.Panel();
            this.pnlsag = new System.Windows.Forms.Panel();
            this.gcdaimi = new DevExpress.XtraGrid.GridControl();
            this.grvdaimi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnldaimisol = new System.Windows.Forms.Panel();
            this.cmbyasmen = new System.Windows.Forms.ComboBox();
            this.dtpvesetibartar = new System.Windows.Forms.DateTimePicker();
            this.dtpvesverilmetar = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbkohne = new System.Windows.Forms.RadioButton();
            this.rbyeni = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbqadin = new System.Windows.Forms.RadioButton();
            this.rbkisi = new System.Windows.Forms.RadioButton();
            this.lblcins = new System.Windows.Forms.Label();
            this.cmbqurumadi = new System.Windows.Forms.ComboBox();
            this.qurumadi = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtfinkod = new System.Windows.Forms.TextBox();
            this.txtmenzil = new System.Windows.Forms.TextBox();
            this.cmbsebeb = new System.Windows.Forms.ComboBox();
            this.lblsebeb = new System.Windows.Forms.Label();
            this.lblmenzil = new System.Windows.Forms.Label();
            this.cmbbinamertebe = new System.Windows.Forms.ComboBox();
            this.lblmertebe = new System.Windows.Forms.Label();
            this.txtgiris = new System.Windows.Forms.TextBox();
            this.lblgiris = new System.Windows.Forms.Label();
            this.cmbev = new System.Windows.Forms.ComboBox();
            this.btntesdiqdaimi = new System.Windows.Forms.Button();
            this.lbletibarliliq = new System.Windows.Forms.Label();
            this.lblverilmetarixi = new System.Windows.Forms.Label();
            this.cmbseriya = new System.Windows.Forms.ComboBox();
            this.lblseriya = new System.Windows.Forms.Label();
            this.lblvesiqenomresi = new System.Windows.Forms.Label();
            this.txtvesiqenomresi = new System.Windows.Forms.TextBox();
            this.lblpinkod = new System.Windows.Forms.Label();
            this.lblev = new System.Windows.Forms.Label();
            this.cmbprospkuce = new System.Windows.Forms.ComboBox();
            this.lblprospektkuce = new System.Windows.Forms.Label();
            this.cmbdogumili = new System.Windows.Forms.ComboBox();
            this.lbldogumili = new System.Windows.Forms.Label();
            this.cmbdogumay = new System.Windows.Forms.ComboBox();
            this.lbldogumayi = new System.Windows.Forms.Label();
            this.cmbdogumgunu = new System.Windows.Forms.ComboBox();
            this.lbldogumgunu = new System.Windows.Forms.Label();
            this.lblyasmen = new System.Windows.Forms.Label();
            this.cmbmenteqe = new System.Windows.Forms.ComboBox();
            this.lblmenteqe = new System.Windows.Forms.Label();
            this.lblataadi = new System.Windows.Forms.Label();
            this.txtataadi = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnyeni = new System.Windows.Forms.Button();
            this.btnduzelis = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.pnlall.SuspendLayout();
            this.pnlsag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdaimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdaimi)).BeginInit();
            this.pnldaimisol.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlall
            // 
            this.pnlall.Controls.Add(this.pnlsag);
            this.pnlall.Controls.Add(this.pnldaimisol);
            this.pnlall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlall.Location = new System.Drawing.Point(0, 0);
            this.pnlall.Name = "pnlall";
            this.pnlall.Size = new System.Drawing.Size(965, 504);
            this.pnlall.TabIndex = 0;
            // 
            // pnlsag
            // 
            this.pnlsag.Controls.Add(this.gcdaimi);
            this.pnlsag.Controls.Add(this.btnsil);
            this.pnlsag.Controls.Add(this.btnduzelis);
            this.pnlsag.Controls.Add(this.btnyeni);
            this.pnlsag.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlsag.Location = new System.Drawing.Point(548, 0);
            this.pnlsag.Name = "pnlsag";
            this.pnlsag.Size = new System.Drawing.Size(417, 504);
            this.pnlsag.TabIndex = 165;
            // 
            // gcdaimi
            // 
            this.gcdaimi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcdaimi.Location = new System.Drawing.Point(0, 31);
            this.gcdaimi.MainView = this.grvdaimi;
            this.gcdaimi.Name = "gcdaimi";
            this.gcdaimi.Size = new System.Drawing.Size(417, 473);
            this.gcdaimi.TabIndex = 170;
            this.gcdaimi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvdaimi,
            this.gridView1});
            this.gcdaimi.Click += new System.EventHandler(this.grvdaimi_Click);
            // 
            // grvdaimi
            // 
            this.grvdaimi.GridControl = this.gcdaimi;
            this.grvdaimi.Name = "grvdaimi";
            this.grvdaimi.OptionsBehavior.Editable = false;
            this.grvdaimi.OptionsView.ColumnAutoWidth = false;
            // 
            // pnldaimisol
            // 
            this.pnldaimisol.Controls.Add(this.cmbyasmen);
            this.pnldaimisol.Controls.Add(this.dtpvesetibartar);
            this.pnldaimisol.Controls.Add(this.dtpvesverilmetar);
            this.pnldaimisol.Controls.Add(this.panel3);
            this.pnldaimisol.Controls.Add(this.panel2);
            this.pnldaimisol.Controls.Add(this.cmbqurumadi);
            this.pnldaimisol.Controls.Add(this.qurumadi);
            this.pnldaimisol.Controls.Add(this.cmbstatus);
            this.pnldaimisol.Controls.Add(this.lblstatus);
            this.pnldaimisol.Controls.Add(this.txtfinkod);
            this.pnldaimisol.Controls.Add(this.txtmenzil);
            this.pnldaimisol.Controls.Add(this.cmbsebeb);
            this.pnldaimisol.Controls.Add(this.lblsebeb);
            this.pnldaimisol.Controls.Add(this.lblmenzil);
            this.pnldaimisol.Controls.Add(this.cmbbinamertebe);
            this.pnldaimisol.Controls.Add(this.lblmertebe);
            this.pnldaimisol.Controls.Add(this.txtgiris);
            this.pnldaimisol.Controls.Add(this.lblgiris);
            this.pnldaimisol.Controls.Add(this.cmbev);
            this.pnldaimisol.Controls.Add(this.btntesdiqdaimi);
            this.pnldaimisol.Controls.Add(this.lbletibarliliq);
            this.pnldaimisol.Controls.Add(this.lblverilmetarixi);
            this.pnldaimisol.Controls.Add(this.cmbseriya);
            this.pnldaimisol.Controls.Add(this.lblseriya);
            this.pnldaimisol.Controls.Add(this.lblvesiqenomresi);
            this.pnldaimisol.Controls.Add(this.txtvesiqenomresi);
            this.pnldaimisol.Controls.Add(this.lblpinkod);
            this.pnldaimisol.Controls.Add(this.lblev);
            this.pnldaimisol.Controls.Add(this.cmbprospkuce);
            this.pnldaimisol.Controls.Add(this.lblprospektkuce);
            this.pnldaimisol.Controls.Add(this.cmbdogumili);
            this.pnldaimisol.Controls.Add(this.lbldogumili);
            this.pnldaimisol.Controls.Add(this.cmbdogumay);
            this.pnldaimisol.Controls.Add(this.lbldogumayi);
            this.pnldaimisol.Controls.Add(this.cmbdogumgunu);
            this.pnldaimisol.Controls.Add(this.lbldogumgunu);
            this.pnldaimisol.Controls.Add(this.lblyasmen);
            this.pnldaimisol.Controls.Add(this.cmbmenteqe);
            this.pnldaimisol.Controls.Add(this.lblmenteqe);
            this.pnldaimisol.Controls.Add(this.lblataadi);
            this.pnldaimisol.Controls.Add(this.txtataadi);
            this.pnldaimisol.Controls.Add(this.lblad);
            this.pnldaimisol.Controls.Add(this.txtad);
            this.pnldaimisol.Controls.Add(this.lblsoyad);
            this.pnldaimisol.Controls.Add(this.txtsoyad);
            this.pnldaimisol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnldaimisol.Location = new System.Drawing.Point(0, 0);
            this.pnldaimisol.Name = "pnldaimisol";
            this.pnldaimisol.Size = new System.Drawing.Size(542, 504);
            this.pnldaimisol.TabIndex = 2;
            // 
            // cmbyasmen
            // 
            this.cmbyasmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbyasmen.FormattingEnabled = true;
            this.cmbyasmen.Location = new System.Drawing.Point(93, 23);
            this.cmbyasmen.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbyasmen.Name = "cmbyasmen";
            this.cmbyasmen.Size = new System.Drawing.Size(170, 21);
            this.cmbyasmen.TabIndex = 150;
            this.cmbyasmen.SelectedIndexChanged += new System.EventHandler(this.cmbyasmen_SelectedIndexChanged);
            // 
            // dtpvesetibartar
            // 
            this.dtpvesetibartar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpvesetibartar.Location = new System.Drawing.Point(275, 296);
            this.dtpvesetibartar.Name = "dtpvesetibartar";
            this.dtpvesetibartar.Size = new System.Drawing.Size(114, 20);
            this.dtpvesetibartar.TabIndex = 149;
            // 
            // dtpvesverilmetar
            // 
            this.dtpvesverilmetar.CustomFormat = "dd.MM.yyyy";
            this.dtpvesverilmetar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpvesverilmetar.Location = new System.Drawing.Point(137, 296);
            this.dtpvesverilmetar.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtpvesverilmetar.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.dtpvesverilmetar.Name = "dtpvesverilmetar";
            this.dtpvesverilmetar.Size = new System.Drawing.Size(125, 20);
            this.dtpvesverilmetar.TabIndex = 148;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbkohne);
            this.panel3.Controls.Add(this.rbyeni);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(136, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 49);
            this.panel3.TabIndex = 147;
            // 
            // rbkohne
            // 
            this.rbkohne.AutoSize = true;
            this.rbkohne.Location = new System.Drawing.Point(51, 22);
            this.rbkohne.Name = "rbkohne";
            this.rbkohne.Size = new System.Drawing.Size(56, 17);
            this.rbkohne.TabIndex = 94;
            this.rbkohne.Text = "Köhnə";
            this.rbkohne.UseVisualStyleBackColor = true;
            // 
            // rbyeni
            // 
            this.rbyeni.AutoSize = true;
            this.rbyeni.Location = new System.Drawing.Point(3, 22);
            this.rbyeni.Name = "rbyeni";
            this.rbyeni.Size = new System.Drawing.Size(46, 17);
            this.rbyeni.TabIndex = 93;
            this.rbyeni.Text = "Yeni";
            this.rbyeni.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "Passport növü:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbqadin);
            this.panel2.Controls.Add(this.rbkisi);
            this.panel2.Controls.Add(this.lblcins);
            this.panel2.Location = new System.Drawing.Point(408, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 49);
            this.panel2.TabIndex = 146;
            // 
            // rbqadin
            // 
            this.rbqadin.AutoSize = true;
            this.rbqadin.Location = new System.Drawing.Point(49, 28);
            this.rbqadin.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rbqadin.Name = "rbqadin";
            this.rbqadin.Size = new System.Drawing.Size(53, 17);
            this.rbqadin.TabIndex = 66;
            this.rbqadin.Text = "Qadın";
            this.rbqadin.UseVisualStyleBackColor = true;
            // 
            // rbkisi
            // 
            this.rbkisi.AutoSize = true;
            this.rbkisi.Location = new System.Drawing.Point(6, 28);
            this.rbkisi.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rbkisi.Name = "rbkisi";
            this.rbkisi.Size = new System.Drawing.Size(41, 17);
            this.rbkisi.TabIndex = 65;
            this.rbkisi.Text = "Kişi";
            this.rbkisi.UseVisualStyleBackColor = true;
            // 
            // lblcins
            // 
            this.lblcins.AutoSize = true;
            this.lblcins.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcins.Location = new System.Drawing.Point(6, 5);
            this.lblcins.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblcins.Name = "lblcins";
            this.lblcins.Size = new System.Drawing.Size(47, 17);
            this.lblcins.TabIndex = 64;
            this.lblcins.Text = "Cinsi:";
            // 
            // cmbqurumadi
            // 
            this.cmbqurumadi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbqurumadi.FormattingEnabled = true;
            this.cmbqurumadi.Location = new System.Drawing.Point(407, 296);
            this.cmbqurumadi.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbqurumadi.Name = "cmbqurumadi";
            this.cmbqurumadi.Size = new System.Drawing.Size(128, 21);
            this.cmbqurumadi.TabIndex = 145;
            // 
            // qurumadi
            // 
            this.qurumadi.AutoSize = true;
            this.qurumadi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qurumadi.Location = new System.Drawing.Point(405, 276);
            this.qurumadi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.qurumadi.Name = "qurumadi";
            this.qurumadi.Size = new System.Drawing.Size(98, 17);
            this.qurumadi.TabIndex = 144;
            this.qurumadi.Text = "Qurumun adı:";
            // 
            // cmbstatus
            // 
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Location = new System.Drawing.Point(10, 238);
            this.cmbstatus.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(112, 21);
            this.cmbstatus.TabIndex = 143;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(6, 219);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(61, 17);
            this.lblstatus.TabIndex = 142;
            this.lblstatus.Text = "Statusu:";
            // 
            // txtfinkod
            // 
            this.txtfinkod.Location = new System.Drawing.Point(10, 296);
            this.txtfinkod.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtfinkod.Name = "txtfinkod";
            this.txtfinkod.Size = new System.Drawing.Size(112, 20);
            this.txtfinkod.TabIndex = 141;
            // 
            // txtmenzil
            // 
            this.txtmenzil.Location = new System.Drawing.Point(408, 70);
            this.txtmenzil.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtmenzil.Name = "txtmenzil";
            this.txtmenzil.Size = new System.Drawing.Size(127, 20);
            this.txtmenzil.TabIndex = 139;
            // 
            // cmbsebeb
            // 
            this.cmbsebeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsebeb.FormattingEnabled = true;
            this.cmbsebeb.Location = new System.Drawing.Point(10, 178);
            this.cmbsebeb.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbsebeb.Name = "cmbsebeb";
            this.cmbsebeb.Size = new System.Drawing.Size(112, 21);
            this.cmbsebeb.TabIndex = 130;
            // 
            // lblsebeb
            // 
            this.lblsebeb.AutoSize = true;
            this.lblsebeb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsebeb.Location = new System.Drawing.Point(3, 158);
            this.lblsebeb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblsebeb.Name = "lblsebeb";
            this.lblsebeb.Size = new System.Drawing.Size(129, 17);
            this.lblsebeb.TabIndex = 129;
            this.lblsebeb.Text = "Daxil olma səbəbi:";
            // 
            // lblmenzil
            // 
            this.lblmenzil.AutoSize = true;
            this.lblmenzil.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenzil.Location = new System.Drawing.Point(404, 51);
            this.lblmenzil.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblmenzil.Name = "lblmenzil";
            this.lblmenzil.Size = new System.Drawing.Size(58, 17);
            this.lblmenzil.TabIndex = 128;
            this.lblmenzil.Text = "Mənzil:";
            // 
            // cmbbinamertebe
            // 
            this.cmbbinamertebe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbinamertebe.FormattingEnabled = true;
            this.cmbbinamertebe.Location = new System.Drawing.Point(275, 70);
            this.cmbbinamertebe.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbbinamertebe.Name = "cmbbinamertebe";
            this.cmbbinamertebe.Size = new System.Drawing.Size(113, 21);
            this.cmbbinamertebe.TabIndex = 127;
            // 
            // lblmertebe
            // 
            this.lblmertebe.AutoSize = true;
            this.lblmertebe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmertebe.Location = new System.Drawing.Point(275, 51);
            this.lblmertebe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblmertebe.Name = "lblmertebe";
            this.lblmertebe.Size = new System.Drawing.Size(71, 17);
            this.lblmertebe.TabIndex = 126;
            this.lblmertebe.Text = "Mərtəbə:";
            // 
            // txtgiris
            // 
            this.txtgiris.Location = new System.Drawing.Point(132, 70);
            this.txtgiris.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtgiris.Name = "txtgiris";
            this.txtgiris.Size = new System.Drawing.Size(130, 20);
            this.txtgiris.TabIndex = 125;
            // 
            // lblgiris
            // 
            this.lblgiris.AutoSize = true;
            this.lblgiris.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgiris.Location = new System.Drawing.Point(128, 51);
            this.lblgiris.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblgiris.Name = "lblgiris";
            this.lblgiris.Size = new System.Drawing.Size(45, 17);
            this.lblgiris.TabIndex = 124;
            this.lblgiris.Text = "Giriş:";
            // 
            // cmbev
            // 
            this.cmbev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbev.FormattingEnabled = true;
            this.cmbev.Location = new System.Drawing.Point(10, 70);
            this.cmbev.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbev.Name = "cmbev";
            this.cmbev.Size = new System.Drawing.Size(112, 21);
            this.cmbev.TabIndex = 123;
            // 
            // btntesdiqdaimi
            // 
            this.btntesdiqdaimi.Location = new System.Drawing.Point(10, 327);
            this.btntesdiqdaimi.Margin = new System.Windows.Forms.Padding(4);
            this.btntesdiqdaimi.Name = "btntesdiqdaimi";
            this.btntesdiqdaimi.Size = new System.Drawing.Size(106, 32);
            this.btntesdiqdaimi.TabIndex = 138;
            this.btntesdiqdaimi.Text = "Təsdiq et";
            this.btntesdiqdaimi.UseVisualStyleBackColor = true;
            this.btntesdiqdaimi.Click += new System.EventHandler(this.btntesdiqdaimi_Click);
            // 
            // lbletibarliliq
            // 
            this.lbletibarliliq.AutoSize = true;
            this.lbletibarliliq.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbletibarliliq.Location = new System.Drawing.Point(275, 276);
            this.lbletibarliliq.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbletibarliliq.Name = "lbletibarliliq";
            this.lbletibarliliq.Size = new System.Drawing.Size(115, 17);
            this.lbletibarliliq.TabIndex = 137;
            this.lbletibarliliq.Text = "Etibarlılıq tarixi:";
            // 
            // lblverilmetarixi
            // 
            this.lblverilmetarixi.AutoSize = true;
            this.lblverilmetarixi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblverilmetarixi.Location = new System.Drawing.Point(134, 276);
            this.lblverilmetarixi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblverilmetarixi.Name = "lblverilmetarixi";
            this.lblverilmetarixi.Size = new System.Drawing.Size(102, 17);
            this.lblverilmetarixi.TabIndex = 136;
            this.lblverilmetarixi.Text = "Verilmə tarixi:";
            // 
            // cmbseriya
            // 
            this.cmbseriya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbseriya.FormattingEnabled = true;
            this.cmbseriya.Location = new System.Drawing.Point(275, 238);
            this.cmbseriya.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbseriya.Name = "cmbseriya";
            this.cmbseriya.Size = new System.Drawing.Size(116, 21);
            this.cmbseriya.TabIndex = 135;
            // 
            // lblseriya
            // 
            this.lblseriya.AutoSize = true;
            this.lblseriya.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseriya.Location = new System.Drawing.Point(275, 219);
            this.lblseriya.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblseriya.Name = "lblseriya";
            this.lblseriya.Size = new System.Drawing.Size(112, 17);
            this.lblseriya.TabIndex = 134;
            this.lblseriya.Text = "Vəsiqə seriyası:";
            // 
            // lblvesiqenomresi
            // 
            this.lblvesiqenomresi.AutoSize = true;
            this.lblvesiqenomresi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvesiqenomresi.Location = new System.Drawing.Point(405, 219);
            this.lblvesiqenomresi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblvesiqenomresi.Name = "lblvesiqenomresi";
            this.lblvesiqenomresi.Size = new System.Drawing.Size(69, 17);
            this.lblvesiqenomresi.TabIndex = 133;
            this.lblvesiqenomresi.Text = "Nömrəsi:";
            // 
            // txtvesiqenomresi
            // 
            this.txtvesiqenomresi.Location = new System.Drawing.Point(407, 240);
            this.txtvesiqenomresi.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtvesiqenomresi.Name = "txtvesiqenomresi";
            this.txtvesiqenomresi.Size = new System.Drawing.Size(128, 20);
            this.txtvesiqenomresi.TabIndex = 132;
            // 
            // lblpinkod
            // 
            this.lblpinkod.AutoSize = true;
            this.lblpinkod.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpinkod.Location = new System.Drawing.Point(6, 276);
            this.lblpinkod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblpinkod.Name = "lblpinkod";
            this.lblpinkod.Size = new System.Drawing.Size(71, 17);
            this.lblpinkod.TabIndex = 131;
            this.lblpinkod.Text = "Fin kodu:";
            // 
            // lblev
            // 
            this.lblev.AutoSize = true;
            this.lblev.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblev.Location = new System.Drawing.Point(6, 51);
            this.lblev.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblev.Name = "lblev";
            this.lblev.Size = new System.Drawing.Size(31, 17);
            this.lblev.TabIndex = 122;
            this.lblev.Text = "Ev:";
            // 
            // cmbprospkuce
            // 
            this.cmbprospkuce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprospkuce.FormattingEnabled = true;
            this.cmbprospkuce.Location = new System.Drawing.Point(276, 23);
            this.cmbprospkuce.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbprospkuce.Name = "cmbprospkuce";
            this.cmbprospkuce.Size = new System.Drawing.Size(259, 21);
            this.cmbprospkuce.TabIndex = 121;
            this.cmbprospkuce.SelectedIndexChanged += new System.EventHandler(this.cmbprospkuce_SelectedIndexChanged);
            // 
            // lblprospektkuce
            // 
            this.lblprospektkuce.AutoSize = true;
            this.lblprospektkuce.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprospektkuce.Location = new System.Drawing.Point(272, 4);
            this.lblprospektkuce.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblprospektkuce.Name = "lblprospektkuce";
            this.lblprospektkuce.Size = new System.Drawing.Size(116, 17);
            this.lblprospektkuce.TabIndex = 120;
            this.lblprospektkuce.Text = "Prospekt, Küçə:";
            // 
            // cmbdogumili
            // 
            this.cmbdogumili.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdogumili.FormattingEnabled = true;
            this.cmbdogumili.Location = new System.Drawing.Point(136, 178);
            this.cmbdogumili.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbdogumili.Name = "cmbdogumili";
            this.cmbdogumili.Size = new System.Drawing.Size(127, 21);
            this.cmbdogumili.TabIndex = 119;
            // 
            // lbldogumili
            // 
            this.lbldogumili.AutoSize = true;
            this.lbldogumili.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldogumili.Location = new System.Drawing.Point(136, 158);
            this.lbldogumili.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbldogumili.Name = "lbldogumili";
            this.lbldogumili.Size = new System.Drawing.Size(76, 17);
            this.lbldogumili.TabIndex = 118;
            this.lbldogumili.Text = "Doğum ili:";
            // 
            // cmbdogumay
            // 
            this.cmbdogumay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdogumay.FormattingEnabled = true;
            this.cmbdogumay.Location = new System.Drawing.Point(275, 178);
            this.cmbdogumay.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbdogumay.Name = "cmbdogumay";
            this.cmbdogumay.Size = new System.Drawing.Size(116, 21);
            this.cmbdogumay.TabIndex = 117;
            // 
            // lbldogumayi
            // 
            this.lbldogumayi.AutoSize = true;
            this.lbldogumayi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldogumayi.Location = new System.Drawing.Point(275, 158);
            this.lbldogumayi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbldogumayi.Name = "lbldogumayi";
            this.lbldogumayi.Size = new System.Drawing.Size(32, 19);
            this.lbldogumayi.TabIndex = 116;
            this.lbldogumayi.Text = "Ay:";
            // 
            // cmbdogumgunu
            // 
            this.cmbdogumgunu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdogumgunu.FormattingEnabled = true;
            this.cmbdogumgunu.Location = new System.Drawing.Point(408, 178);
            this.cmbdogumgunu.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbdogumgunu.Name = "cmbdogumgunu";
            this.cmbdogumgunu.Size = new System.Drawing.Size(127, 21);
            this.cmbdogumgunu.TabIndex = 115;
            // 
            // lbldogumgunu
            // 
            this.lbldogumgunu.AutoSize = true;
            this.lbldogumgunu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldogumgunu.Location = new System.Drawing.Point(405, 160);
            this.lbldogumgunu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbldogumgunu.Name = "lbldogumgunu";
            this.lbldogumgunu.Size = new System.Drawing.Size(48, 17);
            this.lbldogumgunu.TabIndex = 114;
            this.lbldogumgunu.Text = "Günü:";
            // 
            // lblyasmen
            // 
            this.lblyasmen.AutoSize = true;
            this.lblyasmen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyasmen.Location = new System.Drawing.Point(90, 4);
            this.lblyasmen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblyasmen.Name = "lblyasmen";
            this.lblyasmen.Size = new System.Drawing.Size(132, 17);
            this.lblyasmen.TabIndex = 113;
            this.lblyasmen.Text = "Yaşayış məntəqəsi:";
            // 
            // cmbmenteqe
            // 
            this.cmbmenteqe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmenteqe.FormattingEnabled = true;
            this.cmbmenteqe.Location = new System.Drawing.Point(10, 23);
            this.cmbmenteqe.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbmenteqe.Name = "cmbmenteqe";
            this.cmbmenteqe.Size = new System.Drawing.Size(63, 21);
            this.cmbmenteqe.TabIndex = 112;
            this.cmbmenteqe.SelectedIndexChanged += new System.EventHandler(this.cmbmenteqe_SelectedIndexChanged);
            // 
            // lblmenteqe
            // 
            this.lblmenteqe.AutoSize = true;
            this.lblmenteqe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenteqe.Location = new System.Drawing.Point(6, 4);
            this.lblmenteqe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblmenteqe.Name = "lblmenteqe";
            this.lblmenteqe.Size = new System.Drawing.Size(73, 17);
            this.lblmenteqe.TabIndex = 111;
            this.lblmenteqe.Text = "Məntəqə:";
            // 
            // lblataadi
            // 
            this.lblataadi.AutoSize = true;
            this.lblataadi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblataadi.Location = new System.Drawing.Point(275, 104);
            this.lblataadi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblataadi.Name = "lblataadi";
            this.lblataadi.Size = new System.Drawing.Size(59, 17);
            this.lblataadi.TabIndex = 110;
            this.lblataadi.Text = "Ata adı:";
            // 
            // txtataadi
            // 
            this.txtataadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtataadi.Location = new System.Drawing.Point(275, 124);
            this.txtataadi.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtataadi.Name = "txtataadi";
            this.txtataadi.Size = new System.Drawing.Size(116, 20);
            this.txtataadi.TabIndex = 109;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblad.Location = new System.Drawing.Point(132, 104);
            this.lblad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(32, 17);
            this.lblad.TabIndex = 108;
            this.lblad.Text = "Ad:";
            // 
            // txtad
            // 
            this.txtad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtad.Location = new System.Drawing.Point(136, 124);
            this.txtad.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(127, 20);
            this.txtad.TabIndex = 107;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoyad.Location = new System.Drawing.Point(6, 104);
            this.lblsoyad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(51, 17);
            this.lblsoyad.TabIndex = 106;
            this.lblsoyad.Text = "Soyad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsoyad.Location = new System.Drawing.Point(10, 124);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(112, 20);
            this.txtsoyad.TabIndex = 105;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcdaimi;
            this.gridView1.Name = "gridView1";
            // 
            // btnyeni
            // 
            this.btnyeni.Location = new System.Drawing.Point(4, 2);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(120, 23);
            this.btnyeni.TabIndex = 165;
            this.btnyeni.Text = "Yeni";
            this.btnyeni.UseVisualStyleBackColor = true;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // btnduzelis
            // 
            this.btnduzelis.Location = new System.Drawing.Point(150, 2);
            this.btnduzelis.Name = "btnduzelis";
            this.btnduzelis.Size = new System.Drawing.Size(120, 23);
            this.btnduzelis.TabIndex = 166;
            this.btnduzelis.Text = "Düzəliş";
            this.btnduzelis.UseVisualStyleBackColor = true;
            this.btnduzelis.Click += new System.EventHandler(this.btnduzelis_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(300, 1);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(99, 23);
            this.btnsil.TabIndex = 167;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // DaimiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlall);
            this.Name = "DaimiUC";
            this.Size = new System.Drawing.Size(965, 504);
            this.Load += new System.EventHandler(this.DaimiUC_Load_1);
            this.pnlall.ResumeLayout(false);
            this.pnlsag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcdaimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdaimi)).EndInit();
            this.pnldaimisol.ResumeLayout(false);
            this.pnldaimisol.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlall;
        private System.Windows.Forms.Panel pnldaimisol;
        private System.Windows.Forms.ComboBox cmbyasmen;
        private System.Windows.Forms.DateTimePicker dtpvesetibartar;
        private System.Windows.Forms.DateTimePicker dtpvesverilmetar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbkohne;
        private System.Windows.Forms.RadioButton rbyeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbqadin;
        private System.Windows.Forms.RadioButton rbkisi;
        private System.Windows.Forms.Label lblcins;
        private System.Windows.Forms.ComboBox cmbqurumadi;
        private System.Windows.Forms.Label qurumadi;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TextBox txtfinkod;
        private System.Windows.Forms.TextBox txtmenzil;
        private System.Windows.Forms.ComboBox cmbsebeb;
        private System.Windows.Forms.Label lblsebeb;
        private System.Windows.Forms.Label lblmenzil;
        private System.Windows.Forms.ComboBox cmbbinamertebe;
        private System.Windows.Forms.Label lblmertebe;
        private System.Windows.Forms.TextBox txtgiris;
        private System.Windows.Forms.Label lblgiris;
        private System.Windows.Forms.ComboBox cmbev;
        private System.Windows.Forms.Button btntesdiqdaimi;
        private System.Windows.Forms.Label lbletibarliliq;
        private System.Windows.Forms.Label lblverilmetarixi;
        private System.Windows.Forms.ComboBox cmbseriya;
        private System.Windows.Forms.Label lblseriya;
        private System.Windows.Forms.Label lblvesiqenomresi;
        private System.Windows.Forms.TextBox txtvesiqenomresi;
        private System.Windows.Forms.Label lblpinkod;
        private System.Windows.Forms.Label lblev;
        private System.Windows.Forms.ComboBox cmbprospkuce;
        private System.Windows.Forms.Label lblprospektkuce;
        private System.Windows.Forms.ComboBox cmbdogumili;
        private System.Windows.Forms.Label lbldogumili;
        private System.Windows.Forms.ComboBox cmbdogumay;
        private System.Windows.Forms.Label lbldogumayi;
        private System.Windows.Forms.ComboBox cmbdogumgunu;
        private System.Windows.Forms.Label lbldogumgunu;
        private System.Windows.Forms.Label lblyasmen;
        private System.Windows.Forms.ComboBox cmbmenteqe;
        private System.Windows.Forms.Label lblmenteqe;
        private System.Windows.Forms.Label lblataadi;
        private System.Windows.Forms.TextBox txtataadi;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Panel pnlsag;
        private DevExpress.XtraGrid.GridControl gcdaimi;
        private DevExpress.XtraGrid.Views.Grid.GridView grvdaimi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnduzelis;
        private System.Windows.Forms.Button btnyeni;
    }
}
