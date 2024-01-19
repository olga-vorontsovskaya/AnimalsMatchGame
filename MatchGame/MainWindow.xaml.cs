using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MatchGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>() /// Изображения животных через эмодзи Windows
            {
                "🐙","🐙",
                "🦁","🦁",
                "🐍","🐍",
                "🐘","🐘",
                "🐶","🐶",
                "🐱","🐱",
                "🦜","🦜",
                "🐬","🐬",
            };
            Random random = new Random(); /// Случайная выборка пар животных в конструкторе, используя эмодзи-изображения вместо TextBlock
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }
    }
}
