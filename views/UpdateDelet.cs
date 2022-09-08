using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Store.views
{
    public partial class UpdateDelet : KryptonForm
    {
        public UpdateDelet()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            this.Hide();
            Store.views.Create create = new Store.views.Create();
            create.ShowDialog();
            this.Show();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Store.views.List list = new Store.views.List();
            list.ShowDialog();
            this.Show();
        }

        private void btn_update_delet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Store.views.UpdateDelet upD = new Store.views.UpdateDelet();
            upD.ShowDialog();
            this.Show();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
