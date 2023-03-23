using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public partial class StackTest : Form
    {
        String output = ""; //postfix
        Stack<String> stack = new Stack<String>();
        public StackTest()
        {
            InitializeComponent();
        }

        private int valueOf(char opt)
        {
            switch(opt)
            {
                case '^':
                    return 3;
                case '*':
                    return 2;
                case '/':
                    return 2;
                case '+':
                    return 1;
                case '-':
                    return 1;
                default:
                    return 0;
            }
        }

        //private Boolean isOperand(int input)
        //{

        //}

    }
}
