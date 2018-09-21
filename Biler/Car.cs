using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biler
{
    class Car
    {
        private String _brand;
        private String _model;
        private int _year;
        private bool _benzin;
        private String _colour;
        private String _licenseplate;

        public Car(String brand, String model, int year)
        {
            _brand = brand;
            _model = model;
            _year = year;
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public string Licenseplate
        {
            get { return _licenseplate; }
            set { _licenseplate = value; }
        }

        public string Brand
        {
            get { return _brand; }
        }

        public string Model
        {
            get { return _model; }
        }

        public int Year
        {
            get { return _year; }
        }

        public bool Benzin
        {
            get { return _benzin; }
        }

        public double Drive()
        {

            return 1;
        }

        public void Gear()
        {

        }
    }
}
