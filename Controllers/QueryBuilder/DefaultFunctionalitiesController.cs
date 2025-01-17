#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;
using Syncfusion.EJ2.QueryBuilder;

namespace EJ2CoreSampleBrowser.Controllers.QueryBuilder
{
    public partial class QueryBuilderController : Controller
    {
        public IActionResult DefaultFunctionalities()
        {
            ViewBag.ImportBtn = new ButtonModel() { isPrimary = true, cssClass = "e-flat", content = "Import" };
            ViewBag.CancelBtn = new ButtonModel() { content = "Cancel", cssClass = "e-flat" };
            return View();
        }
    }
    public class ButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
        public string cssClass { get; set; }

    }
}