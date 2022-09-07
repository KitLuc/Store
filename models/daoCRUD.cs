using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Store.models
{
    public class daoCRUD
    {
        List<Components> DataBaseComponents = new List<Components>();
        

        /*
                public void Delet(int id)
                {
                    try
                    {
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("" + ex);
                    }
                }


                public void Update(Components DataComponents, int id)
                {
                    try
                    {
                        Delet(id);
                        DataBaseComponents.Insert(id,DataComponents);
                        WriteData(DataBaseComponents);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("" + ex);
                    }
                }*/





        private void CreateData(List<Components> DataListWrite)
        {
            StreamWriter sw = new StreamWriter("SQL.txt");
            FileStream filePath = File.Open(AppDomain.CurrentDomain.BaseDirectory + "productsSQL.txt", FileMode.Create, FileAccess.ReadWrite);

            try
            {
                foreach (Components dtlWrite in DataListWrite)
                {
                    String text = Convert.ToInt16(dtlWrite.IdClothing) + "," +
                                  Convert.ToString(dtlWrite.NameClothing) + "," +
                                  Convert.ToString(dtlWrite.DescriptionClothing) + "," +
                                  Convert.ToString(dtlWrite.Gender) + "," +
                                  Convert.ToString(dtlWrite.Color) + "," +
                                  Convert.ToChar(dtlWrite.Size) + "," +
                                  Convert.ToString(dtlWrite.Value) + "," +
                                  Convert.ToString(dtlWrite.Marca);
                    sw.WriteLine(text + "\n");
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex);
            }
            finally
            {
                sw.Close();
                filePath.Close();
            }
        }


        public List<Components> ReadData()
        {
            DataBaseComponents.Clear();
            Components datasComponent = new Components();
            StreamReader sr = new StreamReader("productsSQL.txt");
            String[] ArrayData = null;

            try
            {
                while (!sr.EndOfStream)
                {
                    ArrayData = sr.ReadLine().Split(',');
                    datasComponent.IdClothing = Convert.ToInt16(ArrayData.ElementAt(0));
                    datasComponent.NameClothing = ArrayData.ElementAt(1);
                    datasComponent.DescriptionClothing = ArrayData.ElementAt(2);
                    datasComponent.Gender = ArrayData.ElementAt(3);
                    datasComponent.Color = ArrayData.ElementAt(4);
                    datasComponent.Size = Convert.ToChar(ArrayData.ElementAt(5));
                    datasComponent.Value = ArrayData.ElementAt(6);
                    datasComponent.Marca = ArrayData.ElementAt(7);

                    DataBaseComponents.Add(datasComponent);
                }
            }
            catch (EndOfStreamException ex)
            {
                throw new Exception("Error tipo: " + ex);
            }
            finally
            {
                sr.Close();
            }
            return DataBaseComponents;
        }

        private void UpdateData(int id)
        { 
        }

        private void DeletData(int id)
        { 
        }




        public void Save(Components DataComponents)
        {
            DataBaseComponents.Add(DataComponents);
            CreateData(DataBaseComponents);
        }


        public int Size()
        {
            return DataBaseComponents.Count();
        }

        public Components Element(int id)
        {
            return DataBaseComponents.ElementAt(id);
        }
    }
}
