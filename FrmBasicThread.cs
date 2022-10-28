using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04LabExercise1
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA, ThreadB;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delThread = new ThreadStart(MyThreadClass.Thread1);
            Console.WriteLine("-Before Starting the Thread-");

            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadA.Name = "Thread A";

            Thread ThreadB = new Thread(MyThreadClass.Thread1);
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = "     -End of Thread-";
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {

        }
    }
}
