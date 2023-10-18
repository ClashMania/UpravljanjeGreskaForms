namespace UpravljanjeGreskamaForms
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
            this.textUnos1 = new System.Windows.Forms.TextBox();
            this.textIspis = new System.Windows.Forms.TextBox();
            this.btnIspis = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textUnos1
            // 
            this.textUnos1.Location = new System.Drawing.Point(10, 59);
            this.textUnos1.Name = "textUnos1";
            this.textUnos1.Size = new System.Drawing.Size(242, 20);
            this.textUnos1.TabIndex = 0;
            // 
            // textIspis
            // 
            this.textIspis.Location = new System.Drawing.Point(10, 118);
            this.textIspis.Name = "textIspis";
            this.textIspis.Size = new System.Drawing.Size(242, 20);
            this.textIspis.TabIndex = 2;
            this.textIspis.TabStop = false;
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(10, 181);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(115, 46);
            this.btnIspis.TabIndex = 1;
            this.btnIspis.Text = "Upis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(7, 43);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(142, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Unesi svoju godinu rođenja: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rođen si:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.textIspis);
            this.Controls.Add(this.textUnos1);
            this.Name = "Form1";
            this.Text = "Upravljanje Greskama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUnos1;
        private System.Windows.Forms.TextBox textIspis;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
    }
}

