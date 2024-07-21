using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Flipper_zero_dolphin_state_editor
{
    public static class DolphinFile
    {
        public static int HEADER_SIZE
        {
            get => 8;
        }
        public static int BUTTHURT_MAX
        {
            get => 14;
        }

        public static byte[] UpdateIcounter(byte[] buffer, int value)
        {
            return [.. buffer[..(HEADER_SIZE + 12)], .. BitConverter.GetBytes(value), .. buffer[(HEADER_SIZE + 16)..]];
        }

        public static byte[] UpdateButthurt(byte[] buffer, int value)
        {
            return [.. buffer[..(HEADER_SIZE + 16)], .. BitConverter.GetBytes(value), .. buffer[(HEADER_SIZE + 20)..]];
        }

        public static byte[] DolphinStateSave(byte[] buffer, string path)
        {
            int checksum = 0;
            foreach (byte b in buffer[HEADER_SIZE..])
            {
                checksum += b;
            }

            Console.WriteLine($"[+] Calculated new checksum: {checksum % 256}");
            buffer[2] = (byte)(checksum % 256);
            File.WriteAllBytes(path, buffer);

            return buffer;
        }

        public delegate bool TryParseHandler<T>(string input, out T result);
    }
}
