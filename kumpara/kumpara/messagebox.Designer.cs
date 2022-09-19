namespace kumpara
{
    partial class messagebox
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
            this.plusButton = new System.Windows.Forms.Button();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.mLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(0, 0);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 23);
            this.plusButton.TabIndex = 0;
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.SystemColors.Control;
            this.yesBtn.FlatAppearance.BorderSize = 0;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.Font = new System.Drawing.Font("Swis721 Hv BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yesBtn.Location = new System.Drawing.Point(249, 88);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(180, 40);
            this.yesBtn.TabIndex = 0;
            this.yesBtn.Text = "Evet";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.SystemColors.Control;
            this.noBtn.FlatAppearance.BorderSize = 0;
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noBtn.Font = new System.Drawing.Font("Swis721 Hv BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noBtn.Location = new System.Drawing.Point(12, 88);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(180, 40);
            this.noBtn.TabIndex = 1;
            this.noBtn.Text = "Hayır";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // mLbl
            // 
            this.mLbl.AutoSize = true;
            this.mLbl.Font = new System.Drawing.Font("Swis721 Hv BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mLbl.Location = new System.Drawing.Point(12, 9);
            this.mLbl.Name = "mLbl";
            this.mLbl.Size = new System.Drawing.Size(0, 16);
            this.mLbl.TabIndex = 2;
            this.mLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messagebox
            // 
            this.ClientSize = new System.Drawing.Size(441, 140);
            this.ControlBox = false;
            this.Controls.Add(this.mLbl);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Name = "messagebox";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label messageLbl;
        public Button yesButton;
        private Button plusButton;
        private Button noButton;
        public Button yesBtn;
        public Button noBtn;
        public Label mLbl;
    }
}