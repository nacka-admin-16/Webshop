using System;

namespace BestOfBrands.Examples
{
    public class CalculateExample
    {
        public double Start()
        {
            var varde1 = "23";
            var varde2 = "73";

            return Beräkna(varde1, varde2);
        }

        private double Beräkna(string varde1, string varde2)
        {            
            try
            {
                var v1 = double.Parse(varde1);
                var v2 = double.Parse(varde2);

                return v1 * v2;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}