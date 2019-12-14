using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sack
{
    public class Sack
    {
        private readonly IList<object> objects = new List<object>();
        private readonly Random rand = new Random();

        public void Add(object obj)
        {
            objects.Add(obj);
        }

        public object Retrieve()
        {
            int selectedIndex = rand.Next(0, objects.Count);

            return objects[selectedIndex];
        }

        public object Remove()
        {
            int selectedIndex = rand.Next(0, objects.Count);

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
