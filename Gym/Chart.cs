﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    class Chart
    {
         public ObservableCollection<TestClass> Errors { get; private set; }
        public ObservableCollection<string> ChartTypes { get; set; }

        private readonly ObservableCollection<Population> _populations = new ObservableCollection<Population>();
        public ObservableCollection<Population> Populations
        {
            get
            {
                return _populations;
            }
        }

        private readonly ObservableCollection<Population> _smallestPopulations = new ObservableCollection<Population>();
        public ObservableCollection<Population> SmallestPopulations
        {
            get
            {
                return _smallestPopulations;
            }
        }

        public Chart()
        {
            ChartTypes = new ObservableCollection<string>();
            Errors = new ObservableCollection<TestClass>();
            Errors.Add(new TestClass() { Category = "Globalization", Number = 75 });
            Errors.Add(new TestClass() { Category = "Features", Number = 2 });
            Errors.Add(new TestClass() { Category = "ContentTypes", Number = 12 });
            Errors.Add(new TestClass() { Category = "Correctness", Number = 83});
            Errors.Add(new TestClass() { Category = "Best Practices", Number = 29 });

            _populations.Add(new Population() { Name = "China", Count = 1340 });
            _populations.Add(new Population() { Name = "India", Count = 1220 });
            _populations.Add(new Population() { Name = "United States", Count = 309 });
            _populations.Add(new Population() { Name = "Indonesia", Count = 240 });
            _populations.Add(new Population() { Name = "Brazil", Count = 195 });
            _populations.Add(new Population() { Name = "Pakistan", Count = 174 });
            _populations.Add(new Population() { Name = "Nigeria", Count = 158 });

            _smallestPopulations.Add(new Population() { Name = "Pitcairn Islands", Count = 48 });
            _smallestPopulations.Add(new Population() { Name = "Cocos Keeling Islands", Count = 605 });
            _smallestPopulations.Add(new Population() { Name = "Vatican City", Count = 826 });
            _smallestPopulations.Add(new Population() { Name = "Niue", Count = 1000 });
            _smallestPopulations.Add(new Population() { Name = "Tokelau", Count = 1416 });
            _smallestPopulations.Add(new Population() { Name = "Christmas Island", Count = 1462 });
            _smallestPopulations.Add(new Population() { Name = "Norfolk Island", Count = 2141 });
        }

        private object selectedItem = null;
        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                // selected item has changed
                selectedItem = value;                
            }
        }
    }

    // class which represent a data point in the chart
    public class TestClass
    {
        public string Category { get; set; }

        public int Number  { get; set; }        
    }

}


