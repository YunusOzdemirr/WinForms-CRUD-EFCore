using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mobility.PrimeThreadApp
{
    public partial class PrimePage : Form
    {
        public PrimePage()
        {
            InitializeComponent();
        }
        static BindingSource bindingSource1 = new BindingSource();
        static BindingSource bindingSource2 = new BindingSource();

        private async void ThreadPrime1_Click(object sender, EventArgs e)
        {
            try
            {

            Thread newWindowThread = new Thread(new ThreadStart(ThreadStartingPoint));
            newWindowThread.SetApartmentState(ApartmentState.STA);
            newWindowThread.IsBackground = true;
            newWindowThread.Start();

                for (int i = 0; i < 3600; i++)
            {
                if (IsPrime(i))
                {
                    bindingSource1.Add(i);
                    Thread1ListBox1.Refresh();
                }
                Task.Delay(1000).Wait();
            }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ThreadPrime2_Click(object sender, EventArgs e)
        {
            Thread newWindowThread = new Thread(new ThreadStart(PrimeCounter));
            newWindowThread.IsBackground = true;
            newWindowThread.Start();

        }
        private void ThreadStartingPoint()
        {
            PrimePageThread tempWindow = new PrimePageThread();
            tempWindow.Show();
        }

        public static void PrimeCounter()
        {
            for (int i = 0; i < 3600; i++)
            {
                if (IsPrime(i))
                    SetData(i);
            }
        }
        public static void SetData(int i)
        {
            bindingSource2.Add(i);
            Thread2ListBox2.Refresh();
        }
        public static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        private void PrimePage_Load(object sender, EventArgs e)
        {
            Thread1ListBox1.DataSource = bindingSource1;
            Thread2ListBox2.DataSource = bindingSource2;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            bindingSource2.Clear();
            Thread1ListBox1.DataSource = bindingSource1;
            Thread2ListBox2.DataSource = bindingSource2;
        }

        private void Thread2ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
