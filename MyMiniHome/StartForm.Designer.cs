
namespace MyMiniHome
{
    partial class StartForm
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
            this.mtc_loginNjoin = new MetroFramework.Controls.MetroTabControl();
            this.mtp_login = new MetroFramework.Controls.MetroTabPage();
            this.mBTN_login = new MetroFramework.Controls.MetroButton();
            this.mtb_loginPW = new MetroFramework.Controls.MetroTextBox();
            this.mtb_loginID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtp_join = new MetroFramework.Controls.MetroTabPage();
            this.mBTN_overlap = new MetroFramework.Controls.MetroButton();
            this.mBTN_join = new MetroFramework.Controls.MetroButton();
            this.mtb_joinNAME = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtb_joinPWcheck = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtb_joinPW = new MetroFramework.Controls.MetroTextBox();
            this.mtb_joinID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtc_loginNjoin.SuspendLayout();
            this.mtp_login.SuspendLayout();
            this.mtp_join.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtc_loginNjoin
            // 
            this.mtc_loginNjoin.Controls.Add(this.mtp_login);
            this.mtc_loginNjoin.Controls.Add(this.mtp_join);
            this.mtc_loginNjoin.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.mtc_loginNjoin.Location = new System.Drawing.Point(23, 46);
            this.mtc_loginNjoin.Name = "mtc_loginNjoin";
            this.mtc_loginNjoin.SelectedIndex = 1;
            this.mtc_loginNjoin.Size = new System.Drawing.Size(307, 277);
            this.mtc_loginNjoin.TabIndex = 0;
            this.mtc_loginNjoin.UseSelectable = true;
            // 
            // mtp_login
            // 
            this.mtp_login.Controls.Add(this.mBTN_login);
            this.mtp_login.Controls.Add(this.mtb_loginPW);
            this.mtp_login.Controls.Add(this.mtb_loginID);
            this.mtp_login.Controls.Add(this.metroLabel2);
            this.mtp_login.Controls.Add(this.metroLabel1);
            this.mtp_login.HorizontalScrollbarBarColor = true;
            this.mtp_login.HorizontalScrollbarHighlightOnWheel = false;
            this.mtp_login.HorizontalScrollbarSize = 9;
            this.mtp_login.Location = new System.Drawing.Point(4, 34);
            this.mtp_login.Name = "mtp_login";
            this.mtp_login.Size = new System.Drawing.Size(299, 239);
            this.mtp_login.TabIndex = 0;
            this.mtp_login.Text = "로그인";
            this.mtp_login.VerticalScrollbarBarColor = true;
            this.mtp_login.VerticalScrollbarHighlightOnWheel = false;
            this.mtp_login.VerticalScrollbarSize = 9;
            // 
            // mBTN_login
            // 
            this.mBTN_login.Location = new System.Drawing.Point(230, 118);
            this.mBTN_login.Name = "mBTN_login";
            this.mBTN_login.Size = new System.Drawing.Size(66, 26);
            this.mBTN_login.TabIndex = 2;
            this.mBTN_login.Text = "로그인";
            this.mBTN_login.UseSelectable = true;
            this.mBTN_login.Click += new System.EventHandler(this.mBTN_login_Click);
            // 
            // mtb_loginPW
            // 
            // 
            // 
            // 
            this.mtb_loginPW.CustomButton.Image = null;
            this.mtb_loginPW.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.mtb_loginPW.CustomButton.Name = "";
            this.mtb_loginPW.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtb_loginPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_loginPW.CustomButton.TabIndex = 1;
            this.mtb_loginPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_loginPW.CustomButton.UseSelectable = true;
            this.mtb_loginPW.CustomButton.Visible = false;
            this.mtb_loginPW.Lines = new string[0];
            this.mtb_loginPW.Location = new System.Drawing.Point(118, 64);
            this.mtb_loginPW.MaxLength = 32767;
            this.mtb_loginPW.Name = "mtb_loginPW";
            this.mtb_loginPW.PasswordChar = '*';
            this.mtb_loginPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_loginPW.SelectedText = "";
            this.mtb_loginPW.SelectionLength = 0;
            this.mtb_loginPW.SelectionStart = 0;
            this.mtb_loginPW.ShortcutsEnabled = true;
            this.mtb_loginPW.Size = new System.Drawing.Size(178, 25);
            this.mtb_loginPW.TabIndex = 1;
            this.mtb_loginPW.UseSelectable = true;
            this.mtb_loginPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_loginPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtb_loginID
            // 
            // 
            // 
            // 
            this.mtb_loginID.CustomButton.Image = null;
            this.mtb_loginID.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.mtb_loginID.CustomButton.Name = "";
            this.mtb_loginID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtb_loginID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_loginID.CustomButton.TabIndex = 1;
            this.mtb_loginID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_loginID.CustomButton.UseSelectable = true;
            this.mtb_loginID.CustomButton.Visible = false;
            this.mtb_loginID.Lines = new string[0];
            this.mtb_loginID.Location = new System.Drawing.Point(118, 31);
            this.mtb_loginID.MaxLength = 32767;
            this.mtb_loginID.Name = "mtb_loginID";
            this.mtb_loginID.PasswordChar = '\0';
            this.mtb_loginID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_loginID.SelectedText = "";
            this.mtb_loginID.SelectionLength = 0;
            this.mtb_loginID.SelectionStart = 0;
            this.mtb_loginID.ShortcutsEnabled = true;
            this.mtb_loginID.Size = new System.Drawing.Size(178, 25);
            this.mtb_loginID.TabIndex = 0;
            this.mtb_loginID.UseSelectable = true;
            this.mtb_loginID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_loginID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(3, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 17);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "비밀번호";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(3, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 17);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "아이디";
            // 
            // mtp_join
            // 
            this.mtp_join.Controls.Add(this.mBTN_overlap);
            this.mtp_join.Controls.Add(this.mBTN_join);
            this.mtp_join.Controls.Add(this.mtb_joinNAME);
            this.mtp_join.Controls.Add(this.metroLabel6);
            this.mtp_join.Controls.Add(this.mtb_joinPWcheck);
            this.mtp_join.Controls.Add(this.metroLabel5);
            this.mtp_join.Controls.Add(this.mtb_joinPW);
            this.mtp_join.Controls.Add(this.mtb_joinID);
            this.mtp_join.Controls.Add(this.metroLabel3);
            this.mtp_join.Controls.Add(this.metroLabel4);
            this.mtp_join.HorizontalScrollbarBarColor = true;
            this.mtp_join.HorizontalScrollbarHighlightOnWheel = false;
            this.mtp_join.HorizontalScrollbarSize = 9;
            this.mtp_join.Location = new System.Drawing.Point(4, 34);
            this.mtp_join.Name = "mtp_join";
            this.mtp_join.Size = new System.Drawing.Size(299, 239);
            this.mtp_join.TabIndex = 1;
            this.mtp_join.Text = "회원가입";
            this.mtp_join.VerticalScrollbarBarColor = true;
            this.mtp_join.VerticalScrollbarHighlightOnWheel = false;
            this.mtp_join.VerticalScrollbarSize = 9;
            // 
            // mBTN_overlap
            // 
            this.mBTN_overlap.Location = new System.Drawing.Point(252, 81);
            this.mBTN_overlap.Name = "mBTN_overlap";
            this.mBTN_overlap.Size = new System.Drawing.Size(44, 24);
            this.mBTN_overlap.TabIndex = 2;
            this.mBTN_overlap.Text = "중복";
            this.mBTN_overlap.UseSelectable = true;
            this.mBTN_overlap.Click += new System.EventHandler(this.mBTN_overlap_Click);
            // 
            // mBTN_join
            // 
            this.mBTN_join.Location = new System.Drawing.Point(230, 192);
            this.mBTN_join.Name = "mBTN_join";
            this.mBTN_join.Size = new System.Drawing.Size(66, 26);
            this.mBTN_join.TabIndex = 5;
            this.mBTN_join.Text = "회원가입";
            this.mBTN_join.UseSelectable = true;
            this.mBTN_join.Click += new System.EventHandler(this.mBTN_join_Click);
            // 
            // mtb_joinNAME
            // 
            // 
            // 
            // 
            this.mtb_joinNAME.CustomButton.Image = null;
            this.mtb_joinNAME.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.mtb_joinNAME.CustomButton.Name = "";
            this.mtb_joinNAME.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtb_joinNAME.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_joinNAME.CustomButton.TabIndex = 1;
            this.mtb_joinNAME.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_joinNAME.CustomButton.UseSelectable = true;
            this.mtb_joinNAME.CustomButton.Visible = false;
            this.mtb_joinNAME.Lines = new string[0];
            this.mtb_joinNAME.Location = new System.Drawing.Point(119, 31);
            this.mtb_joinNAME.MaxLength = 32767;
            this.mtb_joinNAME.Name = "mtb_joinNAME";
            this.mtb_joinNAME.PasswordChar = '\0';
            this.mtb_joinNAME.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_joinNAME.SelectedText = "";
            this.mtb_joinNAME.SelectionLength = 0;
            this.mtb_joinNAME.SelectionStart = 0;
            this.mtb_joinNAME.ShortcutsEnabled = true;
            this.mtb_joinNAME.Size = new System.Drawing.Size(178, 25);
            this.mtb_joinNAME.TabIndex = 0;
            this.mtb_joinNAME.UseSelectable = true;
            this.mtb_joinNAME.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_joinNAME.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(3, 31);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(34, 17);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "이름";
            // 
            // mtb_joinPWcheck
            // 
            // 
            // 
            // 
            this.mtb_joinPWcheck.CustomButton.Image = null;
            this.mtb_joinPWcheck.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.mtb_joinPWcheck.CustomButton.Name = "";
            this.mtb_joinPWcheck.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtb_joinPWcheck.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_joinPWcheck.CustomButton.TabIndex = 1;
            this.mtb_joinPWcheck.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_joinPWcheck.CustomButton.UseSelectable = true;
            this.mtb_joinPWcheck.CustomButton.Visible = false;
            this.mtb_joinPWcheck.Lines = new string[0];
            this.mtb_joinPWcheck.Location = new System.Drawing.Point(119, 143);
            this.mtb_joinPWcheck.MaxLength = 32767;
            this.mtb_joinPWcheck.Name = "mtb_joinPWcheck";
            this.mtb_joinPWcheck.PasswordChar = '*';
            this.mtb_joinPWcheck.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_joinPWcheck.SelectedText = "";
            this.mtb_joinPWcheck.SelectionLength = 0;
            this.mtb_joinPWcheck.SelectionStart = 0;
            this.mtb_joinPWcheck.ShortcutsEnabled = true;
            this.mtb_joinPWcheck.Size = new System.Drawing.Size(177, 25);
            this.mtb_joinPWcheck.TabIndex = 4;
            this.mtb_joinPWcheck.UseSelectable = true;
            this.mtb_joinPWcheck.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_joinPWcheck.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(3, 143);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 17);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "비밀번호 확인";
            // 
            // mtb_joinPW
            // 
            // 
            // 
            // 
            this.mtb_joinPW.CustomButton.Image = null;
            this.mtb_joinPW.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.mtb_joinPW.CustomButton.Name = "";
            this.mtb_joinPW.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtb_joinPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_joinPW.CustomButton.TabIndex = 1;
            this.mtb_joinPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_joinPW.CustomButton.UseSelectable = true;
            this.mtb_joinPW.CustomButton.Visible = false;
            this.mtb_joinPW.Lines = new string[0];
            this.mtb_joinPW.Location = new System.Drawing.Point(119, 112);
            this.mtb_joinPW.MaxLength = 32767;
            this.mtb_joinPW.Name = "mtb_joinPW";
            this.mtb_joinPW.PasswordChar = '*';
            this.mtb_joinPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_joinPW.SelectedText = "";
            this.mtb_joinPW.SelectionLength = 0;
            this.mtb_joinPW.SelectionStart = 0;
            this.mtb_joinPW.ShortcutsEnabled = true;
            this.mtb_joinPW.Size = new System.Drawing.Size(177, 25);
            this.mtb_joinPW.TabIndex = 3;
            this.mtb_joinPW.UseSelectable = true;
            this.mtb_joinPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_joinPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtb_joinID
            // 
            // 
            // 
            // 
            this.mtb_joinID.CustomButton.Image = null;
            this.mtb_joinID.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.mtb_joinID.CustomButton.Name = "";
            this.mtb_joinID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtb_joinID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_joinID.CustomButton.TabIndex = 1;
            this.mtb_joinID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_joinID.CustomButton.UseSelectable = true;
            this.mtb_joinID.CustomButton.Visible = false;
            this.mtb_joinID.Lines = new string[0];
            this.mtb_joinID.Location = new System.Drawing.Point(119, 80);
            this.mtb_joinID.MaxLength = 32767;
            this.mtb_joinID.Name = "mtb_joinID";
            this.mtb_joinID.PasswordChar = '\0';
            this.mtb_joinID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_joinID.SelectedText = "";
            this.mtb_joinID.SelectionLength = 0;
            this.mtb_joinID.SelectionStart = 0;
            this.mtb_joinID.ShortcutsEnabled = true;
            this.mtb_joinID.Size = new System.Drawing.Size(127, 25);
            this.mtb_joinID.TabIndex = 1;
            this.mtb_joinID.UseSelectable = true;
            this.mtb_joinID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_joinID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(3, 112);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 17);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "비밀번호";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(3, 81);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 17);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "아이디";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 346);
            this.Controls.Add(this.mtc_loginNjoin);
            this.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.mtc_loginNjoin.ResumeLayout(false);
            this.mtp_login.ResumeLayout(false);
            this.mtp_login.PerformLayout();
            this.mtp_join.ResumeLayout(false);
            this.mtp_join.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtc_loginNjoin;
        private MetroFramework.Controls.MetroTabPage mtp_login;
        private MetroFramework.Controls.MetroTabPage mtp_join;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mBTN_login;
        private MetroFramework.Controls.MetroTextBox mtb_joinNAME;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mtb_joinPWcheck;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtb_joinPW;
        private MetroFramework.Controls.MetroTextBox mtb_joinID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton mBTN_join;
        private MetroFramework.Controls.MetroTextBox mtb_loginPW;
        private MetroFramework.Controls.MetroTextBox mtb_loginID;
        private MetroFramework.Controls.MetroButton mBTN_overlap;
    }
}