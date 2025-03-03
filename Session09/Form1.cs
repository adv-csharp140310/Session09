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
    }
}
