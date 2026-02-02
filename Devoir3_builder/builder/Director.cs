using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public Pizza make()
        {
            return builder.makeDough()
                          .makeSauce()
                          .makeToppings()
                          .make();
        }
    }
}
