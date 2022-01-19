using MyWebsite.Business.Abstract;
using MyWebsite.Business.ServiceAdapters;
using MyWebsite.Core.Entities.Concrete;
using System;

namespace MyWebsite.ConsoleUI
{
    class Program
    {   
        static void Main(string[] args)
        {
            Person person = new Person();
            person.BirthOfDay = new DateTime(1994,11,03);
            person.FirstName = "Hasan Cantürk";
            person.LastName = "ATAŞ";
            person.IdentityNumber="21509487444";
            MernisServiceAdapter adapter = new MernisServiceAdapter();
            var result = adapter.CheckIfUserRealPerson(person);
           
            Console.WriteLine(result);           
        }
        
    }
}
