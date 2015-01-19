﻿using Easy.Web.CMS.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Easy.Extend;
using Easy.MetaData;
using Easy.Web.CMS.MetaData;

namespace Easy.CMS.Common.Models
{
    [DataConfigure(typeof(ImageWidgetMedaData))]
    public class ImageWidget : WidgetBase
    {
        public string ImageUrl { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }

        public string AltText { get; set; }
    }
    class ImageWidgetMedaData : WidgetMetaData<ImageWidget>
    {

    }
}