namespace WpfApp4._4
{
    /// <summary>
    /// Перечисление типов материалов балок
    /// </summary>
    public enum Material
    {
        StainlessSteel, Aluminium, ReinforcedConcrete, Composite, Titanium
    }

    /// <summary>
    /// Перечисление типов поперечных сечений балок
    /// </summary>
    public enum CrossSection
    {
        IBeam, Box, ZShaped, CShaped
    }

    /// <summary>
    /// Перечисление результатов теста
    /// </summary>
    public enum TestResult
    {
        Pass, Fail
    }

    /// <summary>
    /// Структура, содержащая результаты теста
    /// </summary>
    public struct TestCaseResult
    {
        /// <summary>
        /// Результат теста (перечисление TestResult)
        /// </summary>
        public TestResult Result;

        /// <summary>
        /// Описание причины неудачи
        /// </summary>
        public string ReasonForFailure;

        // Конструктор для инициализации полей
        public TestCaseResult(TestResult result, string reasonForFailure)
        {
            Result = result;
            ReasonForFailure = reasonForFailure;
        }
    }
}
