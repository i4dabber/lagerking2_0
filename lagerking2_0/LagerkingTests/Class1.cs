using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lagerking;
using lagerking.Model;
using Xunit;


namespace LagerkingTests
{

    public class Databasetests
    {

        [Fact]
        public void AddCommandCalled()
        {
   
            Commands ctx = new Commands();
            ctx.Name = "UnitTest";
            ctx.Price = 99;
            ctx.Stock = 99;
            ctx.Description = "Unit Test";

            ctx.AddCommand.CanExecute(true);
            ctx.AddCommand.Execute(null);


           

        }
    }
}
