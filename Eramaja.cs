using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    class EraMaja : Hoone
    {
        int korrus;
        public string maja;
        public EraMaja(int pindala = 50) : base(pindala) { }
        public string Suurus
        {
            get
            {
                maja = "0";
                if (Pindala <= 20)
                {
                    maja = "vaike maja";
                }
                else if (Pindala <= 50)
                {
                    maja = "keskmine maja";
                }
                else if (Pindala <= 80)
                {
                    maja = "suur maja";
                }
                else
                {
                    maja = "liiga suur maja";
                }
                return maja;
            }
        }
        public override void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on { Pindala} m2 ja see on { Suurus} ");
        }
    }
}
