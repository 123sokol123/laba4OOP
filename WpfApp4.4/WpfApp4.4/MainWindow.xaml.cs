using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfApp4._4
{
    public partial class MainWindow : Window
    {
        private TestCaseResult[] results;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunTests_Click(object sender, RoutedEventArgs e)
        {
            // Очистка списка причин ошибок
            ReasonsListBox.Items.Clear();

            // Создание массива результатов тестов
            results = new TestCaseResult[10]; // Пример - 10 тестов
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = TestManager.GenerateResult(); // Генерация случайного результата
            }

            // Подсчет успешных и неудачных тестов
            int passCount = 0;
            int failCount = 0;
            List<string> reasonsList = new List<string>();

            // Перебор массива результатов и обработка
            foreach (var result in results)
            {
                if (result.Result == TestResult.Pass)
                {
                    passCount++;
                }
                else if (result.Result == TestResult.Fail)
                {
                    failCount++;
                    reasonsList.Add(result.ReasonForFailure); // Добавление причины неудачи в список
                }
            }

            // Обновление UI с количеством успешных и неудачных тестов
            SuccessCountText.Text = $"Successes: {passCount}";
            FailureCountText.Text = $"Failures: {failCount}";

            // Отображение причин неудачных тестов
            foreach (var reason in reasonsList)
            {
                ReasonsListBox.Items.Add(reason);
            }
        }
    }
}
