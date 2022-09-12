using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;


namespace Store
{
    public partial class Home : KryptonForm
    {
        public Home()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al iniciar el programa " + exception);
            }

        }

        private void btn_Github_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/KitLuc/Store");
            }
            catch (Exception exception)
            {
                MessageBox.Show("No es posible ir a la direccion web" + exception);
            }
        }

        private void btnLinkedin_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/anderson-g-t");
            }
            catch (Exception exception)
            {
                MessageBox.Show("No es posible ir a la direccion web" + exception);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Store.views.Create create = new Store.views.Create();
            create.ShowDialog();
            this.Show();
        }

        private void btn_Listar_Click(object sender, EventArgs e)
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

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }
}

