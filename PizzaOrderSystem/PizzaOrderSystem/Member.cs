using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzaOrderSystem
{
    internal class Member
    {
        String name;
        String address;
        String email;
        String phone;
        String password;

        public Member(string name, string address, string email, string phone, string password)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.password = password;
        }

        public String getName() { return name; }
        public String getAddress() { return address; }
        public String getEmail() { return email; }
        public String getPhone() { return phone; }
        public String getPassword() { return password; }


        public void saveDataToDatabase()
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                //Change changstudent to our database name
                string sql = "INSERT INTO pizzaplanet_customers (name, address, email, phonenumber, password) VALUES (@uname, @uaddress, @uemail, @uphone, @upassword)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uname", name);
                cmd.Parameters.AddWithValue("@uaddress", address);
                cmd.Parameters.AddWithValue("@uemail", email);
                cmd.Parameters.AddWithValue("@uphone", phone);
                cmd.Parameters.AddWithValue("@upassword", password);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        public void updateMemberInfo()
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                //Change changstudent to our database name
                // "UPDATE pizzaplanet_orders SET orderstatus=@uorderstatus WHERE orderid=@uorderid"
                string sql = "UPDATE pizzaplanet_customers SET name=@uname, address=@uaddress, phonenumber=@uphone, password=@upassword WHERE email=@uemail";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uname", name);
                cmd.Parameters.AddWithValue("@uaddress", address);
                cmd.Parameters.AddWithValue("@uemail", email);
                cmd.Parameters.AddWithValue("@uphone", phone);
                cmd.Parameters.AddWithValue("@upassword", password);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        public void displayExistenceError()
        {
            string message = "The email has been used already.  Please pick another email.";
            string title = "Error";
            MessageBox.Show(message, title);
        }

        //Checks if the specified email already exists in the database.
        //Returns false if the email already exists, returns true otherwise.
        public static bool checkEmail(string emailData)
        {
            string s = emailData;
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM pizzaplanet_customers WHERE email=@emailname";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@emailname", s);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    myReader.Close();
                    return true;
                    //textBox1.Text = myReader["FirstName"].ToString();
                    //textBox2.Text = myReader["LastName"].ToString();
                    //textBox3.Text = myReader["ID"].ToString();
                }
                else
                {
                    myReader.Close();
                    return false;
                }
                //myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return false;

        }

        public static bool checkPassword(string passwordData)
        {
            string s = passwordData;
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM pizzaplanet_customers WHERE password=@password";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@password", s);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    myReader.Close();
                    return true;
                    //textBox1.Text = myReader["FirstName"].ToString();
                    //textBox2.Text = myReader["LastName"].ToString();
                    //textBox3.Text = myReader["ID"].ToString();
                }
                else
                {
                    myReader.Close();
                    return false;
                }
                //myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return false;

        }

        public static string getName(string email)
        {
            string s = email;
            string name = "";
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM pizzaplanet_customers WHERE email=@email";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@email", s);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    name = myReader["name"].ToString();
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return name;
        }
    }
}

