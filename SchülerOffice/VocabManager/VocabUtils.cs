using SchülerOffice.VocabManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchülerOffice
{
    partial class Form1
    {
        /// <summary>
        /// Updates the treeview
        /// </summary>
        public void UpdateVocabulary()
        {
            treeView1.Nodes.Clear();
            foreach (Vocabulary vocab in Data.vocabulary)
            {
                if (!treeView1.Nodes.ContainsKey(getIdentifier(vocab,true)))
                {
                    treeView1.Nodes.Add(getIdentifier(vocab,false), vocab.fromLang + " - " + vocab.toLang);
                }
                treeView1.Nodes[getIdentifier(vocab,false)].Nodes.Add(getIdentifier(vocab,true),vocab.name);
            }
        }

        /// <summary>
        /// Prints the words out on the datagridview of the selected vocabulary
        /// Fires when you select something on the treeview
        /// </summary>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridView_voc.Rows.Clear();
            Vocabulary vocab = getSelectedVocabulary();
            if (vocab != null)
            {
                foreach (VocWord word in vocab.words)
                {
                    dataGridView_voc.Rows.Add(new string[] { word.fromVal, word.toVal, word.desc });
                }
            }
        }

        /// <summary>
        /// Adds a new vocabulary
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            AddVocabulary form = new AddVocabulary();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Data.vocabulary.Add(form.vocabulary);
            }
            UpdateVocabulary();
        }

        /// <summary>
        /// Edits the selected vocabulary
        /// </summary>
        private void button_voc_edit_Click(object sender, EventArgs e)
        {
            Vocabulary vocab = getSelectedVocabulary();
            if (vocab != null)
            {
                AddVocabulary form = new AddVocabulary(vocab);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Data.vocabulary.Remove(vocab);
                    Data.vocabulary.Add(form.vocabulary);
                }
                UpdateVocabulary();
            }
        }

        /// <summary>
        /// Deletes the selected vocabulary
        /// </summary>
        private void button_voc_delete_Click(object sender, EventArgs e)
        {
            Vocabulary vocab = getSelectedVocabulary();
            if (vocab != null)
            {
                Data.vocabulary.Remove(vocab);
                UpdateVocabulary();
            }
        }

        /// <summary>
        /// Gets a identifier to identify which vocabulary is selected in the treeview
        /// </summary>
        /// <param name="vocab">The vocabulary to identify</param>
        /// <param name="large">If it needs a identifer for the vocabulary or the languages (true for vocabulary)</param>
        /// <returns>a string view the identifier</returns>
        private string getIdentifier(Vocabulary vocab, bool large)
        {
            if (large)
            {
                return vocab.fromLang + "," + vocab.toLang + "," + vocab.name + "," + vocab.desc + "," + vocab.date;
            }
            else
            {
                return vocab.fromLang + "," + vocab.toLang;
            }
        }

        /// <summary>
        /// Gets the vocabulary selected in the treeview
        /// </summary>
        /// <returns>The selected vocabulary</returns>
        private Vocabulary getSelectedVocabulary()
        {
            foreach (Vocabulary voc in Data.vocabulary)
            {
                TreeNode node = treeView1.Nodes.Find(getIdentifier(voc, true), true)[0];
                if (treeView1.Nodes.Find(getIdentifier(voc, true), true)[0] == treeView1.SelectedNode)
                {
                    return voc;
                }
            }

            return null;
        }
    }
}
