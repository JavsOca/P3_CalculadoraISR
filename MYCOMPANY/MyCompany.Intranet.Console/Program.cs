using System;
using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Managers;
using MyCompany.Intranet.Core.Services;


namespace MyCompany.Intranet.Console;

public static class Program {
    public static void Main(string[] args){

        float sueldo = 0;

        System.Console.WriteLine("Introduce tu sueldo");
        Single.TryParse(System.Console.ReadLine(), out sueldo);

        var person = new Person{Sueldo = sueldo};

        var service = new IsrService();
        var managers = new IsrManager(service);

        ISR isr = managers.GetImpuesto(person);

        System.Console.WriteLine($"El impuesto a pagar es ${isr.Impuestos}");

    }
}