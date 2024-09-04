using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodAndIngredientManagementApplication.src.View.Login
{
    public partial class frmLogin : Form
    {
        private bool seen;
        private bool status;
        //private ListBookForm listBookForm;
        public frmLogin()
        {
            //listBookForm = new ListBookForm(this);
            this.status = false;
            this.seen = false;
            InitializeComponent();
        }
        private string hashPass(string crypt)
        {
            string hashedPass = BCrypt.Net.BCrypt.HashPassword(crypt);
            return hashedPass;
        }
        public bool isPasswordValid(string input, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(input, hashedPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.btnLogin.Focus();
            if (this.txtUsername.Text == "" || this.txtUsername.Text == "Tên người dùng" || this.txtUsername.Text == "Nhập đủ thông tin")
            {
                this.txtUsername.ForeColor = Color.Red;
                if (this.txtPassword.Text == "" || this.txtPassword.Text == "Mật khẩu" || this.txtPassword.Text == "Nhập đủ thông tin")
                {
                    this.txtPassword.UseSystemPasswordChar = false;
                }
                else
                    this.txtPassword.UseSystemPasswordChar = true;
                this.txtUsername.Text = "Nhập đủ thông tin";
                return;
            }
            if (this.txtPassword.Text == "" || this.txtPassword.Text == "Mật khẩu" || this.txtPassword.Text == "Nhập đủ thông tin")
            {
                this.txtPassword.UseSystemPasswordChar = false;
                this.txtPassword.Text = "Nhập đủ thông tin";
                this.txtPassword.ForeColor = Color.Red;
                return;
            }
            else this.txtPassword.UseSystemPasswordChar = true;
            if (this.status)
            {
                this.Signin();
            }
            else
            {
                this.Login();
            }

        }
        private void Login()
        {
            try
            {
                Model.DataAccess.SqlHelper sqlHelper = new Model.DataAccess.SqlHelper();
                List<string> informationLogin = sqlHelper.GetLogin(this.txtUsername.Text);
                if (informationLogin == null || informationLogin.Count < 2)
                {
                    MessageBox.Show("Tên người không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (this.isPasswordValid(this.txtPassword.Text, informationLogin[1]))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.listBookForm.SetUserName(this.txtUsername.Text);
                    this.txtPassword.Text = "Mật khẩu";
                    this.txtUsername.Text = "Tên người dùng";
                    this.seen = false;
                    this.txtPassword.UseSystemPasswordChar = false;
                    this.Hide();
                    //this.listBookForm.Show();

                    return;
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Signin()
        {
            try
            {
                Model.DataAccess.SqlHelper sqlHelper = new Model.DataAccess.SqlHelper();
                if (sqlHelper.isUserExists(this.txtUsername.Text))
                {
                    MessageBox.Show("Tên người dùng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sqlHelper.AddUser(this.txtUsername.Text, this.txtPassword.Text);
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPassword.Text = "Mật khẩu";
                this.txtUsername.Text = "Tên người dùng";
                this.lblTitle.Text = "Đăng nhập";
                this.btnLogin.Text = "Đăng nhập";
                this.lblSign.Text = "Đăng ký";
                this.txtPassword.UseSystemPasswordChar = false;
                this.status = !this.status;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu\nĐăng ký không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "Tên người dùng" || this.txtUsername.Text == "Nhập đủ thông tin")
            {
                this.txtUsername.ForeColor = Color.Black;
                this.txtUsername.Text = "";
            }
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "")
                this.txtUsername.Text = "Tên người dùng";

        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "Mật khẩu" || this.txtPassword.Text == "Nhập đủ thông tin")
            {
                this.txtPassword.ForeColor = Color.Black;
                this.txtPassword.Text = "";
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
                this.txtPassword.Text = "Mật khẩu";
        }
        private void setLogin()
        {
            this.txtPassword.ForeColor = Color.Black;
            this.txtUsername.ForeColor = Color.Black;
            this.txtPassword.Text = "Mật khẩu";
            this.txtUsername.Text = "Tên người dùng";
            this.lblTitle.Text = "Đăng nhập";
            this.btnLogin.Text = "Đăng nhập";
            this.lblSign.Text = "Đăng ký";
        }
        private void setSign()
        {
            this.txtPassword.ForeColor = Color.Black;
            this.txtUsername.ForeColor = Color.Black;
            this.txtPassword.Text = "Mật khẩu";
            this.txtUsername.Text = "Tên người dùng";
            this.lblTitle.Text = "Đăng ký";
            this.btnLogin.Text = "Đăng ký";
            this.lblSign.Text = "Đăng nhập";
            this.txtPassword.UseSystemPasswordChar = false;
        }
        private void lblSign_Click(object sender, EventArgs e)
        {
            this.lblSign.Focus();
            this.status = !this.status;
            if (this.status)
                setSign();
            else
                setLogin();

            this.txtPassword.UseSystemPasswordChar = false;
        }

        private void btnSeen_Click(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = !this.txtPassword.UseSystemPasswordChar;
            string currentDirectory = Directory.GetCurrentDirectory();

            string seenPath = Path.Combine(currentDirectory, @"..\..\Resources\show.png");
            string unSeenPath = Path.Combine(currentDirectory, @"..\..\Resources\unshow.png");

            seenPath = Path.GetFullPath(seenPath);
            unSeenPath = Path.GetFullPath(unSeenPath);
            if (this.seen)
            {
                if (System.IO.File.Exists(seenPath))
                {
                    this.btnSeen.BackgroundImage = Image.FromFile(seenPath);
                }
            }
            else
            {
                if (System.IO.File.Exists(unSeenPath))
                {
                    this.btnSeen.BackgroundImage = Image.FromFile(unSeenPath);
                }
            }
            this.seen = !this.seen;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!this.seen)
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
            if (this.txtPassword.Text == "" || this.txtPassword.Text == "Mật khẩu" || this.txtPassword.Text == "Nhập đủ thông tin")
            {
                this.btnSeen.Visible = false;
            }
            else
            {
                this.btnSeen.Visible = true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
