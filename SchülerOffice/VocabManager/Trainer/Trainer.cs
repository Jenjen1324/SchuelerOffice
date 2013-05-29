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
using System.Threading;
using System.Diagnostics;

namespace SchülerOffice.VocabManager.Trainer
{
    public partial class Trainer : Form
    {
        private static Vocabulary vocab = new Vocabulary();
        private static Vocabulary currentVocab = new Vocabulary();
        private static int correct;
        private static int incorrect;
        private static ArrayList list = new ArrayList();
        private static int currentWord;
        private static Stopwatch time = new Stopwatch();

        public Trainer(Vocabulary v)
        {
            InitializeComponent();
            vocab = v;
            currentVocab = v;
            label_1lang.Text = vocab.fromLang;
            label_2lang.Text = vocab.toLang;
            this.ActiveControl = button_start;

            foreach (VocWord word in currentVocab.words)
            {
                word.correct = false;
            }
        }

        private void start()
        {
            button_check.Enabled = true;
            time.Reset();
            time.Start();
            correct = 0;
            incorrect = 0;
            currentWord = 0;
            list = Data.RandomNumbers(currentVocab.words.Count);
            displayWord();
        }

        private bool displayWord()
        {
            VocWord word = getCurrentWord();
            while (word.correct)
            {
                currentWord++;
                if (list.Count == currentWord)
                {
                    word = getCurrentWord();
                }
                else
                {
                    return false;
                }
            }
            textBox_1lang.Text = getCurrentWord().fromVal;
            textBox_cright.Text = correct.ToString();
            textBox_cwrong.Text = incorrect.ToString();
            textBox_cremaining.Text = (currentVocab.words.Capacity- currentWord -1).ToString();
            textBox_2lang.Text = "";
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VocWord word = getCurrentWord();

            if (textBox_2lang.Text == word.toVal)
            {
                correct++;
                changeCurrentWord(true);
                textBox_response.ForeColor = Color.Green;
                textBox_response.Text = "Richtig!";
            }
            else
            {
                incorrect++;
                Data.messageBox("Falsch!", "Die richtige Lösung wäre: " + word.toVal);
                textBox_response.ForeColor = Color.Red;
                textBox_response.Text = "Falsch!" + Environment.NewLine +
                    "Die richtige Lösung wäre: "+ word.toVal;
            }

            currentWord++;

            if (!displayWord())
            {
                timer1.Stop();
                textBox_cright.Text = correct.ToString();
                textBox_cwrong.Text = incorrect.ToString();
                textBox_cremaining.Text = (currentVocab.words.Capacity - currentWord - 1).ToString();
                Data.messageBox("Gut gemacht!", "Du bist fertig!");
                button_check.Enabled = false;

                if (incorrect > 0)
                {
                    Thread.Sleep(1000);
                    textBox_response.ForeColor = Color.Black;
                    textBox_response.Text = "Du bist fertig hast aber nicht alle Wörter richtig gehabt!" + Environment.NewLine +
                        "Wenn du die falschen Wörter noch üben willst drücke auf Start";
                    button_start.Enabled = true;
                    time.Stop();
                }
                else
                {
                    textBox_response.ForeColor = Color.Green;
                    textBox_response.Text = "Gut gemacht! Du hast alle Wörter richtig gehabt!";
                }
            }

        }

        private VocWord getCurrentWord()
        {
            try
            {
                return currentVocab.words[Convert.ToInt32(list[currentWord])-1];
            }
            catch
            {
                throw new Exception("Couldn't get the current word!");
            }
        }

        private void changeCurrentWord(bool val)
        {
            currentVocab.words[Convert.ToInt32(list[currentWord]) - 1].correct = val;
        }
        
        private void button_start_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            timer1.Start();
            this.ActiveControl = textBox_2lang;
            start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox_ctime.Text = time.Elapsed.Seconds.ToString();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            time.Stop();
            button_continue.Enabled = true;
            button_pause.Enabled = false;
            timer1.Stop();
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            time.Start();
            button_continue.Enabled = false;
            button_pause.Enabled = true;
            timer1.Start();
        }
    }
}
