using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public class PizzaEspagnolBuilder : IPizzaBuilder
    {
        Pizza pizza;

        public PizzaEspagnolBuilder()
        {
            this.pizza = new Pizza();
        }
        public IPizzaBuilder makeDough()
        {
            this.pizza.setPate("pate espagnol");
            return this;
        }

        public IPizzaBuilder makeSauce()
        {
            this.pizza.setSauce("sauce espagnol");
            return this;
        }

        public IPizzaBuilder makeToppings()
        {
            this.pizza.setGarniture("garnitures espagnol");
            return this;
        }
        public Pizza make()
        {
            return this.pizza;
        }

    }
}
