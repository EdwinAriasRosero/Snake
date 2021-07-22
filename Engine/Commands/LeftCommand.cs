using System.Linq;

namespace SnakeConsole
{
    public class LeftCommand : ICommand
    {
        private readonly ILocalizable _asset;

        public LeftCommand(ILocalizable asset)
        {
            _asset = asset;
        }

        public void Handle()
        {
            _asset.Move(new Location(_asset.LocationList.First().X - 1, _asset.LocationList.First().Y));
        }
    }
}