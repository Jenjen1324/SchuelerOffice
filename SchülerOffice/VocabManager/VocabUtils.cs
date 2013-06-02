using SchülerOffice.VocabManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
            treeView1.ExpandAll();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Vocabulary vocab = getSelectedVocabulary();
            if (vocab != null)
            {
                EmailPrompt ep = new EmailPrompt();
                if (ep.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(Data.tmpFolder))
                    {
                        Directory.CreateDirectory(Data.tmpFolder);
                    }
                    string[] files = Directory.GetFiles(Data.tmpFolder);
                    foreach (string file in files)
                    {
                        File.Delete(file);
                    }

                    
                    string xml = Vocabulary.vocabToXml(vocab);
                    string _file = Data.tmpFolder + vocab.name + ".xml";
                    File.WriteAllText(_file, xml);

                    MapiMailMessage message = new MapiMailMessage("Ich teile ein Vokabular mit dir: " + vocab.name, "Speichere den Anhang, wähle \"Importieren\" im Vokabular-Trainer und wähle den gespeicherten Anhang aus!");
                    message.Recipients.Add(ep.email);
                    message.Files.Add(_file);
                    message.ShowDialog();

                    /*string args = "?subject=" + "Ich teile ein Vokabular mit dir: " + vocab.name
                        + "&body=" + "Speichere den Anhang, wähle \"Importieren\" im Vokabular-Trainer und wähle den gespeicherten Anhang aus!"
                        + "&Attach=\"" + Data.tmpFolder + vocab.name + ".xml\""
                       ;
                    MessageBox.Show(args);

                    System.Diagnostics.Process.Start("mailto:" + ep.email + args);*/
                }
            }
        }

        private void button_voc_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml files (*.xml)|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = ofd.FileName;
                    string data = File.ReadAllText(filename);
                    Vocabulary vocab = Vocabulary.xmlToVocab(data);
                    if (vocab.name == "" || vocab.name == null)
                    {
                        throw new Exception("Invalid vocabulary!");
                    }
                    Data.vocabulary.Add(vocab);
                    UpdateVocabulary();
                }
                catch
                {
                    Data.messageBox("Error!", "Invalides vokabular!");
                }
            }
        }
    }
}
