using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AsciiCheck
{
    public static class MainEngine
    {
        #region Public Methods

        public static Dictionary<string, CheckResult[]> Check(string[] fileNames, Encoding encoding, int findMax)
        {
            var checkResults = new Dictionary<string, List<CheckResult>>();

            foreach (string fileName in fileNames)
            {
                string[] lines;

                try
                {
                    lines = File.ReadAllLines(fileName, encoding);
                }
                catch
                {
                    checkResults[fileName] = null;
                    continue;
                }

                for (int row = 0; row < lines.Length; ++row)
                {
                    string line = lines[row];

                    for (int column = 0; column < line.Length; ++column)
                    {
                        char text = line[column];

                        if (text > 0x7F)
                        {
                            List<CheckResult> checkResult;

                            if (!checkResults.TryGetValue(fileName, out checkResult))
                            {
                                checkResult = new List<CheckResult>();
                                checkResults[fileName] = checkResult;
                            }

                            if (checkResult.Count < findMax)
                            {
                                checkResult.Add(new CheckResult(row, column, text.ToString()));
                            }
                        }
                    }
                }
            }

            var result = new Dictionary<string, CheckResult[]>(checkResults.Count);

            foreach (KeyValuePair<string, List<CheckResult>> checkResult in checkResults)
            {
                result[checkResult.Key] = checkResult.Value.ToArray();
            }

            return result;
        }

        #endregion
    }
}
