using System.Collections.Generic;
using System.Linq;

namespace SnakeConsole
{
    public abstract class DrawObject : IDrawer
    {
        public DrawObject Parent { get; set; }

        protected readonly IDrawing Drawing;

        public DrawObject()
        {
            LocationList = new Queue<Location>();
            Drawing = new Drawing();
        }

        public Queue<Location> LocationList { get; set; }

        public Location Location
        {
            get
            {
                return LocationList.ElementAt(0);
            }
        }

        public abstract void Draw();
    }

}