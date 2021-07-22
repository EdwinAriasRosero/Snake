using System.Linq;

namespace SnakeConsole
{
    public class TopCommand : ICommand
    {
        private readonly ILocalizable _asset;

        public TopCommand(ILocalizable asset)
        {
            _asset = asset;
        }

        public void Handle()
        {
            _asset.Move(new Location(_asset.LocationList.First().X, _asset.LocationList.First().Y - 1));
        }
    }
}