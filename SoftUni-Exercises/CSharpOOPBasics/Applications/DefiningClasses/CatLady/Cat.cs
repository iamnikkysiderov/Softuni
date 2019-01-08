using System;
using System.Collections.Generic;
using System.Text;

namespace CatLady
{
    class Cat
    {
        private string name;
        private string breed;
        private decimal specificCharacteristic;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public decimal SpecificCharacteristic
        {
            get { return this.specificCharacteristic; }
            set { this.specificCharacteristic = value; }
        }

        public override string ToString()
        {
            return $"{Breed} {Name} {SpecificCharacteristic}";
        }
    }
}
