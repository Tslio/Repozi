using Cars_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Library
{
    public class Car : IComparable<Car>
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public string VIN { get; }
        public CarBodyType BodyType { get; set; }
        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; }
        public string BuyerFullName { get; set; }
        public Car(string brand, int year, string vin, CarBodyType bodyType, decimal price, DateTime saleDate, string buyerFullName)
        {
            Brand = brand;
            Year = year;
            VIN = vin;
            BodyType = bodyType;
            Price = price;
            BuyerFullName = buyerFullName;
            SaleDate = saleDate;
        }
        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"{Brand} ({Year}) - VIN: {VIN}";
            info[1] =
                $"Тип кузова: {BodyType}. Цена: {Price:C}. " +
                $"Дата продажи: {SaleDate:d}. " +   
                $"Покупатель: {BuyerFullName}.";
            return info;
        }
        public int CompareTo(Car other)
        {
            if (Brand != other.Brand)
                return Brand.CompareTo(other.Brand);
            else
                return Price.CompareTo(other.Price);
        }
    }
}
