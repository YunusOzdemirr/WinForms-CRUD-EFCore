namespace Mobility.PrimeThreadApp
{
    public partial class PrimePage : Form
    {
        public PrimePage()
        {
            InitializeComponent();
        }
        private static readonly object lockObject = new object();
        static BindingSource bindingSource1 = new BindingSource();
        static BindingSource bindingSource2 = new BindingSource();
        //public static ObservableCollection<int> Numbers1 = new ObservableCollection<int>();
        //public static ObservableCollection<int> Numbers2 = new ObservableCollection<int>();
        private async void ThreadPrime1_Click(object sender, EventArgs e)
        {
            Thread newWindowThread = new Thread(new ThreadStart(ThreadStartingPoint));
            newWindowThread.SetApartmentState(ApartmentState.STA);
            newWindowThread.IsBackground = true;
            newWindowThread.Start();
        }

        private void ThreadPrime2_Click(object sender, EventArgs e)
        {
            Thread newWindowThread = new Thread(new ThreadStart(ThreadStartingPoint2));
            newWindowThread.SetApartmentState(ApartmentState.STA);
            newWindowThread.IsBackground = true;
            newWindowThread.Start();
        }
        private void ThreadStartingPoint()
        {
            for (int i = 0; i < int.Parse(txtThread1.Text); i++)
            {
                if (IsPrime(i))
                {
                    //if (Thread1ListBox1.InvokeRequired)
                    //{
                    //    SetValueToListBox dlgt = new SetValueToListBox(SetData);
                    //    this.Invoke(dlgt, new object[] { i });
                    //    Thread1ListBox1.Refresh();
                    //}
                    lock (lockObject)
                    {
                        bindingSource1.Add(i);
                    }
                    Thread1ListBox1.Invoke((Action)(() =>
                    {
                        Thread1ListBox1.DataSource = null;
                        Thread1ListBox1.DataSource = bindingSource1;
                    }));
                }
                Task.Delay(1000).Wait();
            }
        }
        private void ThreadStartingPoint2()
        {
            for (int i = 0; i < int.Parse(txtThread2.Text); i++)
            {
                if (IsPrime(i))
                {
                    lock (lockObject)
                    {
                        bindingSource2.Add(i);
                    }
                    Thread2ListBox2.Invoke((Action)(() =>
                    {
                        Thread2ListBox2.DataSource = null;
                        Thread2ListBox2.DataSource = bindingSource2;
                    }));
                }
                Task.Delay(250).Wait();
            }
        }

        delegate void SetValueToListBox(int text);
        delegate void ResetListBoxs();
        public static void SetData(int i)
        {
            bindingSource2.Add(i);
        }
        public static void SetData2(int i)
        {
            bindingSource1.Add(i);
        }

        private void PrimePage_Load(object sender, EventArgs e)
        {
            Thread1ListBox1.DataSource = bindingSource1;
            Thread2ListBox2.DataSource = bindingSource2;
            txtThread1.Text = 100.ToString();
            txtThread2.Text = 100.ToString();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            lock (lockObject)
            {
                bindingSource1.Clear();
                bindingSource2.Clear();
            }
            Thread1ListBox1.Invoke(new Action(() => Thread1ListBox1.Refresh()));
            Thread2ListBox2.Invoke(new Action(() => Thread2ListBox2.Refresh()));
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

        private void Thread2ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
