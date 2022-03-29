using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Framtal.Database
{
    public class RSK101_4_VAXTAGJOLD
    {
        public string T101_VX_SKLDREI { get; set; }
        public decimal N101_VX_LANSTIMI { get; set; }
        public uint N101_VX_HEILDARGR { get; set; }
        public uint N101_VX_AFBORGUN { get; set; }
        public uint N101_VX_AFFOLL { get; set; }
        public uint N101_VX_LANTOKUKOSTN { get; set; }
        public uint N101_VX_VAXTAGJ { get; set; }
        public uint N101_VX_EFTIRST { get; set; }
        public string K101_VX_LANSNUMER { get; set; }
        public DateTime D101_VX_LANTOKUDAGUR { get; set; }
        public DateTime D101_VX_YFIRTOKUDAGUR { get; set; }
        //TODO: Laga Enum
        //public enum RSK_VX_UPPRUNI { get; set; }
        public decimal N101_VX_HLUTFALL { get; set; }
        public int N101_VX_HLUTFALL_VAXTAGJ { get; set; }
        public int N101_VX_HLUTFALL_EFTIRST { get; set; }

    }
}
