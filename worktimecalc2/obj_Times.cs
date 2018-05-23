using System;
using System.Collections.Generic;

namespace worktimecalc2
{
    public class obj_Times
    {
        public List<int> l_id = new List<int>();
        public List<DateTime> l_Dates = new List<DateTime>();
        public List<DateTime> l_Arrivals = new List<DateTime>();
        public List<DateTime> l_Departures = new List<DateTime>();
        public List<TimeSpan> l_AtWork = new List<TimeSpan>();

        public bool addItem(int id, DateTime date, DateTime arrival, DateTime departure, TimeSpan atwork)
        {
            bool success = false;

            if(!l_id.Contains(id))
            {
                l_id.Add(id);
                l_Dates.Add(date);
                l_Arrivals.Add(arrival);
                l_Departures.Add(departure);
                l_AtWork.Add(atwork);

                success = true;
            }else
            {
                success = false;
            }

            return success;
        }

        public int getDays()
        {
            return l_id.Count;
        }

        public List<Object[]> getTimes()
        {
            List<object[]> oal = new List<object[]>();
            
            foreach(int i in l_id)
            {
                Object[] t = new object[4];
                int ind = l_id.IndexOf(i);
                t[0] = l_Dates[ind];
                t[1] = l_Arrivals[ind];
                t[2] = l_Departures[ind];
                t[3] = l_AtWork[ind];

                oal.Add(t);
            }



            return oal;
        }
    }
}
