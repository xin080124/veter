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

            labelMeaning.Visible = false;
            labelWord.Visible = false;

            textWord.Visible = false;
            textMeaning.Visible = false;

            butAdd.Visible = false;
            butSave.Visible = false;

            btnSuccess.Visible = false;
            butFail.Visible = false;

            labelName.Visible = false;
            textName.Visible = false;
            ModeComboBox.Visible = false;

            btnReport.Visible = false;


            theController = new WordController(this);
            //Student Tom = new Student("Tom");
            //theController.setStudent(Tom);
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
            butShowMeaning.Enabled = false;
            btnSuccess.Enabled = true;
            butFail.Enabled = true;
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            theController.addStudentPassTimes();
            butShowWord.Enabled = true;
            btnSuccess.Enabled = false;
            butFail.Enabled = false;
        }

        private void butFail_Click(object sender, EventArgs e)
        {
            theController.resetStudentPassTimes();
            butShowWord.Enabled = true;
            btnSuccess.Enabled = false;
            butFail.Enabled = false;
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

                btnSuccess.Visible = false;
                butFail.Visible = false;
            }    
            else
            {
                butShowWord.Visible = true;
                butShowMeaning.Visible = true;
                textWord.Visible = true;
                textMeaning.Visible = true;

                btnSuccess.Visible = true;
                butFail.Visible = true;
                
                string studentName = textName.Text;
                Student s = new Student(studentName);
                theController.setStudent(s);
            }

        }

        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountComboBox.Enabled = false;
            if(accountComboBox.SelectedIndex == 0)
            {
                int mode = 2;
                theController.setMode(2);

                butShowWord.Visible = false;
                butShowMeaning.Visible = false;

                butAdd.Visible = true;
                butSave.Visible = true;

                labelMeaning.Visible = true;
                labelWord.Visible = true;
                textWord.Visible = true;
                textMeaning.Visible = true;

                btnSuccess.Visible = false;
                butFail.Visible = false;
            }
            else if(accountComboBox.SelectedIndex == 1)
            {
                labelName.Visible = true;
                textName.Visible = true;
                ModeComboBox.Visible = true;

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

        private void btnReport_Click(object sender, EventArgs e)
        {
            String reportStr = "";
            reportStr = theController.generateReportString();
            MessageBox.Show(reportStr, "Test report");
        }
    }
}
