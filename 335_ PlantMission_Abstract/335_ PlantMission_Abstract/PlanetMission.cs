using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _335__PlantMission_Abstract
{
    abstract class PlanetMission
    {
        public long RocketFuelPerMile;
        public long RockeSpeedMPH;
        public int MilesToPlanet;

        public long UnitOfFelNeeded()
        {
            return MilesToPlanet * RocketFuelPerMile;
        }

        public int TimeNeeded()
        {
            return MilesToPlanet / (int)RockeSpeedMPH;
        }

        public string FuelNeeded()
        {
            return "你需要" + UnitOfFelNeeded() + "單位的油" + TimeNeeded() + "小時，才會到達目的地。";
        }

        public abstract void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rockeSpeedMPH);
        
    }

    class Venus : PlanetMission
    {
        public Venus()
        {
            MilesToPlanet = 4000000;
            RockeSpeedMPH = 25000;
            RocketFuelPerMile = 100000;
        }

        public override void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rockeSpeedMPH)
        {
            this.MilesToPlanet = milesToPlanet;
            this.RockeSpeedMPH = rockeSpeedMPH;
            this.RocketFuelPerMile = rocketFuelPerMile;
        }
    }

    class Mars : PlanetMission
    {
        public Mars()
        {
            MilesToPlanet = 7500000;
            RockeSpeedMPH = 25000;
            RocketFuelPerMile = 100000;
        }

        public override void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rockeSpeedMPH)
        {
            this.MilesToPlanet = milesToPlanet;
            this.RockeSpeedMPH = rockeSpeedMPH;
            this.RocketFuelPerMile = rocketFuelPerMile;
        }
    }
}
