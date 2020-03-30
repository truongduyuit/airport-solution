using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    public class Gate
    {
        public int currentProcessTime { get; set; }
        public int minProcessTime { get; set; }
        public int maxProcessTime { get; set; }

        public List<Passenger> passengers = new List<Passenger>();

        public void CountDownProcess()
        {
            if (passengers.Count > 0)
            {
                currentProcessTime--;
                if (currentProcessTime < 0)
                {
                    Random rd = new Random();
                    currentProcessTime = rd.Next(minProcessTime, maxProcessTime + 1);
                }
                else if (currentProcessTime == 0)
                {
                    RemovePassengerAtIndex(0);
                }
            }
        }

        public void AddPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
        }

        public void RemovePassenger(Passenger passenger)
        {
            if (passengers.Count > 0) passengers.Remove(passenger); 
        }

        public void RemovePassengerAtIndex(int index)
        {
            if (passengers.Count > index) passengers.RemoveAt(index);
        }

        public Passenger GetPassengerAtIndex(int index)
        {
            if (index < passengers.Count)
                return passengers[index];
            return null;
        }

        public Gate()
        {
            currentProcessTime = 0;
        }

        public Gate(int min, int max)
        {
            currentProcessTime = 0;
            minProcessTime = min;
            maxProcessTime = max;
        }
    }
}
