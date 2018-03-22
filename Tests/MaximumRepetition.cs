using System.Windows.Controls;

namespace Sequence_testing.Tests
{
    class MaximumRepetition
    {
        public void MaximumRepetitionTest(string sequence, TextBox textBox)
        {
            int maxZeroCount = 0;
            int maxOneCount = 0;
            int currentMaxZeroCount = 0;
            int currentMaxOneCount = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if(sequence[i] == '0')
                {
                    currentMaxOneCount = 0;
                    currentMaxZeroCount++;
                    if (currentMaxZeroCount > maxZeroCount)
                        maxZeroCount = currentMaxZeroCount;
                }
                if (sequence[i] == '1')
                {
                    currentMaxZeroCount = 0;
                    currentMaxOneCount++;
                    if (currentMaxOneCount > maxOneCount)
                        maxOneCount = currentMaxOneCount;
                }
            }

            textBox.Text = "Number of maximum of zero: " + maxZeroCount + "\n";
            textBox.Text += "Number of maximum of one: " + maxOneCount;
        }
    }
}
