using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class Form_Questions : Form
    {
        private int questionIndex;
        private int correctAnswers;
        private List<Question> questions;
        private readonly Database_Manager dbManager;

        public Form_Questions(int index, string domeniu)
        {
            InitializeComponent();
            dbManager = new Database_Manager();
            InitQuestions(index, domeniu);
            InitControls();
        }

        private void InitQuestions(int indice, string domeniu)
        {
            questions = dbManager.GetQuestions(domeniu);
            label_title.Text = "Întrebări din " + domeniu;
        }

        private void InitControls()
        {
            questionIndex = 0;
            correctAnswers = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            label_percent.Text = "0 %";
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            Question question = questions[questionIndex];
            groupBox1.Text = question.Text;
            radioButton1.Text = question.Answers[0];
            radioButton2.Text = question.Answers[1];
            radioButton3.Text = question.Answers[2];
            radioButton4.Text = question.Answers[3];
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            button_next.Enabled = false;
        }

        private void CheckAnswer()
        {
            Question question = questions[questionIndex];
            string selectedAnswer = "";
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        selectedAnswer = radio.Text;
                    }
                }
            }
            if (selectedAnswer == question.CorrectAnswer)
            {
                correctAnswers++;
            }
            progressBar1.Value = correctAnswers * 100 / questions.Count;
            label_percent.Text = Convert.ToString(progressBar1.Value) + " %";
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            questionIndex++;
            if (questionIndex == questions.Count)
            {
                MessageBox.Show("Quiz terminat! Ai raspuns corect la " +
                    correctAnswers + " intrebari din " + questions.Count
                    + "." + Environment.NewLine + "Procentajul de raspunsuri " +
                    "corecte este de: " + progressBar1.Value + "%.", "Rezultat quiz");
                InitControls();
            }
            else
            {
                DisplayQuestion();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            button_next.Enabled = true;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Question
    {
        public string Text;
        public List<string> Answers;
        public string CorrectAnswer;

        public Question(string text)
        {
            Text = text;
            Answers = new List<string>();
        }
    }
}