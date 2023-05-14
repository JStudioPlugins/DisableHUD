using Rocket.API;
using Rocket.Unturned;
using Rocket.Core;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using Rocket.Unturned.Player;

namespace DisableHUD
{
    public class DisableHUD : RocketPlugin<DisableHUDConfiguration>
    {
        public static DisableHUDConfiguration Config { get; private set; }

        protected override void Load()
        {
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
            Config = Configuration.Instance;

            Logger.Log("DisableHUD by JStudio is now loaded.");
        }

        private void Events_OnPlayerConnected(UnturnedPlayer player)
        {
            if (!Config.EnemyInteraction)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowInteractWithEnemy);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowInteractWithEnemy);
            if (!Config.HealthBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowHealth);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowHealth);
            if (!Config.FoodBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowFood);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowFood);
            if (!Config.WaterBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowWater);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowWater);
            if (!Config.VirusBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowVirus);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowVirus);
            if (!Config.StaminaBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStamina);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowStamina);
            if (!Config.OxygenBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowOxygen);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowOxygen);
            if (!Config.StatusIcons)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStatusIcons);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowStatusIcons);
            if (!Config.GunStatus)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowUseableGunStatus);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowUseableGunStatus);
            if (!Config.VehicleStatus)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowVehicleStatus);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowVehicleStatus);
            if (!Config.CenterDot)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowCenterDot);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowCenterDot);
            if (!Config.ReputationChange)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowReputationChangeNotification);
            else
                player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowReputationChangeNotification);

        }

        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;

            Logger.Log("DisableHUD by JStudio is now loaded.");
        }
    }

    public class DisableHUDConfiguration : IRocketPluginConfiguration
    {
        public bool EnemyInteraction { get; set; }
        public bool HealthBar { get; set; }
        public bool FoodBar { get; set; }
        public bool WaterBar { get; set; }
        public bool VirusBar { get; set; }
        public bool StaminaBar { get; set; }
        public bool OxygenBar { get; set; }
        public bool StatusIcons { get; set; }
        public bool GunStatus { get; set; }
        public bool VehicleStatus { get; set; }
        public bool CenterDot { get; set; }
        public bool ReputationChange { get; set; }

        public void LoadDefaults()
        {
            EnemyInteraction = true;
            HealthBar = true;
            FoodBar = true;
            WaterBar = true;
            VirusBar = true;
            StaminaBar = true;
            OxygenBar = true;
            StatusIcons = true;
            GunStatus = true;
            VehicleStatus = true;
            CenterDot = true;
            ReputationChange = true;
        }
    }
}
