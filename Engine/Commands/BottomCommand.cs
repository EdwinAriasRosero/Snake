using System.Linq;

namespace Engine
{
    public class BottomCommand : ICommand
    {
        private readonly ILocalizable _asset;

        public BottomCommand(ILocalizable asset)
        {
            _asset = asset;
        }

        public void Handle()
        {
            _asset.Move(new Location(_asset.LocationList.First().X, _asset.LocationList.First().Y + 1));
        }
    }
}