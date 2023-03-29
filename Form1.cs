using System.Xml.Serialization;

namespace WinFormsTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Random random = new Random();
        bool HorseWin = false;


        private void button1_Click(object sender, EventArgs e) {

            Reset();
            //progressBarUpdate();
            HorseRun();
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
            while (HorseWin == false) {

                foreach (ProgressBar p in pbList) {
                    if (random.Next() % 100 == 0) {
                        p.Value++;
                        if (p.Value == 100) { HorseWin = true; }
                    }
                }
                /*
                                ProgressBar1Label.Text = updateLabel(progressBar1);
                                ProgressBar2Label.Text = updateLabel(progressBar2);
                                ProgressBar3Label.Text = updateLabel(progressBar3);*/
                //Thread.Sleep(1);
            }
        }

        private string updateLabel(ProgressBar bar) {
            int progress = bar.Value;
            if (progress == 100) {
                return "WINNER";
            } else {
                string returning = progress.ToString() + "%";
                return returning;
            }
        }

        private void Reset() {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            HorseWin = false;
            /*ProgressBar1Label.Text = "0%";
            ProgressBar2Label.Text = "0%";
            ProgressBar3Label.Text = "0%";*/
        }

        private async void HorseRun() {
            ProgressBar1Label.Visible = false;
            ProgressBar2Label.Visible = false;
            ProgressBar3Label.Visible = false;
            List<ProgressBar> pbList = new List<ProgressBar>()
            {
                progressBar1,
                progressBar2,
                progressBar3
            };

            var tasks = pbList.Select(pb => RunHorse(pb)).ToList();
            await Task.WhenAny(Task.WhenAll(tasks), Task.Delay(Timeout.Infinite));

            var winnerIndex = pbList.FindIndex(pb => pb.Value == 100);
            if (winnerIndex != -1) {
                UpdateProgressBarLabel(pbList[winnerIndex]);
                button1.Text = "Horse " + (winnerIndex + 1) + " Win";

                ProgressBar1Label.Visible = true;
                ProgressBar2Label.Visible = true;
                ProgressBar3Label.Visible = true;
                if (progressBar1.Value == 100) { ProgressBar1Label.Text = "WINNER!"; } else { ProgressBar1Label.Text = progressBar1.Value.ToString() + "%"; }
                if (progressBar2.Value == 100) { ProgressBar2Label.Text = "WINNER!"; } else { ProgressBar2Label.Text = progressBar2.Value.ToString() + "%"; }
                if (progressBar3.Value == 100) { ProgressBar3Label.Text = "WINNER!"; } else { ProgressBar3Label.Text = progressBar3.Value.ToString() + "%"; }
            }
        }

        private async Task RunHorse(ProgressBar pb) {
            while (pb.Value < 100 && HorseWin == false) {
                await Task.Delay(1);
                if (random.Next() % 10 == 0) {
                    pb.Value++;
                    pb.BeginInvoke(new Action(() => {
                        pb.Value++;
                        UpdateProgressBarLabel(pb);
                    }));
                }
            }
        }

        private void UpdateProgressBarLabel(ProgressBar progressBar) {
            int progress = progressBar.Value;

            if (progress == 100) {
                //progressBar.CreateGraphics().DrawString("WINNER", new Font("Arial", 8), Brushes.Black, new PointF(400, 5));
                HorseWin = true;
            }
        }

        private void label5_Click(object sender, EventArgs e) {

        }
    }
}