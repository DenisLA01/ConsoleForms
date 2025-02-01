using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleForms
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Form form = new InteractiveForm("Опрос");
            Application.Run(form);
        }
        public class InteractiveForm : Form
        {
            public InteractiveForm(string title)
            {
                Text = title;
                Height = 300;
                Width = 400;
                StartPosition = FormStartPosition.CenterScreen;
                Button exitButton = CreateButton(new Size(80, 40), new Point(290, 220), "Выход");
                exitButton.Click += (sender, e) => Application.Exit();
                Button yesButton = CreateButton(new Size(80, 40), new Point(200, 125), "Да");
                yesButton.Click += (sender, e) => { MessageBox.Show("Отлично, знания - сила!"); Application.Exit(); };
                Button noButton = CreateButton(new Size(80, 40), new Point(100, 125), "Нет");
                noButton.Click += (sender, e) => { MessageBox.Show("Поступайте в Политех!"); Application.Exit(); };
                Label label = CreateLabel(new Size(200, 35), new Point(140, 80), "Вы учитесь в ВУЗе?");

            }
            private void ShowLabel(Label label)
            {

            }
            private void SetCommonParameters(Control element, Size size, Point position, string title)
            {
                element.Size = size;
                element.Location = position;
                element.Text = title;
                Controls.Add(element);
            }
            private Button CreateButton(Size size, Point position, string title)
            {
                Button button = new Button();
                SetCommonParameters(button, size, position, title);
                return button;
            }
            private Label CreateLabel(Size size, Point position, string title)
            {
                Label label = new Label();
                SetCommonParameters(label, size, position, title);
                return label;
            }


        }
    }
}



        
    

