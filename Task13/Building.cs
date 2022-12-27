using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Task13
{
    class Building
    {
        private string adress;
        private double length;
        private double width;
        private double hight;

        public Building(string adress, double length, double width, double hight)
        {
            this.Adress = adress;
            this.Length = length;
            this.Width = width;
            this.Hight = hight;
        }

        public string Adress
        {
            get { return adress; }
            set
            {
                if (value is "")
                {
                    adress = "Неизвестен";
                }
                else
                {
                    adress = value;
                }
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина меньше или равна 0");

                }
                else
                    length = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ширина меньше или равна 0");
                }
                else
                    width = value;
            }
        }

        public double Hight
        {
            get { return hight; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Высота меньше или равна 0");
                }
                else
                    hight = value;
            }
        }

        public string Print()
        {
            if (length <= 0 || width <= 0 || hight <= 0)
                return "Некорректно введены данные";
            else
                return $"Адрес: {adress}, размеры: длина={length}м, ширина={width}м, высота={hight}м";
        }
    }
}
