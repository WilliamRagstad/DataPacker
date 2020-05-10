using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPacker
{
    static class Settings
    {
        public static Version CurrentVersion = new Version(1, 0, 0);

        public static string ProjectName = "DataPacker";
        public static string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string HomeFolder = Path.Combine(AppData, ProjectName);
        public static string DataPacksFolder = Path.Combine(HomeFolder, "datapacks");

        public static string MinecraftFolder = Path.Combine(AppData, ".minecraft");
        public static string WorldsFolder = Path.Combine(MinecraftFolder, "saves");

        public static string DataPack_thumbnail = "pack.png";
        public static string DataPack_meta = "pack.mcmeta";

        public static string TreeList_tag_mainMenu = "mainmenu";
        public static string TreeList_tag_dataPack = "datapack";
        public static string TreeList_tag_world = "world";
    }
}
