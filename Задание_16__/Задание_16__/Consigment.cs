using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_16__
{
    public struct Consigment
    {
        private int quantity;
        private double price;
        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество не может быть отрицательным");

                quantity = value;
            }
        }
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Цена не может быть отрицательной");
                price = Math.Round(value, 2);
            }
        }
        public double Cost
        {
            get => Math.Round(Quantity * Price, 2);
        }
        public Consigment(int quantity, double price) : this()
        {
            Quantity = quantity;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Quantity} шт. по {Price.ToString("F2", CultureInfo.InvariantCulture)} руб.";
        }
        public override bool Equals(object obj)
        {
            if (obj is Consigment c)
            {
                return Quantity == c.Quantity &&
                       Price == c.Price;
            }
            throw new ArgumentException("Объект не является партией товара");
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                const int p = 23;
                hash = hash * p + Quantity.GetHashCode();
                hash = hash * p + Price.GetHashCode();
                return hash;
            }
        }
        public static bool operator ==(Consigment x, Consigment y)
            => x.Equals(y);

        public static bool operator !=(Consigment x, Consigment y)
            => !x.Equals(y);
        public static Consigment operator +(Consigment x, Consigment y)
        {
            if (x.Price != y.Price)
                throw new ArgumentException("Цены должны совпадать");
            return new Consigment(x.Quantity + y.Quantity, x.Price);
        }
        public static Consigment operator -(Consigment x, Consigment y)
        {
            if (x.Price != y.Price)
                throw new ArgumentException("Цены должны совпадать");
            if (x.Quantity < y.Quantity)
                throw new ArgumentException("Нельзя вычесть бо'льшее количество товара");
            return new Consigment(x.Quantity - y.Quantity, x.Price);
        }
    }
}
