namespace Flipper_zero_dolphin_state_editor
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
            dolphin_exp = new NumericUpDown();
            dolphin_state = new ComboBox();
            dolphin_exp_lbl = new Label();
            dolphin_state_lbl = new Label();
            folderBrowserDialog = new FolderBrowserDialog();
            save = new Button();
            dolphin_exp_lbl2 = new Label();
            pictureBox1 = new PictureBox();
            title_lbl = new Label();
            github_link = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            butthurt_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dolphin_exp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // dolphin_exp
            // 
            dolphin_exp.Anchor = AnchorStyles.None;
            dolphin_exp.BorderStyle = BorderStyle.FixedSingle;
            dolphin_exp.Location = new Point(367, 184);
            dolphin_exp.Margin = new Padding(3, 4, 3, 4);
            dolphin_exp.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            dolphin_exp.Name = "dolphin_exp";
            dolphin_exp.Size = new Size(161, 27);
            dolphin_exp.TabIndex = 0;
            dolphin_exp.TextAlign = HorizontalAlignment.Center;
            dolphin_exp.ValueChanged += DolphinExp_ValueChanged;
            // 
            // dolphin_state
            // 
            dolphin_state.Anchor = AnchorStyles.None;
            dolphin_state.DropDownStyle = ComboBoxStyle.DropDownList;
            dolphin_state.FormattingEnabled = true;
            dolphin_state.Items.AddRange(new object[] { "0 - Happy", "1 - Happy", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14" });
            dolphin_state.Location = new Point(367, 225);
            dolphin_state.Margin = new Padding(3, 4, 3, 4);
            dolphin_state.Name = "dolphin_state";
            dolphin_state.Size = new Size(161, 28);
            dolphin_state.TabIndex = 1;
            // 
            // dolphin_exp_lbl
            // 
            dolphin_exp_lbl.Anchor = AnchorStyles.None;
            dolphin_exp_lbl.AutoSize = true;
            dolphin_exp_lbl.Location = new Point(199, 184);
            dolphin_exp_lbl.Name = "dolphin_exp_lbl";
            dolphin_exp_lbl.Size = new Size(91, 20);
            dolphin_exp_lbl.TabIndex = 2;
            dolphin_exp_lbl.Text = "Dolphin EXP";
            // 
            // dolphin_state_lbl
            // 
            dolphin_state_lbl.Anchor = AnchorStyles.None;
            dolphin_state_lbl.AutoSize = true;
            dolphin_state_lbl.Location = new Point(66, 224);
            dolphin_state_lbl.Name = "dolphin_state_lbl";
            dolphin_state_lbl.Size = new Size(170, 20);
            dolphin_state_lbl.TabIndex = 3;
            dolphin_state_lbl.Text = "Dolphin emotional state";
            // 
            // save
            // 
            save.Anchor = AnchorStyles.None;
            save.BackgroundImage = Resources.save_image;
            save.BackgroundImageLayout = ImageLayout.Stretch;
            save.FlatAppearance.BorderColor = Color.Black;
            save.FlatAppearance.BorderSize = 8;
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            save.ForeColor = Color.Black;
            save.Location = new Point(280, 345);
            save.Name = "save";
            save.Size = new Size(177, 95);
            save.TabIndex = 4;
            save.UseVisualStyleBackColor = true;
            save.Click += SaveBTN_Click;
            // 
            // dolphin_exp_lbl2
            // 
            dolphin_exp_lbl2.Anchor = AnchorStyles.None;
            dolphin_exp_lbl2.AutoSize = true;
            dolphin_exp_lbl2.Location = new Point(534, 186);
            dolphin_exp_lbl2.Name = "dolphin_exp_lbl2";
            dolphin_exp_lbl2.Size = new Size(91, 20);
            dolphin_exp_lbl2.TabIndex = 5;
            dolphin_exp_lbl2.Text = "EXP (level 1)";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(58, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(576, 127);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            title_lbl.ForeColor = Color.FromArgb(255, 130, 0);
            title_lbl.Location = new Point(58, 29);
            title_lbl.Margin = new Padding(0);
            title_lbl.Name = "title_lbl";
            title_lbl.Padding = new Padding(7);
            title_lbl.Size = new Size(377, 46);
            title_lbl.TabIndex = 7;
            title_lbl.Text = "Flipper Zero Dolphin state editor";
            title_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // github_link
            // 
            github_link.ActiveLinkColor = Color.FromArgb(255, 130, 0);
            github_link.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            github_link.AutoSize = true;
            github_link.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            github_link.LinkBehavior = LinkBehavior.NeverUnderline;
            github_link.LinkColor = Color.FromArgb(255, 130, 0);
            github_link.Location = new Point(508, 411);
            github_link.Name = "github_link";
            github_link.Size = new Size(137, 15);
            github_link.TabIndex = 8;
            github_link.TabStop = true;
            github_link.Text = "GitHub: @Zakrzewiaczek";
            github_link.VisitedLinkColor = Color.FromArgb(255, 130, 0);
            github_link.LinkClicked += GitHub_otworz;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(107, 262);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(421, 50);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(600, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 50);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(600, 133);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 50);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(124, 122);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(131, 50);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(367, 111);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 50);
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(631, 186);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(56, 50);
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            // 
            // butthurt_lbl
            // 
            butthurt_lbl.Anchor = AnchorStyles.None;
            butthurt_lbl.AutoSize = true;
            butthurt_lbl.Location = new Point(258, 261);
            butthurt_lbl.Name = "butthurt_lbl";
            butthurt_lbl.Size = new Size(72, 20);
            butthurt_lbl.TabIndex = 15;
            butthurt_lbl.Text = "(butthurt)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Resources.background;
            ClientSize = new Size(771, 477);
            Controls.Add(butthurt_lbl);
            Controls.Add(github_link);
            Controls.Add(title_lbl);
            Controls.Add(dolphin_exp_lbl2);
            Controls.Add(save);
            Controls.Add(dolphin_state_lbl);
            Controls.Add(dolphin_exp_lbl);
            Controls.Add(dolphin_state);
            Controls.Add(dolphin_exp);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox7);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dolphin_exp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown dolphin_exp;
        private ComboBox dolphin_state;
        private Label dolphin_exp_lbl;
        private Label dolphin_state_lbl;
        private FolderBrowserDialog folderBrowserDialog;
        private Button save;
        private Label dolphin_exp_lbl2;
        private PictureBox pictureBox1;
        private Label title_lbl;
        private LinkLabel github_link;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label butthurt_lbl;
    }
}
