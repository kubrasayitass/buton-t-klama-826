namespace buton_tıklama_826
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
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lbAd = new System.Windows.Forms.ListBox();
            this.lbKisiler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(12, 36);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(100, 20);
            this.txtAranan.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(155, 36);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lbAd
            // 
            this.lbAd.FormattingEnabled = true;
            this.lbAd.Items.AddRange(new object[] {
            "efe",
            "kübra",
            "hayrunnisa",
            "eymen",
            "ömer",
            "sukeyna",
            "mehmet",
            "efe",
            "kübra",
            "arda",
            "hayrunnisa ",
            "eymen",
            "efe",
            "kübra"});
            this.lbAd.Location = new System.Drawing.Point(76, 92);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(120, 238);
            this.lbAd.TabIndex = 3;
            // 
            // lbKisiler
            // 
            this.lbKisiler.AutoSize = true;
            this.lbKisiler.Location = new System.Drawing.Point(31, 359);
            this.lbKisiler.Name = "lbKisiler";
            this.lbKisiler.Size = new System.Drawing.Size(42, 13);
            this.lbKisiler.TabIndex = 4;
            this.lbKisiler.Text = "...kişiler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.lbKisiler);
            this.Controls.Add(this.lbAd);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAranan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ListBox lbAd;
        private System.Windows.Forms.Label lbKisiler;
    }
}

