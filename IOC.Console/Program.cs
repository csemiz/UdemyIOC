// See https://aka.ms/new-console-template for more information


using IOC.Console;

BL bl = new BL(new OracleDAL());
//BL bl = new BL(ne w  DAL());

bl.GetProducts().ForEach(x =>
    {
        Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}");

    });


Console.ReadLine();