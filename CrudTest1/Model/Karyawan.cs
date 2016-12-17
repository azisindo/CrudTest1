using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTest1.Model
{
    public class Karyawan
    {
        private string _nik;
        public string nik
        {
            get { return _nik; }
            set { _nik = value; }
        }

        private string _nama;
        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }
                
        private DateTime _tglLahir;
        public DateTime tglLahir
        {
            get { return _tglLahir; }
            set { _tglLahir = value; }
        }

        private String _alamat;
        public string alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }

        private Int32 _jmlLembur;
        public Int32 jmllembur
        {
            get { return _jmlLembur; }
            set { _jmlLembur = value; }
        }

        private double _pajak;
        public double pajak
        {
            get { return _pajak; }
            set { _pajak = value; }
        }

        private int _total;
        public int total
        {
            get { return _total; }
            set { _total = value; }
        }
            
    }


}
