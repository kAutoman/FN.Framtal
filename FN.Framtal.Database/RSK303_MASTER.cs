using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Framtal.Database
{
    public class RSK303_MASTER
    {
        public bool R303_TEGUND { get; set; }
        public string T303_UPP_STDSET { get; set; }
        public string K303_UPP_NUMER_EIGN { get; set; }
        public string T303_UPP_BG_STG { get; set; }
        //TODO: Laga enum
        //public enum R303_UPP_TEGUND { get; set; }
        public string T303_UPP_TEG_ANNAD { get; set; }
        public string A303_UPP_BYGG_HOFST { get; set; }
        public string A303_UPP_BYGG_LAUK { get; set; }
        public string A303_UPP_NOTKUN { get; set; }
        public decimal N303_UPP_EIGNARH_PROSENT { get; set; }
        public decimal N303_UPP_EIGNARH_FERM { get; set; }
        public decimal N303_UPP_EIGNARH_RUMM { get; set; }
        public int N303_A_TRESMIDI { get; set; }
        public int N303_A_MURVERK { get; set; }
        public int N303_A_PIPULAGNIR { get; set; }
        public int N303_A_RAFLAGNIR { get; set; }
        public int N303_A_MALUN { get; set; }
        public int N303_A_TEIKNINGAR { get; set; }
        public string T303_A_ANNAD_SKYRING { get; set; }
        public int N303_A_ANNAD_FJARH { get; set; }
        public int N303_B_KEYPT_BYGGEFNI_SAMT { get; set; }
        public string T303_C_ANNAR_BYGGKOSTN1 { get; set; }
        public int N303_C_ANNAR_BYGGKOSTN1 { get; set; }
        public string T303_C_ANNAR_BYGGKOSTN2 { get; set; }
        public int N303_C_ANNAR_BYGGKOSTN2 { get; set; }
        public string T303_C_ANNAR_BYGGKOSTN3 { get; set; }
        public int N303_C_ANNAR_BYGGKOSTN3 { get; set; }
        public int N303_D_AUKAVINNA_KLST1 { get; set; }
        public int N303_D_AUKAVINNA_TAXTI1 { get; set; }
        public int N303_D_AUKAVINNA_FJARH1 { get; set; }
        public int N303_D_AUKAVINNA_KLST2 { get; set; }
        public int N303_D_AUKAVINNA_TAXTI2 { get; set; }
        public int N303_D_AUKAVINNA_FJARH2 { get; set; }
        public int N303_E_ONNUR_EIGIN_VINNA_KLST1 { get; set; }
        public int N303_E_ONNUR_EIGIN_VINNA_TXTI1 { get; set; }
        public int N303_E_ONNUR_EIGIN_VINNA_FJRH1 { get; set; }
        public int N303_E_ONNUR_EIGIN_VINNA_KLST2 { get; set; }
        public int N303_E_ONNUR_EIGIN_VINNA_TXTI2 { get; set; }
        public int N303_E_ONNUR_EIGIN_VINNA_FJRH2 { get; set; }
        public int N303_SAMTALS_SUND_KOSTN_ARS_1 { get; set; }
        public int N303_KAUPV_HUS_I_SMIDUM { get; set; }
        public int N303_HLUTD_SAMEIG_BYGGKOSTN { get; set; }
        public int N303_SERKOSTN_EIGANDA { get; set; }
        public int N303_ENDURGR_VSK { get; set; }
        public int N303_KOSTNADUR_ALLS_A_ARINU { get; set; }
        public int N303_HEILDARKOSTN_F_FYRRA_ARI { get; set; }
        public int N303_SOLUHAGN1 { get; set; }
        public int N303_STOFNKOSTNADUR_SAMTALS { get; set; }
        public int N303_FASTEIGNAMAT { get; set; }
        public int N303_OMETIN_BYGGINGARKOSTN { get; set; }
        public int N303_SAMTALS_FLUTT_A_101 { get; set; }
        public int N303_SAMTALS_SUND_KOSTN_ARS_2 { get; set; }
    }
}
