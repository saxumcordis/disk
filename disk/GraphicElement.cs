using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disk
{
    class GraphicElement
    {
        public Size size { get; set; }
        public Point location { get; set; }
        public Image image { get; set; }
        public GraphicElement() { }
        public GraphicElement(Size size, Point location, Image image)
        {
            this.size = size;
            this.location = location;
            this.image = image;
        }
        public List<GraphicElement> GraphicElements = new List<GraphicElement>();
    }
}
