using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sack
{
    public class Sack
    {
        private List<object> objects;

        public Sack()
        {
            objects = new List<object>();
        }

        public void Add<T>(T obj)
        {
            objects.Add(obj);
        }

        public object Retrieve()
        {
            int numberObjects = objects.Count;

            Random rand = new Random();
            int selectedIndex = rand.Next(0, numberObjects);

            return objects[selectedIndex];
        }

        public object Remove()
        {
            int numberObjects = objects.Count;

            Random rand = new Random();
            int selectedIndex = rand.Next(0, numberObjects);

            object selectedObject = objects[selectedIndex];
            objects.RemoveAt(selectedIndex);

            return selectedObject;
        }

        public void Empty()
        {
            objects.Clear();
        }
    }
}
