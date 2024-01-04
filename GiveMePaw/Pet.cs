using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMePaw
{
    class Pet
    {
        public string Pet_type { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }
        public string Breed { get; set; }
        public string Photo { get; set; }

        public Pet(string pet_type, string name, string age, string weight, string breed, string photo)
        {
            Pet_type = pet_type;
            Name = name;
            Age = age;
            Weight = weight;
            Breed = breed;
            Photo = photo;
        }
    }
}
