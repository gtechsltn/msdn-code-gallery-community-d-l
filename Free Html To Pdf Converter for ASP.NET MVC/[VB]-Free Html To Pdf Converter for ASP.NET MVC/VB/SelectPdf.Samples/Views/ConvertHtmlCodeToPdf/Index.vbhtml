﻿@code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "SelectPdf Free Html To Pdf Converter for .NET - Convert from Html Code to Pdf - VB.NET / ASP.NET MVC"
    ViewBag.Description = "SelectPdf Free Html To Pdf Converter Convert from Html Code to Pdf Sample for VB.NET ASP.NET MVC. Pdf Library for .NET with full sample code in C# and VB.NET."
    ViewBag.Keywords = "convert from html to pdf, pdf library, sample code, html to pdf, pdf converter"
End code

@Using (Html.BeginForm("SubmitAction", "ConvertHtmlCodeToPdf", FormMethod.Post))

    @<article class="post type-post status-publish format-standard hentry">
        <header class="entry-header">
            <h1 class="entry-title">SelectPdf Free Html To Pdf Converter - Convert from Html Code to Pdf - VB.NET / ASP.NET MVC Sample</h1>
        </header>
        <!-- .entry-header -->

        <div class="entry-content">
            <p>
                This sample shows how to use SelectPdf html to pdf converter to convert a raw html code to pdf, also setting a few properties.
            </p>
            <p>
                Html Code:<br />
                <textarea id="TxtHtmlCode" name="TxtHtmlCode" style="height:150px; width: 90%;">@ViewData("TxtHtmlCode")</textarea>
                <br />
                <br />
                Base Url:<br />
                <input type="text" value="" name="TxtBaseUrl" style="width: 90%;" />
                
            </p>
            <div class="col2">
                Pdf Page Size:<br />
                <select name="DdlPageSize">
                    <option value="A1">A1</option>
                    <option value="A2">A2</option>
                    <option value="A3">A3</option>
                    <option value="A4" selected>A4</option>
                    <option value="A5">A5</option>
                    <option value="Letter">Letter</option>
                    <option value="HalfLetter">HalfLetter</option>
                    <option value="Ledger">Ledger</option>
                    <option value="Legal">Legal</option>
                </select>
               <br />
                <br />
                Pdf Page Orientation:<br />
                <select name="DdlPageOrientation">
                    <option value="Portrait" selected>Portrait</option>
                    <option value="Landscape">Landscape</option>
                </select><br />
                <br />
            </div>
            <div class="col2">
                Web Page Width:<br />
                <input type="text" value="1024" name="TxtWidth" style="width: 50px;" />
                 px<br />
                <br />
                Web Page Height:<br />
                <input type="text" value="" name="TxtHeight" style="width: 50px;" />
                 px<br />
                (leave empty to auto detect)<br />
                <br />

            </div>
            <div class="col-clear"></div>
            <p>
                <input type="submit" name="BtnConvert" value="Create PDF" class="mybutton" />
            </p>
        </div>
        <!-- .entry-content -->
    </article>
End Using