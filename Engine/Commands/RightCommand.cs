using System.Linq;

namespace Engine
{
    public class RightCommand : ICommand
    {
        private readonly ILocalizable _asset;

        public RightCommand(ILocalizable asset)
        {
            _asset = asset;
        }

        public void Handle()
        {
            _asset.Move(new Location(_asset.LocationList.First().X + 1, _asset.LocationList.First().Y));
        }
    }
}