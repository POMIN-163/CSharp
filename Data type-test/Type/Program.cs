using System;
using System.Windows.Forms;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Type
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\n char:" + sizeof(char) +
                              "\n int:" + sizeof(int) +
                              "\n long:" + sizeof(long) +
                              "\n float:" + sizeof(float) +
                              "\n double:" + sizeof(double)
                              );
            Type.Program my = typeof(Form);
            while (true) ;
        }
    }
}