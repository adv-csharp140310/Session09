namespace Session09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSendEmail = new Button();
            buttonTestMsg = new Button();
            buttonSendEmailMultiThread = new Button();
            progressBarEmails = new ProgressBar();
            buttonRaceConditon = new Button();
            listBoxMsg = new ListBox();
            buttonAsyncAwait = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonSendEmail
            // 
            buttonSendEmail.Location = new Point(12, 12);
            buttonSendEmail.Name = "buttonSendEmail";
            buttonSendEmail.Size = new Size(161, 50);
            buttonSendEmail.TabIndex = 0;
            buttonSendEmail.Text = "Send Email";
            buttonSendEmail.UseVisualStyleBackColor = true;
            buttonSendEmail.Click += buttonSendEmail_Click;
            // 
            // buttonTestMsg
            // 
            buttonTestMsg.Location = new Point(594, 12);
            buttonTestMsg.Name = "buttonTestMsg";
            buttonTestMsg.Size = new Size(194, 50);
            buttonTestMsg.TabIndex = 1;
            buttonTestMsg.Text = "Test MSG";
            buttonTestMsg.UseVisualStyleBackColor = true;
            buttonTestMsg.Click += buttonTestMsg_Click;
            // 
            // buttonSendEmailMultiThread
            // 
            buttonSendEmailMultiThread.Location = new Point(12, 68);
            buttonSendEmailMultiThread.Name = "buttonSendEmailMultiThread";
            buttonSendEmailMultiThread.Size = new Size(161, 50);
            buttonSendEmailMultiThread.TabIndex = 2;
            buttonSendEmailMultiThread.Text = "Send Email - Multi Thread";
            buttonSendEmailMultiThread.UseVisualStyleBackColor = true;
            buttonSendEmailMultiThread.Click += buttonSendEmailMultiThread_Click;
            // 
            // progressBarEmails
            // 
            progressBarEmails.Location = new Point(12, 124);
            progressBarEmails.Name = "progressBarEmails";
            progressBarEmails.Size = new Size(161, 23);
            progressBarEmails.TabIndex = 3;
            // 
            // buttonRaceConditon
            // 
            buttonRaceConditon.Location = new Point(12, 235);
            buttonRaceConditon.Name = "buttonRaceConditon";
            buttonRaceConditon.Size = new Size(161, 50);
            buttonRaceConditon.TabIndex = 4;
            buttonRaceConditon.Text = "Race Condition";
            buttonRaceConditon.UseVisualStyleBackColor = true;
            buttonRaceConditon.Click += buttonRaceConditon_Click;
            // 
            // listBoxMsg
            // 
            listBoxMsg.FormattingEnabled = true;
            listBoxMsg.Location = new Point(179, 235);
            listBoxMsg.Name = "listBoxMsg";
            listBoxMsg.Size = new Size(609, 184);
            listBoxMsg.TabIndex = 5;
            // 
            // buttonAsyncAwait
            // 
            buttonAsyncAwait.Location = new Point(12, 291);
            buttonAsyncAwait.Name = "buttonAsyncAwait";
            buttonAsyncAwait.Size = new Size(161, 50);
            buttonAsyncAwait.TabIndex = 6;
            buttonAsyncAwait.Text = "Async Await";
            buttonAsyncAwait.UseVisualStyleBackColor = true;
            buttonAsyncAwait.Click += buttonAsyncAwait_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 347);
            button1.Name = "button1";
            button1.Size = new Size(161, 53);
            button1.TabIndex = 7;
            button1.Text = "Read File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonAsyncAwait);
            Controls.Add(listBoxMsg);
            Controls.Add(buttonRaceConditon);
            Controls.Add(progressBarEmails);
            Controls.Add(buttonSendEmailMultiThread);
            Controls.Add(buttonTestMsg);
            Controls.Add(buttonSendEmail);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSendEmail;
        private Button buttonTestMsg;
        private Button buttonSendEmailMultiThread;
        private ProgressBar progressBarEmails;
        private Button buttonRaceConditon;
        private ListBox listBoxMsg;
        private Button buttonAsyncAwait;
        private Button button1;
    }
}
