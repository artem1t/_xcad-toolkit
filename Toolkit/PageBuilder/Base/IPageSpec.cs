﻿//*********************************************************************
//xCAD
//Copyright(C) 2020 Xarial Pty Limited
//Product URL: https://www.xcad.net
//License: https://github.com/xarial/xcad/blob/master/LICENSE
//*********************************************************************

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xarial.XCad.UI.PropertyPage.Enums;

namespace Xarial.XCad.Utils.PageBuilder.Base
{
    public interface IPageSpec
    {
        string Title { get; }
        PageOptions_e Options { get; }
    }
}
