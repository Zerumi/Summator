using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    static class Calculator
    {
        public enum Symbols
        {
            Sum = '+',
            Dif = '-',
            Mul = '*',
            Div = '/'
        }

        public static void DeleteZeroIfExists (MainWindow window)
        {
            if (window.tbOutput.Text == "0" || window.isNextNumStartWrite)
            {
                window.tbOutput.Text = string.Empty;
                window.isNextNumStartWrite = false;
            }
        }
        static int FirstNum { get; set; }
        static int SecondNum { get; set; }
        static bool IsFirstNumAdded = false;
        public static void AddNumber(int number)
        {
            if (IsFirstNumAdded)
            {
                SecondNum = number;
            }
            else
            {
                FirstNum = number;
            }
            IsFirstNumAdded = !IsFirstNumAdded;
        }
        public static string Calculate(Symbols symbol)
        {
            try
            {
                if (!IsFirstNumAdded)
                {
                    switch (symbol)
                    {
                        case Symbols.Sum:
                            return Convert.ToString(FirstNum + SecondNum);
                        case Symbols.Dif:
                            return Convert.ToString(FirstNum - SecondNum);
                        case Symbols.Mul:
                            return Convert.ToString(FirstNum * SecondNum);
                        case Symbols.Div:
                            return Convert.ToString(FirstNum / SecondNum);
                        default:
                            break;
                    }
                }
                else
                {
                    throw new ArgumentException("Недостаточно параметров");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                IsFirstNumAdded = false;
            }
            return "0";
        }
    }
}
