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
            btnPefill = new Button();
            btnGet = new Button();
            txtInfo = new RichTextBox();
            txtOut = new RichTextBox();
            SuspendLayout();
            // 
            // btnPefill
            // 
            btnPefill.Location = new Point(12, 12);
            btnPefill.Name = "btnPefill";
            btnPefill.Size = new Size(284, 29);
            btnPefill.TabIndex = 0;
            btnPefill.Text = "Перезаполнить";
            btnPefill.UseVisualStyleBackColor = true;
            btnPefill.Click += btnPefill_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(203, 115);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 120);
            btnGet.TabIndex = 1;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(12, 47);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(284, 62);
            txtInfo.TabIndex = 2;
            txtInfo.Text = "";
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 115);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(185, 120);
            txtOut.TabIndex = 3;
            txtOut.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 255);
            Controls.Add(txtOut);
            Controls.Add(txtInfo);
            Controls.Add(btnGet);
            Controls.Add(btnPefill);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPefill;
        private Button btnGet;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
    }
}
