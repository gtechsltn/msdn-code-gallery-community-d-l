# Excel Financial functions for .NET
## Requires
- Visual Studio 2010
## License
- Apache License, Version 2.0
## Technologies
- Microsoft Office Excel 2010
## Topics
- Excel
## Updated
- 07/02/2011
## Description

<p><strong>What is it?</strong><br>
This is a .NET library that provides the full set of financial functions from Excel. The main goal for the library is compatibility with Excel, by providing the same functions, with the same behaviour. Note though that this is not a wrapper over the Excel library;
 the functions have been re-implemented in managed code so that you do not need to have Excel installed to use this library.</p>
<p>The old codegallery is here:&nbsp;<a href="http://archive.msdn.microsoft.com/FinancialFunctions/Wiki/View.aspx?title=Home">http://archive.msdn.microsoft.com/FinancialFunctions/Wiki/View.aspx?title=Home</a>. It contains a beta version that works inside SQL
 Server.</p>
<p><br>
<strong>Where I can find documentation on these functions?</strong><br>
Just open Excel and click on Formulas/Financial or go to this link:&nbsp;<a href="http://office.microsoft.com/client/helppreview.aspx?AssetID=HP100791841033&ns=EXCEL&lcid=1033&CTT=3&Origin=HP100623561033">http://office.microsoft.com/client/helppreview.aspx?AssetID=HP100791841033&amp;ns=EXCEL&amp;lcid=1033&amp;CTT=3&amp;Origin=HP100623561033</a><br>
<br>
<strong>I don't think one of the function is right. Excel produces the wrong results! Why don't you do it right?</strong><br>
My goal is to replicate Excel 12 results (right and wrong). Feel free to contribute to the effort by coding what you think is the right solution and I'll add an ExcelCompliant flag to the function to conditionally invoke your code.<br>
<br>
<strong>How do I use the library?</strong><br>
Just add Financial.dll to the references in your project. The functions are provided as static methods on a Financial class in the <a class="libraryLink" href="http://msdn.microsoft.com/en-US/library/System.Numeric.aspx" target="_blank" title="Auto generated link to System.Numeric">System.Numeric</a> namespace<br>
<br>
<strong>I see the library was implemented with F#. But I don&rsquo;t want to redistribute F# along with my application. What should I do?</strong><br>
There are two versions of the library. One of them statically links the F# libraries so that there is no dependency on F#. However, this assembly larger, so if you have F# installed, you can use the FinancialNotStandalone.dll instead.<br>
<br>
<strong>How do I run the tests?</strong><br>
Run FinancialTests.exe. You need Excel 12 for the tests to work because they use Excel to test that the results are correct. You don't need Excel 12 to use the library in your own application.<br>
<br>
<strong>How do I compile the library?</strong><br>
You need to have F# September CTP installed (you can get it from here&nbsp;<a href="http://www.microsoft.com/downloads/details.aspx?FamilyID=61ad6924-93ad-48dc-8c67-60f7e7803d3c">http://www.microsoft.com/downloads/details.aspx?FamilyID=61ad6924-93ad-48dc-8c67-60f7e7803d3c</a>).
 There are two batch files (CreateLibraryStandalone.bat and CreateLibraryNotStandalon.bat). Run them from a VS Command Prompt to compile the dll. You might have to change the path to the F# compiler inside these files if you run it from a normal command prompt.<br>
<br>
<strong>How do I compile the tests?</strong><br>
Run CreateTests.bat<br>
<br>
<strong>Have you tested this thing?</strong><br>
Yes, I do have 201,349 testcases running against it. You can easily raise that number significantly by adding new values to test in testdef.fs. If you have a multiproc machine the testcases will run faster as I parallelize their execution.<br>
<br>
<strong>Have you run performance tests on it?</strong><br>
Not at all. The only thing I checked is that all the recursive functions are tail recursive. Feel free to let me know if they are slow.<br>
<br>
<strong>Are there any functions that behave different from Excel?</strong><br>
Yes, there are two of them.<br>
<br>
<em>CoupDays</em><br>
The Excel algorithm seems wrong in that it doesn't respect the following:<br>
coupDays = coupDaysBS &#43; coupDaysNC.<br>
This equality should stand. By manually counting the days, I'm pretty confident that my algorithm is correct.My result differs from Excel by &#43;/- one or two days when the date spans a leap year.<br>
<br>
<em>VDB</em><br>
In the excel version of this algorithm the depreciation in the period (0,1) is not the same as the sum of the depreciations in periods (0,0.5) (0.5,1).<br>
VDB(100,10,13,0,0.5,1,0) &#43; VDB(100,10,13,0.5,1,1,0) &lt;&gt; VDB(100,10,13,0,1,1,0)<br>
Notice that in Excel by using '1' (no_switch) instead of '0' as the last parameter everything works as expected. The last parameter should have no influence in the calculation given that in the first period there is no switch to sln depreciation.<br>
Overall, I think my algorithm is correct, even if it disagrees with Excel when startperiod is fractional.<br>
<br>
<strong>Can you list the functions with their testcases results?</strong><br>
Succeeded 1840/1840 for PV<br>
Succeeded 2024/2024 for FV<br>
Succeeded 2240/2240 for PMT<br>
Succeeded 853/853 for NPER<br>
Succeeded 5355/5355 for IPMT<br>
Succeeded 5355/5355 for PPMT<br>
Succeeded 208/208 for CUMIPMT<br>
Succeeded 208/208 for CUMPRINC<br>
Succeeded 624/624 for ISPMT<br>
Succeeded 12/12 for FVSCHEDULE<br>
Succeeded 9/9 for IRR<br>
Succeeded 21/21 for NPV<br>
Succeeded 147/147 for MIRR<br>
Succeeded 18/18 for XIRR<br>
Succeeded 396/396 for DB<br>
Succeeded 24/24 for SLN<br>
Succeeded 132/132 for SYD<br>
Succeeded 456/456 for DDB<br>
Succeeded 2544/2544 for VDB excluding fractional startdates<br>
Succeeded 11520/11520 for AMORLINC<br>
Succeeded 23040/23040 for AMORDEGRC<br>
Succeeded 15/15 for COUPDAYS excluding leap years<br>
Succeeded 915/915 for COUPDAYSBS<br>
Succeeded 915/915 for COUPDAYSNC<br>
Succeeded 915/915 for COUPNUM<br>
Succeeded 915/915 for COUPPCD<br>
Succeeded 915/915 for COUPNCD<br>
Succeeded 360/360 for ACCRINTM<br>
Succeeded 1920/1920 for ACCRINT<br>
Succeeded 10980/10980 for PRICE<br>
Succeeded 1940/1940 for PRICEMAT<br>
Succeeded 2910/2910 for YIELDMAT<br>
Succeeded 1395/1395 for YEARFRAC<br>
Succeeded 2745/2745 for INTRATE<br>
Succeeded 1290/1290 for RECEIVED<br>
Succeeded 2745/2745 for DISC<br>
Succeeded 3660/3660 for PRICEDISC<br>
Succeeded 2745/2745 for YIELDDISC<br>
Succeeded 48/48 for TBILLEQ<br>
Succeeded 69/69 for TBILLYIELD<br>
Succeeded 81/81 for TBILLPrice<br>
Succeeded 12/12 for DOLLARDE<br>
Succeeded 12/12 for DOLLARFR<br>
Succeeded 12/12 for EFFECT<br>
Succeeded 12/12 for NOMINAL<br>
Succeeded 5490/5490 for DURATION<br>
Succeeded 5490/5490 for MDURATION<br>
Succeeded 19320/19320 for ODDFPRICE<br>
Succeeded 30600/30600 for ODDLPRICE<br>
Succeeded 45900/45900 for ODDLYIELD<br>
Test Cases Succeeded 201349/201349</p>
