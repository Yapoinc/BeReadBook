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
        public List<Test> GetData() { 
            var appContext = new AppContext();
            var p1 = appContext.Test.ToList();
            return appContext.Test.ToList();        
        }
    }
}
