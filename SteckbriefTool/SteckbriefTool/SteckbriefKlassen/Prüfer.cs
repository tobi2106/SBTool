namespace SteckbriefTool.SteckbriefKlassen
{
    class Prüfer
    {
        private const int MaxAlter = 120;
        private const int MaxStrLänge = 500;

        public static bool AlterCheck(int alter)
        {
            return (alter > 0 && alter <= MaxAlter);
        }

        public static bool StringCheck(string str)
        {
            return (!string.IsNullOrWhiteSpace(str) && str.Length <= MaxStrLänge);
        }
    }
}
