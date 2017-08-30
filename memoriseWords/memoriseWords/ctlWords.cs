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

        ///<Summary> method : ctlWords()
        //the constructor of ctlWords
        ///</Summary>
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
        }

        ///<Summary> method : butShowWord_Click()
        //the response of 'show word' button
        ///</Summary>
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

                if(theController.ifEnd() == true)
                {
                    btnReport.Visible = true;
                }
            }
                
        }

        ///<Summary> method : butShowMeaning_Click()
        //the response of 'show meaning' button
        ///</Summary>
        private void butShowMeaning_Click(object sender, EventArgs e)
        {
            textMeaning.Text = theController.getMeaning();
            butShowMeaning.Enabled = false;
            btnSuccess.Enabled = true;
            butFail.Enabled = true;
        }

        ///<Summary> method : btnSuccess_Click()
        //the response of 'success' button
        ///</Summary>
        private void btnSuccess_Click(object sender, EventArgs e)
        {
            theController.addStudentPassTimes();
            butShowWord.Enabled = true;
            btnSuccess.Enabled = false;
            butFail.Enabled = false;
        }

        ///<Summary> method : butFail_Click()
        //the response of 'fail' button
        ///</Summary>
        private void butFail_Click(object sender, EventArgs e)
        {
            theController.resetStudentPassTimes();
            butShowWord.Enabled = true;
            btnSuccess.Enabled = false;
            butFail.Enabled = false;
        }

        ///<Summary> method : ModeComboBox_SelectedIndexChanged()
        //the response of mode selector
        ///</Summary>
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

        ///<Summary> method : accountComboBox_SelectedIndexChanged()
        //the response of action selector
        ///</Summary>
        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountComboBox.Enabled = false;
            if(accountComboBox.SelectedIndex == 0)
            {
                int mode = 2;
                theController.setMode(mode);

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

        ///<Summary> method : butAdd_Click()
        //the response of 'add' button
        ///</Summary>
        private void butAdd_Click(object sender, EventArgs e)
        {
            string newWord = textWord.Text;
            string newMeaning = textMeaning.Text;
            theController.addNewWord(newWord, newMeaning);
        }

        ///<Summary> method : butSave_Click()
        //the response of 'save' button
        ///</Summary>
        private void butSave_Click(object sender, EventArgs e)
        {
            theController.saveNewWords();
        }

        ///<Summary> method : btnReport_Click()
        //the response of 'report' button
        ///</Summary>
        private void btnReport_Click(object sender, EventArgs e)
        {
            String reportStr = "";
            reportStr = theController.generateReportString();
            MessageBox.Show(reportStr, "Test report");
        }
    }
}
