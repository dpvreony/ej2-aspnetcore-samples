#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser_NET6.Controllers.CircularChart3D
{
    public partial class CircularChart3DController : Controller
    {
        public IActionResult Selection()
        {
            List<SelectionChartData> ChartPoints = new List<SelectionChartData>
            {
                new SelectionChartData { X = "Chrome",             Y = 62.92 },
                new SelectionChartData { X = "Internet Explorer",  Y = 6.12  },
                new SelectionChartData { X = "Edge",               Y = 5.5   },
                new SelectionChartData { X = "Opera",              Y = 3.15  },
                new SelectionChartData { X = "Safari",             Y = 19.97 },
                new SelectionChartData { X = "Others",             Y = 2.34  }
            };
            ViewBag.ChartData = ChartPoints;
            return View();
        }
        public class SelectionChartData
        {
            public string X;
            public double Y;
        }
    }
}
