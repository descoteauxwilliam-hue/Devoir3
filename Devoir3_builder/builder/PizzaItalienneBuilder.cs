using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public class PizzaItalienneBuilder : IBuilder
    {
        Pizza pizza;

        public PizzaItalienneBuilder()
        {
            this.pizza = new Pizza();
        }
        IBuilder IBuilder.makeDough()
        {
            this.pizza.setPate("italien");
            return this;
        }

        IBuilder IBuilder.makeSauce()
        {
            this.pizza.setSauce("italien");
            return this;
        }

        IBuilder IBuilder.makeToppings()
        {
            this.pizza.setGarniture("italien");
            return this;
        }
        public Pizza make()
        {
            return this.pizza;
        }
    }
}

