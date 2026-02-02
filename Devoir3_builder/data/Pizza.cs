using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.data
{
    public class Pizza
    {
        string pate;
        string sauce;
        string garnitures;

        public void setPate(string pate)
        {
            this.pate = pate;
        }
        public void setSauce(string sauce)
        {
            this.sauce = sauce;
        }
        public void setGarniture(string garnitures)
        {
            this.garnitures = garnitures;
        }

        public override string ToString() // pour tester
        {
            return $"{pate}, {sauce}, {garnitures}";
        }
    }
}
