using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalGroup.Utilities
{
    public class Utilities
    {
        public static bool RemoveImage(string root, string image)
        {
            string path = Path.Combine(root, "images", image);
            if (File.Exists(path))
            {
                File.Delete(path);
                return true;
            }
            return false;
        }
    }
}
