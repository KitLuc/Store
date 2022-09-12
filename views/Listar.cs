using ComponentFactory.Krypton.Toolkit;
using Store.Controller;
using System;

namespace Store.views
{
    public partial class List : KryptonForm
    {
        Product ctProduct = new Product();


        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            // Read
            ctProduct.Read(DataGriedView);
        }
    }
}
