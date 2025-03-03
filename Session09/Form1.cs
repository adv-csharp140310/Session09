namespace Session09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {
            //Multi Task

            //Thread / نخ            
            //Concurrent

            sendEmail();
        }

        private void sendEmail()
        {
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(1000); //1000ms = 1s;
                Thread.Sleep(100); //100ms = 0.1s;
                //progressBarEmails.Value = i + 1;
                progressBarEmails.Invoke(() => progressBarEmails.Value = i + 1);
            }
        }

        private void buttonTestMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void buttonSendEmailMultiThread_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => sendEmail());
            t.Start();
        }

        int balance = 100;
        private void buttonRaceConditon_Click(object sender, EventArgs e)
        {
            listBoxMsg.Items.Clear();
            balance = 100;
            var rnd = new Random();
            var t1 = new Thread(() => updateBalance(10, rnd.Next(1000)));
            var t2 = new Thread(() => updateBalance(-50, rnd.Next(1000)));
            var t3 = new Thread(() => updateBalance(20, rnd.Next(1000)));
            t1.Start();
            t2.Start();
            t3.Start();
        }


        private void updateBalance(int amount, int delay)
        {
            //Critical Region
            lock (this)
            {
                var newBalance = balance + amount; //110
                Thread.Sleep(delay);
                listBoxMsg.Invoke(() => listBoxMsg.Items.Add($"Balance {balance} -> {newBalance}"));
                balance = newBalance;
            }
        }

        // void -> Task
        // int -> Tasl<int>
        private Task updateBalanceAsync(int amount, int delay)
        {
            var task = new Task(() =>
            {
                var newBalance = balance + amount;
                Thread.Sleep(delay);
                listBoxMsg.Invoke(() => listBoxMsg.Items.Add($"Balance {balance} -> {newBalance}"));
                balance = newBalance;
            });
            task.Start();
            return task;
        }

        private async void buttonAsyncAwait_Click(object sender, EventArgs e)
        {
            listBoxMsg.Items.Clear();
            balance = 100;
            var rnd = new Random();
            await updateBalanceAsync(10, rnd.Next(1000));
            await updateBalanceAsync(-50, rnd.Next(1000));
            await updateBalanceAsync(20, rnd.Next(1000));
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader("expense-tracker.mp4");
            //var data = reader.ReadToEnd();
            var data = await reader.ReadToEndAsync();
            MessageBox.Show("Done");
        }
    }
}
