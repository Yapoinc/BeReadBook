using Model.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlRepository
{
    public class TestData
    {
        private readonly AppContext appContext;
        private Random rnd = new Random();

        public TestData()
        {
            appContext = new AppContext();
        }

        public List<Test> GetData() { 
            var p1 = appContext.Test.ToList();
            return appContext.Test.ToList();        
        }
        public void SetNewData(string name)
        {
            var newTest = new Test { Name= name + rnd.Next(int.MaxValue) };
            appContext.Test.Add(newTest);
            appContext.SaveChanges();
                
            
        }

    }
}
