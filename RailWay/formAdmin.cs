using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailWay
{
    public partial class formAdmin : Form
    {
        private Button currentButton;
        private Form activeForm;
        public formAdmin()
        {
            InitializeComponent();
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
            OpenChildForm(new adminForm.dashboard(), sender);

        }

        private void btnTourist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForm.Clients(), sender);
        }

        private void btnFun_Click(object sender, EventArgs e)
        {
            OpenChildForm(new adminForm.Simulation(), sender);
        }
    }
}
