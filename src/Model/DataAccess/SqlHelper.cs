using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAndIngredientManagementApplication.src.Model.DataAccess
{
    //private string connectionString = "Data Source=_1504_\\SQLEXPRESS;Initial Catalog=ListBook;User Id=admin;Password=123";
    //builder = new SqlConnectionStringBuilder
    //{
    //    DataSource = "_1504_\\SQLEXPRESS",
    //    InitialCatalog = "ListBook",
    //    IntegratedSecurity = true
    //};
    public class SqlHelper
    {
        private string localhost = "_1504_\\SQLEXPRESS";
        private string catalog = "ListBook";
        private string username = "admin";
        private string password = "123";
        private SqlConnectionStringBuilder builder;

        public SqlHelper()
        {
            builder = new SqlConnectionStringBuilder
            {
                DataSource = this.localhost,
                InitialCatalog = this.catalog,
                UserID = this.username,
                Password = this.password,
            };

        }
        public void Reconnect(string usernameUpdate, string passwordUpdate)
        {
            this.builder = new SqlConnectionStringBuilder
            {
                DataSource = this.localhost,
                InitialCatalog = this.catalog,
                UserID = usernameUpdate,
                Password = passwordUpdate
            };
        }
        // Hàm load data từ Database
        public DataTable GetBooks()
        {
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM book", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Hàm thêm sách mới
        public void AddBook(string id, string name, string author, int quantity, string qrCode)
        {
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "INSERT INTO book (ID, BookName, AuthorName, Quantity, QRCode) VALUES (@ID, @name, @Author, @Quantity, @QRCode)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@QRCode", qrCode);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Hàm cập nhật thông tin sách
        public void UpdateBook(string id, string name, string author, int quantity, string qrCode)
        {
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "UPDATE book SET BookName=@name, AuthorName=@Author, Quantity=@Quantity, QRCode=@QRCode WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@QRCode", qrCode);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Hàm xóa sách
        public void DeleteBook(string id)
        {
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "DELETE FROM book WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        // Hàm kiểm tra xem có sách trong Database chưa
        public bool isBookExists(string bookID)
        {
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM book WHERE ID = @BookID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookID", bookID);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
        public bool isUserExists(string username)
        {
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM information_login WHERE UserName = @UserName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", username);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }


        // Hàm tìm kiếm sách theo tên, tác giả hoặc QR code
        public DataTable SearchBooks(string searchType, string searchValue)
        {

            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = $"SELECT * FROM book WHERE {searchType} LIKE @SearchValue";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        // Hàm đọc data trả về dưới dạng List Book, tạm thời chưa dùng
        //public List<Book> ReadFromDatabase()
        //{
        //    List<Book> books = new List<Book>();

        //    using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
        //    {
        //        string query = "SELECT ID, BookName, AuthorName, Quantity, QRCode FROM book";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        conn.Open();

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                Book book = new Book
        //                {
        //                    Id = reader["ID"].ToString(),
        //                    Name = reader["BookName"].ToString(),
        //                    Author = reader["AuthorName"].ToString(),
        //                    Amount = Convert.ToInt32(reader["Quantity"]),
        //                    QrCode = reader["QRCode"].ToString()
        //                };

        //                books.Add(book);
        //            }
        //        }
        //    }

        //    return books;
        //}
        public List<string> GetLogin(string username)
        {
            List<string> login = new List<string>();
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "SELECT [UserName], [UserPassword] FROM [ListBook].[dbo].[information_login] WHERE UserName = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        login.Add(reader["UserName"].ToString());
                        login.Add(reader["UserPassword"].ToString());
                    }
                }
            }
            return login;
        }
        public void AddUser(string username, string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "INSERT INTO information_login (UserName, UserPassword) VALUES (@UserName, @UserPassword)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@UserPassword", hashedPassword);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
