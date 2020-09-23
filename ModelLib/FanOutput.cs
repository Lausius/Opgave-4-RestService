using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opgave1_Model_Klasse
{
    public class FanOutput
    {
        public static List<FanOutput> fanOutputReadings = new List<FanOutput>()
        {
            new FanOutput(1, "First Output", 15, 30),
            new FanOutput(2, "Second Output", 18, 41),
            new FanOutput(3, "Third Output", 24, 69),
            new FanOutput(4, "Fourth Output", 22, 49),
            new FanOutput(5, "Sixth Output", 20, 75),
            new FanOutput(6, "Seventh Output", 16, 50),
        };

        public FanOutput()
        {

        }

        public FanOutput(int id, string name, double temperature, double humidity)
        {
            Id = id;
            Name = name;
            Temperature = temperature;
            Humidity = humidity;
        }

        private int _id;
        private string _name;
        private double _temperature;
        private double _humidity;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Id", "Id må ikke være 0 eller negativ.");
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 2)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Navn", "Navn skal mindst indeholde 2 eller flere bogstaver");
                }
            }
        }
        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if (value >= 15 && value <= 25)
                {
                    _temperature = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Temperatur", "Temperaturen skal ligge mellem 15 og 25 grader celsius");
                }
            }
        }
        public double Humidity
        {
            get { return _humidity; }
            set
            {
                if (value >= 30 && value <= 80)
                {
                    _humidity = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Fugtighed", "Fugtigheden skal have en værdi mellem 30 og 80");
                }
            }
        }

    }
}
