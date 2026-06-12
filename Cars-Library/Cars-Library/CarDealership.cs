using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Library
{
    public class CarDealership : IEnumerable<Car>
    {
        public string Title { get; set; }
        public string Address { get; set; }
        private List<Car> cars;
        public int Count
        {
            get => cars.Count;
        }

        public CarDealership(
            string title,
            string address,
            IEnumerable<Car> collection)
        {
            Title = title;

            Address = address;

            cars = new List<Car>();

            foreach (var car in collection)
            {
                if (!cars.Contains(car))
                    cars.Add(car);
            }
        }
        public IEnumerator<Car> GetEnumerator() =>
            cars.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() =>
            GetEnumerator();
    }
}
