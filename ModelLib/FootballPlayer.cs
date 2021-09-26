using System;

namespace ModelLib
{
    public class FootballPlayer
    {
        private int _id;
        private string _name;
        private double _price;
        private int _shirtNumber;

        public FootballPlayer(int id, string name, double price, int shirtNumber)
        {
            _id = id;
            if (!(name.Length >= 4))
            {
                throw new ArgumentException("Name must be minimum 4 letters or more");
            }
            _name = name;
            if (!(price > 0))
            {
                throw new ArgumentException("Price must be above 0");
            }
            _price = price;
            if (!(shirtNumber >= 1 && shirtNumber <= 100))
            {
                throw new ArgumentException("Number must be beetween 1 and 100");
            }
            _shirtNumber = shirtNumber;
        }
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (!(value.Length >= 4))
                {
                    throw new ArgumentException("Name must be minimum 4 letters or more");
                }
                _name = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (!(value > 0))
                {
                    throw new ArgumentException("Price must be above 0");
                }
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (!(value >= 1 && value <= 100))
                {
                    throw new ArgumentException("Number must be beetween 1 and 100");
                }
                _shirtNumber = value;
            }
        }
    }
}
