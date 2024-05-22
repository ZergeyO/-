using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PPP
{
    internal class FunctionForSignals
    {
        private double _amplitude;
        private double _frequency;
        private double _time;
        private double _phase;

        public double Amplitude { get => _amplitude; set => _amplitude = value; }
        public double Frequency { get => _frequency; set => _frequency = value; }
        public double Time { get => _time; set => _time = value; }
        public double Phase { get => _phase; set => _phase = value; }

        public FunctionForSignals(double amplitude, double frequency, double time, double phase)
        {
            this._amplitude = amplitude;
            this._frequency = frequency;
            this._time = time;
            this._phase = phase;
        }

        public double Deltha(double time)
        {
            this._time = time;
            int teriod = Convert.ToInt32(1000 / (_frequency));
            if ((1024 - _time+Phase*25) % teriod == 0) { return 1; }
            else { return 0; }
        }

        public double Meandr(double time, int old_value)
        {
            this._time = time;
            int teriod = Convert.ToInt32(1000 / _frequency);
            if ( (1024-_time+Phase*25)%teriod==0) { return -old_value*_amplitude; }
            else { return old_value * _amplitude; }
        }

        public double CosSignal(double time) {
            this._time = time/2048;
            return _amplitude* Math.Cos(2 * Math.PI * _frequency * _time + _phase* Math.PI/4);
        }
        public double SinSignal(double time)
        {
            this._time = time/1024;
            return _amplitude * Math.Sin(2 * Math.PI * _frequency * _time + _phase * Math.PI / 4);
        }
        public double TriangleSignal(double time)
        {
            this._time = time;
            return 2 * _amplitude / Math.PI * Math.Asin(Math.Sin(2 * Math.PI * _frequency/10* _time/200+Phase));
        }
        public double SawtoothSignal(double time)
        {
            this._time = time;
            int teriod= Convert.ToInt32(1000 / _frequency);
            while (_time > teriod) {_time-= teriod;}
            return _amplitude*_time/teriod;
        }

    }
}
