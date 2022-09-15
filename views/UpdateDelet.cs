using ComponentFactory.Krypton.Toolkit;
using Store.Controller;
using Store.models;
using System;
using System.Windows.Forms;

namespace Store.views
{
    public partial class UpdateDelet : KryptonForm
    {
        Product product = new Product();

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

        // btn_delet_Click
        private void btn_delet_Click(object sender, EventArgs e)
        {
            try
            {
                product.Delete(Convert.ToInt32(textIdDelet.Text.Trim()));
                MessageBox.Show("Producto eliminado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema tipo: " + ex);
            }
            finally
            {
                cleanComponents();
            }
        }

        // btn_update_Click with varibale of Clase type Components
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                Components dtoComponent = new Components();
                dtoComponent.IdClothing = Convert.ToInt32(textId.Text.Trim());
                dtoComponent.NameClothing = textName.Text.Trim();
                dtoComponent.DescriptionClothing = textDescript.Text.Trim();
                dtoComponent.Gender = boxGender.SelectedItem.ToString();
                dtoComponent.Color = textColor.Text.ToString();
                dtoComponent.Size = Convert.ToChar(boxSize.SelectedItem.ToString());
                dtoComponent.Value = textPrice.Text.Trim();
                dtoComponent.Marca = textMarca.Text.Trim();
                product.Update(dtoComponent, Convert.ToInt16(textId.Text.Trim()));
                MessageBox.Show("Producto actualizado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema tipo: " + ex);
            }
            finally
            {
                cleanComponents();
            }
        }

        private void cleanComponents()
        {
            textId.Clear();
            textIdDelet.Clear();
            textName.Clear();
            textDescript.Clear();
            textColor.Clear();
            textPrice.Clear();
            textMarca.Clear();
            boxGender.SelectedIndex = 0;
            boxSize.SelectedIndex = 0;
        }
    }
}
