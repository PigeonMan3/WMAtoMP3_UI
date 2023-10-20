namespace WMAtoMP3_UI
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
            this.LBLwma = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LBLmp3 = new System.Windows.Forms.Label();
            this.LBLdata = new System.Windows.Forms.Label();
            this.BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLwma
            // 
            this.LBLwma.AutoSize = true;
            this.LBLwma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLwma.Location = new System.Drawing.Point(54, 36);
            this.LBLwma.Name = "LBLwma";
            this.LBLwma.Size = new System.Drawing.Size(395, 17);
            this.LBLwma.TabIndex = 0;
            this.LBLwma.Text = "Vul hier het pad in van de map die de WMA bestanden bavat:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(645, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(645, 20);
            this.textBox2.TabIndex = 3;
            // 
            // LBLmp3
            // 
            this.LBLmp3.AutoSize = true;
            this.LBLmp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLmp3.Location = new System.Drawing.Point(54, 123);
            this.LBLmp3.Name = "LBLmp3";
            this.LBLmp3.Size = new System.Drawing.Size(452, 17);
            this.LBLmp3.TabIndex = 2;
            this.LBLmp3.Text = "Vul hier het pad in van de map waar je de MP3 bestanden wilt hebben:";
            // 
            // LBLdata
            // 
            this.LBLdata.Location = new System.Drawing.Point(54, 227);
            this.LBLdata.Name = "LBLdata";
            this.LBLdata.Size = new System.Drawing.Size(100, 23);
            this.LBLdata.TabIndex = 4;
            // 
            // BTN
            // 
            this.BTN.Location = new System.Drawing.Point(627, 227);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(75, 23);
            this.BTN.TabIndex = 5;
            this.BTN.Text = "Convert";
            this.BTN.UseVisualStyleBackColor = true;
            this.BTN.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 333);
            this.Controls.Add(this.BTN);
            this.Controls.Add(this.LBLdata);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LBLmp3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LBLwma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLwma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LBLmp3;
        private System.Windows.Forms.Label LBLdata;
        private System.Windows.Forms.Button BTN;
    }
}

