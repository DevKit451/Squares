using Newtonsoft.Json.Linq;
using RestSharp;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Squares
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int indexForColorOfButton1;
        public int indexForColorOfButton2;
        public int indexForColorOfButton3;
        public int indexForColorOfButton4;
        public int indexForColorOfButton5;
        public int indexForColorOfButton6;
        public int indexForColorOfButton7;
        public int indexForColorOfButton8;
        public int indexForColorOfButton9;
        public ColorHelper colorHelper = new ColorHelper();
        public Counter iterator = new Counter();
        public MainWindow()
        {
            InitializeComponent();
            //Добавляем в подписчики счетчик количества нажатий
            colorHelper.AddSubscribers(iterator);
            // генерируем рандомную информацию по изначальным цветам
            var button1Color = colorHelper.getRandomColor();
            var button2Color = colorHelper.getRandomColor();
            var button3Color = colorHelper.getRandomColor();
            var button4Color = colorHelper.getRandomColor();
            var button5Color = colorHelper.getRandomColor();
            var button6Color = colorHelper.getRandomColor();
            var button7Color = colorHelper.getRandomColor();
            var button8Color = colorHelper.getRandomColor();
            var button9Color = colorHelper.getRandomColor();
            // применяем изначальные значения
            Button1.Background = new SolidColorBrush(button1Color.Color);
            Button1.Content = button1Color.Name;

            Button2.Background = new SolidColorBrush(button2Color.Color);
            Button2.Content = button2Color.Name;

            Button3.Background = new SolidColorBrush(button3Color.Color);
            Button3.Content = button3Color.Name;

            Button4.Background = new SolidColorBrush(button4Color.Color);
            Button4.Content = button4Color.Name;

            Button5.Background = new SolidColorBrush(button5Color.Color);
            Button5.Content = button5Color.Name;

            Button6.Background = new SolidColorBrush(button6Color.Color);
            Button6.Content = button6Color.Name;

            Button7.Background = new SolidColorBrush(button7Color.Color);
            Button7.Content = button7Color.Name;

            Button8.Background = new SolidColorBrush(button8Color.Color);
            Button8.Content = button8Color.Name;

            Button9.Background = new SolidColorBrush(button9Color.Color);
            Button9.Content = button9Color.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            colorHelper.ChaingeColor(button);
            Iterator.Text = "Количество нажатий: " + iterator.getCounter().ToString();
        }
        private void Temp_TextChanged(object sender, TextChangedEventArgs e)
        {
            // get запрос
            var client = new RestClient("https://pogoda.mail.ru");
            var request = new RestRequest("/ext/cities/");
            var response = client.ExecuteGet(request);
            // парсим результат
            JObject data = JObject.Parse(response.Content);
            Temp.Text = $"Текущее время: {DateTime.Now.ToString("HH:mm")}\n Температура воздуха: {(string)data["cities"][0]["temp"]}";
        }

        private void Iterator_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}