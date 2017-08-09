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
            theController = new WordController(this);
            Student Tom = new Student("Tom");
            theController.setStudent(Tom);
        }

        private void butShowWord_Click(object sender, EventArgs e)
        {
            //theController.readWord();
            textWord.Text = theController.readWord();
        }

        private void butShowMeaning_Click(object sender, EventArgs e)
        {
            textMeaning.Text = theController.readMeaning();
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            theController.addStudentPassTimes();
        }
    }
}
