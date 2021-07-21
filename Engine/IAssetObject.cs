using System.Collections.Generic;

namespace SnakeConsole
{
    public interface IObject
    {
        Queue<Location> LocationList { get; set; }
    }
}