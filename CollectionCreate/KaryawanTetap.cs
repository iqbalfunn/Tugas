﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionCreate
{
    public class KaryawanTetap : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double GajiBulanan { get; set; }
        public override double Gaji() { return GajiBulanan; }
    }
}
