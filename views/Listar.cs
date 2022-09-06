using Store.Controller;
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
    public partial class List : KryptonForm
    {
        Product ctProduct = new Product();
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            ctProduct.View(DataGriedView);
        }
    }
}
