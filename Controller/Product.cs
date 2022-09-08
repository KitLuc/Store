using Store.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  

namespace Store.Controller
{
    public class Product
    {
        
        daoCRUD _DaoProducts = new daoCRUD();

        public void Create(Components CompSave)
        {
            try
            {
                _DaoProducts.Save(CompSave);
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex);
            }
        }

        public void Read(DataGridView tableGrid)
        {
            _DaoProducts.ReadData();
            int f;
            var _table = tableGrid;
            _table.Rows.Clear();
            _table.ColumnCount = 8;
            
            _table.Columns[0].HeaderText = "ID";
            _table.Columns[1].HeaderText = "Nombre";
            _table.Columns[2].HeaderText = "Descripcion";
            _table.Columns[3].HeaderText = "Genero";
            _table.Columns[4].HeaderText = "Color";
            _table.Columns[5].HeaderText = "Tamaño";
            _table.Columns[6].HeaderText = "Precio";
            _table.Columns[7].HeaderText = "Marca";


            for (int i = 0; i < _DaoProducts.Size(); i++)
            {
                f = _table.Rows.Add();
                _table.AutoResizeColumns();

                _table.Rows[f].Cells[0].Value = _DaoProducts.Element(i).IdClothing;
                _table.Rows[f].Cells[1].Value = _DaoProducts.Element(i).NameClothing;
                _table.Rows[f].Cells[2].Value = _DaoProducts.Element(i).DescriptionClothing;
                _table.Rows[f].Cells[3].Value = _DaoProducts.Element(i).Gender;
                _table.Rows[f].Cells[4].Value = _DaoProducts.Element(i).Color;
                _table.Rows[f].Cells[5].Value = _DaoProducts.Element(i).Size;
                _table.Rows[f].Cells[6].Value = _DaoProducts.Element(i).Value;
                _table.Rows[f].Cells[7].Value = _DaoProducts.Element(i).Marca;
            }
        }


        /*public String Update(Components Update, int IdClothing) 
        {
            try
            {
                _DaoProducts.Update(Update, IdClothing);
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex);
            }
        }*/

        /*public void Delet(int IdClothing)
        {
            try
            {
                _DaoProducts.Delet(IdClothing);
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex);
            }
        }*/


        public void Update()
        { 
        }

        public void Delet()
        { 
        }
    }
}
