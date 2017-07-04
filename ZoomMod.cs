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

            GameEvents.UpdateTick += GameEvents_UpdateTick;
            ControlEvents.KeyPressed += ControlEvents_KeyPressed;
            ControlEvents.ControllerButtonPressed += ControlEvents_ControllerButtonPressed;
        }

        private void GameEvents_UpdateTick(object sender, System.EventArgs e)
        {
            if(Game1.options.zoomLevel < .35f)
            {
                Game1.options.zoomLevel = .35f;
               Program.gamePtr.refreshWindowSettings();
                
                //Log.Out(Game1.options.zoomLevel);
            }

            if (Game1.options.zoomLevel > 1.25f)
            {
                Game1.options.zoomLevel = 1.25f;
                Program.gamePtr.refreshWindowSettings();
                //Log.Out(Game1.options.zoomLevel);
            }
        }

        private void ControlEvents_KeyPressed(object sender, EventArgsKeyPressed e)
        {
            
            if(e.KeyPressed == config.KeyIn)
            {
                Game1.options.zoomLevel += .05f;
                Program.gamePtr.refreshWindowSettings();
                //Log.Out(Game1.options.zoomLevel);
            }

            if(e.KeyPressed == config.KeyOut)
            {
                Game1.options.zoomLevel -= .05f;
                Program.gamePtr.refreshWindowSettings();
                //Log.Out(Game1.options.zoomLevel);
            }
        }

        private void ControlEvents_ControllerButtonPressed(object sender, EventArgsControllerButtonPressed e)
        {
            if (e.ButtonPressed == config.ButtonIn)
            {
                Game1.options.zoomLevel += .05f;
                Program.gamePtr.refreshWindowSettings();
                //Log.Out(Game1.options.zoomLevel);
            }

            if (e.ButtonPressed == config.ButtonOut)
            {
                Game1.options.zoomLevel -= .05f;
                Program.gamePtr.refreshWindowSettings();
                //Log.Out(Game1.options.zoomLevel);
            }
        }
    }
}
