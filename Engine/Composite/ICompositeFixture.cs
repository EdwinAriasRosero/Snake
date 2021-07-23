using System.Collections.Generic;

namespace SnakeConsole
{
    public interface ICompositeFixture
    {
        DrawingFixture Parent { get; set; }
        List<DrawingFixture> Children { get; set; }
    }

}