using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DisableHUD
{
    class DisableHUDCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "disablehud";

        public string Help => "Disables certain portions of the HUD.";

        public string Syntax => "<health/food/water/virus/stamina/oxygen/status/gun/vehicle>";

        public List<string> Aliases => new() { "huddisable", "hdisable", "disableh", "disableui", "uidisable"};

        public List<string> Permissions => new() { "j.disablehud" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;
            if (command.Length < 1) { UnturnedChat.Say(caller, DisableHUD.Instance.Translate("InvalidSyntax"), Color.red); return; }
            string lower = command[0].ToLower();
            switch (lower)
            {
                case "health":
                    player.Player.disablePluginWidgetFlag(SDG.Unturned.EPluginWidgetFlags.ShowHealth);
                    UnturnedChat.Say(caller, DisableHUD.Instance.Translate("Disable", lower), Color.red);
                    return;
                case "food":
                    player.Player.disablePluginWidgetFlag(SDG.Unturned.EPluginWidgetFlags.ShowFood);
                    UnturnedChat.Say(caller, DisableHUD.Instance.Translate("Disable", lower), Color.red);
                    return;
                case "water":
                    player.Player.disablePluginWidgetFlag(SDG.Unturned.EPluginWidgetFlags.ShowWater);
                    UnturnedChat.Say(caller, DisableHUD.Instance.Translate("Disable", lower), Color.red);
                    return;
                case "virus":
                    player.Player.disablePluginWidgetFlag(SDG.Unturned.EPluginWidgetFlags.ShowVirus);
                    UnturnedChat.Say(caller, DisableHUD.Instance.Translate("Disable", lower), Color.red);
                    return;
                case "stamina":
                    player.Player.disablePluginWidgetFlag(SDG.Unturned.EPluginWidgetFlags.ShowStamina);
                    UnturnedChat.Say(caller, DisableHUD.Instance.Translate("Disable", lower), Color.red);
                    return;
                case "oxygen":
                    player.Player.disablePluginWidgetFlag(SDG.Unturned.EPluginWidgetFlags.ShowOxygen);
                    UnturnedChat.Say(caller, DisableHUD.Instance.Translate("Disable", lower), Color.red);
                    return;
                case "status":
                    player.Player.disablePluginWidgetFlag(SDG.Unturned.EPluginWidgetFlags.ShowStatusIcons);
                    UnturnedChat.Say(caller, DisableHUD.Instance.Translate("Disable", lower), Color.red);
                    return;
                case "gun":
                    player.Player.disablePluginWidgetFlag(SDG.Unturned.EPluginWidgetFlags.ShowUseableGunStatus);
                    UnturnedChat.Say(caller, DisableHUD.Instance.Translate("Disable", lower), Color.red);
                    return;
                case "vehicle":
                    player.Player.disablePluginWidgetFlag(SDG.Unturned.EPluginWidgetFlags.ShowVehicleStatus);
                    UnturnedChat.Say(caller, DisableHUD.Instance.Translate("Disable", lower), Color.red);
                    return;
            }

            UnturnedChat.Say(caller, DisableHUD.Instance.Translate("InvalidSyntax"), Color.red);
        }
    }
}
