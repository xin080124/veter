using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoriseWords
{
    public partial class ctlWords: UserControl
    {
        private WordController theController;

        public ctlWords()
        {
            InitializeComponent();

            butShowWord.Visible = false;
            butShowMeaning.Visible = false;

            textWord.Visible = false;
            textMeaning.Visible = false;

            theController = new WordController(this);
            Student Tom = new Student("Tom");
            theController.setStudent(Tom);
        }

        private void butShowWord_Click(object sender, EventArgs e)
        {
            //theController.readWord();
            textWord.Text = theController.getWord();
            if (ModeComboBox.SelectedIndex == 0)
                textMeaning.Text = theController.getMeaning();
            else if (ModeComboBox.SelectedIndex == 1)
            {
                textMeaning.Text = "";
                butShowWord.Enabled = false;
                butShowMeaning.Enabled = true;
            }
                
        }

        private void butShowMeaning_Click(object sender, EventArgs e)
        {
            textMeaning.Text = theController.getMeaning();
            butShowWord.Enabled = true;
            butShowMeaning.Enabled = false;
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            theController.addStudentPassTimes();
        }

        private void ModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mode = ModeComboBox.SelectedIndex;
            theController.setMode(mode);

            if (ModeComboBox.SelectedIndex == 0)
            {
                butShowWord.Visible = true;
                butShowMeaning.Visible = false;
                textWord.Visible = true;
                textMeaning.Visible = true;
            }    
            else
            {
                butShowWord.Visible = true;
                butShowMeaning.Visible = true;
                textWord.Visible = true;
                textMeaning.Visible = true;
            }

        }

        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(accountComboBox.SelectedIndex == 0)
            {
                int mode = 2;
                theController.setMode(2);

                butShowWord.Visible = false;
                butShowMeaning.Visible = false;
                textWord.Visible = true;
                textMeaning.Visible = true;

                btnSuccess.Visible = false;
                butFail.Visible = false;
            }
            else if(accountComboBox.SelectedIndex == 1)
            {
                butShowWord.Visible = false;
                butShowMeaning.Visible = false;
                textWord.Visible = false;
                textMeaning.Visible = false;
            }
            
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            string newWord = textWord.Text;
            string newMeaning = textMeaning.Text;
            theController.addNewWord(newWord, newMeaning);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            theController.saveNewWords();
        }
    }
}
