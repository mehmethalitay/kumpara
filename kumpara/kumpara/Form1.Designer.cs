namespace kumpara
{
    partial class mainForm
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
            this.headLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.totalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mainmonetTb = new System.Windows.Forms.TextBox();
            this.valueLayout = new System.Windows.Forms.TableLayoutPanel();
            this.nowmoneyTb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.footerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.exiButton = new System.Windows.Forms.Button();
            this.headLayout.SuspendLayout();
            this.totalLayout.SuspendLayout();
            this.valueLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.footerLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // headLayout
            // 
            this.headLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headLayout.BackColor = System.Drawing.Color.Transparent;
            this.headLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headLayout.Controls.Add(this.headerLbl, 0, 0);
            this.headLayout.Location = new System.Drawing.Point(-1, 12);
            this.headLayout.Name = "headLayout";
            this.headLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headLayout.Size = new System.Drawing.Size(449, 109);
            this.headLayout.TabIndex = 4;
            // 
            // headerLbl
            // 
            this.headerLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLbl.Font = new System.Drawing.Font("brusaha", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.headerLbl.Location = new System.Drawing.Point(3, 12);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(443, 85);
            this.headerLbl.TabIndex = 0;
            this.headerLbl.Text = " kumpara";
            this.headerLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerLbl_MouseDown);
            this.headerLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerLbl_MouseMove);
            this.headerLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerLbl_MouseUp);
            // 
            // totalLayout
            // 
            this.totalLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLayout.BackColor = System.Drawing.Color.Transparent;
            this.totalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.totalLayout.Controls.Add(this.mainmonetTb, 0, 0);
            this.totalLayout.Location = new System.Drawing.Point(12, 127);
            this.totalLayout.Name = "totalLayout";
            this.totalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.totalLayout.Size = new System.Drawing.Size(426, 77);
            this.totalLayout.TabIndex = 3;
            // 
            // mainmonetTb
            // 
            this.mainmonetTb.BackColor = System.Drawing.SystemColors.Control;
            this.mainmonetTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainmonetTb.Font = new System.Drawing.Font("Swis721 Hv BT", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainmonetTb.Location = new System.Drawing.Point(3, 3);
            this.mainmonetTb.Name = "mainmonetTb";
            this.mainmonetTb.ReadOnly = true;
            this.mainmonetTb.ShortcutsEnabled = false;
            this.mainmonetTb.Size = new System.Drawing.Size(420, 64);
            this.mainmonetTb.TabIndex = 6;
            this.mainmonetTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainmonetTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainmonetTb_KeyPress);
            // 
            // valueLayout
            // 
            this.valueLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueLayout.BackColor = System.Drawing.Color.Transparent;
            this.valueLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.valueLayout.Controls.Add(this.nowmoneyTb, 0, 0);
            this.valueLayout.Location = new System.Drawing.Point(12, 210);
            this.valueLayout.Name = "valueLayout";
            this.valueLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.valueLayout.Size = new System.Drawing.Size(426, 77);
            this.valueLayout.TabIndex = 2;
            // 
            // nowmoneyTb
            // 
            this.nowmoneyTb.BackColor = System.Drawing.SystemColors.Control;
            this.nowmoneyTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nowmoneyTb.Font = new System.Drawing.Font("Swis721 Hv BT", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nowmoneyTb.Location = new System.Drawing.Point(3, 3);
            this.nowmoneyTb.Name = "nowmoneyTb";
            this.nowmoneyTb.ShortcutsEnabled = false;
            this.nowmoneyTb.Size = new System.Drawing.Size(420, 64);
            this.nowmoneyTb.TabIndex = 7;
            this.nowmoneyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nowmoneyTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nowmoneyTb_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.plusButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.minusButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 293);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 81);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // plusButton
            // 
            this.plusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Swis721 Hv BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plusButton.Location = new System.Drawing.Point(216, 7);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(206, 66);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "Ekle";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Swis721 Hv BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minusButton.Location = new System.Drawing.Point(4, 7);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(205, 66);
            this.minusButton.TabIndex = 1;
            this.minusButton.Text = "Çıkar";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // footerLayout
            // 
            this.footerLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footerLayout.BackColor = System.Drawing.Color.Transparent;
            this.footerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.footerLayout.Controls.Add(this.exiButton, 0, 0);
            this.footerLayout.Location = new System.Drawing.Point(12, 380);
            this.footerLayout.Name = "footerLayout";
            this.footerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.footerLayout.Size = new System.Drawing.Size(426, 57);
            this.footerLayout.TabIndex = 0;
            // 
            // exiButton
            // 
            this.exiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exiButton.FlatAppearance.BorderSize = 0;
            this.exiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exiButton.Font = new System.Drawing.Font("Swis721 Hv BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exiButton.Location = new System.Drawing.Point(4, 7);
            this.exiButton.Name = "exiButton";
            this.exiButton.Size = new System.Drawing.Size(417, 42);
            this.exiButton.TabIndex = 1;
            this.exiButton.Text = "Çıkış";
            this.exiButton.UseVisualStyleBackColor = true;
            this.exiButton.Click += new System.EventHandler(this.exiButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 456);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.valueLayout);
            this.Controls.Add(this.totalLayout);
            this.Controls.Add(this.headLayout);
            this.Controls.Add(this.footerLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.headLayout.ResumeLayout(false);
            this.totalLayout.ResumeLayout(false);
            this.totalLayout.PerformLayout();
            this.valueLayout.ResumeLayout(false);
            this.valueLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.footerLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel headLayout;
        private TableLayoutPanel totalLayout;
        private TableLayoutPanel valueLayout;
        private TableLayoutPanel tableLayoutPanel1;
        private Label headerLbl;
        private Button plusButton;
        private Button minusButton;
        private TableLayoutPanel footerLayout;
        private Button exiButton;
        private TextBox mainmonetTb;
        private TextBox nowmoneyTb;
    }
}