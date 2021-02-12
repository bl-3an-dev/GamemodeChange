using System;
using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using MiNET.Worlds;

namespace GamemodeChange
{

    [Plugin(PluginName = "GamemodeChange", Description = "GamemodeChange", PluginVersion = "1.0", Author = "bl_3an_dev")]
    public class MainClass : Plugin
    {

        protected override void OnEnable()
        {
            Console.WriteLine("GamemodeChange 플러그인이 활성화되었습니다.");
        }

        public override void OnDisable()
        {
            Console.WriteLine("GamemodeChange 플러그인이 비활성화되었습니다.");
        }

        [Command(Name = "gamemode", Aliases = new[]{"gm"}, Description = "Change Gamemode")]
        public static void Gamemode(Player player, int gamemode)
        {
            player.SendMessage($"내 게임 모드를 {GamemodeName(gamemode)} 모드(으)로 변경했습니다.");
            player.SetGameMode((GameMode)gamemode);
        }

        public static string GamemodeName(int gamemode)
        {
            if (gamemode == 0)
            {
                return "서바이벌";
            }
            else if (gamemode == 1)
            {
                return "크리에이티브";
            }
            else if (gamemode == 2)
            {
                return "모험";
            }
            else if (gamemode == 3)
            {
                return "관람자";
            }
            else
            {
                return "알수없음";
            }
        }

    }

}
