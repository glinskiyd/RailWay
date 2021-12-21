using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailWay.passTour
{
    public partial class transpForm : Form
    {
        sqlFunction sql = new sqlFunction();
        account account = new account();
        DataTable data = new DataTable();


        public transpForm()
        {
            InitializeComponent();
        }


        public transpForm(account account)
        {
            InitializeComponent();
            this.account = account;
        }
        private void buyButton_Click(object sender, EventArgs e)
        {
            string fio = account.Name + " " + account.Surname;
            string routes = data.Rows[comboBox1.SelectedIndex][0].ToString();
            string price = data.Rows[comboBox1.SelectedIndex][7].ToString();
            string id_User = account.Id;
            string fullPrice = (Convert.ToDouble(price) * Convert.ToDouble(textBox1.Text)).ToString();



            sqlFunction sql1 = sql;
            sql1.createOrder(fio, routes, fullPrice, id_User);

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            data = sql.GetRoutes(dateTimePicker1.Value, "cargo");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                comboBox1.Items.Add(data.Rows[i][1]);
            }

        }
    }
}
