using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MySpace_Inventory.Config
{
    public static class AppConfig
    {

        public static readonly string app_folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MySpaceApp","Data");
        public static readonly string inventory_path = Path.Combine(app_folder, "inventario.json");



    }
}
