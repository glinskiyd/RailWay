using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Data.Common;

namespace RailWay
{
    class sqlFunction
    {
        
        MySqlConnection conn = DB.GetConnection();


        public bool loginuser(string loginUser, string passUser)
        {
            bool flag = false;
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP",conn );

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            conn.Open();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                flag = true;
            }
            conn.Close();
            return flag;

         }
        public bool RegUser(string id, string login, string password, string name, string surname)
        {
            
                bool flag = false;


                string sql = String.Format("INSERT INTO users(id,login,pass,name,surname) VALUES (@uId,@uLogin, @uPass, @uName, @uSurname)");

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.Add("@uId", MySqlDbType.VarChar).Value = id;
                command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = password;
                command.Parameters.Add("@uName", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uSurname", MySqlDbType.VarChar).Value = surname;
                



                conn.Open();


                if (command.ExecuteNonQuery() == 1)
                {
                    flag = true;
                    conn.Close();

                }




                return flag;
            
        }

        public DataTable GetRoutes(DateTime date,string type)
        {
            DataTable data = new DataTable();
            string dateStart = date.Date.ToString("yyyy-MM-dd");
            var dateEnd = date.AddHours(23).ToString("yyyy-MM-dd");
            data.Clear();
            conn.Open();
           
            string sql = String.Format("SELECT * FROM routes WHERE type = @type AND time_go BETWEEN @date AND @dateEnd  ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = dateStart;
            command.Parameters.Add("@dateEnd", MySqlDbType.VarChar).Value = dateEnd;


            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);


            conn.Close();
            return data;
        }
        public bool createOrder(string fio, string routes, string price, string id_user)
        {
            bool flag = false;
            Random random = new Random();
            string id = random.Next(10000, 99999).ToString();
            string id_ticket = "ticket-"+random.Next(10000, 99999).ToString();
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string coach = random.Next(1, 5).ToString();
            string place = random.Next(1, 100).ToString();

            string sql = String.Format("INSERT INTO orders(id,id_ticket,id_User,FIO,id_routes,price,sale_date,coach,place) VALUES (@id,@id_ticket,@id_User,@FIO,@id_routes,@price,@sale_date,@coach,@place)");
            
            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                command.Parameters.Add("@id_ticket", MySqlDbType.VarChar).Value = id_ticket;
                command.Parameters.Add("@id_User", MySqlDbType.VarChar).Value = id_user;
                command.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = fio;
                command.Parameters.Add("@id_routes", MySqlDbType.VarChar).Value = routes;
                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                command.Parameters.Add("@sale_date", MySqlDbType.VarChar).Value = dateTime;
                command.Parameters.Add("@coach", MySqlDbType.VarChar).Value = coach;
                command.Parameters.Add("@place", MySqlDbType.VarChar).Value = place;

                conn.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    flag = true;

                }
                else
                {

                }
            }
            finally
            {
                conn.Close();
            }


            return flag;
        }
        public DataTable GetClient(string login)
        {
            DataTable data = new DataTable();
            data.Clear();
            string sql = String.Format("SELECT * FROM users WHERE login = @uLogin ");
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = login;
            conn.Open();
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);

            conn.Close();
            return data;
        }
        public ArrayList AllClients()
        {
            ArrayList allclients = new ArrayList();
            conn.Open();

            string sql = String.Format("SELECT id,login,name,surname FROM users order by name");
            MySqlCommand command = new MySqlCommand(sql, conn);
            try
            {
                MySqlDataReader sqldr = command.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        allclients.Add(result);
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }

            return allclients;
        }
        public ArrayList allroutes()
        {
            ArrayList allroutes = new ArrayList();
            conn.Open();

            string sql = String.Format("SELECT r.name, t.typeTrain, r.type, r.time_go, r.time_away, r.railWay_type, r.price FROM routes r JOIN trains t ON t.id = r.id_train");
            
            MySqlCommand command = new MySqlCommand(sql, conn);
            try
            {
                MySqlDataReader sqldr = command.ExecuteReader();

                if (sqldr.HasRows)
                {
                    foreach (DbDataRecord result in sqldr)
                        allroutes.Add(result);
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.ExitThread();
            }

            return allroutes;
        }

    }
}

