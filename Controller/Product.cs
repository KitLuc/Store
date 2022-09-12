using Store.models;
using System;
using System.Windows.Forms;

namespace Store.Controller
{
    public class Product
    {
        daoCRUD _DaoProductCRUD = new daoCRUD();


        // Create
        public void Create(Components ProductCreate)
        {
            try
            {
                _DaoProductCRUD.Create(ProductCreate);
            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un problema tipo: " + ex);
            }
        }

        // Read
        public void Read(DataGridView tableGrid)
        {
            try
            {
	            _DaoProductCRUD.Read();
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
	
	
	            for (int i = 0; i < _DaoProductCRUD.Size(); i++)
	            {
	                f = _table.Rows.Add();
	                _table.AutoResizeColumns();
	
	                _table.Rows[f].Cells[0].Value = _DaoProductCRUD.Element(i).IdClothing;
	                _table.Rows[f].Cells[1].Value = _DaoProductCRUD.Element(i).NameClothing;
	                _table.Rows[f].Cells[2].Value = _DaoProductCRUD.Element(i).DescriptionClothing;
	                _table.Rows[f].Cells[3].Value = _DaoProductCRUD.Element(i).Gender;
	                _table.Rows[f].Cells[4].Value = _DaoProductCRUD.Element(i).Color;
	                _table.Rows[f].Cells[5].Value = _DaoProductCRUD.Element(i).Size;
	                _table.Rows[f].Cells[6].Value = _DaoProductCRUD.Element(i).Value;
	                _table.Rows[f].Cells[7].Value = _DaoProductCRUD.Element(i).Marca;
	            }
            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un problema tipo: " + ex);
            }
        }

        // Update
        public void Update(Components ProductUpdate)
        {
            try
            {
                _DaoProductCRUD.Update(ProductUpdate);
            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un problema tipo: " + ex);
            }
        }

        // Delete
        public void Delete(int id)
        {
            try
            {
                _DaoProductCRUD.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un problema tipo: " + ex);
            }
        }

    }
}

