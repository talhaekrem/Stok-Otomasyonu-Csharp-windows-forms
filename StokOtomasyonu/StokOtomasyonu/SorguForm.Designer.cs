namespace StokOtomasyonu
{
    partial class SorguForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorguForm));
            this.markaRadio = new System.Windows.Forms.RadioButton();
            this.adRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.sorgutxt = new System.Windows.Forms.TextBox();
            this.sorguyapBtn = new System.Windows.Forms.Button();
            this.sorgugrid = new System.Windows.Forms.DataGridView();
            this.btnResimleri = new System.Windows.Forms.ImageList(this.components);
            this.btnYrdmHoverTT = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sorgugrid)).BeginInit();
            this.SuspendLayout();
            // 
            // markaRadio
            // 
            this.markaRadio.AutoSize = true;
            this.markaRadio.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaRadio.Location = new System.Drawing.Point(72, 28);
            this.markaRadio.Name = "markaRadio";
            this.markaRadio.Size = new System.Drawing.Size(150, 20);
            this.markaRadio.TabIndex = 0;
            this.markaRadio.TabStop = true;
            this.markaRadio.Text = "Ürün Markasına Göre";
            this.markaRadio.UseVisualStyleBackColor = true;
            // 
            // adRadio
            // 
            this.adRadio.AutoSize = true;
            this.adRadio.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adRadio.Location = new System.Drawing.Point(316, 28);
            this.adRadio.Name = "adRadio";
            this.adRadio.Size = new System.Drawing.Size(121, 20);
            this.adRadio.TabIndex = 1;
            this.adRadio.TabStop = true;
            this.adRadio.Text = "Ürün Adına Göre";
            this.adRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seçiminize Göre Sorgulamak İstediğiniz Değeri Girin:";
            // 
            // sorgutxt
            // 
            this.sorgutxt.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorgutxt.Location = new System.Drawing.Point(342, 76);
            this.sorgutxt.Name = "sorgutxt";
            this.sorgutxt.Size = new System.Drawing.Size(158, 23);
            this.sorgutxt.TabIndex = 4;
            // 
            // sorguyapBtn
            // 
            this.sorguyapBtn.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorguyapBtn.Location = new System.Drawing.Point(412, 118);
            this.sorguyapBtn.Name = "sorguyapBtn";
            this.sorguyapBtn.Size = new System.Drawing.Size(88, 37);
            this.sorguyapBtn.TabIndex = 5;
            this.sorguyapBtn.Text = "SORGULA";
            this.sorguyapBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYrdmHoverTT.SetToolTip(this.sorguyapBtn, "Ürün stok durumunu sorgulamak için tıklayınız.\r\nSeçili kritere göre ürün sorgulam" +
        "ası yapılır.\r\nKritere uyan ürünlerin ID, marka, ad, adet bilgileri\r\nekrana liste" +
        "lenir.");
            this.sorguyapBtn.UseVisualStyleBackColor = true;
            this.sorguyapBtn.Click += new System.EventHandler(this.sorguyapBtn_Click);
            // 
            // sorgugrid
            // 
            this.sorgugrid.AllowUserToAddRows = false;
            this.sorgugrid.AllowUserToDeleteRows = false;
            this.sorgugrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sorgugrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sorgugrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sorgugrid.Location = new System.Drawing.Point(12, 176);
            this.sorgugrid.Name = "sorgugrid";
            this.sorgugrid.ReadOnly = true;
            this.sorgugrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sorgugrid.Size = new System.Drawing.Size(488, 146);
            this.sorgugrid.TabIndex = 6;
            // 
            // btnResimleri
            // 
            this.btnResimleri.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnResimleri.ImageStream")));
            this.btnResimleri.TransparentColor = System.Drawing.Color.Transparent;
            this.btnResimleri.Images.SetKeyName(0, "yesiltikimage.png");
            this.btnResimleri.Images.SetKeyName(1, "kırmızıX.png");
            this.btnResimleri.Images.SetKeyName(2, "updateimg.png");
            this.btnResimleri.Images.SetKeyName(3, "search.png");
            // 
            // SorguForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::StokOtomasyonu.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(512, 334);
            this.Controls.Add(this.sorgugrid);
            this.Controls.Add(this.sorguyapBtn);
            this.Controls.Add(this.sorgutxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adRadio);
            this.Controls.Add(this.markaRadio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SorguForm";
            this.Text = "Ürün Sorgula";
            this.Load += new System.EventHandler(this.SorguForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sorgugrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton markaRadio;
        private System.Windows.Forms.RadioButton adRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sorgutxt;
        private System.Windows.Forms.Button sorguyapBtn;
        private System.Windows.Forms.DataGridView sorgugrid;
        private System.Windows.Forms.ImageList btnResimleri;
        private System.Windows.Forms.ToolTip btnYrdmHoverTT;
    }
}