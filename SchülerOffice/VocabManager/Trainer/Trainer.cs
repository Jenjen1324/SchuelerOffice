using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchülerOffice.VocabManager.Trainer
{
    public partial class Trainer : Form
    {
        private static Vocabulary vocab;
        private static Vocabulary currentVocab;
        private static int correct;
        private static int incorrect;
        private static ArrayList list;
        private static int currentWord;

        public Trainer(Vocabulary v)
        {
            InitializeComponent();
            vocab = v;
            currentVocab = v;
            label1.Text = vocab.fromLang;
            label2.Text = vocab.toLang;
            label3.Text = "";
            start();
        }

        private void start()
        {
            incorrect = 0;
            correct = 0;
            Vocabulary v = new Vocabulary();
            foreach (VocWord word in currentVocab.words)
            {
                if (word.correct)
                {
                    correct++;
                }
                else
                {
                    incorrect++;
                    v.words.Add(word);
                }
            }
            currentVocab = v;
            currentWord = 0;
            list = Data.RandomNumbers(incorrect);
            displayWord();
        }

        private void displayWord()
        {
            textBox1.Text = getCurrentWord().fromVal;
            label3.Text = getCurrentWord().desc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VocWord word = getCurrentWord();
            if (textBox2.Text == word.toVal)
            {
                correct++;
                incorrect--;
                changeCurrentWord(true);
            }
            else
            {
                incorrect++;
                Data.messageBox("Falsch!", "Die richtige Lösung wäre: " + getCurrentWord().toVal);
            }

            if (list.Count != currentWord + 1)
            {
                currentWord++;
                textBox2.Text = "";
                displayWord();
            }
            else
            {
                Data.messageBox("Fertig!", "Du bist fertig!");
                if (incorrect > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Du hast nicht alles richtig gehabt! Willst du die falschen Wörter nochamals üben?", "", MessageBoxButtons.YesNo))
                    {
                        start();
                    }
                }
            }

        }

        private VocWord getCurrentWord()
        {
            try
            {
                return currentVocab.words[Convert.ToInt32(list[currentWord]) - 1];
            }
            catch
            {
                return null;
            }
        }

        private void changeCurrentWord(bool val)
        {
            currentVocab.words[Convert.ToInt32(list[currentWord]) - 1].correct = val;
        }
    }
}
