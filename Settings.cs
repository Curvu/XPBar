using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;

namespace XPBar
{
    public class Settings : ISettings
    {
        public Settings()
        {
        }

        public ToggleNode Enable { get; set; } = new ToggleNode(true);
    }
}
