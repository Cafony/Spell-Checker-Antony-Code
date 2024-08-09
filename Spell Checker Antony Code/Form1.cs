using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHunspell;

namespace Spell_Checker_Antony_Code
{
    public partial class Form1 : Form
    {
        
        private Hunspell _hunspell;

        public Form1()
        {
            InitializeComponent();
            // Initialize Hunspell with the .aff and .dic files
            InicializeLanguage();

        }

        private void  InicializeLanguage ()
        {
            //Dictionary downloaded here:
            //https://github.com/titoBouzout/Dictionaries/blob/master/English%20(American).txt
            
            _hunspell?.Dispose ();

            if(radioButtonPT.Checked )
            {
                _hunspell = new Hunspell(
                @"C:\Users\tozec\source\repos\Spell Checker Antony Code\Spell Checker Antony Code\Portuguese (European).aff",
                "C:\\Users\\tozec\\source\\repos\\Spell Checker Antony Code\\Spell Checker Antony Code\\Portuguese (European).dic");
            }
            else
            {
                _hunspell = new Hunspell(
         @"C:\Users\tozec\source\repos\Spell Checker Antony Code\Spell Checker Antony Code\English (American).aff",
         "C:\\Users\\tozec\\source\\repos\\Spell Checker Antony Code\\Spell Checker Antony Code\\English (American).dic");
            }

        }


        public void CheckSpelling(RichTextBox richTextBox)
        {
            InicializeLanguage();

            ClearHighlights();

            // Get the text from the RichTextBox
            string text = richTextBox1.Text;

            // Split the text into words for spell checking
            string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int startIndex = 0;

            foreach (string word in words)
            {
                // Find the word in the text (to get its position)
                startIndex = text.IndexOf(word, startIndex);

                if (!_hunspell.Spell(word))
                {
                    // Word is misspelled, highlight it
                    HighlightWord(startIndex, word.Length);
                }

                // Move past this word for the next search
                startIndex += word.Length;
            }
        }

        private void HighlightWord(int startIndex, int length)
        {
            // Save the current selection
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            // Highlight the misspelled word
            richTextBox1.Select(startIndex, length);
            richTextBox1.SelectionBackColor = Color.Yellow;

            // Restore the original selection
            richTextBox1.Select(selectionStart, selectionLength);
        }

        private void ClearHighlights()
        {
            // Save the current selection
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            // Clear all highlighting by setting the background color to default
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;

            // Restore the original selection
            richTextBox1.Select(selectionStart, selectionLength);
        }
        //AUTO CORRECT====================
        private void ReplaceWord(int startIndex, int length, string replacement)
        {
            // Save the current selection
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            // Replace the misspelled word
            richTextBox1.Select(startIndex, length);
            richTextBox1.SelectedText = replacement;

            // Restore the original selection
            richTextBox1.Select(selectionStart, selectionLength);
        }

        private void AutoCorrectSpelling()
        {
            // Get the text from the RichTextBox
            string text = richTextBox1.Text;

            // Split the text into words for spell checking
            string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int startIndex = 0;

            foreach (string word in words)
            {
                // Find the word in the text (to get its position)
                startIndex = text.IndexOf(word, startIndex);

                if (!_hunspell.Spell(word))
                {
                    // Get suggestions for the misspelled word
                    var suggestions = _hunspell.Suggest(word);
                    if (suggestions.Count > 0)
                    {
                        // Automatically replace with the first suggestion
                        ReplaceWord(startIndex, word.Length, suggestions[0]);
                    }
                }

                // Move past this word for the next search
                startIndex += word.Length;
            }
        }

            private void buttonCheckText_Click(object sender, EventArgs e)
        {
            CheckSpelling(richTextBox1);
        }

        private void buttonClearHighlights_Click(object sender, EventArgs e)
        {
            ClearHighlights();
        }

        private void buttonCorrectAll_Click(object sender, EventArgs e)
        {
            AutoCorrectSpelling();
        }

        private void radioButtonPT_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
