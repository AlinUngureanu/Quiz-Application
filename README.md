# Quiz-Application

It's a quiz app consisting of three forms. The first form is for authentication, where the user enters his login data, which is checked against those stored in a file, assuming he already has an account created. After logging in, the user will have a list of domains to choose from to start the quiz.

Each domain contains a set of 25 questions in the database, from which five are selected randomly for the quiz. If the user wants to repeat the quiz on the same domain, another set of five questions will be selected randomly from the 25 available questions. This applies to any domain.

After selecting the domain, the application displays one question on each page (5 questions in total), each with 4 answer options, from which the user must choose the correct one. On the questions form, a progress bar is also displayed that indicates the percentage of correct answers, so the user can see whether he answered each question correctly or incorrectly.

At the end of the quiz, the user will receive a message with the score obtained, after which the quiz is reset. The user also has the option to exit the quiz and select another domain to continue with other questions.
