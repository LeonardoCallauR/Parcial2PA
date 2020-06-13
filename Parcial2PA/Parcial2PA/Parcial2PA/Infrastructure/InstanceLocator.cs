using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial2PA.Infrastructure
{
    using Parcial2PA.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}