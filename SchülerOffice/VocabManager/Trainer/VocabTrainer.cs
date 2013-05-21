using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SchülerOffice.VocabManager.Trainer;
using SchülerOffice.VocabManager;

namespace SchülerOffice
{
    partial class Form1
    {
        private void button_voc_learn_Click(object sender, EventArgs e)
        {
            dataGridView_voc.Rows.Clear();
            Vocabulary vocab = getSelectedVocabulary();
            if (vocab != null)
            {
                Trainer form = new Trainer(getSelectedVocabulary());
                form.ShowDialog();
            }
            UpdateVocabulary();
        }

        private void button_voc_test_Click(object sender, EventArgs e)
        {
            Vocabulary vocab = getSelectedVocabulary();
            if (vocab != null)
            {
                // Test Form
                //form.ShowDialog();
            }
        }

        private void button_voc_display_Click(object sender, EventArgs e)
        {

        }
    }
}
