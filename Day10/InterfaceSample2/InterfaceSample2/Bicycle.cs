using System;

namespace InterfaceSample2
{
    class Bicycle : Vehicle
    {

        int speed;
        int gear;

        // to change gear
        public void changeGear(int newGear)
        {

            gear = newGear;
        }

        // to increase speed
        public void speedUp(int increment)
        {

            speed = speed + increment;
        }

        // to decrease speed
        public void applyBrakes(int decrement)
        {

            speed = speed - decrement;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed +
                            " gear: " + gear);
        }
    }
}