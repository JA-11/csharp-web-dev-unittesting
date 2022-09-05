using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public int NumberOfPictures { get; set; }

        public SmartPhone(double ram, double storage, bool hasKeyboard, int numberOfPictures) : base(ram, storage, hasKeyboard)
        {
            NumberOfPictures = numberOfPictures;
        }

        public int TakePicture()
        {
            NumberOfPictures++;
            return NumberOfPictures;
        }
    }
}
