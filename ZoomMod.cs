using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace RockinMods
{
    public class ZoomMod : Mod
    {
        internal static ZoomConfig config;

        public override void Entry(IModHelper helper)
        {
            config = helper.ReadConfig<ZoomConfig>();
            helper.Events.Input.ButtonPressed += ControlEvents_KeyPressed;
          
        }
        
        private void ControlEvents_KeyPressed(object sender, ButtonPressedEventArgs e)
        {
         
            if (e.Button == config.KeyIn || e.Button == config.ButtonIn)
            {
                Game1.options.zoomLevel += .05f;
                Program.gamePtr.refreshWindowSettings();

                if(Game1.options.zoomLevel > 1.25f)
                {
                    Game1.options.zoomLevel = 1.25f;
                    Program.gamePtr.refreshWindowSettings();
                }

                Monitor.Log("Current zoom level " + Game1.options.zoomLevel, LogLevel.Trace);
            }

            if(e.Button == config.KeyOut || e.Button == config.ButtonOut)
            {
                Game1.options.zoomLevel -= .05f;
                Program.gamePtr.refreshWindowSettings();

                if (Game1.options.zoomLevel < .35f)
                {
                    Game1.options.zoomLevel = .35f;
                    Program.gamePtr.refreshWindowSettings();
                }

                Monitor.Log("Current zoom level " + Game1.options.zoomLevel, LogLevel.Trace);
            }
        }
    }
}
