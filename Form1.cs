namespace WinFormsTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) {
            /*List<Thread> tList = new List<Thread>();
            tList.Add(new Thread(() => progressBarUpdate(progressBar1)));
            tList.Add(new Thread(() => progressBarUpdate(progressBar2)));
            tList.Add(new Thread(() => progressBarUpdate(progressBar3)));*/

            /*foreach (Thread t in tList) {
                t.Start();
            }
            foreach (Thread t in tList) {
                t.Join();
            }*/
            progressBarUpdate();
            button1.Text = "Horse Win";
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        void progressBarUpdate() {
            bool HorseWin = false;
            List<ProgressBar> pbList = new List<ProgressBar>();
            pbList.Add(progressBar1);
            pbList.Add(progressBar2);
            pbList.Add(progressBar3);
            Random random = new Random();
            while (HorseWin == false) {
                /*if (bar.InvokeRequired) {
                    bar.Invoke(new Action(() => {
                        bar.Value++;
                        if (bar.Value == 100) { HorseWin = true; }
                    }));
                } else {
                    bar.Value++;
                    if (bar.Value == 100) { HorseWin = true; }
                }*/

                foreach (ProgressBar p in pbList) {
                    if (random.Next() % 100 == 0) 
                        {
                        p.Value++;
                        if (p.Value == 100) { HorseWin = true; }
                    }
                }

                ProgressBar1Label.Text = updateLabel(progressBar1);
                ProgressBar2Label.Text = updateLabel(progressBar2);
                ProgressBar3Label.Text = updateLabel(progressBar3);
                Thread.Sleep(1);
            }
        }

        private string updateLabel(ProgressBar bar) {
            int progress = bar.Value;
            if (progress == 100) {
                return "WINNER";
            }
            string returning = progress.ToString() + "%";
            return returning;
        }
    }
}