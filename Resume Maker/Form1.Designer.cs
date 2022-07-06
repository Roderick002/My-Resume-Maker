namespace Resume_Maker
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
            this.BtnRmStart = new System.Windows.Forms.Button();
            this.BtnRmSave = new System.Windows.Forms.Button();
            this.RtbRmInformationPanel = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnRmStart
            // 
            this.BtnRmStart.Location = new System.Drawing.Point(300, 384);
            this.BtnRmStart.Name = "BtnRmStart";
            this.BtnRmStart.Size = new System.Drawing.Size(94, 29);
            this.BtnRmStart.TabIndex = 0;
            this.BtnRmStart.Text = "start";
            this.BtnRmStart.UseVisualStyleBackColor = true;
            this.BtnRmStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRmSave
            // 
            this.BtnRmSave.Location = new System.Drawing.Point(300, 439);
            this.BtnRmSave.Name = "BtnRmSave";
            this.BtnRmSave.Size = new System.Drawing.Size(94, 29);
            this.BtnRmSave.TabIndex = 2;
            this.BtnRmSave.Text = "save";
            this.BtnRmSave.UseVisualStyleBackColor = true;
            this.BtnRmSave.Click += new System.EventHandler(this.BtnRmSave_Click);
            // 
            // RtbRmInformationPanel
            // 
            this.RtbRmInformationPanel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbRmInformationPanel.Location = new System.Drawing.Point(5, 123);
            this.RtbRmInformationPanel.Name = "RtbRmInformationPanel";
            this.RtbRmInformationPanel.Size = new System.Drawing.Size(716, 120);
            this.RtbRmInformationPanel.TabIndex = 3;
            this.RtbRmInformationPanel.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 518);
            this.Controls.Add(this.RtbRmInformationPanel);
            this.Controls.Add(this.BtnRmSave);
            this.Controls.Add(this.BtnRmStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnRmStart;
        private Button BtnRmSave;
        private RichTextBox RtbRmInformationPanel;
    }
}