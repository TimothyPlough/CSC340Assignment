using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PizzaOrderSystem
{
    public partial class Form1 : Form
    {
        String Order;
        int price;
        int OrderId = 0;
        String eMail;
        String eName;
        
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
            panel8.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel2.Hide();
            label1.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel8.Hide();
            string s = eMail;
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
                    txtEditName.Text = myReader["name"].ToString();
                    eName = txtEditName.Text;
                    txtEditPhone.Text = myReader["phonenumber"].ToString();
                    txtEditAdd.Text = myReader["address"].ToString();
                    txtEditPass.Text = myReader["password"].ToString();
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel8.Hide();
            label1.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel3.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            label1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string email = UNametxt.Text;
            string name = Nametxt.Text;
            string phone = Phonetxt.Text;
            string address = Addtxt.Text;
            string pass = Passtxt.Text;

            //Create a new Member with the given info.
            Member newMem = new Member(name, address, email, phone, pass);
            if (Member.checkEmail(email))
            {
                newMem.saveDataToDatabase();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            label1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
            string message = "The password has been used already.  Please enter a diffrent password or skip edit";
            string title = "Error";
            MessageBox.Show(message, title);
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel8.Hide();
            label1.Hide();
            panel2.Hide();
            panel5.Hide();
            panel6.Hide();
            panel3.Hide();

            if(OrderId == 0)
            {
                StatusTxt.Text = "NO ORDER";
            }
            else
            {
                string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();

                    string sql = "SELECT * pizzaplanet_orders WHERE orderid=@uorderid";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@uorderID", OrderId);
                    MySqlDataReader myReader = cmd.ExecuteReader();

                    if (myReader.Read())
                    {
                        int status = Int32.Parse(myReader["orderstatus"].ToString());
                        if (status == 0)
                        {
                            StatusTxt.Text = "Recived";
                        }
                        if (status == 1)
                        {
                            StatusTxt.Text = "Making";
                        }
                        if (status == 2)
                        {
                            StatusTxt.Text = "Recived";
                        }
                    }
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            label1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Show();
            panel8.Hide();
            label1.Hide();
            panel2.Hide();
            panel4.Hide();
            panel6.Hide();
            panel3.Hide();
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "SELECT * FROM pizzaplanet_orders WHERE orderedby=@name";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uorderID", eName);

                MySqlDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string comboString = "";
                    comboString += myReader["timeordered"] + " - " + myReader["price"] + " - " + myReader["orderid"];
                    DDOrderHis.Items.Add(comboString);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            label1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "UPDATE pizzaplanet_orders SET orderstatus=@uorderstatus, timeordered=@timeOrder WHERE orderid=@uorderid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@timeOrder", DateTime.Now);
                cmd.Parameters.AddWithValue("@uorderstatus", 0);
                cmd.Parameters.AddWithValue("@uorderID", OrderId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel6.Show();
            panel2.Hide();
            label1.Hide();
            panel4.Hide();
            panel5.Hide();
            panel8.Hide();
            panel3.Hide();
            //Erase previous order
            Order = "";
            price = 0;
            OrderListtxt.Items.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            label1.Show();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int valA = OrderPizzaDD.SelectedIndex;
            int valB = OrderSizeDD.SelectedIndex;
            Order = Order + valB + "" + valA;
            price = price + (valB * 6);
            OrderListtxt.Items.Add(((string)OrderSizeDD.SelectedItem) + " " + ((string)OrderPizzaDD.SelectedItem));
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            string encodeOrder = Pizza.encodeOrder(Order);

            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "INSERT INTO pizzaplanet_orders (orderedby, price, pizzas, timeordered, orderstatus) VALUES (@orderedby, @price, @pizzas, @timeordered, @orderstatus)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@orderedby", eName);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@pizzas", encodeOrder);
                cmd.Parameters.AddWithValue("@timeordered", DateTime.Now);
                cmd.Parameters.AddWithValue("@orderstatus", 0);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel8.Show();
            panel2.Hide();
            label1.Hide();
            panel4.Hide();
            panel5.Hide();
            panel3.Hide();
            panel6.Hide();
        }

        private void btnLogCancel_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            label1.Show();
        }

        private void btnLogSubmit_Click(object sender, EventArgs e)
        {
            //login
            string emailtxt = txtLogEmail.Text;
            string passtxt = txtLogPassword.Text;
            if (Member.checkEmail(emailtxt))
            {
                if (Member.checkPassword(emailtxt))
                {
                    panel1.Show();
                    eMail = emailtxt;
                    eName = Member.getName(eMail);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel3.Hide();
            label1.Show();
        }

        private void btnEditSubmit_Click(object sender, EventArgs e)
        {
            //submit edit
            string email = eMail;
            string name = txtEditName.Text;
            string phone = txtEditPhone.Text;
            string address = txtEditAdd.Text;
            string pass = txtEditPass.Text;

            //Create a new Member with the given info.
            Member newMem = new Member(name, address, email, phone, pass);
            newMem.updateMemberInfo();
        }

        private void DDOrderHis_SelectedIndexChanged(object sender, EventArgs e)
        {
            HistoryBoxList.Items.Clear();

            string dropDown = (string)DDOrderHis.SelectedItem;
            int item = Int32.Parse(dropDown.Split('-').Last().Substring(1));
            OrderId = item;

            //Get the entry from the database with the orderID
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                //Get all of the orders in the db
                string sql = "SELECT * FROM pizzaplanet_orders WHERE orderID = @uorderID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uorderID", item);

                MySqlDataReader myReader = cmd.ExecuteReader();


                if (myReader.Read())
                {
                    //Decode Order from database
                    string[] pizzas = Pizza.decodeOrder((string)myReader["pizzas"]);

                    //Add Customer name to List
                    HistoryBoxList.Items.Add("Name: " + myReader["orderedby"]);

                    //Add all pizzas to List
                    for (int i = 0; i < pizzas.Length; i++)
                    {
                        System.Console.WriteLine(pizzas[i]);
                        HistoryBoxList.Items.Add(pizzas[i]);
                    }


                    //Add total price to List
                    HistoryBoxList.Items.Add("Total: $" + myReader["price"]);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
