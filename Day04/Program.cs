using System;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Car
    {
        Wheel[] wheel;
        Engine[] engine;
        Price price;
        Color color;
        Seat[] seats;
        Pedal[] pedals;
        Door[] doors;

        void Drive()
        {
            doors = new Door[2];

            doors[0].Lock();
            doors[1].Lock();
        }

    }

    class Door
    {
        int windowsCount;
        void Open()
        {
        }

        void Close()
        {
        }

        public void Lock()
        {

        }

        void UnLock()
        {
        }
    }

    class Wheel
    {
    }

    class Engine
    {
    }

    class Price
    {
    }

    class Color
    {
    }

    class Seat
    {
    }

    class Handle
    {
    }

    class Pedal
    {
    }


}
