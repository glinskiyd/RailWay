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
    public partial class passForm : Form
    {

        sqlFunction sql = new sqlFunction();
        account account = new account();
        DataTable data = new DataTable();


        public passForm()

        {
            InitializeComponent();
        }
        public passForm(account account)

        {
            InitializeComponent();
            this.account = account;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            string fio = account.Name+" "+account.Surname;
            string routes = data.Rows[comboBox1.SelectedIndex][0].ToString();
            string price = data.Rows[comboBox1.SelectedIndex][6].ToString();
            string id_User = account.Id;



            sql.createOrder(fio,routes,price,id_User);

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            data = sql.GetRoutes(dateTimePicker1.Value, "passenger");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                comboBox1.Items.Add(data.Rows[i][1]);
            }

        }
    }
}
