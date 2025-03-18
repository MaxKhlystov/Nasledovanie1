namespace Nasledovanie
{
    public partial class Form1 : Form
    {
        List<Tanks> tanksList = new List<Tanks>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnPefill_Click(object sender, EventArgs e)
        {
            
        }
        private void ShowInfo()
        {
            int lightTankCount = 0;
            int middleTankCount = 0;
            int heavyTankCount = 0;

            foreach (var tank in this.tanksList)
            {

                if (tank is LightTank) 
                {
                    lightTankCount += 1;
                }
                else if (tank is MiddleTank)
                {
                    middleTankCount += 1;
                }
                else if (tank is HeavyTank)
                {
                    heavyTankCount += 1;
                }
            }

            txtInfo.Text = "ЛТ\tСТ\tТТ";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", lightTankCount, middleTankCount, heavyTankCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
  
        }

        private void btnPefill_Click_1(object sender, EventArgs e)
        {
            txtOut.Clear();
            this.tanksList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                switch (rnd.Next(0, 3))
                {
                    case 0:
                        this.tanksList.Add(LightTank.Generate());
                        break;
                    case 1:
                        this.tanksList.Add(MiddleTank.Generate());
                        break;
                    case 2:
                        this.tanksList.Add(HeavyTank.Generate());
                        break;
                }
            }
            richTextBox1.Clear();
            foreach (var tank in tanksList)
            {
                if (tank is LightTank)
                {
                    richTextBox1.AppendText("Лёгкий танк" + Environment.NewLine);
                }
                else if (tank is MiddleTank)
                {
                    richTextBox1.AppendText("Средний танк" + Environment.NewLine);
                }
                else if (tank is HeavyTank)
                {
                    richTextBox1.AppendText("Тяжёлый танк" + Environment.NewLine);
                }
            }
            ShowInfo();
        }

        private void btnGet_Click_1(object sender, EventArgs e)
        {
            if (this.tanksList.Count == 0)
            {
                txtOut.Text = "Танки зажали :(";
                return;
            }

            var tank = this.tanksList[0];
            this.tanksList.RemoveAt(0);
            txtOut.Text = tank.GetInfo();
            ShowInfo();
            richTextBox1.Clear();

            foreach (var i in tanksList)
            {
                if (i is LightTank)
                {
                    richTextBox1.AppendText("Лёгкий танк" + Environment.NewLine);
                }
                else if (i is MiddleTank)
                {
                    richTextBox1.AppendText("Средний танк" + Environment.NewLine);
                }
                else if (i is HeavyTank)
                {
                    richTextBox1.AppendText("Тяжёлый танк" + Environment.NewLine);
                }
            }
        }
    }
}
