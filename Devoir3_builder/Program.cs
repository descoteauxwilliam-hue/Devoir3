// See https://aka.ms/new-console-template for more information
using Devoir3_builder.builder;
using Devoir3_builder.data;
using System.Diagnostics;

test();


void test()
{
    Director director;
    Pizza pizza;

    //colombienne
    PizzaColombienneBuilder colombienneBuilder = new PizzaColombienneBuilder();
    director = new Director(colombienneBuilder);
    pizza = director.make();

    Debug.Assert("colombienne, colombienne, colombienne" == pizza.ToString());

    //italien
    PizzaItalienneBuilder italienBuilder = new PizzaItalienneBuilder();
    director = new Director(italienBuilder);
    pizza = director.make();

    Debug.Assert("italien, italien, italien" == pizza.ToString());

    //espagnol
    PizzaEspagnolBuilder espagnolBuilder = new PizzaEspagnolBuilder();
    director = new Director(espagnolBuilder);
    pizza = director.make();

    Debug.Assert("espagnol, espagnol, espagnol" == pizza.ToString());
    
    //senegalaise
    PizzaSenegalaiseBuilder senegalBuilder = new PizzaSenegalaiseBuilder();
    director = new Director(senegalBuilder);
    pizza = director.make();

    Debug.Assert("senegalaise, senegalaise, senegalaise" == pizza.ToString());
}