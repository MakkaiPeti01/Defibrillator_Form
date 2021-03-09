using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defibrillator_Form
{
    class Keszulek
    {
        private Defibrillator defi;

        private int id;

        public int ID
        {
            get { return id; }
        }

        private string name;

        public string Name
        {
            get { return name; }
        }

        private double latitude;

        public double Latitude
        {
            get { return latitude; }
        }

        private double longitude;

        public double Longitude
        {
            get { return longitude; }
        }

        private string tel;

        public string Tel
        {
            get { return tel; }
        }

        private string address;

        public string Address
        {
            get { return address; }
        }

        private double dist;

        public double Dist
        {
            get { return dist; }
        }

        public void DistCalc(double x, double y)
        {
            
        }

        public Keszulek(int id, string name, double latitude, double longitude, string tel, string address)
        {
            this.id = id;
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
            this.tel = tel;
            this.address = address;
        }
    }
}
