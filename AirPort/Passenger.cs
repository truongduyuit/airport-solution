using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    public class Passenger
    {
        public string type { get; set; }
        public string avatar { get; set; }
        public Passenger()
        {
            Random rd = new Random();
            int random = rd.Next(0, 101);

            // random customer type
            if (random < Constand.BUSINESS_COSTOMER_RANDOM_PERCENT)
            {
                type = Constand.CUSTOMER_TYPE_LIST[0];
                avatar = @"\images\11.png";
            }

            else if (random >= Constand.BUSINESS_COSTOMER_RANDOM_PERCENT &&
                        random < Constand.ONLINE_CUSTOMER_RANDOM_PERCENT + Constand.BUSINESS_COSTOMER_RANDOM_PERCENT)
            {
                type = Constand.CUSTOMER_TYPE_LIST[1];
                avatar = @"\images\22.png";
            }

            else
            {
                type = Constand.CUSTOMER_TYPE_LIST[2];
                avatar = @"\images\33.png";
            }
        }
    }
}
