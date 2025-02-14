using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Quiz_Application
{
    class Database_Manager
    {
        private readonly string connectionString = @"Data Source=DESKTOP-9GKFSI5\SQLEXPRESS;Initial Catalog=QuizApplication;Integrated Security=True;";
        public List<Question> GetQuestions(string category)
        {
            List<Question> questions = new List<Question>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT q.Question_ID, q.Text, a.AnswerText, a.IsCorrect " +
                               "FROM Questions q " +
                               "JOIN Answers a ON q.Question_ID = a.Question_ID " +
                               "WHERE q.Category = @category " +
                               "ORDER BY q.Question_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@category", category);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Guid currentQuestionId = Guid.Empty;
                        Question currentQuestion = null;
                        while (reader.Read())
                        {
                            Guid questionId = reader.GetGuid(0);
                            string text = reader.GetString(1);
                            string answerText = reader.GetString(2);
                            bool isCorrect = reader.GetBoolean(3);
                            if (questionId != currentQuestionId)
                            {
                                currentQuestion = new Question(text);
                                questions.Add(currentQuestion);
                                currentQuestionId = questionId;
                            }
                            currentQuestion.Answers.Add(answerText);
                            if (isCorrect)
                            {
                                currentQuestion.CorrectAnswer = answerText;
                            }
                        }
                    }
                }
            }
            return questions;
        }
    }
}