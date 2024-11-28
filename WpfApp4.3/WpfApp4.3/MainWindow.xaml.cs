using StressTest;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp4._3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Проверка на null, чтобы избежать ошибок при отсутствии выбранного элемента
            if (materialsListBox.SelectedItem != null &&
                crossSectionsListBox.SelectedItem != null &&
                testResultsListBox.SelectedItem != null)
            {
                // Получаем выбранные значения перечислений с проверкой типа
                Material selectedMaterial = (Material)Enum.Parse(typeof(Material), ((ListBoxItem)materialsListBox.SelectedItem).Content.ToString());
                CrossSection selectedCrossSection = (CrossSection)Enum.Parse(typeof(CrossSection), ((ListBoxItem)crossSectionsListBox.SelectedItem).Content.ToString());
                TestResult selectedTestResult = (TestResult)Enum.Parse(typeof(TestResult), ((ListBoxItem)testResultsListBox.SelectedItem).Content.ToString());

                // Создаем строку с результатами выбора
                StringBuilder selectionStringBuilder = new StringBuilder();

                // Формируем строку с материалом
                switch (selectedMaterial)
                {
                    case Material.StainlessSteel:
                        selectionStringBuilder.Append("Material: Stainless Steel, ");
                        break;
                    case Material.Aluminium:
                        selectionStringBuilder.Append("Material: Aluminum, ");
                        break;
                    case Material.ReinforcedConcrete:
                        selectionStringBuilder.Append("Material: Reinforced Concrete, ");
                        break;
                    case Material.Composite:
                        selectionStringBuilder.Append("Material: Composite, ");
                        break;
                    case Material.Titanium:
                        selectionStringBuilder.Append("Material: Titanium, ");
                        break;
                }

                // Формируем строку с типом сечения
                switch (selectedCrossSection)
                {
                    case CrossSection.IBeam:
                        selectionStringBuilder.Append("Crosssection: I-Beam, ");
                        break;
                    case CrossSection.Box:
                        selectionStringBuilder.Append("Crosssection: Box, ");
                        break;
                    case CrossSection.ZShaped:
                        selectionStringBuilder.Append("Crosssection: Z-Shaped, ");
                        break;
                    case CrossSection.CShaped:
                        selectionStringBuilder.Append("Crosssection: C-Shaped, ");
                        break;
                }

                // Формируем строку с результатом теста
                switch (selectedTestResult)
                {
                    case TestResult.Pass:
                        selectionStringBuilder.Append("Result: Pass.");
                        break;
                    case TestResult.Fail:
                        selectionStringBuilder.Append("Result: Fail.");
                        break;
                }

                // Обновляем метку с результатами
                testDetailsLabel.Content = selectionStringBuilder.ToString();
            }
            else
            {
                // Если ничего не выбрано, выводим сообщение
                testDetailsLabel.Content = "Please select all options.";
            }
        }


    }
}
