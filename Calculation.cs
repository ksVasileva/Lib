using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if (productType > 3 || productType <= 0 || materialType > 2 || materialType <= 0 || count < 0 || width <= 0 || length <= 0)
                return -1;

            float product_type = 0;
            switch (productType)
            {
                case 1: product_type = (float)1.1; break;
                case 2: product_type = (float)2.5; break;
                case 3: product_type = (float)8.43; break;
            }
            float material_type = 0;
            switch (materialType)
            {
                case 1: material_type = (float)0.3; break;
                case 2: material_type = (float)0.12; break;
            }

            float countForOne = width * length * product_type / 100 * (100 + material_type);

            return (int)Math.Ceiling(countForOne * count);
        }
    }
}
