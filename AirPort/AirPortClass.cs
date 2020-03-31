using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    public class AirPortClass
    {
        private static AirPortClass instance;
        private static readonly object lockObjest = new object();
        public List<Gate> gates = new List<Gate>();

        public static AirPortClass GetInstance()
        {
            
            if (instance == null)
            {
                lock (lockObjest)
                {
                    instance = new AirPortClass();
                }
            }
            return instance;
        }

        public void CountDownProcessTime()
        {
            for (int i = 0; i < gates.Count; i++)
            {
                if (gates[i].passengers.Count > 0) gates[i].CountDownProcess();
            }
        }

        public void RandomPassenger()
        {
            int count = 0;
            gates.ForEach(delegate (Gate gate)
            {
                count += gate.passengers.Count;
            });
           
            if (count < 24)
            {
                Passenger passenger = new Passenger();

                if (passenger.type == Constand.CUSTOMER_TYPE_LIST[0])
                {
                    gates[0].AddPassenger(passenger);
                }
                else if (passenger.type == Constand.CUSTOMER_TYPE_LIST[1])
                {
                    gates[1].AddPassenger(passenger);
                }
                else
                {
                    gates[2].AddPassenger(passenger);
                }
            }
        }

        public void TranferPassenger()
        {           
            for (int i =0; i < gates.Count; i++)
            {
                if (this.gates[i].passengers.Count == 0)
                {
                    switch(i)
                    {
                        case 0:
                            TranferPassenger(this.gates[0], this.gates[1], this.gates[2]);
                            break;

                        case 1:
                            TranferPassenger(this.gates[1], this.gates[0], this.gates[2]);
                            break;

                        case 2:
                            TranferPassenger(this.gates[2], this.gates[1], this.gates[2]);
                            break;
                    }

                    break;
                }
            }
        }

        private void TranferPassenger(Gate a, Gate b, Gate c)
        {
            if (b.passengers.Count == 0 && c.passengers.Count == 0) return;

            if (b.passengers.Count >= c.passengers.Count && b.passengers.Count > 1)
            {
                a.passengers.Add(b.GetPassengerAtIndex(Constand.PASSENGER_INDEX_TRANFER));
                b.RemovePassengerAtIndex(Constand.PASSENGER_INDEX_TRANFER);
            }
            else if (c.passengers.Count > 1)
            {
                a.passengers.Add(c.GetPassengerAtIndex(Constand.PASSENGER_INDEX_TRANFER));
                c.RemovePassengerAtIndex(Constand.PASSENGER_INDEX_TRANFER);
            }
        }

        private AirPortClass()
        {
            Gate gateA = new Gate(Constand.GATE_A_MIN_PROCESS_TIME, Constand.GATE_A_MAX_PROCESS_TIME);
            gates.Add(gateA);

            Gate gateB = new Gate(Constand.GATE_B_MIN_PROCESS_TIME, Constand.GATE_B_MAX_PROCESS_TIME);
            gates.Add(gateB);

            Gate gateC = new Gate(Constand.GATE_C_MIN_PROCESS_TIME, Constand.GATE_C_MAX_PROCESS_TIME);
            gates.Add(gateC);
        }
    }
}
