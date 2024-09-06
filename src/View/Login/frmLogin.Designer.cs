using System.Windows.Forms;

namespace FoodAndIngredientManagementApplication.src.View.Login
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSeen = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSign = new System.Windows.Forms.Label();
            this.timerNameMove = new System.Windows.Forms.Timer(this.components);
            this.timerPassMove = new System.Windows.Forms.Timer(this.components);
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.pnlPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(70, 18);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 14);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TabStop = false;
            this.txtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUser.BackgroundImage")));
            this.pnlUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUser.Controls.Add(this.pnlLine1);
            this.pnlUser.Controls.Add(this.picUser);
            this.pnlUser.Controls.Add(this.lblName);
            this.pnlUser.Controls.Add(this.txtUsername);
            this.pnlUser.Location = new System.Drawing.Point(62, 189);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(338, 50);
            this.pnlUser.TabIndex = 8;
            // 
            // pnlLine1
            // 
            this.pnlLine1.BackColor = System.Drawing.Color.Black;
            this.pnlLine1.Location = new System.Drawing.Point(50, 9);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(2, 30);
            this.pnlLine1.TabIndex = 8;
            // 
            // picUser
            // 
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUser.Location = new System.Drawing.Point(15, 6);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(24, 34);
            this.picUser.TabIndex = 7;
            this.picUser.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(67, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(234, 15);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Tên người dùng";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // picTitle
            // 
            this.picTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTitle.BackgroundImage")));
            this.picTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picTitle.Location = new System.Drawing.Point(190, 38);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(77, 65);
            this.picTitle.TabIndex = 9;
            this.picTitle.TabStop = false;
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.White;
            this.pnlPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPass.BackgroundImage")));
            this.pnlPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPass.Controls.Add(this.lblPassword);
            this.pnlPass.Controls.Add(this.btnSeen);
            this.pnlPass.Controls.Add(this.panel2);
            this.pnlPass.Controls.Add(this.picPassword);
            this.pnlPass.Controls.Add(this.txtPassword);
            this.pnlPass.Location = new System.Drawing.Point(62, 255);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(338, 50);
            this.pnlPass.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(67, 18);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(234, 15);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Mật khẩu";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // btnSeen
            // 
            this.btnSeen.BackColor = System.Drawing.Color.Transparent;
            this.btnSeen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeen.BackgroundImage")));
            this.btnSeen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeen.Location = new System.Drawing.Point(307, 15);
            this.btnSeen.Name = "btnSeen";
            this.btnSeen.Size = new System.Drawing.Size(20, 20);
            this.btnSeen.TabIndex = 9;
            this.btnSeen.TabStop = false;
            this.btnSeen.Visible = false;
            this.btnSeen.Click += new System.EventHandler(this.BtnSeen_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(50, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 30);
            this.panel2.TabIndex = 8;
            // 
            // picPassword
            // 
            this.picPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPassword.BackgroundImage")));
            this.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPassword.Location = new System.Drawing.Point(15, 6);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(24, 34);
            this.picPassword.TabIndex = 7;
            this.picPassword.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(70, 18);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 14);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Leelawadee UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(150, 118);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 40);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Đăng nhập";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.Green;
            this.btnLogin.Location = new System.Drawing.Point(62, 320);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(338, 51);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSign.ForeColor = System.Drawing.Color.Green;
            this.lblSign.Location = new System.Drawing.Point(342, 388);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(58, 16);
            this.lblSign.TabIndex = 12;
            this.lblSign.Text = "Đăng ký";
            // 
            // timerNameMove
            // 
            this.timerNameMove.Interval = 15;
            this.timerNameMove.Tick += new System.EventHandler(this.timerNameMove_Tick);
            // 
            // timerPassMove
            // 
            this.timerPassMove.Interval = 15;
            this.timerPassMove.Tick += new System.EventHandler(this.timerPassMove_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 469);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlPass);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.pnlUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.pnlPass.ResumeLayout(false);
            this.pnlPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogin;
        private Label lblSign;
        private PictureBox btnSeen;
        private Label lblName;
        private Timer timerNameMove;
        private Label lblPassword;
        private Timer timerPassMove;
    }
}