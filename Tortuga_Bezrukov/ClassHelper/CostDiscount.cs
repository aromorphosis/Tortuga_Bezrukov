﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tortuga_Bezrukov.Windows;

namespace Tortuga_Bezrukov.ClassHelper
{
    public static class CostDisc
    {
        public static decimal Sum(DateTime date, decimal cost)
        {
            int month = date.Month;
            int year = date.Year;
            DateTime dates = new DateTime(year, month, 1);
            int counts = DateTime.DaysInMonth(year, month);
            int dateadd = (int)dates.AddDays(28).DayOfWeek;
            if (dateadd > 4 && (int)date.DayOfWeek == 6)
            {
                return cost * (decimal)0.89;
            }
            return cost;
        }
    }
}
