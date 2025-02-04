﻿@code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "SelectPdf Free Html To Pdf Converter for .NET - Use media types with Html to Pdf Converter - VB.NET / ASP.NET MVC"
    ViewBag.Description = "SelectPdf Free Html To Pdf Converter Use media types with Html to Pdf Converter Sample for VB.NET ASP.NET MVC. Pdf Library for .NET with full sample code in C# and VB.NET."
    ViewBag.Keywords = "media type, media print, pdf library, sample code, html to pdf, pdf converter"
End code

@Using (Html.BeginForm("SubmitAction", "MediaTypes", FormMethod.Post))

    @<article class="post type-post status-publish format-standard hentry">
        <header class="entry-header">
            <h1 class="entry-title">SelectPdf Free Html To Pdf Converter - Use media types with Html to Pdf Converter - VB.NET / ASP.NET MVC Sample</h1>
        </header>
        <!-- .entry-header -->

        <div class="entry-content">
            <p>
                This sample shows how to convert an url to pdf using SelectPdf Pdf Library for .NET and also use a media type during the conversion.
                <br />
                <br />
                The 2 available media types are <i>Screen</i> and <i>Print</i>. They are useful for pages that use a different set of styles when displayed in browser and when sent to printers.
            </p>
            <p>
                Url:<br />
                <input type="text" value="http://selectpdf.com" name="TxtUrl" style="width: 90%;" />                
                <br />
                <br />
                Media Type:<br />
                <select name="DdlCssMediaType" >
                    <option value="Screen" selected="selected">Screen</option>
                    <option value="Print">Print</option>                    
                </select>
                <br />
                <br />
                <input type="submit" name="BtnConvert" value="Create PDF" class="mybutton" />
            </p>
        </div>
        <!-- .entry-content -->
    </article>
    
   
end Using
    