using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public class PizzaColombienneBuilder : IBuilder
    {
        Pizza pizza;

        public PizzaColombienneBuilder()
        {
            this.pizza = new Pizza();
        }

        IBuilder IBuilder.makeDough()
        {
            this.pizza.setPate("colombienne");
            return this;
        }

        IBuilder IBuilder.makeSauce()
        {
            this.pizza.setSauce("colombienne");
            return this;
        }

        IBuilder IBuilder.makeToppings()
        {
            this.pizza.setGarniture("colombienne");
            return this;
        }

        public Pizza make()
        {
            return this.pizza;
        }

    }
}
