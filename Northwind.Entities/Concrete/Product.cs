using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.Concrete
{
    public class Product : IEntity
    {
        [DisplayName("Produkt Id")]
        public int ProductId { get; set; }
        [DisplayName("Produktname")]
        public string ProductName { get; set; }
        [DisplayName("Kategorie Id")]
        public int CategoryId { get; set; }
        [DisplayName("Stückpreis")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Anzahl pro Einheit")]
        public string QuantityPerUnit { get; set; }
        [DisplayName("Stock")]
        public Int16 UnitsInStock { get; set; }
    }
}
