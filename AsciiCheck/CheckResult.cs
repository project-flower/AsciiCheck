namespace AsciiCheck
{
    public class CheckResult
    {
        #region Public Fields

        public int Column;
        public int Row;
        public string Text;

        #endregion

        #region Public Methods

        public CheckResult(int row, int column, string text)
        {
            Column = column;
            Text = text;
            Row = row;
        }

        #endregion
    }
}
