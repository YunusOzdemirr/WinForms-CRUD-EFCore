using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobility.PrimeThreadApp
{
    public partial class PrimePageThread : Form
    {
        public PrimePageThread()
        {
            InitializeComponent();
        }
        static BindingSource bindingSource2 = new BindingSource();

        private async void ThreadPrime2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 3600; i++)
                {
                    if (IsPrime(i))
                    {
                        bindingSource2.Add(i);
                        Thread2ListBox2.Refresh();
                    }
                    Task.Delay(1000).Wait();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            Thread2ListBox2.DataSource = bindingSource2;
        }


        private void Thread2ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
