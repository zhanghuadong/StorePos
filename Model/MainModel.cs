using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePos.Model
{
    public class MainModel: ObservableObject
    {
        private double _num0;

        public double Num0
        {
            get { return _num0; }
            set
            {
                _num0 = value;
                RaisePropertyChanged(() => Num0);
                Result = Num1 + value;
            }
        }

        private double _num1;

        public double Num1
        {
            get { return _num1; }
            set
            {
                _num1 = value;
                RaisePropertyChanged(() => Num1);
                Result = Num0 + value;
            }
        }

        private double _Result;

        public double Result
        {
            get { return _Result; }
            set { _Result = value; RaisePropertyChanged(() => Result); }
        }
    }
}
