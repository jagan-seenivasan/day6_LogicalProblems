using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_LogicalProblems
{
    internal class CouponNumbers
    
		{
			public static void PrintCouponCode()
			{
				var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
				var stringChars = new char[6];
				var random = new Random();

				for (int i = 0; i < stringChars.Length; i++)
				{
					stringChars[i] = chars[random.Next(chars.Length)];
				}

				
			}
		}

	}

