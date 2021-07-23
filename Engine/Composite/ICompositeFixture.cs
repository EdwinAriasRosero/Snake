using System.Collections.Generic;

namespace Engine
{
    public interface ICompositeFixture
    {
        DrawingFixture Parent { get; set; }
        List<DrawingFixture> Children { get; set; }
    }

}