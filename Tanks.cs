﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    public class Tanks
    {
        public int TankWeight = 0;
        public virtual String GetInfo()
        {
            var str = String.Format("\nВес танка: {0}", this.TankWeight);
            return str;
        }
    }

    public class LightTank : Tanks
    {
        public int ViewRange = 0;
        public int CamouflagePercent = 0;
        public override String GetInfo()
        {
            var str = "Лёгкий танк";
            str += base.GetInfo();
            str += String.Format("\nДальность обзора: {0}", this.ViewRange);
            str += String.Format("\nПроцент маскировки: {0}", this.CamouflagePercent);
            return str;
        }

        public static LightTank Generate()
        {
            var rnd = new Random();
            return new LightTank
            {
                TankWeight = rnd.Next() % 100,
                SliceCount = 5 + rnd.Next() % 20, 
                WithLeaf = rnd.Next() % 2 == 0 
            };
        }
    }

    public enum HeavyTankType { ordinary, premium}

    public class HeavyTank : Tanks
    {
        public HeavyTankType typeHeavy = HeavyTankType.premium;
        public int ArmorThikness = 0;
        public override String GetInfo()
        {
            var str = "Тяжёлый танк";
            str += base.GetInfo();
            str += String.Format("\nСтатус танка: {0}", this.typeHeavy);
            str += String.Format("\nТолщина брони: {0}", this.ArmorThikness);
            return str;
        }
    }

    public enum MiddletankType { universal, sniper, support}
    public class MiddleTank : Tanks
    {
        public MiddletankType typeMiddle = MiddletankType.universal;
        public bool HighMobility = true;

        public override String GetInfo()
        {
            var str = "Средний танк";
            str += base.GetInfo();
            str += String.Format("\nТип танка: {0}", this.typeMiddle);
            str += String.Format("\nЕсть хорошая мобильность?: {0}", this.HighMobility);
            return str;
        }
    }
}
