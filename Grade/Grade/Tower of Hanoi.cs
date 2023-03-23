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
    public partial class Tower_of_Hanoi : Form
    {
        public Tower_of_Hanoi()
        {
            InitializeComponent();
            towerOfHanoi();
        }
        private void towerOfHanoi()
        {
            Stack<int> tower1 = new Stack<int>();
            Stack<int> tower2 = new Stack<int>();
            Stack<int> tower3 = new Stack<int>();
            tower1.Push(5);
            tower1.Push(4);
            tower1.Push(3);
            tower1.Push(2);
            tower1.Push(1);
            tower3.Push(tower1.Pop());
            tower2.Push(tower1.Pop());
            tower2.Push(tower3.Pop());
            tower3.Push(tower1.Pop());
            tower1.Push(tower2.Pop());
            tower3.Push(tower2.Pop());
            tower3.Push(tower1.Pop());
            tower2.Push(tower1.Pop());
            tower2.Push(tower3.Pop());
            tower1.Push(tower3.Pop());
            tower1.Push(tower2.Pop());
            tower2.Push(tower3.Pop());
            tower3.Push(tower1.Pop());
            tower2.Push(tower1.Pop());
            tower2.Push(tower3.Pop());
            tower3.Push(tower1.Pop()); //ครั้งที่ 16 
            tower1.Push(tower2.Pop());
            tower3.Push(tower2.Pop());
            tower3.Push(tower1.Pop());
            tower1.Push(tower2.Pop());
            tower2.Push(tower3.Pop());
            tower1.Push(tower3.Pop());
            tower1.Push(tower2.Pop());
            tower3.Push(tower2.Pop());
            tower3.Push(tower1.Pop());
            tower2.Push(tower1.Pop());
            tower2.Push(tower3.Pop());
            tower3.Push(tower1.Pop());
            tower1.Push(tower2.Pop());
            tower3.Push(tower2.Pop());
            tower3.Push(tower1.Pop());
            Console.WriteLine("เสาที่ 1");
            showTower(tower1);
            Console.WriteLine("เสาที่ 2");
            showTower(tower2);
            Console.WriteLine("เสาที่ 3 ");
            showTower(tower3);
        }

        private void showTower(Stack<int> tower)
        {
            foreach (int data in tower)
            {
                Console.WriteLine(data + "");
            }
        }
    }
}
