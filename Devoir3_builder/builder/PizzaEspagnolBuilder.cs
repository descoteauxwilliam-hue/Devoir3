using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public class PizzaEspagnolBuilder : IBuilder
    {
        Pizza pizza;

        public PizzaEspagnolBuilder()
        {
            this.pizza = new Pizza();
        }
        IBuilder IBuilder.makeDough()
        {
            this.pizza.setPate("espagnol");
            return this;
        }

        IBuilder IBuilder.makeSauce()
        {
            this.pizza.setSauce("espagnol");
            return this;
        }

        IBuilder IBuilder.makeToppings()
        {
            this.pizza.setGarniture("espagnol");
            return this;
        }
        public Pizza make()
        {
            return this.pizza;
        }
    }
}
