using ComponentFactory.Krypton.Toolkit;
using Store.Controller;
using Store.models;
using System;
using System.Windows.Forms;

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

        // btn_Save_Click
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // if authcomponents
                if (authComponents())
                {
                    Components dtoComponent = new Components();
                    dtoComponent.IdClothing = Convert.ToInt32(textId.Text);
                    dtoComponent.NameClothing = textName.Text.Trim();
                    dtoComponent.DescriptionClothing = textDescript.Text.Trim();
                    dtoComponent.Gender = boxGender.SelectedItem.ToString();
                    dtoComponent.Color = textColor.Text.ToString();
                    dtoComponent.Size =  Convert.ToChar(boxSize.SelectedItem.ToString());
                    dtoComponent.Value = textPrice.Text.Trim();
                    dtoComponent.Marca = textMarca.Text.Trim();
                    
                    ctProduct.Create(dtoComponent);
                    MessageBox.Show("Producto creado con exito");
                }
                else
                {
                    MessageBox.Show("Faltan datos por llenar");
                }
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

        // Open Form Create
        private void btn_Create_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
            this.Hide();
        }

        // Open Form List
        private void btn_listar_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.Show();
            this.Hide();
        }

        // Open Form Update
        private void btn_update_delet_Click(object sender, EventArgs e)
        {
            UpdateDelet update = new UpdateDelet();
            update.Show();
            this.Hide();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }


        // auth Components
        private bool authComponents()
        {
            return !(textId.Text.Trim() == "" || 
                     textName.Text.Trim() == "" || 
                     textDescript.Text.Trim() == "" ||
                     textColor.Text.Trim() == "" ||
                     textPrice.Text.Trim() == "" || 
                     textMarca.Text.Trim() == "" ||
                     boxGender.SelectedIndex.ToString() == "" ||
                     boxSize.SelectedIndex.ToString() == ""
                    );
        }

        // Clean Components
        private void cleanComponents()
        {
            textId.Clear();
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
