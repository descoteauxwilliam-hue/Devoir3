using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public interface IBuilder
    {
        IBuilder makeDough();
        IBuilder makeSauce();
        IBuilder makeToppings();

        Pizza make();
    }
}
