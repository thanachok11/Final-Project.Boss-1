using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Boss
{
    internal class codepay

    {
        private string couponCode = string.Empty;
        private double minimunPrice;

        public void create(double min)
        {
            this.minimunPrice = min;
            if (min > 0)
            {
                this.minimunPrice = min - (this.minimunPrice * 0.20);

            }

        }

        public double getCoupon()
        {
            return this.minimunPrice;
        }
    }
}
