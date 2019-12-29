using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sack
{
    public class Sack
    {
        private readonly List<object> objects = new List<object>();
        private readonly Random rand = new Random();

        public void Add(object obj)
        {
            objects.Add(obj);
        }

        public object Retrieve(bool remove)
        {
            int selectedIndex = rand.Next(0, objects.Count);

            object selectedObject = objects[selectedIndex];
            
            if (remove)
            {
                objects.RemoveAt(selectedIndex);
            }

            return selectedObject;
        }
        
        public void Clear()
        {
            objects.Clear();
        }

        public List<object> Empty()
        {
            List<object> returnList = new List<object>();
            foreach (var obj in objects)
            {
                returnList.Add(obj);
            }
            Clear();

            return returnList;
        }
    }
}
