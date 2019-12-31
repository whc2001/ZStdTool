using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdNet;

namespace ZStdTool
{
    public static class ZstdWrapper
    {
        public static void CompressFile(string path)
        {
            FileInfo fi = new FileInfo(path);
            Compressor comp = new Compressor();
            byte[] source = File.ReadAllBytes(path);
            File.WriteAllBytes($"{fi.DirectoryName}\\{Path.GetFileNameWithoutExtension(fi.Name)}_Compressed{fi.Extension}", comp.Wrap(source));
        }

        public static void DecompressFile(string path)
        {
            FileInfo fi = new FileInfo(path);
            Decompressor decomp = new Decompressor();
            byte[] source = File.ReadAllBytes(path);
            File.WriteAllBytes($"{fi.DirectoryName}\\{Path.GetFileNameWithoutExtension(fi.Name)}_Decompressed{fi.Extension}", decomp.Unwrap(source));
        }
    }
}
