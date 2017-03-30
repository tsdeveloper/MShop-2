using Mshop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mshop.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            new DatabaseHelper().GetAll();
        }
    }
}
