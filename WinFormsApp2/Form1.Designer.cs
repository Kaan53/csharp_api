namespace WinFormsApp2
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
            btnFetch = new Button();
            txtData = new RichTextBox();
            SuspendLayout();
            // 
            // btnFetch
            // 
            btnFetch.Location = new Point(121, 367);
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new Size(75, 23);
            btnFetch.TabIndex = 0;
            btnFetch.Text = "Veri Getir";
            btnFetch.UseVisualStyleBackColor = true;
            btnFetch.Click += btnFetch_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(27, 12);
            txtData.Name = "txtData";
            txtData.Size = new Size(169, 349);
            txtData.TabIndex = 1;
            txtData.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtData);
            Controls.Add(btnFetch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFetch;
        private RichTextBox txtData;
    }
}
