# Invoke ScriptNotify event when we click a button inside a WebView
## Requires
- Visual Studio 2013
## License
- MS-LPL
## Technologies
- Windows Store Apps
## Topics
- WebView
## Updated
- 01/21/2015
## Description

<h1>Introduction</h1>
<p>In Windows Store apps is possible to use a WebView control to show web pages and sometimes we may need to intercept between the web page and the code behind of the XAML page, to do others task based in the action.</p>
<p>There are some changes from Windows 8.0 to Windows 8.1 related with the WebView control. These differences can be find here
<a href="http://blogs.windows.com/buildingapps/2013/07/17/whats-new-in-webview-in-windows-8-1/">
What&rsquo;s new in WebView in Windows 8.1</a>&nbsp;and there is an interesting sample:&nbsp;<a href="https://code.msdn.microsoft.com/windowsapps/How-to-intercept-854d33da">How to intercept JavaScript alert in WebView in universal Windows apps</a>&nbsp;from&nbsp;<a title="Go to OneCode Team's profile" href="https://social.msdn.microsoft.com/profile/onecode%20team/" target="_blank">OneCode
 Team</a>. In this sample, we will see a solution for when we click a button from a web page hosted in a WebView.</p>
<p>&nbsp;</p>
<h1><span>Building the Sample</span></h1>
<p><em><em>You only need Visual Studio 2013 and Windows 8.1.</em></em></p>
<p><span style="font-size:20px; font-weight:bold">Description</span></p>
<p>To start, we need to create a Windows Store App, we can select the Blank Template, and then we need to create a basic html page with a button, as following:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>HTML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">html</span>

<div class="preview">
<pre class="csharp">&lt;!DOCTYPE&nbsp;html&gt;&nbsp;
&nbsp;
&lt;html&nbsp;lang=<span class="cs__string">&quot;en&quot;</span>&nbsp;xmlns=<span class="cs__string">&quot;http://www.w3.org/1999/xhtml&quot;</span>&gt;&nbsp;
&lt;head&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;meta&nbsp;charset=<span class="cs__string">&quot;utf-8&quot;</span>&nbsp;/&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;title&gt;&lt;/title&gt;&nbsp;
&lt;/head&gt;&nbsp;
&lt;body&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&lt;button&nbsp;type=<span class="cs__string">&quot;button&quot;</span>&nbsp;id=<span class="cs__string">&quot;MyButton&quot;</span>&gt;Click&nbsp;here...&lt;/button&gt;&nbsp;
&lt;/body&gt;&nbsp;
&lt;/html&gt;</pre>
</div>
</div>
</div>
<p>After it, we need to define a WebView in the MainPage.xaml, as following:</p>
<p>&nbsp;</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XAML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xaml</span>

<div class="preview">
<pre class="js">&nbsp;&nbsp;&lt;WebView&nbsp;Name=<span class="js__string">&quot;WebView&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Margin=<span class="js__string">&quot;100&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;NavigationCompleted=<span class="js__string">&quot;WebView_OnNavigationCompleted&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ScriptNotify=<span class="js__string">&quot;WebView_OnScriptNotify&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Source=<span class="js__string">&quot;ms-appx-web:///HtmlPage.html&quot;</span>&nbsp;/&gt;</pre>
</div>
</div>
</div>
<div class="endscriptcode">
<p>And in code behind, we need define the NavigationCompleted event handler as following:</p>
</div>
<div class="endscriptcode"></div>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="js">&nbsp;&nbsp;private&nbsp;async&nbsp;<span class="js__operator">void</span>&nbsp;WebView_OnNavigationCompleted(WebView&nbsp;sender,&nbsp;WebViewNavigationCompletedEventArgs&nbsp;args)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__brace">{</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;await&nbsp;WebView.InvokeScriptAsync(<span class="js__string">&quot;eval&quot;</span>,&nbsp;<span class="js__operator">new</span>[]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__brace">{</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__string">&quot;var&nbsp;signButton=document.getElementById(\&quot;MyButton\&quot;);&quot;</span>&nbsp;&#43;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__string">&quot;if&nbsp;(signButton.addEventListener)&nbsp;{&quot;</span>&nbsp;&#43;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__string">&quot;signButton.addEventListener(\&quot;click\&quot;,&nbsp;MyButtonClicked,&nbsp;false);&quot;</span>&nbsp;&#43;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__string">&quot;}&nbsp;else&nbsp;{&quot;</span>&nbsp;&#43;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__string">&quot;signButton.attachEvent('onclick',&nbsp;MyButtonClicked);&quot;</span>&nbsp;&#43;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__string">&quot;}&nbsp;&nbsp;&quot;</span>&nbsp;&#43;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__string">&quot;function&nbsp;MyButtonClicked(){&quot;</span>&nbsp;&#43;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__string">&quot;&nbsp;window.external.notify('%%'&nbsp;&#43;&nbsp;location.href);&quot;</span>&#43;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__string">&quot;}&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__brace">}</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__brace">}</span></pre>
</div>
</div>
</div>
<div class="endscriptcode">
<p>Here we are injecting JavaScript code to the web page, that will add the event click to the &quot;MyButton&quot; button defined in the html page. Each time the click event is fired the function &quot;MyButtonClicked&quot; will be called and it will fire the ScriptNotify&nbsp;event
 providing the url.&nbsp;</p>
<p>Now, we need to define the WebView's&nbsp;ScriptNotify&nbsp;event handler as following</p>
</div>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="js">&nbsp;private&nbsp;<span class="js__operator">void</span>&nbsp;WebView_OnScriptNotify(object&nbsp;sender,&nbsp;NotifyEventArgs&nbsp;e)&nbsp;
<span class="js__brace">{</span>&nbsp;
&nbsp;&nbsp;&nbsp;<span class="js__statement">var</span>&nbsp;url&nbsp;=&nbsp;e.Value;&nbsp;
<span class="js__brace">}</span></pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;The event handler is fired and the url value is set.</div>
<div class="endscriptcode"></div>
<h1>Running the application</h1>
<p>&nbsp;</p>
<div class="entry-content">
<p><img src="http://i2.wp.com/s20.postimg.org/ep1brhnfh/webview1.jpg?w=584" alt="The webview" width="584" height="328"></p>
<p>&nbsp;</p>
<p>And clicking in the button we will get the url value, as we can see in the following image:</p>
<p>&nbsp;</p>
<p><img src="http://i2.wp.com/s20.postimg.org/ffu1x9pst/webview2.jpg?w=584" alt="The webview's scriptnotify event handler" width="584" height="114"></p>
</div>
<p>&nbsp;</p>
<h1><span>Source Code Files</span></h1>
<ul>
<li><em><strong>HtmlPage.html </strong>- define the HTML page to dispaly in the WebView.</em>
</li><li><em><em><strong>MainPage.xaml</strong> - define the Xaml page that show the WebView.</em></em>
</li></ul>
<h1>More Information</h1>
<p><em><em><em>Ask me on twitter&nbsp;<em><em><a href="https://twitter.com/saramgsilva">@saramgsilva</a></em></em></em></em></em></p>
<p>&nbsp;</p>
<h1>Follow me</h1>
<blockquote>
<p><a href="http://www.saramgsilva.com/">My blog: typeof(saramgsilva)</a></p>
<p><a href="https://twitter.com/saramgsilva">My twitter @saramgsilva</a></p>
</blockquote>
<p><em><em><em><em><em><br>
</em></em></em></em></em></p>
<p><a title="shopify analytics tool" href="http://statcounter.com/shopify/" target="_blank"><img src="http://c.statcounter.com/10247856/0/fbddae77/1/" alt="shopify analytics tool" style="border:none"></a></p>
