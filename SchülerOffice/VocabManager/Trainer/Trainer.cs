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
        private static int correct = 0;
        private static int incorrect = 0;
        private static ArrayList list = new ArrayList();
        private static int currentWord = 0;
        private static Stopwatch time = new Stopwatch();

        public Trainer(Vocabulary v)
        {
            InitializeComponent();
            vocab = v;
            currentVocab = v;
            label_1lang.Text = vocab.fromLang;
            label_2lang.Text = vocab.toLang;
           this.ActiveControl = button_start;
        }

        private void start()
        {
            button_check.Enabled = true;
            time.Reset();
            time.Start();
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
            textBox_1lang.Text = getCurrentWord().fromVal;
            textBox_cright.Text = correct.ToString();
            textBox_cwrong.Text = incorrect.ToString();
            textBox_cremaining.Text = (currentVocab.words.Capacity- currentWord -1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VocWord word = getCurrentWord();
            if (textBox_2lang.Text == word.toVal)
            {
                correct++;
                incorrect--;
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
            displayWord();
            if (list.Count != currentWord + 1)
            {
                currentWord++;
                textBox_2lang.Text = "";
                
                
            }
            else
            {
                timer1.Stop();
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

                textBox_response.ForeColor = Color.Green;
                textBox_response.Text = "Gut gemacht! Du hast alle Wörter richtig gehabt!";
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
