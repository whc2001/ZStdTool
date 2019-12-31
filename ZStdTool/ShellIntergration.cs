using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZStdTool
{
    public static class ShellIntergration
    {
        private const string regMenuCompress = "*\\shell\\ZstdToolCompress";
        private const string regMenuCompressCmd = "*\\shell\\ZstdToolCompress\\command";
        private const string regMenuDecompress = "*\\shell\\ZstdToolDecompress";
        private const string regMenuDecompressCmd = "*\\shell\\ZstdToolDecompress\\command";

        public static void Set(bool install)
        {
            if(install)
            {
                RegistryKey compress = Registry.ClassesRoot.CreateSubKey(regMenuCompress);
                compress.SetValue("", "Zstd Compress");
                RegistryKey compressCmd = Registry.ClassesRoot.CreateSubKey(regMenuCompressCmd);
                compressCmd.SetValue("", $"{Application.ExecutablePath} /c %1");

                RegistryKey decompress = Registry.ClassesRoot.CreateSubKey(regMenuDecompress);
                decompress.SetValue("", "Zstd Decompress");
                RegistryKey decompressCmd = Registry.ClassesRoot.CreateSubKey(regMenuDecompressCmd);
                decompressCmd.SetValue("", $"{Application.ExecutablePath} /d %1");
            }
            else
            {
                RegistryKey compress = Registry.ClassesRoot.CreateSubKey(regMenuCompress);
                if (compress != null)
                    Registry.ClassesRoot.DeleteSubKeyTree(regMenuCompress);
                RegistryKey decompress = Registry.ClassesRoot.CreateSubKey(regMenuDecompress);
                if (decompress != null)
                    Registry.ClassesRoot.DeleteSubKeyTree(regMenuDecompress);
            }
        }
    }
}
