using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    public class Constand
    {
        public static int BUSINESS_COSTOMER_RANDOM_PERCENT = 10;
        public static int ONLINE_CUSTOMER_RANDOM_PERCENT = 30;

        public static int GATE_A_MIN_PROCESS_TIME = 2;
        public static int GATE_A_MAX_PROCESS_TIME = 3;
        public static int GATE_B_MIN_PROCESS_TIME = 1;
        public static int GATE_B_MAX_PROCESS_TIME = 4;
        public static int GATE_C_MIN_PROCESS_TIME = 3;
        public static int GATE_C_MAX_PROCESS_TIME = 7;

        //  0 : Business
        //  1 : Online
        //  2 : Normal
        public static List<string> CUSTOMER_TYPE_LIST = new List<string> { "Business", "Online", "Normal"  };

        public static int PASSENGER_AVATAR_SIZE_X = 75;
        public static int PASSENGER_AVATAR_SIZE_Y = 75;


        public static int PASSENGER_INDEX_TRANFER = 2;
    }
}
