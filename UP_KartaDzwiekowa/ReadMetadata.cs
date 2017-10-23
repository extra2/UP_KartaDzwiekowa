using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_KartaDzwiekowa
{
    class ReadMetadata
    {
        int position;
        int count;
        byte[] byteArray;
        Stream waveFileStream = File.OpenRead("1.wav");
    }
}
