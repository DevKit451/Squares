using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Squares
{
    public class NamedColor
    {
        public String Name { get; set; }
        public Color Color { get; set; }

        public NamedColor (string name, Color color)
        {
            this.Name = name;
            this.Color = color;
        }
    }
}
