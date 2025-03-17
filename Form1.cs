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
            this.tanksList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0:
                        this.tanksList.Add(new LightTank
                        {
                            TankWeight = 5 + rnd.Next() % 41
                        });
                        break;
                    case 1:
                        this.tanksList.Add(new MiddleTank
                        {
                            TankWeight = 10 + rnd.Next() % 61
                        });
                        break;
                    case 2:
                        this.tanksList.Add(new HeavyTank
                        {
                            TankWeight = 20 + rnd.Next() % 81 
                        });
                        break;

                }
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            int LightTankCount = 0;
            int MiddleTankCount = 0;
            int HeavyTankCount = 0;

            foreach (var tank in this.tanksList)
            {

                if (tank is LightTank) 
                {
                    LightTankCount += 1;
                }
                else if (tank is MiddleTank)
                {
                    MiddleTankCount += 1;
                }
                else if (tank is HeavyTank)
                {
                    HeavyTankCount += 1;
                }
            }

            txtInfo.Text = "ЛТ\tСТ\tТТ";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", LightTankCount, MiddleTankCount, HeavyTankCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
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
        }
    }
}
