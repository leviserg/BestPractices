using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    public class SingletonExample
    {

        // 1. private constructor
        // 2. private static field with type of self Class
        // 3. public static readonly property that returns instance of Class or create new if not created before

        private static SingletonExample _instance;
        private SingletonExample() { }

        public static SingletonExample Instance
        {
            get { 
                if(_instance is null)
                {
                    _instance = new SingletonExample();
                }
                return _instance;
            }
        }


    }
}
