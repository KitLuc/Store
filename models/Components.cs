using System;

namespace Store.models
{
    public class Components
    {
        public int IdClothing { get; set; }
        public String NameClothing { get; set; }
        public String DescriptionClothing { get; set; }
        public String Gender { get; set; }
        public String Color { get; set; }
        public Char Size { get; set; }
        public String Value { get; set; }
        public String Marca { get; set; }

        
        public Components(){}

        public Components(int IdClothing,
                          String NameClothing,
                          String DescriptionClothing,
                          String Gender,
                          String Color,
                          Char Size,
                          String Value,
                          String Marca
                        )
        {
            this.IdClothing = IdClothing;
            this.NameClothing = NameClothing;
            this.DescriptionClothing = DescriptionClothing;
            this.Gender = Gender;
            this.Color = Color;
            this.Size = Size;
            this.Value = Value;
            this.Marca = Marca;
        }
    }
}
