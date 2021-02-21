﻿using System;
using System.Globalization;

namespace Comparison_Treino1.Entities {
    class Product {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public override string ToString() {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(Product other) {
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }
    }
}
