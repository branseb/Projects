using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Extensions;

namespace FolderListing
{
    public static class Directory
    {
        public static void RenderFolders(int level, string folder)
        {
            var directories = System.IO.Directory.GetDirectories(folder);
            foreach (var d in directories)
            {
                Console.WriteLine(" ".Multyply(level * 4) + d);
                RenderFolders(level + 1, d);
            }
        }
    }
}
