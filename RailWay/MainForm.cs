using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RailWay.passTour;

namespace RailWay
{
    public partial class MainForm : Form
    {
        account account = new account();
        DataTable DataTable = new DataTable();
        sqlFunction sql = new sqlFunction();
        private Button currentButton;
        private Form activeForm;

        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string login)
        {
            InitializeComponent();
            DataTable.Clear();
            DataTable = sql.GetClient(login);
           

            account.Id = DataTable.Rows[0][0].ToString();
            account.Login = DataTable.Rows[0][1].ToString();
            account.Name = DataTable.Rows[0][3].ToString();
            account.Surname = DataTable.Rows[0][4].ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.DeepSkyBlue;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                   
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelControl.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.LightBlue;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childForm);
            this.panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void btnPassenger_Click(object sender, EventArgs e)
        {
            OpenChildForm(new passForm(account), sender);
        }

        private void btnTourist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new transpForm(account), sender);
        }

        private void btnFun_Click(object sender, EventArgs e)
        {
            OpenChildForm(new funForm(account), sender);
        }

        

 
    }
}
