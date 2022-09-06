using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Store.Controller;
using Store.models;


namespace Store.views
{
    public partial class Create : KryptonForm
    {
        Product ctProduct = new Product();

        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (AuthComponents())
            {
                Components dtoComponent = new Components();
                try
                {
                    dtoComponent.IdClothing = Convert.ToInt16(textId.Text.Trim());
                    dtoComponent.NameClothing = textName.Text.Trim();
                    dtoComponent.DescriptionClothing = textDescript.Text.Trim();
                    dtoComponent.Gender = boxGender.SelectedItem.ToString();
                    dtoComponent.Color = textColor.Text.Trim();
                    dtoComponent.Size = Convert.ToChar(boxSize.SelectedItem);
                    dtoComponent.Value = Convert.ToDouble(textPrice.Text.Trim());
                    dtoComponent.Marca = textMarca.Text.Trim();
                    ctProduct.Save(dtoComponent);
                }
                catch (Exception ex)
                {
                    throw new Exception("" + ex);
                }
            }

            textId.Clear();
            textName.Clear();
            textDescript.Clear();
            textColor.Clear();
            textPrice.Clear();
            textMarca.Clear();
        }

        private bool AuthComponents() 
        {
            return !(textId.Text.Trim() == "" || textName.Text.Trim() == "" || textDescript.Text.Trim() == "" || boxGender.SelectedItem.ToString() == "" || textColor.Text.Trim() == "" || boxSize.SelectedItem.ToString() == "" || textPrice.Text.Trim() == "" || textMarca.Text.Trim() == "");
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
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

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }
}
