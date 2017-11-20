using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GStaff.Models
{
    public class MainMenuItem
    {
        public int NoID { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}
