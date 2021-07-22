namespace SnakeConsole
{
    public interface IDrawer
    {
        void Draw(DrawingFixture parent, int left, int top, string symbol);

        void SetBoardDimension(int width, int height);

        void SetText(int x, int y, string text);
    }
}