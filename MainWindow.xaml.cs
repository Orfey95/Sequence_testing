using Microsoft.Win32;
using Sequence_testing.Tests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sequence_testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ZeroOneCount zeroOneCount = new ZeroOneCount();
        RepetitionOfSymbolGroups repetitionOfSymbolGroups = new RepetitionOfSymbolGroups();
        MaximumRepetition maximumRepetition = new MaximumRepetition();
        SpectralDiagram spectralDiagram = new SpectralDiagram();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void sequenceBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            sequenceLength.Content = ("Sequence Length: " + sequenceBox.Text.Length);
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            sequenceBox.Text = "";
        }

        private void loadFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == true)
            {
                sequenceBox.Text = File.ReadAllText(ofd.FileName, Encoding.Default);
            }
        }

        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            if (testComboBox.SelectedIndex == 0)
            {
                zeroOneCount.ZeroOneCountTest(sequenceBox.Text, testResultBox);
            }
            if (testComboBox.SelectedIndex == 1)
            {
                repetitionOfSymbolGroups.RepetitionOfSymbolGroupsTest(sequenceBox.Text, testResultBox);
            }
            if (testComboBox.SelectedIndex == 2)
            {
                maximumRepetition.MaximumRepetitionTest(sequenceBox.Text, testResultBox);
            }
            if (testComboBox.SelectedIndex == 3)
            {
                if (sequenceBox.Text.Length == 160000)
                    spectralDiagram.SpectralDiagramTest(sequenceBox.Text, spectral);
                else
                    MessageBox.Show("The length is not enough", "Error");
            }
        }
    }
}
