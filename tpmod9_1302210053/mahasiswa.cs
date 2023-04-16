
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace tpmod9_1302210053
{
    public class Mahasiswaa
    {
        public string Nama { get; private set; }
        public string Nim { get; private set; }

        public Mahasiswaa(string nama, string nim) { this.Nama = nama; this.Nim = nim; }
    }
}
