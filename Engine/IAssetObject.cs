using System.Collections.Generic;

namespace SnakeConsole
{
    public interface IAssetObject
    {
        Queue<Location> LocationList { get; set; }
    }
}