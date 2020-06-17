using System;
using System.Collections.Generic;
using System.Text;

namespace TugasLab8
{
    public class KaryawanHarian : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public override double Gaji() { return UpahPerJam * JumlahJamKerja; }
    }
}
