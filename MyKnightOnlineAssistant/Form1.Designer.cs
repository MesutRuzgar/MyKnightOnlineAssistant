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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTax = new System.Windows.Forms.Button();
            this.tbxNetCoins = new System.Windows.Forms.TextBox();
            this.lblNetCoins = new System.Windows.Forms.Label();
            this.tbxTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.tbxSell = new System.Windows.Forms.TextBox();
            this.lblSellCoins = new System.Windows.Forms.Label();
            this.gbxPus.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTax);
            this.groupBox1.Controls.Add(this.tbxNetCoins);
            this.groupBox1.Controls.Add(this.lblNetCoins);
            this.groupBox1.Controls.Add(this.tbxTax);
            this.groupBox1.Controls.Add(this.lblTax);
            this.groupBox1.Controls.Add(this.tbxSell);
            this.groupBox1.Controls.Add(this.lblSellCoins);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PAZAR VERGİ HESAPLAYICI";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxPus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxPus.ResumeLayout(false);
            this.gbxPus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.TextBox tbxNetCoins;
        private System.Windows.Forms.Label lblNetCoins;
        private System.Windows.Forms.TextBox tbxTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox tbxSell;
        private System.Windows.Forms.Label lblSellCoins;
    }
}

