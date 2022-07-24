namespace StokOtomasyonu
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.veriGorunum = new System.Windows.Forms.DataGridView();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.btnResimleri = new System.Windows.Forms.ImageList(this.components);
            this.silBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.tarihLabel = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Timer(this.components);
            this.saatlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UrunMarkatxt = new System.Windows.Forms.TextBox();
            this.UrunAdtxt = new System.Windows.Forms.TextBox();
            this.UrunKategoricombo = new System.Windows.Forms.ComboBox();
            this.SKTdatepicker = new System.Windows.Forms.DateTimePicker();
            this.Adetnumeric = new System.Windows.Forms.NumericUpDown();
            this.Fiyattxt = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.ToolTip(this.components);
            this.sorguBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.veriGorunum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adetnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // veriGorunum
            // 
            this.veriGorunum.AllowUserToAddRows = false;
            this.veriGorunum.AllowUserToDeleteRows = false;
            this.veriGorunum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.veriGorunum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.veriGorunum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.veriGorunum, "veriGorunum");
            this.veriGorunum.MultiSelect = false;
            this.veriGorunum.Name = "veriGorunum";
            this.veriGorunum.ReadOnly = true;
            this.veriGorunum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.veriGorunum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.veriGorunum_CellClick);
            // 
            // ekleBtn
            // 
            resources.ApplyResources(this.ekleBtn, "ekleBtn");
            this.ekleBtn.ImageList = this.btnResimleri;
            this.ekleBtn.Name = "ekleBtn";
            this.aciklama.SetToolTip(this.ekleBtn, resources.GetString("ekleBtn.ToolTip"));
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // btnResimleri
            // 
            this.btnResimleri.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnResimleri.ImageStream")));
            this.btnResimleri.TransparentColor = System.Drawing.Color.Transparent;
            this.btnResimleri.Images.SetKeyName(0, "yesilArti.png");
            this.btnResimleri.Images.SetKeyName(1, "kırmızıX.png");
            this.btnResimleri.Images.SetKeyName(2, "updateimg.png");
            this.btnResimleri.Images.SetKeyName(3, "search.png");
            // 
            // silBtn
            // 
            resources.ApplyResources(this.silBtn, "silBtn");
            this.silBtn.ImageList = this.btnResimleri;
            this.silBtn.Name = "silBtn";
            this.aciklama.SetToolTip(this.silBtn, resources.GetString("silBtn.ToolTip"));
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // guncelleBtn
            // 
            resources.ApplyResources(this.guncelleBtn, "guncelleBtn");
            this.guncelleBtn.ImageList = this.btnResimleri;
            this.guncelleBtn.Name = "guncelleBtn";
            this.aciklama.SetToolTip(this.guncelleBtn, resources.GetString("guncelleBtn.ToolTip"));
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // IDtxt
            // 
            resources.ApplyResources(this.IDtxt, "IDtxt");
            this.IDtxt.Name = "IDtxt";
            this.aciklama.SetToolTip(this.IDtxt, resources.GetString("IDtxt.ToolTip"));
            // 
            // tarihLabel
            // 
            resources.ApplyResources(this.tarihLabel, "tarihLabel");
            this.tarihLabel.Name = "tarihLabel";
            // 
            // saat
            // 
            this.saat.Interval = 1000;
            this.saat.Tick += new System.EventHandler(this.saat_Tick);
            // 
            // saatlbl
            // 
            resources.ApplyResources(this.saatlbl, "saatlbl");
            this.saatlbl.Name = "saatlbl";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // UrunMarkatxt
            // 
            resources.ApplyResources(this.UrunMarkatxt, "UrunMarkatxt");
            this.UrunMarkatxt.Name = "UrunMarkatxt";
            this.aciklama.SetToolTip(this.UrunMarkatxt, resources.GetString("UrunMarkatxt.ToolTip"));
            // 
            // UrunAdtxt
            // 
            resources.ApplyResources(this.UrunAdtxt, "UrunAdtxt");
            this.UrunAdtxt.Name = "UrunAdtxt";
            this.aciklama.SetToolTip(this.UrunAdtxt, resources.GetString("UrunAdtxt.ToolTip"));
            // 
            // UrunKategoricombo
            // 
            resources.ApplyResources(this.UrunKategoricombo, "UrunKategoricombo");
            this.UrunKategoricombo.FormattingEnabled = true;
            this.UrunKategoricombo.Items.AddRange(new object[] {
            resources.GetString("UrunKategoricombo.Items"),
            resources.GetString("UrunKategoricombo.Items1"),
            resources.GetString("UrunKategoricombo.Items2"),
            resources.GetString("UrunKategoricombo.Items3"),
            resources.GetString("UrunKategoricombo.Items4"),
            resources.GetString("UrunKategoricombo.Items5"),
            resources.GetString("UrunKategoricombo.Items6"),
            resources.GetString("UrunKategoricombo.Items7"),
            resources.GetString("UrunKategoricombo.Items8"),
            resources.GetString("UrunKategoricombo.Items9"),
            resources.GetString("UrunKategoricombo.Items10"),
            resources.GetString("UrunKategoricombo.Items11"),
            resources.GetString("UrunKategoricombo.Items12"),
            resources.GetString("UrunKategoricombo.Items13"),
            resources.GetString("UrunKategoricombo.Items14"),
            resources.GetString("UrunKategoricombo.Items15"),
            resources.GetString("UrunKategoricombo.Items16"),
            resources.GetString("UrunKategoricombo.Items17")});
            this.UrunKategoricombo.Name = "UrunKategoricombo";
            this.aciklama.SetToolTip(this.UrunKategoricombo, resources.GetString("UrunKategoricombo.ToolTip"));
            // 
            // SKTdatepicker
            // 
            resources.ApplyResources(this.SKTdatepicker, "SKTdatepicker");
            this.SKTdatepicker.Name = "SKTdatepicker";
            this.aciklama.SetToolTip(this.SKTdatepicker, resources.GetString("SKTdatepicker.ToolTip"));
            this.SKTdatepicker.Value = new System.DateTime(2020, 9, 13, 0, 0, 0, 0);
            // 
            // Adetnumeric
            // 
            resources.ApplyResources(this.Adetnumeric, "Adetnumeric");
            this.Adetnumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Adetnumeric.Name = "Adetnumeric";
            this.aciklama.SetToolTip(this.Adetnumeric, resources.GetString("Adetnumeric.ToolTip"));
            this.Adetnumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Fiyattxt
            // 
            resources.ApplyResources(this.Fiyattxt, "Fiyattxt");
            this.Fiyattxt.Name = "Fiyattxt";
            this.aciklama.SetToolTip(this.Fiyattxt, resources.GetString("Fiyattxt.ToolTip"));
            // 
            // aciklama
            // 
            this.aciklama.AutomaticDelay = 100;
            // 
            // sorguBtn
            // 
            resources.ApplyResources(this.sorguBtn, "sorguBtn");
            this.sorguBtn.ImageList = this.btnResimleri;
            this.sorguBtn.Name = "sorguBtn";
            this.aciklama.SetToolTip(this.sorguBtn, resources.GetString("sorguBtn.ToolTip"));
            this.sorguBtn.UseVisualStyleBackColor = true;
            this.sorguBtn.Click += new System.EventHandler(this.sorguBtn_Click);
            // 
            // AnaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::StokOtomasyonu.Properties.Resources.background;
            this.Controls.Add(this.sorguBtn);
            this.Controls.Add(this.Fiyattxt);
            this.Controls.Add(this.Adetnumeric);
            this.Controls.Add(this.SKTdatepicker);
            this.Controls.Add(this.UrunKategoricombo);
            this.Controls.Add(this.UrunAdtxt);
            this.Controls.Add(this.UrunMarkatxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saatlbl);
            this.Controls.Add(this.tarihLabel);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.veriGorunum);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AnaForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.AnaForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.veriGorunum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adetnumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView veriGorunum;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label tarihLabel;
        private System.Windows.Forms.Timer saat;
        private System.Windows.Forms.Label saatlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UrunMarkatxt;
        private System.Windows.Forms.TextBox UrunAdtxt;
        private System.Windows.Forms.ComboBox UrunKategoricombo;
        private System.Windows.Forms.DateTimePicker SKTdatepicker;
        private System.Windows.Forms.NumericUpDown Adetnumeric;
        private System.Windows.Forms.TextBox Fiyattxt;
        private System.Windows.Forms.ToolTip aciklama;
        private System.Windows.Forms.Button sorguBtn;
        private System.Windows.Forms.ImageList btnResimleri;

    }
}

