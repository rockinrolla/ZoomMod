using Microsoft.Xna.Framework.Input;
using StardewModdingAPI;

namespace RockinMods
{
    class ZoomConfig
    {
        public SButton KeyIn { get; set; }
        public SButton KeyOut { get; set; }

        public SButton ButtonIn { get; set; }
        public SButton ButtonOut { get; set; }

        public ZoomConfig()
        {
            KeyIn = SButton.OemPlus;
            KeyOut = SButton.OemMinus;

            ButtonIn = SButton.DPadDown;
            ButtonOut = SButton.DPadUp;
        }
    }
}
