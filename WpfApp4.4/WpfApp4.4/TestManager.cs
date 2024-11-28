using StressTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4._4
{
    public static class TestManager
    {
        private static Random _random = new Random();

        /// <summary>
        /// Генерирует результат теста. Может быть Pass или Fail с причиной.
        /// </summary>
        public static TestCaseResult GenerateResult()
        {
            // Генерация случайного результата (Pass или Fail)
            var result = _random.Next(2) == 0 ? TestResult.Pass : TestResult.Fail;

            if (result == TestResult.Fail)
            {
                // В случае неудачи генерируем случайную причину
                string[] failureReasons = { "Overload", "Material defect", "Design flaw", "Unexpected stress" };
                string reason = failureReasons[_random.Next(failureReasons.Length)];
                return new TestCaseResult(result, reason);
            }
            else
            {
                return new TestCaseResult(result, string.Empty);
            }
        }
    }
}
