using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctlQuizLib
{
    public enum outcome { Win, Lose, Draw };

    public partial class ctlQuiz: UserControl
    {
        private QuizController theController;

        public ctlQuiz()
        {
            InitializeComponent();
            theController = new QuizController(this);
            btnSubmit.Enabled = false;
            txtAnswer.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            theController.startQuiz();
            txtQuestion.Text = theController.readQuestion();
            btnSubmit.Enabled = true;
            btnStart.Enabled = false;
            txtAnswer.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            outcome result;
            string gameOutcome;
            string question;
            theController.processAnswer(txtAnswer.Text);
            txtQuestion.Text = "";
            txtAnswer.Text = "";
            question = theController.readQuestion();
            if (question == null)
            {
                result = theController.gameover();
                btnSubmit.Enabled = false;
                gameOutcome = Enum.GetName(typeof(outcome), result);
                MessageBox.Show(gameOutcome, "Game 0ver");
                btnStart.Enabled = true;
                txtAnswer.Enabled = false;
            }
            else
            {
                txtQuestion.Text = question;
            }
        }
    }
}
