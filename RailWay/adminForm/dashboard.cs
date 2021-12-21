using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailWay.adminForm
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        sqlFunction sql = new sqlFunction();
        private void dgv_routes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {
            dgv_routes.DataSource = sql.allroutes();
        }
    }
}
