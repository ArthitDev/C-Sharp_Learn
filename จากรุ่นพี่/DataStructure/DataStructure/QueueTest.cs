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
    public partial class QueueTest : Form
    {
        int queueresult;
        int queuecount;
        Queue<int> queue = new Queue<int>();
        public QueueTest()
        {
            InitializeComponent();
        }
        private void QueueTest_Load(object sender, EventArgs e)
        {
            dataAll();
        }

        private void bEnqueue_Click(object sender, EventArgs e)
        {
            queue.Enqueue(int.Parse(queueNumber.Text));
            foreach(int data in queue)
            {
                Console.WriteLine("Queue: " + data);
            }
            Console.WriteLine("Number of Queue : " + queue.Count);
            nOfQueue.Text = queue.Count.ToString();
        }

        private void CheckQueue()
        {
            if (queue.Count == 1)
            {
                service1.Enabled = true;
                service2.Enabled = true;
                service3.Enabled = true;
            }
            else
            {
                service1.Enabled = false;
                service2.Enabled = false;
                service3.Enabled = false;
            }
        }

        private void bservice1_Click(object sender, EventArgs e)
        {
            queuecount = queue.Dequeue();
            service1.Text = queuecount.ToString();
            queueNumber.Text = queuecount.ToString();
            CheckQueue();
        }

        private void bservice2_Click(object sender, EventArgs e)
        {
            queuecount = queue.Dequeue();
            service1.Text = queuecount.ToString();
            queueNumber.Text = queuecount.ToString();
            CheckQueue();
        }

        private void bservice3_Click(object sender, EventArgs e)
        {
            queuecount = queue.Dequeue();
            service1.Text = queuecount.ToString();
            queueNumber.Text = queuecount.ToString();
            CheckQueue();
        }

        private void dataAll()
        {
            queue.Clear();
            queueresult = 0;
            service1.Text = "0";
            service2.Text = "0";
            service3.Text = "0";
            CheckQueue();
        }
    }
}
