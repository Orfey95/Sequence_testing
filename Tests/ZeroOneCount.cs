using System;
using System.Windows.Controls;

namespace Sequence_testing.Tests
{
    class ZeroOneCount
    {
        public void ZeroOneCountTest(string sequence, TextBox textBox)
        {
            int countZero = 0;
            int countOne = 0;

            for(int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '0')
                    countZero++;
                if (sequence[i] == '1')
                    countOne++;
            }

            double percentOfZero = ((double)countZero * 100 / sequence.Length);
            double percentOfOne = ((double)countOne * 100 / sequence.Length);
            percentOfZero = Math.Round(percentOfZero, 3);
            percentOfOne = Math.Round(percentOfOne, 3);

            textBox.Text = "Number of zero: " + countZero + " (" + percentOfZero + "%)\n";
            textBox.Text += "Number of one: " + countOne + " ( " + percentOfOne + "%)";
        }
    }
}
