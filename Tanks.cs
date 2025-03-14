using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    public class Tanks
    {

    }

    public class LightTank : Tanks
    {
        public int ViewRange = 0;
        public int CamouflagePercent = 0;
        public int TankWeight = 0;
    }

    public enum HeavyTankType { ordinary, premium}

    public class HeavyTank : Tanks
    {
        public int TankWeight = 0;
        public HeavyTankType typeHeavy = HeavyTankType.premium;
        public int ArmorThikness = 0;
    }

    public enum MiddletankType { universal, sniper, support}
    public class MiddleTank : Tanks
    {
        public int TankWeight = 0;
        public MiddletankType typeMiddle = MiddletankType.universal;
        public bool HighMobility = true;
    }
}
