namespace MyKnightOnlineAssistant
{
    partial class Form1
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
            this.gbxPus = new System.Windows.Forms.GroupBox();
            this.btnPus = new System.Windows.Forms.Button();
            this.tbxCoins = new System.Windows.Forms.TextBox();
            this.lblCoins = new System.Windows.Forms.Label();
            this.tbxPus = new System.Windows.Forms.TextBox();
            this.lblCalcPus = new System.Windows.Forms.Label();
            this.tbxGb = new System.Windows.Forms.TextBox();
            this.lblGb = new System.Windows.Forms.Label();
            this.tbx400npoint = new System.Windows.Forms.TextBox();
            this.lbl400npoint = new System.Windows.Forms.Label();
            this.gbxTax = new System.Windows.Forms.GroupBox();
            this.btnTax = new System.Windows.Forms.Button();
            this.tbxNetCoins = new System.Windows.Forms.TextBox();
            this.lblNetCoins = new System.Windows.Forms.Label();
            this.tbxTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.tbxSell = new System.Windows.Forms.TextBox();
            this.lblSellCoins = new System.Windows.Forms.Label();
            this.gbxExp = new System.Windows.Forms.GroupBox();
            this.btnExp = new System.Windows.Forms.Button();
            this.tbxTotalExp = new System.Windows.Forms.TextBox();
            this.lblTotalExp = new System.Windows.Forms.Label();
            this.tbxMob = new System.Windows.Forms.TextBox();
            this.lblMob = new System.Windows.Forms.Label();
            this.tbxExp = new System.Windows.Forms.TextBox();
            this.lblExp = new System.Windows.Forms.Label();
            this.cbxActivity = new System.Windows.Forms.ComboBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.gbxPus.SuspendLayout();
            this.gbxTax.SuspendLayout();
            this.gbxExp.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPus
            // 
            this.gbxPus.Controls.Add(this.btnPus);
            this.gbxPus.Controls.Add(this.tbxCoins);
            this.gbxPus.Controls.Add(this.lblCoins);
            this.gbxPus.Controls.Add(this.tbxPus);
            this.gbxPus.Controls.Add(this.lblCalcPus);
            this.gbxPus.Controls.Add(this.tbxGb);
            this.gbxPus.Controls.Add(this.lblGb);
            this.gbxPus.Controls.Add(this.tbx400npoint);
            this.gbxPus.Controls.Add(this.lbl400npoint);
            this.gbxPus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxPus.Location = new System.Drawing.Point(12, 12);
            this.gbxPus.Name = "gbxPus";
            this.gbxPus.Size = new System.Drawing.Size(318, 226);
            this.gbxPus.TabIndex = 0;
            this.gbxPus.TabStop = false;
            this.gbxPus.Text = "PUS HESAPLAYICI";
            // 
            // btnPus
            // 
            this.btnPus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPus.Location = new System.Drawing.Point(202, 182);
            this.btnPus.Name = "btnPus";
            this.btnPus.Size = new System.Drawing.Size(100, 33);
            this.btnPus.TabIndex = 334;
            this.btnPus.Text = "Hesapla";
            this.btnPus.UseVisualStyleBackColor = true;
            this.btnPus.Click += new System.EventHandler(this.btnPus_Click);
            // 
            // tbxCoins
            // 
            this.tbxCoins.Enabled = false;
            this.tbxCoins.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbxCoins.Location = new System.Drawing.Point(202, 150);
            this.tbxCoins.Name = "tbxCoins";
            this.tbxCoins.Size = new System.Drawing.Size(100, 29);
            this.tbxCoins.TabIndex = 333;
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCoins.Location = new System.Drawing.Point(14, 158);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(182, 15);
            this.lblCoins.TabIndex = 6;
            this.lblCoins.Text = "OYUNDAKİ COİNS KARŞILIĞI:";
            // 
            // tbxPus
            // 
            this.tbxPus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbxPus.Location = new System.Drawing.Point(202, 111);
            this.tbxPus.Name = "tbxPus";
            this.tbxPus.Size = new System.Drawing.Size(100, 29);
            this.tbxPus.TabIndex = 3;
            // 
            // lblCalcPus
            // 
            this.lblCalcPus.AutoSize = true;
            this.lblCalcPus.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalcPus.Location = new System.Drawing.Point(19, 117);
            this.lblCalcPus.Name = "lblCalcPus";
            this.lblCalcPus.Size = new System.Drawing.Size(177, 18);
            this.lblCalcPus.TabIndex = 4;
            this.lblCalcPus.Text = "HESAPLANACAK NPOİNT:";
            // 
            // tbxGb
            // 
            this.tbxGb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbxGb.Location = new System.Drawing.Point(202, 76);
            this.tbxGb.Name = "tbxGb";
            this.tbxGb.Size = new System.Drawing.Size(100, 29);
            this.tbxGb.TabIndex = 2;
            // 
            // lblGb
            // 
            this.lblGb.AutoSize = true;
            this.lblGb.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGb.Location = new System.Drawing.Point(38, 82);
            this.lblGb.Name = "lblGb";
            this.lblGb.Size = new System.Drawing.Size(158, 18);
            this.lblGb.TabIndex = 2;
            this.lblGb.Text = "GOLD BAR ALIŞ FİYATI:";
            // 
            // tbx400npoint
            // 
            this.tbx400npoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbx400npoint.Location = new System.Drawing.Point(202, 41);
            this.tbx400npoint.Name = "tbx400npoint";
            this.tbx400npoint.Size = new System.Drawing.Size(100, 29);
            this.tbx400npoint.TabIndex = 1;
            // 
            // lbl400npoint
            // 
            this.lbl400npoint.AutoSize = true;
            this.lbl400npoint.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl400npoint.Location = new System.Drawing.Point(18, 47);
            this.lbl400npoint.Name = "lbl400npoint";
            this.lbl400npoint.Size = new System.Drawing.Size(178, 18);
            this.lbl400npoint.TabIndex = 0;
            this.lbl400npoint.Text = "400 NPOİNT TL KARŞILIĞI:";
            // 
            // gbxTax
            // 
            this.gbxTax.Controls.Add(this.btnTax);
            this.gbxTax.Controls.Add(this.tbxNetCoins);
            this.gbxTax.Controls.Add(this.lblNetCoins);
            this.gbxTax.Controls.Add(this.tbxTax);
            this.gbxTax.Controls.Add(this.lblTax);
            this.gbxTax.Controls.Add(this.tbxSell);
            this.gbxTax.Controls.Add(this.lblSellCoins);
            this.gbxTax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxTax.Location = new System.Drawing.Point(12, 244);
            this.gbxTax.Name = "gbxTax";
            this.gbxTax.Size = new System.Drawing.Size(318, 198);
            this.gbxTax.TabIndex = 1;
            this.gbxTax.TabStop = false;
            this.gbxTax.Text = "PAZAR VERGİ HESAPLAYICI";
            // 
            // btnTax
            // 
            this.btnTax.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTax.Location = new System.Drawing.Point(202, 156);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(100, 33);
            this.btnTax.TabIndex = 335;
            this.btnTax.Text = "Hesapla";
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // tbxNetCoins
            // 
            this.tbxNetCoins.Enabled = false;
            this.tbxNetCoins.Location = new System.Drawing.Point(202, 121);
            this.tbxNetCoins.Name = "tbxNetCoins";
            this.tbxNetCoins.Size = new System.Drawing.Size(100, 29);
            this.tbxNetCoins.TabIndex = 5;
            // 
            // lblNetCoins
            // 
            this.lblNetCoins.AutoSize = true;
            this.lblNetCoins.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNetCoins.Location = new System.Drawing.Point(88, 125);
            this.lblNetCoins.Name = "lblNetCoins";
            this.lblNetCoins.Size = new System.Drawing.Size(108, 20);
            this.lblNetCoins.TabIndex = 4;
            this.lblNetCoins.Text = "NET KAZANÇ:";
            // 
            // tbxTax
            // 
            this.tbxTax.Enabled = false;
            this.tbxTax.Location = new System.Drawing.Point(202, 82);
            this.tbxTax.Name = "tbxTax";
            this.tbxTax.Size = new System.Drawing.Size(100, 29);
            this.tbxTax.TabIndex = 3;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTax.Location = new System.Drawing.Point(92, 86);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(104, 20);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "VERGİ TUTARI:";
            // 
            // tbxSell
            // 
            this.tbxSell.Location = new System.Drawing.Point(202, 44);
            this.tbxSell.Name = "tbxSell";
            this.tbxSell.Size = new System.Drawing.Size(100, 29);
            this.tbxSell.TabIndex = 1;
            // 
            // lblSellCoins
            // 
            this.lblSellCoins.AutoSize = true;
            this.lblSellCoins.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSellCoins.Location = new System.Drawing.Point(3, 48);
            this.lblSellCoins.Name = "lblSellCoins";
            this.lblSellCoins.Size = new System.Drawing.Size(193, 20);
            this.lblSellCoins.TabIndex = 0;
            this.lblSellCoins.Text = "SATMAK İSTEDİĞİNİZ FİYAT:";
            // 
            // gbxExp
            // 
            this.gbxExp.Controls.Add(this.btnExp);
            this.gbxExp.Controls.Add(this.tbxTotalExp);
            this.gbxExp.Controls.Add(this.lblTotalExp);
            this.gbxExp.Controls.Add(this.tbxMob);
            this.gbxExp.Controls.Add(this.lblMob);
            this.gbxExp.Controls.Add(this.tbxExp);
            this.gbxExp.Controls.Add(this.lblExp);
            this.gbxExp.Controls.Add(this.cbxActivity);
            this.gbxExp.Controls.Add(this.lblActivity);
            this.gbxExp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbxExp.Location = new System.Drawing.Point(12, 448);
            this.gbxExp.Name = "gbxExp";
            this.gbxExp.Size = new System.Drawing.Size(318, 240);
            this.gbxExp.TabIndex = 4;
            this.gbxExp.TabStop = false;
            this.gbxExp.Text = "EXP HESAPLAYICI";
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExp.Location = new System.Drawing.Point(202, 201);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(100, 33);
            this.btnExp.TabIndex = 336;
            this.btnExp.Text = "Hesapla";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // tbxTotalExp
            // 
            this.tbxTotalExp.Enabled = false;
            this.tbxTotalExp.Location = new System.Drawing.Point(202, 159);
            this.tbxTotalExp.Name = "tbxTotalExp";
            this.tbxTotalExp.Size = new System.Drawing.Size(100, 29);
            this.tbxTotalExp.TabIndex = 10;
            // 
            // lblTotalExp
            // 
            this.lblTotalExp.AutoSize = true;
            this.lblTotalExp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalExp.Location = new System.Drawing.Point(13, 162);
            this.lblTotalExp.Name = "lblTotalExp";
            this.lblTotalExp.Size = new System.Drawing.Size(175, 20);
            this.lblTotalExp.TabIndex = 9;
            this.lblTotalExp.Text = "24 SAATTE GELECEK EXP:";
            // 
            // tbxMob
            // 
            this.tbxMob.Location = new System.Drawing.Point(202, 118);
            this.tbxMob.Name = "tbxMob";
            this.tbxMob.Size = new System.Drawing.Size(100, 29);
            this.tbxMob.TabIndex = 8;
            // 
            // lblMob
            // 
            this.lblMob.AutoSize = true;
            this.lblMob.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMob.Location = new System.Drawing.Point(13, 122);
            this.lblMob.Name = "lblMob";
            this.lblMob.Size = new System.Drawing.Size(182, 20);
            this.lblMob.TabIndex = 7;
            this.lblMob.Text = "DAKİKADA KESİLEN MOB:";
            // 
            // tbxExp
            // 
            this.tbxExp.Location = new System.Drawing.Point(202, 77);
            this.tbxExp.Name = "tbxExp";
            this.tbxExp.Size = new System.Drawing.Size(100, 29);
            this.tbxExp.TabIndex = 6;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExp.Location = new System.Drawing.Point(13, 81);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(85, 20);
            this.lblExp.TabIndex = 5;
            this.lblExp.Text = "GELEN EXP:";
            // 
            // cbxActivity
            // 
            this.cbxActivity.FormattingEnabled = true;
            this.cbxActivity.Items.AddRange(new object[] {
            "EXP PARTY",
            "OTURMAK"});
            this.cbxActivity.Location = new System.Drawing.Point(181, 31);
            this.cbxActivity.Name = "cbxActivity";
            this.cbxActivity.Size = new System.Drawing.Size(121, 29);
            this.cbxActivity.TabIndex = 4;
            this.cbxActivity.SelectedIndexChanged += new System.EventHandler(this.cbxActivity_SelectedIndexChanged);
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblActivity.Location = new System.Drawing.Point(13, 35);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(72, 20);
            this.lblActivity.TabIndex = 3;
            this.lblActivity.Text = "AKTİVİTE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 700);
            this.Controls.Add(this.gbxExp);
            this.Controls.Add(this.gbxTax);
            this.Controls.Add(this.gbxPus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxPus.ResumeLayout(false);
            this.gbxPus.PerformLayout();
            this.gbxTax.ResumeLayout(false);
            this.gbxTax.PerformLayout();
            this.gbxExp.ResumeLayout(false);
            this.gbxExp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPus;
        private System.Windows.Forms.TextBox tbxCoins;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.TextBox tbxPus;
        private System.Windows.Forms.Label lblCalcPus;
        private System.Windows.Forms.TextBox tbxGb;
        private System.Windows.Forms.Label lblGb;
        private System.Windows.Forms.TextBox tbx400npoint;
        private System.Windows.Forms.Label lbl400npoint;
        private System.Windows.Forms.Button btnPus;
        private System.Windows.Forms.GroupBox gbxTax;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.TextBox tbxNetCoins;
        private System.Windows.Forms.Label lblNetCoins;
        private System.Windows.Forms.TextBox tbxTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox tbxSell;
        private System.Windows.Forms.Label lblSellCoins;
        private System.Windows.Forms.GroupBox gbxExp;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.TextBox tbxTotalExp;
        private System.Windows.Forms.Label lblTotalExp;
        private System.Windows.Forms.TextBox tbxMob;
        private System.Windows.Forms.Label lblMob;
        private System.Windows.Forms.TextBox tbxExp;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.ComboBox cbxActivity;
        private System.Windows.Forms.Label lblActivity;
    }
}

