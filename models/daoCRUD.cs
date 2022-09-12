using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Store.models
{
    public class daoCRUD
    {
        // Create list of products and customers to store data in memory
        List<Components> DataBaseComponents = new List<Components>();

        // CRUD
        private void CreateDataBase(List<Components> ComponentsWrite)
        {
            // Write data to file
            using (FileStream filePath = new FileStream("productsSQL.txt", FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    try
                    {
                        foreach (Components fileWrite in ComponentsWrite)
                        {
                            String newTextLine = Convert.ToInt16(fileWrite.IdClothing)
                                + "|" + Convert.ToString(fileWrite.NameClothing)
                                + "|" + Convert.ToString(fileWrite.DescriptionClothing)
                                + "|" + Convert.ToString(fileWrite.Gender)
                                + "|" + Convert.ToString(fileWrite.Color)
                                + "|" + Convert.ToChar(fileWrite.Size)
                                + "|" + Convert.ToString(fileWrite.Value)
                                + "|" + Convert.ToString(fileWrite.Marca);
                            sw.WriteLine(newTextLine);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Hubo un problema tipo: " + ex);
                    }
                    finally
                    {
                        sw.Close();
                        filePath.Close();
                    }
                }
            }
        }

        private List<Components> ReadDataBase()
        {
            // Read data from file
            using (FileStream filePath = File.Open(
                                        AppDomain.CurrentDomain.BaseDirectory
                                        + "\\productsSQL.txt", FileMode.Open,
                                        FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    try
                    {
                        String line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            String[] lineSplit = line.Split('|');
                            Components newComponent = new Components();
                            newComponent.IdClothing = Convert.ToInt16(lineSplit[0]);
                            newComponent.NameClothing = lineSplit[1];
                            newComponent.DescriptionClothing = lineSplit[2];
                            newComponent.Gender = lineSplit[3];
                            newComponent.Color = lineSplit[4];
                            newComponent.Size = Convert.ToChar(lineSplit[5]);
                            newComponent.Value = Convert.ToString(lineSplit[6]);
                            newComponent.Marca = lineSplit[7];
                            DataBaseComponents.Add(newComponent);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Hubo un problema tipo: " + ex);
                    }
                    finally
                    {
                        sr.Close();
                        filePath.Close();
                    }
                }
            }
            return DataBaseComponents;
        }


        private void UpdateDataBase(Components newComponent)
        {
            // UpdateDataBase(new Components(1, "Camisa", "Camisa de algodon", "M", "Azul", 'M', 10000, "Nike"));
            ReadDataBase();
            Components oldComponent = DataBaseComponents.Find(x => x.IdClothing == newComponent.IdClothing);
            oldComponent.NameClothing = newComponent.NameClothing;
            oldComponent.DescriptionClothing = newComponent.DescriptionClothing;
            oldComponent.Gender = newComponent.Gender;
            oldComponent.Color = newComponent.Color;
            oldComponent.Size = newComponent.Size;
            oldComponent.Value = newComponent.Value;
            oldComponent.Marca = newComponent.Marca;
            CreateDataBase(DataBaseComponents);
        }

        // DeleteDataBase id
        private void DeleteDataBase(int id)
        {
            ReadDataBase();
            Components oldComponent = DataBaseComponents.Find(x => x.IdClothing == Convert.ToInt16(id));
            DataBaseComponents.Remove(oldComponent);
            CreateDataBase(DataBaseComponents);
        }


        /**
         *  CRUD with funcionts lambda
         */

        public void Create(Components newComponent) => CreateDataBase(new List<Components> { newComponent });
        public List<Components> Read() => ReadDataBase();
        public void Update(Components newComponent) => UpdateDataBase(newComponent);
        public void Delete(int id) => DeleteDataBase(id);

        // References
        public Components Element(int index) => DataBaseComponents.ElementAt(index);
        public int Size() => DataBaseComponents.Count();
    }
}