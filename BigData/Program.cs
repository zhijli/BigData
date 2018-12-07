using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigData
{
    using ZhijieLi.CommonUtility.Logger;

    static class Program
    {
        static void Main()
        {
            var product = DataAccessor.GetProducts();
            Console.WriteLine(product.DebugInfo(false));
            Console.ReadKey();
        }
    }
}
