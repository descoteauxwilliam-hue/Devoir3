using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public interface IPizzaBuilder
    {
        public IPizzaBuilder makeDough();
        public IPizzaBuilder makeSauce();
        public IPizzaBuilder makeToppings();

        public Pizza make();
    }
}
