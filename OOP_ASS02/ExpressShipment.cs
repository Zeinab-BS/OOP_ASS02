using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_ASS02
{
    internal class ExpressShipment:Shipment
    {

		private decimal extrafee;

		public decimal ExtraFee
        {
			get { return extrafee; }

			set {
				if (value < 0)
				{
					throw new ArgumentException("ExtraFee must be greater than or equal 0");
				}
				extrafee = value;
			
			}
		}

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5)+ ExtraFee;
            }
        }
        public ExpressShipment(string tc, string descrip, decimal wg, decimal df, DeliveryAddress destin,decimal ex) : base(tc, descrip, wg, df, destin)
        {
            ExtraFee = ex;

        }



    }
}
