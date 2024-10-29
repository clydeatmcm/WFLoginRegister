using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WFLoginRegister.Models;

namespace WFLoginRegister.ModelViews
{
    internal class UserMV
    {
        private string connectionString;
        public UserMV()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        public void RegisterUser(UserModel user)
        {
            // Generate a new salt and hash the password
            user.Salt = GenerateSalt();
            user.PasswordHash = HashPassword(user.PasswordHash, user.Salt);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Username, PasswordHash, Salt) VALUES (@Username, @PasswordHash, @Salt);";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                command.Parameters.AddWithValue("@Salt", user.Salt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool LoginUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT PasswordHash, Salt FROM Users WHERE Username = @Username;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        byte[] storedSalt = (byte[])reader["Salt"];
                        string storedHash = (string)reader["PasswordHash"];

                        // Hash the input password with the stored salt
                        string hashedInputPassword = HashPassword(password, storedSalt);
                        return storedHash == hashedInputPassword;
                    }
                }
            }
            return false; // Username not found
        }

        private byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16]; // 16 bytes is a good length for a salt
                rng.GetBytes(salt);
                return salt;
            }
        }

        private string HashPassword(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000)) // 10000 iterations
            {
                byte[] hash = pbkdf2.GetBytes(20); // Hash length of 20 bytes
                return Convert.ToBase64String(hash);
            }
        }
    }
}
