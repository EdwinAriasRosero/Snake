using System.Collections.Generic;

namespace SnakeConsole
{
    public interface IObject
    {
        Queue<Position> Position { get; set; }
    }
}