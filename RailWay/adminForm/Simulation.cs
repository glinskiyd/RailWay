using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailWay.adminForm
{
    public partial class Simulation : Form
    {
        sqlFunction sql = new sqlFunction();
        public Simulation()
        {
            InitializeComponent();
        }


        private bool working = false;
        private int countUser = 0;


        public void SimpleGenerateUser()
        {
            string login, password, name, surname;

            string[] Arrlogin = { "Anton", "Vadim", "Andrey", "Jura", "Max", "Yaroslav", "Fedor", "Sergey", "Leonid"};
            string[] Arrpassword = { "Qu3jdh", "okH84N", "Pkijf94", "Fsndb72","Ddsds222","Dsdqw12", "Ssewe1","Dsdsd21", "dsad12" };
            string[] Arrname = { "Гоша", "Петя", "Кекс", "Илья", "Макс", "Антон", "Никита", "Влад", "Артём", "Вадим" };
            string[] Arrsurname = { "Гошевич", "Петрович", "Кексович", "Ильин", "Максович", "Антонович", "Никитич", "Владович", "Артёмович", "Вадимович" };

            Random random = new Random();

            while (working)
            {
                string id = random.Next(10000, 99999).ToString();
                login = Arrlogin[random.Next(0, Arrlogin.Length - 1)];
                password = Arrpassword[random.Next(0, Arrpassword.Length - 1)];
                name = Arrname[random.Next(0, Arrname.Length - 1)];
                surname = Arrsurname[random.Next(0, Arrsurname.Length - 1)];


                countUser++;
                sql.RegUser(id, login, password, name, surname);
                
               
                Симуляция.Invoke(new Action(() => Симуляция.Text = countUser.ToString())); 


                Thread.Sleep(1000);

            }



        }




        private void Start()
        {
            working = true;
            Task.Run(() => SimpleGenerateUser());
        }

        private void Stop()
        {
            working = false;
        }


      




        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
