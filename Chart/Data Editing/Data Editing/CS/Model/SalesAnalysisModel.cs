#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualDataEditing.Annotations;

namespace VisualDataEditing
{
    public class SalesAnalysisModel : INotifyPropertyChanged
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private double income;

        public double Income
        {
            get { return income; }
            set { income = value; }
        }

        private double noOfCustomer;

        public double NoOfCustomer
        {
            get { return noOfCustomer; }
            set { noOfCustomer = value; }
        }

        private string year;

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        public SalesAnalysisModel(string year, double count, double income, string text)
        {
            Year = year;
            NoOfCustomer = count;
            Income = income;
            Text = text;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
