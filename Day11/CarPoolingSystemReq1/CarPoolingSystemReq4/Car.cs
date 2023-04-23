using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystemReq4
{
    public abstract class Car

    {

        public long Id { get; set; }

        public string Name { get; set; }

        // Abstract method for calculating drive cost

        public abstract double CalculateDriveCost(double km);

    }

    // Hatchback class

    public class Hatchback : Car

    {

        public bool PowerWindows { get; set; }

        public bool AutomaticGear { get; set; }

        // Constructor

        public Hatchback(long id, string name, bool powerWindows, bool automaticGear)

        {

            Id = id;

            Name = name;

            PowerWindows = powerWindows;

            AutomaticGear = automaticGear;

        }

        // Implementing abstract method from Car class

        public override double CalculateDriveCost(double km)

        {

            double cost = 0;

            if (AutomaticGear)

                cost = 12;

            else

                cost = 10;

            return cost * km;

        }

    }

    // Sedan class

    public class Sedan : Car

    {

        public bool ABS { get; set; }

        public int BootSpace { get; set; }

        // Constructor

        public Sedan(long id, string name, bool abs, int bootSpace)

        {

            Id = id;

            Name = name;

            ABS = abs;

            BootSpace = bootSpace;

        }

        // Implementing abstract method from Car class

        public override double CalculateDriveCost(double km)

        {

            double cost = 0;

            if (BootSpace > 600)

                cost = 15 + (15 * 0.20);

            else

                cost = 15;

            return cost * km;

        }

    }

    // UtilityCar class

    public class UtilityCar : Car

    {

        public bool RearCoolingVents { get; set; }

        // Constructor

        public UtilityCar(long id, string name, bool rearCoolingVents)

        {

            Id = id;

            Name = name;

            RearCoolingVents = rearCoolingVents;

        }

        // Implementing abstract method from Car class

        public override double CalculateDriveCost(double km)

        {

            return 18 * km;

        }

    }
}
