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
    public partial class RecursiveDemo : Form
    {
        public RecursiveDemo()
        {
            InitializeComponent();
            //Console.WriteLine(shownum(10));
            shownum(10);
        }

        private int factorial2(int n)
        {
            if (n == 1)
                return 1;
            return n * factorial2(n - 1);

        }

        private void shownum(int n)
        {
            Console.WriteLine(n);
            if (n != 1)
                shownum(n - 1);
        }


        private int factorial(int n)
        {
            int result = 1;
            for(int i = 5;i >= 1; i--)
            {
                result = result * i;
            }
            return result;
        }
    }
}
