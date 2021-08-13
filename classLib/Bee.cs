using System.Collections.Generic;
using Beez.classLib;
namespace Beez.classLib
{
    public class Bee
    {
        public string Name {get;set;}
        public float Size {get;set;}


        // decimal values, use float instead of int
        public Bee(string name, float size)
        {
        this.Name = name;
        this.Size = size;
        }
    }
}