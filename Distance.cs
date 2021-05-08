namespace Line_Comparison
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    
    public class Distance
    {

        public double distance;
        public int x2, y2, x1, y1;
        public Distance(int x1,int y1,int x2,int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public double GetDistance()
        {
            
            distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
            return distance;
        }   
    }   
}