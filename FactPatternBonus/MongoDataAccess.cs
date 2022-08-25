using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactPatternBonus
{
    public class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine();
            Console.WriteLine("I am reading data from mongo database.");
            var products = new List<IDataAccess>();
        }

        public void SaveData()
        {
            Console.WriteLine();
            Console.WriteLine("I am saving data to mongo database.");
        }
    }
}
