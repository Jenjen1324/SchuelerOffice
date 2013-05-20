using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchülerOffice.VocabManager
{
    public partial class AddVocabulary : Form
    {

        private static bool editing = false;
        private static Vocabulary vocab = new Vocabulary("","",new List<VocWord>(), "","","","");

        public Vocabulary vocabulary
        {
            get { return vocab; }
        }

        public AddVocabulary()
        {
            InitializeComponent();
            updateList();
        }

        public AddVocabulary(Vocabulary vocab_)
        {
            InitializeComponent();
            vocab = vocab_;
            updateList();

            textBox_name.Text = vocab.name;
            textBox_desc.Text = vocab.desc;
            textBox_1lang.Text = vocab.fromLang;
            textBox_2lang.Text = vocab.toLang;
        }

        private void updateList()
        {
            if(textBox_1lang.Text != "" && textBox_2lang.Text != "")
            {
            dataGridView1.Columns[0].HeaderText = textBox_1lang.Text;
            dataGridView1.Columns[1].HeaderText = textBox_2lang.Text;
            label_word_1lang.Text = textBox_1lang.Text;
            label_word_2lang.Text = textBox_2lang.Text;
            }
            dataGridView1.Rows.Clear();
            foreach (VocWord word in vocab.words)
            {
                dataGridView1.Rows.Add(new string[] { word.fromVal,word.toVal,word.desc,getWordIdentifier(word) });
            }
        }

        void dataGridView1_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Selected = true;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            VocWord word = getSelectedWord();
            if (word != null)
            {
                vocab.words.Remove(word);
                updateList();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_word_1lang.Text == "" || textBox_word_2lang.Text == "")
            {
                Data.messageBox("Warnung!", "Bitte beide sprachen eingeben!");
            }
            else
            {
                VocWord word = new VocWord(textBox_word_1lang.Text, textBox_word_2lang.Text, textBox_word_desc.Text);
                vocab.words.Add(word);
                textBox_word_1lang.Text = "";
                textBox_word_2lang.Text = "";
                textBox_word_desc.Text = "";
                updateList();
            }
        }

        private void AddVocabulary_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            vocab.name = textBox_name.Text;
            vocab.desc = textBox_desc.Text;
            vocab.fromLang = textBox_1lang.Text;
            vocab.toLang = textBox_2lang.Text;
            vocab.author = "Not implemented";
            vocab.date = DateTime.Now.ToString("d.MM.yy");
        }

        private string getWordIdentifier(VocWord word)
        {
            return word.fromVal + "," + word.toVal + "," + word.desc;
        }

        private VocWord getSelectedWord()
        {
            foreach (VocWord word in vocab.words)
            {
                if (getWordIdentifier(word) == dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value.ToString())
                {
                    return word;
                }
            }
            return null;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                button_edit.Text = "Editieren";
                editing = false;
                VocWord word = getSelectedWord();
                vocab.words.Remove(word);
                button_add_Click(null, null);
            }
            else
            {
                button_edit.Text = "Speichern";
                editing = true;
                VocWord word = getSelectedWord();
                textBox_word_1lang.Text = word.fromVal;
                textBox_word_2lang.Text = word.toVal;
                textBox_word_desc.Text = word.desc;
            }
        }
    }
}
