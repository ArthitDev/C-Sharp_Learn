using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade
{
    public partial class infix_postfix : Form
    {
        public infix_postfix()
        {
            InitializeComponent();
            String postfix = infixToPostfix("5 + 7 * 9 / 3 - 4 ");
            Console.WriteLine(postfix);
            answer("5296*3//6/+");
        }
        public static bool isOperand(String input)
        {
            try
            {
                double num = Double.Parse(input);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static int getValue(String input)
        {
            switch (input)
            {
                case "+":
                case "-": return 1;
                case "*":
                case "/": return 2;
                case "^": return 3;
            }
            return 0;
        }
        public static String infixToPostfix(String infix)
        {
            String[] input = infix.Split(' ');
            Stack<String> Data = new Stack<String>();
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (isOperand(input[i]))
                {
                    output += input[i];
                }
                else
                {
                    switch (input[i])
                    {
                        case "(": Data.Push(input[i]); break;
                        case ")":
                            while (Data.Peek() != "(")
                            {
                                output += Data.Pop();
                            }
                            Data.Pop();
                            break;
                        default:
                            while (Data.Count > 0)
                            {
                                int inputValue = getValue(input[i]);
                                int stackValue = getValue(Data.Peek());
                                if (inputValue > stackValue)
                                {
                                    break;
                                }
                                else
                                {
                                    output += Data.Pop();
                                }
                            }
                            Data.Push(input[i]);
                            break;
                    }
                }
            }
            while (Data.Count > 0)
            {
                output += Data.Pop();
            }
            return output;
        }
        public double answer(String Ans_Post_Fix)
        {
            return 0;
        }
    }
}