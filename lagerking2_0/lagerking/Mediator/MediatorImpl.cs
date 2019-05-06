using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lagerking
{
    static public class MediatorImpl
    {
        static IDictionary<string, List<Action<object>>> listObjects = new Dictionary<string, List<Action<object>>>();


        static public void NotifyColleagues(string msg, object args)
        {
            
            if (listObjects.ContainsKey(msg))
                foreach (var raise in listObjects[msg])
                    raise(args);
        }
    }
}
