using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CallAPI
{
    //[DataContract]
    public class SanPham
    {
        public int Ma { get; set; }
       
        public string Ten { get; set; }
    
        public int DonGia { get; set; }
    }
}
