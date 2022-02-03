using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aditionalTask
{
    struct Notebook
    {
        public readonly string Model, Manufacturer;
        public readonly double Price;

        public Notebook(string model, string manufacturer, double price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override string ToString() => $"Model: {Model};\nManufacturer: {Manufacturer};\nPrice: {Price};";
    }
}
