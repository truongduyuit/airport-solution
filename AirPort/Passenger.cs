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
            }

            else if (random >= Constand.BUSINESS_COSTOMER_RANDOM_PERCENT && 
                        random < Constand.ONLINE_CUSTOMER_RANDOM_PERCENT)
            {
                type = Constand.CUSTOMER_TYPE_LIST[1];
            }   
            
            else
            {
                type = Constand.CUSTOMER_TYPE_LIST[2];
            }    

            // random avatar
            if (random % 4 == 0)
            {
                avatar = @"\images\man1.png";
            }
            else if(random % 4 == 1)
            {
                avatar = @"\images\man_2.png";
            }
            else if (random % 4 == 2)
            {
                avatar = @"\images\women_1.png";
            }
            else
            {
                avatar = @"\images\women_2.png";
            }
        }
    }
}
