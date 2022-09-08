using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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





        private void CreateData(List<Components> ComponentsWrite)
        {
            FileStream filePath = File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\productsSQL.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(filePath);
            
            try
            {
                foreach (Components fileWrite in ComponentsWrite)
                {
                    String textString = 
                        Convert.ToInt16(fileWrite.IdClothing) + "|" +
                        Convert.ToString(fileWrite.NameClothing) + "|" +
                        Convert.ToString(fileWrite.DescriptionClothing) + "|" +
                        Convert.ToString(fileWrite.Gender) + "|" +
                        Convert.ToString(fileWrite.Color) + "|" +
                        Convert.ToChar(fileWrite.Size) + "|" +
                        Convert.ToString(fileWrite.Value) + "|" +
                        Convert.ToString(fileWrite.Marca);
                    sw.WriteLine(textString);
                }
                
                sw.Close();
                filePath.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex);
            }
        }


        public List<Components> ReadData()
        {
            StreamReader sr = new StreamReader("productsSQL.txt");
            DataBaseComponents.Clear();
            Components datasComponent = new Components();
            String[] ArrayData = null;
            
            try
            {
                while (!sr.EndOfStream)
                {
                    ArrayData = sr.ReadLine().Split('|');
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
                sr.Close();
            }
            catch (EndOfStreamException ex)
            {
                throw new Exception("Error tipo: " + ex);
            }
            return DataBaseComponents;
        }

        private void UpdateData(int id)
        { 
        }

        private void DeletData(int id)
        { 
        }


        public void Save(Components CompSave)
        {
            DataBaseComponents.Add(CompSave);
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
