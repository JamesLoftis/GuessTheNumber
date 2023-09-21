using System.Linq;
namespace GuessTheNumber
{
    public class Guess
    {
        private int _number;
        public int NumberCorrect { get; set; }
        public int NumberInRightPlace { get; set; }
        public int Number {
            get
            {
                return _number; 
            }
            set
            {
                _number = value;
            } 
        }

        public List<int> Digits => Number.ToString().ToCharArray().ToList().Select(x => int.Parse(x.ToString())).ToList();

        public void CheckNumbers(int[] currentTarget)
        {
            NumberCorrect = 0;
            NumberInRightPlace = 0;
            for (int i = 0; i < Digits.Count; i++)
            {
                var currentDigit = Digits[i];
                var currentTargetDigit = currentTarget[i];

                if (currentDigit == currentTargetDigit)
                {
                    NumberInRightPlace++;
                }

                if (currentTarget.Contains(currentDigit))
                {
                    NumberCorrect++;
                }
            }
        }
    }
}
