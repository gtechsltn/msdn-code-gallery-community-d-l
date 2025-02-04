﻿//using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Design;
using System.Drawing;

namespace Household_budget_calculator_CS.expanding_property_classes.TypeEditors
{
    public class TypeEditor0 : UITypeEditor
    {
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context)
        {
            return true;
        }

        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e)
        {
            Bitmap img = new Bitmap(19, 12);
            Graphics gr = Graphics.FromImage(img);
            gr.Clear(Color.FromArgb(215, 215, 195));
            e.Graphics.DrawImage(img, new Point(2, 2));
            base.PaintValue(e);
        }

    }
}
