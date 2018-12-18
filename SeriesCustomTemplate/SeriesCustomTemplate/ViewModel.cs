using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesCustomTemplate
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ObservableCollection<Model> StepLineData { get; set; }

        public ObservableCollection<Model> ColumnData { get; set; }

        public ObservableCollection<Model> BarData { get; set; }

        public ViewModel()
        {
            BarData = new ObservableCollection<Model>()
            {
                new Model(){XValue="1", YValue=10},
                new Model(){XValue="2", YValue=20},
                new Model(){XValue="3", YValue=30},
                new Model(){XValue="4", YValue=50},
                new Model(){XValue="5", YValue=25},
                new Model(){XValue="6", YValue=10},
                new Model(){XValue="7", YValue=35},
            };

            Data = new ObservableCollection<Model>()
            {
                new Model() { XValue = "1", Size = 35, Count = 14},
                new Model() { XValue = "2", Size = 50, Count = 30},
                new Model() { XValue = "3", Size = 55, Count = 15},
                new Model() { XValue = "4", Size = 33, Count = 24},
                new Model() { XValue = "5", Size = 22, Count = 19},
                new Model() { XValue = "6", Size = 30, Count = 16},
                new Model() { XValue = "7", Size = 28, Count = 21},
                new Model() { XValue = "8", Size = 35, Count = 33},
                new Model() { XValue = "9", Size = 45, Count = 22},
                new Model() { XValue = "10",Size = 22, Count = 19},
                new Model() { XValue = "11",Size = 45, Count = 29},
                new Model() { XValue = "12",Size = 15, Count = 13},
            };

            ColumnData = new ObservableCollection<Model>()
            {
                new Model(){XValue="1", YValue=10},
                new Model(){XValue="2", YValue=20},
                new Model(){XValue="3", YValue=30},
                new Model(){XValue="4", YValue=40},
                new Model(){XValue="5", YValue=50},
                new Model(){XValue="6", YValue=60},

            };

            StepLineData = new ObservableCollection<Model>();

            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                double yValue = rd.Next(0, 50);

                StepLineData.Add(new Model()
                {
                    XValue = i.ToString(),
                    YValue = yValue
                });
            }

        }

    }
}
