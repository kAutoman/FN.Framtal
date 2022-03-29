namespace FN.Framtal.Domain._2004.Validation
{
    public class RSK401_EIGNASKRA
    {
        public string T401_ES_HEI { get; set; }
        public string A401_ES_KAUP_BYGG_AR { get; set; }
        public string R401_ES_FLOKKUR_FYRNINGAR { get; set; }
        public string R401_ES_TEGUND_FYRNINGAR { get; set; }
        public string T401_ES_RADNUMER_EIGNAR { get; set; }
        public string K401_ES_AUDKENNI_EIGNAR { get; set; }
        //TODO: Laga Enum
        //public enum R401_ES_UPPRUNI { get; set; }
        //public enum R401_ES_RADSTOFUN { get; set; }
        public string K401_ES_KENNITALA_SELJANDA { get; set; }
        public int N401_ES_INNSKATTUR { get; set; }
        public int N401_ES_KAUPVERD_STOFNVERD { get; set; }
        public int N401_ES_BOKFAERT_VERD_UPPHAF { get; set; }
        public decimal N401_ES_FYRNINGARHLUTFALL { get; set; }
        public int N401_ES_ALMENN_FYRNING { get; set; }
        public int N401_ES_AUKAFYRNINGAR { get; set; }
        public int N401_ES_BOKFAERT_VERD_LOK { get; set; }
        public string K401_ES_KENNITALA_KAUPANDA { get; set; }
        public int N401_ES_SOLUVERD { get; set; }
        public int N401_ES_UTSKATTUR { get; set; }
        public int N401_ES_SOLUHAGNADUR_SOLUTAP { get; set; }
        public int N401_ES_FRESTADUR_SOLUHAGNADUR { get; set; }
        //Laga Enum
        //public enum R401_ES_FLOKKUR_FRESTUNAR { get; set; }
        //public enum RSK_ES_UPPRUNI_GAGNA { get; set; }
    }
}
