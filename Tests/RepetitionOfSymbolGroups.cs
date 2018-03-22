using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Sequence_testing.Tests
{
    class RepetitionOfSymbolGroups
    {
        public void RepetitionOfSymbolGroupsTest(string sequence, TextBox textBox)
        {
            int countDoubleZero = 0;
            int countDoubleOne = 0;
            int countTripleZero = 0;
            int countTripleOne = 0;
            int countQuadrupleZero = 0;
            int countQuadrupleOne = 0;

            countDoubleZero = new Regex("00").Matches(sequence).Count;
            countDoubleOne = new Regex("11").Matches(sequence).Count;
            countTripleZero = new Regex("000").Matches(sequence).Count;
            countTripleOne = new Regex("111").Matches(sequence).Count;
            countQuadrupleZero = new Regex("0000").Matches(sequence).Count;
            countQuadrupleOne = new Regex("1111").Matches(sequence).Count;

            textBox.Text = "Double zero: " + countDoubleZero + "\n";
            textBox.Text += "Double one: " + countDoubleOne + "\n";
            textBox.Text += "Triple zero: " + countTripleZero + "\n";
            textBox.Text += "Triple one: " + countTripleOne + "\n";
            textBox.Text += "Quadruple zero: " + countQuadrupleZero + "\n";
            textBox.Text += "Quadruple one: " + countQuadrupleOne;
        }
    }
}
