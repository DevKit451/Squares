using Squares;
using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Squares
{
    
    public class ColorHelper
    {
        private List<Subscribers> subscrubersList = new List<Subscribers>();
        public List<NamedColor> colors = new List<NamedColor>() 
        { 
            new NamedColor( "Белый", Color.FromRgb(255, 255, 255)),
            new NamedColor( "Чёрный",  Color.FromRgb(0, 0, 0)),
            new NamedColor( "Коричневый", Color.FromRgb(150, 75, 0)),
            new NamedColor( "Синий", Color.FromRgb(0, 0, 255)),
            new NamedColor( "Голубой", Color.FromRgb(0, 255, 255)),
            new NamedColor("Красный", Color.FromRgb(255, 0, 0)),
            new NamedColor("Жёлтый", Color.FromRgb(255, 255, 0)),
            new NamedColor("Зелёный", Color.FromRgb(0, 128, 0)),
            new NamedColor("Серый", Color.FromRgb(128, 128, 128)),
            new NamedColor("Розовый", Color.FromRgb(255, 192, 203))
        };
        //Механизм подписки
        public void AddSubscribers(Subscribers Subscriber)
        {
            subscrubersList.Add(Subscriber);
        }
        private void notifySubscribers()
        {
            subscrubersList.ForEach((Sub) => Sub.Update());
        }


        public NamedColor getRandomColor()
        {
            int listIndex = new Random().Next(0, colors.Count);
            NamedColor color = colors.ElementAt(listIndex);

            colors.RemoveAt(listIndex);

            return color;
        }
        public void ChaingeColor(Button button) {
            var BrushAdapter = new { brush = (SolidColorBrush)button.Background };
            NamedColor color = colors.ElementAt(0);

            colors.Add(new NamedColor(button.Content.ToString(), BrushAdapter.brush.Color));
            button.Background = new SolidColorBrush(color.Color);
            button.Content = color.Name;

            colors.RemoveAt(0);

            notifySubscribers();
        }
    }
}
