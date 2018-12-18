using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesCustomTemplate
{
    public class Model : INotifyPropertyChanged
    {
        private string xValue;
        public string XValue
        {
            get
            {
                return xValue;
            }

            set
            {
                if (value != xValue)
                {
                    xValue = value;
                    OnPropertyChanged("XValue");
                }
            }
        }

        private double yValue;
        public double YValue
        {
            get
            {
                return yValue;
            }

            set
            {
                if (value != yValue)
                {
                    yValue = value;
                    OnPropertyChanged("YValue");
                }
            }
        }

        private double count;
        public double Count
        {
            get
            {
                return count;
            }

            set
            {
                if (value != count)
                {
                    count = value;
                    OnPropertyChanged("Count");
                }
            }
        }

        private double size;
        public double Size
        {
            get
            {
                return size;
            }

            set
            {
                if (value != size)
                {
                    size = value;
                    OnPropertyChanged("Size");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}