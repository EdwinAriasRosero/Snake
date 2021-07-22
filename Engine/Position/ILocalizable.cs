using System.Collections.Generic;

namespace SnakeConsole
{
    public interface ILocalizable
    {
        void Move(Location location);
        
        LinkedList<Location> LocationList { get; set; }
    }
}