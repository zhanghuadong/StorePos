using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace StorePos.Utils
{
    public class Toast : Label
    {
        public Toast()
        {

        }

        public void SetTimeClose(TimeSpan time)
        {
            new Thread(() =>
            {
                Thread.Sleep(time);
                if (this.Parent is Panel)
                {
                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        (this.Parent as Panel).Children.Remove(this);
                    }));
                }
            })
            { IsBackground = true }.Start();
        }
    }
}
