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
                switch (rnd.Next() % 3) // ��������� ��������� ����� �� 0 �� 2 (�� ������� �� ������� �� 3)
                {
                    case 0:
                        this.tanksList.Add(new LightTank());
                        break;
                    case 1:
                        this.tanksList.Add(new MiddleTank());
                        break;
                    case 2:
                        this.tanksList.Add(new HeavyTank());
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

                if (tank is LightTank) // �������� ����� ��� ������ ������, "���� fruit ���� ��������"
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

            txtInfo.Text = "��\t��\t��";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", LightTankCount, MiddleTankCount, HeavyTankCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.tanksList.Count == 0)
            {
                txtOut.Text = "����� ������ :(";
                return;
            }

            // ����� ������ �����
            var tank = this.tanksList[0];
            // ��� ��� �� ����������, ������ ��� �� ����� ���� �������� ��������� �� ������� � ������
            // ��� �������� ��������� ������, ��� ��� ���� ������ �������, ����� ��� ���
            this.tanksList.RemoveAt(0);

            // �� � ������ ��������� ���������� ��� �����
            if (tank is LightTank)
            {
                txtOut.Text = "˸���� ����";
            }
            else if (tank is MiddleTank)
            {
                txtOut.Text = "������� ����";
            }
            else if (tank is HeavyTank)
            {
                txtOut.Text = "������ ����";
            }

            // ������� ���������� � ���������� ������ �� �����
            ShowInfo();
        }
    }
}
