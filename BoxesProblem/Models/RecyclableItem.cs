using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.BoxesProblem.Models
{
    public class RecyclableItem : IItem
    {
        public string Name { get; set ; }
        public int Weight { get; set; }
        public int Size { get; set; }

        public RecyclableItem(string Name, int Weight, int Size) { 
            this.Name = Name;
            this.Weight = Weight;
            this.Size = Size;
        }
    }
}
