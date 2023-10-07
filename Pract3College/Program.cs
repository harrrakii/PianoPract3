using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3College
{
    internal class Program
    {
        static void Main()
        {
                Console.WriteLine("Клавиши для игры на пианино: Q; W; E; R; T; Y; O; P; {; }\n\r" +
                "Переключение октав: F1; F2; F3\n\r" +
                "Для выхода из программы нажмите клавишу Escape");
                PianoPlay();
        }
        private static double[] Octaves(int changeOfOctave)
        {
            double[] octaves = new double[12];
            switch (changeOfOctave)
            {
                case 1:
                    {
                        octaves[0] = 261.63;
                        octaves[1] = 277.18;
                        octaves[2] = 293.66;
                        octaves[3] = 311.13;
                        octaves[4] = 329.63;
                        octaves[5] = 349.23;
                        octaves[6] = 369.99;
                        octaves[7] = 392.00;
                        octaves[8] = 415.30;
                        octaves[9] = 440.00;
                        octaves[10] = 466.16;
                        octaves[11] = 493.88;
                        break;
                    }
                case 2:
                    {
                        octaves[0] = 523.25;
                        octaves[1] = 554.36;
                        octaves[2] = 587.32;
                        octaves[3] = 622.26;
                        octaves[4] = 659.26;
                        octaves[5] = 698.46;
                        octaves[6] = 739.98;
                        octaves[7] = 784.00;
                        octaves[8] = 830.60;
                        octaves[9] = 880.00;
                        octaves[10] = 932.32;
                        octaves[11] = 987.75;
                        break;
                    }
                case 3:
                    {
                        octaves[0] = 1046.50;
                        octaves[1] = 1108.70;
                        octaves[2] = 1174.60;
                        octaves[3] = 1244.50;
                        octaves[4] = 1318.50;
                        octaves[5] = 1396.90;
                        octaves[6] = 1480.00;
                        octaves[7] = 1568.00;
                        octaves[8] = 1661.20;
                        octaves[9] = 1720.00;
                        octaves[10] = 1864.60;
                        octaves[11] = 1975.50;
                        break;
                    }
                default:
                    Console.WriteLine("Неверная клавиша");
                    break;
            }
            return octaves;
        }
        static void PianoPlay()
        {
            double[] octaves;
            ConsoleKeyInfo key;
            int changeOfOctave = 1;
            octaves = Octaves(changeOfOctave);
            do
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Q:
                        Console.Beep(Convert.ToInt32(octaves[0]), 500);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(Convert.ToInt32(octaves[1]), 500);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(Convert.ToInt32(octaves[2]), 500);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(Convert.ToInt32(octaves[3]), 500);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(Convert.ToInt32(octaves[4]), 500);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(Convert.ToInt32(octaves[5]), 500);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(Convert.ToInt32(octaves[6]), 500);
                        break;
                    case ConsoleKey.I:
                        Console.Beep(Convert.ToInt32(octaves[7]), 500);
                        break;
                    case ConsoleKey.O:
                        Console.Beep(Convert.ToInt32(octaves[8]), 500);
                        break;
                    case ConsoleKey.P:
                        Console.Beep(Convert.ToInt32(octaves[9]), 500);
                        break;
                    case ConsoleKey.Oem4:
                        Console.Beep(Convert.ToInt32(octaves[10]), 500);
                        break;
                    case ConsoleKey.Oem6:
                        Console.Beep(Convert.ToInt32(octaves[11]), 500);
                        break;
                    case ConsoleKey.F1:
                        octaves = Octaves(1);
                        break;
                    case ConsoleKey.F2:
                        octaves = Octaves(2);
                        break;
                    case ConsoleKey.F3:
                        octaves = Octaves(3);
                        break;
                    default:
                        Console.WriteLine("Неправильная клавиша!");
                        break;
                }
            }
            while (key.Key != ConsoleKey.Escape);
        }
    }
}