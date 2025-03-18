namespace Nasledovanie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPefill = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPefill
            // 
            this.btnPefill.Location = new System.Drawing.Point(10, 9);
            this.btnPefill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPefill.Name = "btnPefill";
            this.btnPefill.Size = new System.Drawing.Size(248, 22);
            this.btnPefill.TabIndex = 0;
            this.btnPefill.Text = "Перезаполнить";
            this.btnPefill.UseVisualStyleBackColor = true;
            this.btnPefill.Click += new System.EventHandler(this.btnPefill_Click_1);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(178, 86);
            this.btnGet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(82, 90);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click_1);
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(10, 35);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(248, 46);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Text = "";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(10, 86);
            this.txtOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(162, 91);
            this.txtOut.TabIndex = 3;
            this.txtOut.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(266, 11);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(123, 165);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 191);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnPefill);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPefill;
        private Button btnGet;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
        private RichTextBox richTextBox1;
    }
}
