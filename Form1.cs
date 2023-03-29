using System;
using System.Xml.Serialization;

namespace WinFormsTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Random random = new Random();
        bool HorseWin = false;

        int HorseDistance1 = 0;
        int HorseDistance2 = 0;
        int HorseDistance3 = 0;



        private void button1_Click(object sender, EventArgs e) {

            Reset();
            //progressBarUpdate();
            HorseRun();
            //button1.Text = "Horse Win";
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
            HorseDistance1 = 0;
            HorseDistance2 = 0;
            HorseDistance3 = 0;
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

            //var tasks = pbList.Select(pb => RunHorse(pb)).ToList();
            //Task.Run(tasks () =>)
            //    ;

            List<int> Horses = new List<int>() {
                HorseDistance1, HorseDistance2, HorseDistance3
            };


            
            List<Task> tasks = new List<Task>();
            while(HorseWin == false) {

                //foreach (var horse in Horses) {
                //    tasks.Add(Task.Run(()=> (horse = RunHorse(horse))));
                //}

                /*for(int i = 0; i < Horses.Count; i++) {
                    tasks.Add(Task.Run(()=> Horses[i] = RunHorse(Horses[i])));
                }*/


                tasks.Add(Task.Run(() => HorseDistance1 = RunHorse(HorseDistance1)));
                tasks.Add(Task.Run(() => HorseDistance2 = RunHorse(HorseDistance2)));
                tasks.Add(Task.Run(() => HorseDistance3 = RunHorse(HorseDistance3)));


                await Task.WhenAll(tasks);

                progressBar1.Value = HorseDistance1;
                progressBar2.Value = HorseDistance2;
                progressBar3.Value = HorseDistance3;


                
            }/*
                var winnerIndex = pbList.FindIndex(pb => pb.Value == 100);
                if (winnerIndex != -1) {
                    //UpdateProgressBarLabel(pbList[winnerIndex]);
                    button1.Text = "Horse " + (winnerIndex + 1) + " Win";
*/
                    ProgressBar1Label.Visible = true;
                    ProgressBar2Label.Visible = true;
                    ProgressBar3Label.Visible = true;
                    if (progressBar1.Value == 100) { ProgressBar1Label.Text = "WINNER!"; } else { ProgressBar1Label.Text = progressBar1.Value.ToString() + "%"; }
                    if (progressBar2.Value == 100) { ProgressBar2Label.Text = "WINNER!"; } else { ProgressBar2Label.Text = progressBar2.Value.ToString() + "%"; }
                    if (progressBar3.Value == 100) { ProgressBar3Label.Text = "WINNER!"; } else { ProgressBar3Label.Text = progressBar3.Value.ToString() + "%"; }
                //}
        }

        private int  RunHorse(int horseDistance) {
           // while (pb.Value < 100 && HorseWin == false) {
                //await Task.Delay(1);
                if (random.Next() % 10 == 0) 
                {
                    horseDistance++;
                }

            if (horseDistance >= 100) {
                HorseWin = true;
            }

            return horseDistance;
            //}
        }

        

    }
}