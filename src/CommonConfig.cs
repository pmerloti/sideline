using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sideline
{
    public static class CommonConfig
    {
        public static string TeamsFolder
        {
            get
            {
                var s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var path = Path.Combine(s, "Sideline Volleyball");
                path = Path.Combine(path, "Teams");

                Directory.CreateDirectory(path);

                return path;
            }
        }
    }
}
