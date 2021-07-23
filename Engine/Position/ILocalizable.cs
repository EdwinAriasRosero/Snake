using System.Collections.Generic;

namespace Engine
{
    public interface ILocalizable
    {
        void Move(Location location);
        
        LinkedList<Location> LocationList { get; set; }
    }
}