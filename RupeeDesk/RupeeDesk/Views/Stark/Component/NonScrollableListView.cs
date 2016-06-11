﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RupeeDesk.Views.Stark.Component
{
    public class NonScrollableListView : ListView
    {
        public NonScrollableListView()
            : base(ListViewCachingStrategy.RecycleElement)
        {
            if (Device.OS == TargetPlatform.Windows || Device.OS == TargetPlatform.WinPhone)
                BackgroundColor = Color.White;
        }
    }
}
