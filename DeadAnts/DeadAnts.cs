using System.Linq;
using System.Text.RegularExpressions;

namespace DeadAnts
{
    public class DeadAnts
    {
        public int DeadAntCount(string antStr)
        {
            if (string.IsNullOrEmpty(antStr)) { return 0; }

            var deadAntStr = Regex.Replace(antStr, "ant|[^ant]", "");
            var count = GetDeadAntCount(deadAntStr);

            return count;
        }

        private static int GetDeadAntCount(string deadAntStr)
        {
            if (string.IsNullOrEmpty(deadAntStr)) { return 0; }
                
            return deadAntStr.GroupBy(x => x).Max(x => x.Count());
        }
    }
}