namespace ConstructorInterview.QSSCorp
{
    public class RomanNumber
    {
        public string RomanNumberOption => this.setRomanValue();
        private int NormalInterger;
        public RomanNumber(int number)
        {
            this.NormalInterger = number;
        }

        string setRomanValue()
        {
            string[] romanLiterals = { "", "i", "ii", "iii", "iv", "v", "vi", "vii", "viii", "ix" };
            string numberStr = this.NormalInterger.ToString();
            //char[] charArray = numberStr.ToCharArray();
            int length = numberStr.Length;
            string result = string.Empty;

            for (int i = 0; i <= length - 1; i++)
            {
                if (i == length - 2 && numberStr[i] == '0')
                {
                    result += "x";
                }
                else
                {
                    var position = Convert.ToInt32(numberStr[i].ToString());
                    result += romanLiterals[position];
                }
            }
            return result;
        }
    }
}
