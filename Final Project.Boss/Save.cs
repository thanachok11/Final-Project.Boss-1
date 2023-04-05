using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Boss
{
    public class Save
    {
        private string name,Email, Date,time, room;
        private int phone = 0;

        public Save (string name, int Phone, string Email,
            string Date, string time, string room)
        {
            this.name = name;
            this.Email= Email;
            this.phone = Phone;
            this.Date=Date;
            this.time = time;
            this.room = room;
            
        }

        public string Name { get => name; }
        public string email { get => Email; }
        public string date { get => Date; }
        public string Time { get => time; }
        public string Room { get => room; }
        public int Phone { get => phone; }
    }
}
