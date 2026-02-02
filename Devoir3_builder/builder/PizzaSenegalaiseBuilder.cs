using Devoir3_builder.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.builder
{
    public class PizzaSenegalaiseBuilder : IBuilder
    {
        Pizza pizza;
        public PizzaSenegalaiseBuilder()
        {
            pizza = new Pizza();
        }
        IBuilder IBuilder.makeDough()
        {
            this.pizza.setPate("senegalaise");
            return this;
        }

        IBuilder IBuilder.makeSauce()
        {
            this.pizza.setSauce("senegalaise");
            return this;
        }

        IBuilder IBuilder.makeToppings()
        {
            this.pizza.setGarniture("senegalaise");
            return this;
        }
        public Pizza make()
        {
            return this.pizza;
        }
    }
}
