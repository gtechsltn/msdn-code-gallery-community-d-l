# Dynamic XAML - XamlReader
## Requires
- Visual Studio 2013
## License
- MIT
## Technologies
- WPF
## Topics
- WPF
- XAML
- Dynamic XAML
- Dynamic UI
## Updated
- 01/02/2015
## Description

<p>This sample is intended to introduce the reader to using <a href="http://msdn.microsoft.com/en-us/library/system.windows.markup.xamlreader(v=vs.110).aspx">
XamlReader </a>to generate UI objects at run time. &nbsp;The very basics are covered plus some tips which are a bit more advanced.</p>
<p><span style="color:#ff00ff">If you like this article and or the sample, please don't forget to click that 5 star rating.&nbsp;(Thanks).</span></p>
<h2>The Dynamic XAML Series</h2>
<p>This sample is part of the Dynamic XAML Series, you can find the parent article&nbsp;<a href="https://code.msdn.microsoft.com/Dynamic-XAML-b03c9303">here</a>.</p>
<h2>Pre Requisites</h2>
<p>This sample was build using Visual Studio 2013 and targets .Net 4.51. <br>
<br>
</p>
<h2>Usage</h2>
<p>If you click either of the top two buttons on the left it generates a button and adds it to the window on the right. &nbsp;You can then click one of these and a &quot;Hello&quot; message will appear in the centre for a few seconds. Whilst not particularly awe inspiring
 of itself the &quot;Hello&quot; message proves the button is connecting up to code.</p>
<p>The third button is intended for you to use in order to experiment with various aspects of manipulation in order to gain a better understanding of what's going on and what you can do.&nbsp;</p>
<p>Click the top button.</p>
<p>You see a button &quot;Button in Xaml File&quot; appear on the right.</p>
<p>Click that,</p>
<p>A &quot;Hello&quot; message appears and fades out after a few seconds.</p>
<p>Click the middle left button.</p>
<p>A button &quot;Button in xml File&quot; appears.</p>
<p>Click that.</p>
<p>A &quot;Hello&quot; message appears and fades out after a few seconds.</p>
<p>Save the third button for later.</p>
<h2>Show Me the Code</h2>
<p>This article is slightly different from others in that you're going to join in. &nbsp;If you didn't already, go get the code and crank up Visual Studio. &nbsp;Visual Studio Express will do. &nbsp;The best way to learn is hands on. &nbsp;Spin her up for a
 ride and try those buttons. Not the experimental one... not yet.</p>
<p>Let's start explaining things with the markup - the bulk of the XAML is doing that message fade animation.</p>
<h2>MainWindow markup</h2>
<p>MainWindow has a Grid with 3 columns. &nbsp;In the middle column is a TextBox &nbsp;- that's where you see the &quot;Hello&quot;.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">XAML</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xaml</span>

<div class="preview">
<pre class="xaml">&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;Grid</span><span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;Grid</span>.ColumnDefinitions<span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;ColumnDefinition</span>&nbsp;<span class="xaml__attr_name">Width</span>=<span class="xaml__attr_value">&quot;*&quot;</span><span class="xaml__tag_start">/&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;ColumnDefinition</span>&nbsp;<span class="xaml__attr_name">Width</span>=<span class="xaml__attr_value">&quot;*&quot;</span><span class="xaml__tag_start">/&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;ColumnDefinition</span>&nbsp;<span class="xaml__attr_name">Width</span>=<span class="xaml__attr_value">&quot;*&quot;</span><span class="xaml__tag_start">/&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;/Grid.ColumnDefinitions&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;StackPanel</span><span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;Button</span>&nbsp;<span class="xaml__attr_name">Click</span>=<span class="xaml__attr_value">&quot;Button1_Click&quot;</span><span class="xaml__tag_start">&gt;</span>Xaml&nbsp;Button<span class="xaml__tag_end">&lt;/Button&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;Button</span>&nbsp;<span class="xaml__attr_name">Click</span>=<span class="xaml__attr_value">&quot;Button2_Click&quot;</span><span class="xaml__tag_start">&gt;</span>txt&nbsp;Button<span class="xaml__tag_end">&lt;/Button&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;Button</span>&nbsp;<span class="xaml__attr_name">Click</span>=<span class="xaml__attr_value">&quot;Button3_Click&quot;</span><span class="xaml__tag_start">&gt;</span>Experimental&nbsp;Button<span class="xaml__tag_end">&lt;/Button&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_end">&lt;/StackPanel&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;StackPanel</span>&nbsp;<span class="xaml__attr_name">Name</span>=<span class="xaml__attr_value">&quot;AddHere&quot;</span>&nbsp;Grid.<span class="xaml__attr_name">Column</span>=<span class="xaml__attr_value">&quot;2&quot;</span><span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_end">&lt;/StackPanel&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;TextBlock</span>&nbsp;x:<span class="xaml__attr_name">Name</span>=<span class="xaml__attr_value">&quot;UIMessage&quot;</span>&nbsp;<span class="xaml__attr_name">Text</span>=<span class="xaml__attr_value">&quot;{Binding&nbsp;Msg}&quot;</span>&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__attr_name">HorizontalAlignment</span>=<span class="xaml__attr_value">&quot;Center&quot;</span>&nbsp;<span class="xaml__attr_name">VerticalAlignment</span>=<span class="xaml__attr_value">&quot;Top&quot;</span>&nbsp;Grid.<span class="xaml__attr_name">Column</span>=<span class="xaml__attr_value">&quot;1&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__attr_name">Opacity</span>=<span class="xaml__attr_value">&quot;{Binding&nbsp;MsgOpacity,&nbsp;Mode=TwoWay,&nbsp;FallbackValue=0}&quot;</span><span class="xaml__tag_start">&gt;&nbsp;
</span><span class="xaml__tag_start">&lt;TextBlock</span>.Style<span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;Style</span><span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;Style</span>.Triggers<span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;DataTrigger</span>&nbsp;<span class="xaml__attr_name">Binding</span>=<span class="xaml__attr_value">&quot;{Binding&nbsp;ElementName=UIMessage,&nbsp;Path=Opacity}&quot;</span>&nbsp;<span class="xaml__attr_name">Value</span>=<span class="xaml__attr_value">&quot;1&quot;</span><span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;DataTrigger</span>.EnterActions<span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;BeginStoryboard</span><span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;Storyboard</span><span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&lt;DoubleAnimation</span>&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Storyboard.<span class="xaml__attr_name">TargetProperty</span>=<span class="xaml__attr_value">&quot;Opacity&quot;</span>&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__attr_name">From</span>=<span class="xaml__attr_value">&quot;1&quot;</span>&nbsp;<span class="xaml__attr_name">To</span>=<span class="xaml__attr_value">&quot;0&quot;</span>&nbsp;<span class="xaml__attr_name">Duration</span>=<span class="xaml__attr_value">&quot;0:0:3&quot;</span>&nbsp;<span class="xaml__attr_name">FillBehavior</span>=<span class="xaml__attr_value">&quot;Stop&quot;</span>&nbsp;<span class="xaml__tag_start">/&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_end">&lt;/Storyboard&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_end">&lt;/BeginStoryboard&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;/DataTrigger.EnterActions&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_end">&lt;/DataTrigger&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;/Style.Triggers&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_end">&lt;/Style&gt;</span>&nbsp;
&lt;/TextBlock.Style&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_end">&lt;/TextBlock&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_end">&lt;/Grid&gt;</span></pre>
</div>
</div>
</div>
<div class="endscriptcode">The three buttons are the ones you already saw running the app. &nbsp;They go in Column 0 so they're in the left third of the window.</div>
<div class="endscriptcode">Column 1 has that TextBlock for the message.</div>
<div class="endscriptcode">Column 2 has just a StackPanel in it - &nbsp;those buttons which appear are dynamically created and added to this.&nbsp;</div>
<div class="endscriptcode"></div>
<div class="endscriptcode"></div>
<div class="endscriptcode">Most of the rest is to do with the message. &nbsp;The TextBlock has it's Opactity bound to a property in a Viewmodel we'll be looking at shortly.</div>
<div class="endscriptcode">When that is changed to 1 by that binding, the DataTrigger kicks in and starts the fade.</div>
<div class="endscriptcode">The resulting animation fades the opacity from 1 to 0 over 3 seconds.</div>
<div class="endscriptcode">Because this is a EnterAction which does this the default is for that to over-write the value of the property animated. &nbsp;That's no good because a set value takes precedence over a binding and we'd lose the binding completely.
 &nbsp;Setting FillBehavior to Stop avoids this and when the storyboard stop it will revert to whatever value comes from the binding. &nbsp;More on that later.</div>
<div class="endscriptcode"></div>
<div class="endscriptcode">
<h2>MainWindow Code Behind</h2>
</div>
<div class="endscriptcode"></div>
<div class="endscriptcode">The constructor of MainWindow sets it's Datacontext to an instance of MainWindowViewModel.</div>
<div class="endscriptcode">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">C#</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="csharp">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;MainWindow()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;InitializeComponent();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">this</span>.DataContext&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;MainWindowViewModel();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}</pre>
</div>
</div>
</div>
<div class="endscriptcode">There are also several click handlers which are wired up to those three buttons.</div>
<div class="endscriptcode">This is arguably the most important bit - we'll come back to them later.</div>
</div>
<div class="endscriptcode"></div>
<div class="endscriptcode">
<h2>MainWindowViewModel</h2>
</div>
<div class="endscriptcode">MVVMLight is used in this sample and it's the Hello relay command which does that message.</div>
<div class="endscriptcode">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">C#</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="csharp">&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">class</span>&nbsp;MainWindowViewModel&nbsp;:&nbsp;ViewModelBase&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;RelayCommand&nbsp;Hello&nbsp;{<span class="cs__keyword">get</span>;&nbsp;<span class="cs__keyword">set</span>;}&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">double</span>&nbsp;msgOpacity&nbsp;=&nbsp;<span class="cs__number">0.0</span>;&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">double</span>&nbsp;MsgOpacity&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">get</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;msgOpacity;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">set</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;msgOpacity&nbsp;=&nbsp;<span class="cs__keyword">value</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RaisePropertyChanged();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;msg&nbsp;=&nbsp;<span class="cs__string">&quot;&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;Msg&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">get</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;msg;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">set</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;msg&nbsp;=&nbsp;<span class="cs__keyword">value</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RaisePropertyChanged();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;MainWindowViewModel()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Hello&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;RelayCommand(HelloExecute);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;HelloExecute()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Msg&nbsp;=&nbsp;<span class="cs__string">&quot;Hello&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MsgOpacity&nbsp;=&nbsp;<span class="cs__number">1.0</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MsgOpacity&nbsp;=&nbsp;<span class="cs__number">0.0</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}</pre>
</div>
</div>
</div>
<div class="endscriptcode">In there we can see there's that MsgOpacity which we touched on earlier. &nbsp; The Msg property will expose that &quot;Hello&quot; and is bound to the Textblock's text property we saw in the markup.</div>
</div>
<p>The Hello relaycommand is wired up to HelloExecute in the constructor.</p>
<p>When that command is invoked it sets Msg to &quot;Hello&quot; and MsgOpacity to 1. &nbsp;That triggers the storyboard in the View and that starts fading the opacity from 1 to 0. When that finishes it will revert to whatever the property is - which is why it's immediately
 set to 0. &nbsp;The animation has control over what the value is whilst it's running, when it finishes the value it's bound to is used and that then picks up 0. &nbsp;If you missed out that MsgOpacity = 0.0 then the opacity would return to 1 at the end of
 the animation.</p>
<p>Animations always get people's attention but let's move on to dynamic control generation. &nbsp;Which is pretty cool itself.</p>
<h2>Xaml Button</h2>
<p>The click event for this uses a Xaml file.&nbsp;Since this article is all about XamlReader and how it can be used to generate UI objects there's probably no surprise to see it's using the
<a href="http://msdn.microsoft.com/en-us/library/ms590388(v=vs.110).aspx">Load</a> method of XamlReader there. &nbsp;</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">C#</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="csharp">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;Button1_Click(<span class="cs__keyword">object</span>&nbsp;sender,&nbsp;RoutedEventArgs&nbsp;e)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;StreamReader&nbsp;sr&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;StreamReader(<span class="cs__string">&quot;Button1.xaml&quot;</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Button&nbsp;btn&nbsp;=&nbsp;XamlReader.Load(sr.BaseStream)&nbsp;<span class="cs__keyword">as</span>&nbsp;Button;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">this</span>.AddHere.Children.Add(btn);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}</pre>
</div>
</div>
</div>
<div class="endscriptcode">That creates a streamreader from Button1.xaml. &nbsp;A Button is created using that xaml and added to that stackpanel in column 2 of the view.</div>
<div class="endscriptcode">&nbsp;</div>
<div class="endscriptcode">The Load method is overloaded and takes an xmlReader; a XamlReader or a stream. &nbsp;Stream tends to be the most useful. &nbsp;The Load method is best suited to where you aren't going to manipulate anything and just take whatever
 you get.</div>
<div class="endscriptcode">Notice that there is also a LoadAsync method which is good if you're getting the Xaml from a service or if whatever you are reading is very big.</div>
<div class="endscriptcode"></div>
<div class="endscriptcode"></div>
<div class="endscriptcode">How about that file it's using.</div>
<div class="endscriptcode"></div>
<div class="endscriptcode">
<h2>Button1.xaml</h2>
</div>
<div class="endscriptcode">When you take a look at this file it looks pretty much like you would any Button you'd see in regular markup. &nbsp;Like other similar files in the sample, this is a file whose properties are set to Content and Copy if newer. &nbsp;That
 means it will be copied into the Debug folder along with your exe. Go check that for yourself. &nbsp;There's quite a few things in that folder but the Buttons are up at the top. &nbsp;Almost like that was planned to make it easy for you to see ;^) &nbsp;</div>
<div class="endscriptcode">There's two buttons and Experiment.txt in there.&nbsp;</div>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">XAML</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xaml</span>

<div class="preview">
<pre class="xaml"><span class="xaml__tag_start">&lt;Button</span>&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__attr_name">xmlns</span>=<span class="xaml__attr_value">&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__keyword">xmlns</span>:<span class="xaml__attr_name">x</span>=<span class="xaml__attr_value">&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__attr_name">Width</span>=<span class="xaml__attr_value">&quot;120&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__attr_name">Height</span>=<span class="xaml__attr_value">&quot;24&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__attr_name">Command</span>=<span class="xaml__attr_value">&quot;{Binding&nbsp;Hello}&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;Button&nbsp;in&nbsp;Xaml&nbsp;File&nbsp;
<span class="xaml__tag_end">&lt;/Button&gt;</span></pre>
</div>
</div>
</div>
<div class="endscriptcode">It's a button with a binding which will grab that Hello command from the Viewmodel. &nbsp;That's quite interesting when you think about it. &nbsp;As the window is shown, it has it's datacontext set so the viewmodel is there. &nbsp;Nothing
 is connected up to that Hello command until you create a button using this markup and add it onto the window. &nbsp;Then it grabs the command.</div>
<div class="endscriptcode">Nothing cares whether something or nothing ( or two things as you will see ) are connected up to that Hello command.</div>
<div class="endscriptcode">You could have numerous commands and load up a button based on some logic which connects to whichever.</div>
<div class="endscriptcode">As you will see in later samples in this series you could even dynamically set an attribute like which command a button is bound to.</div>
<p>There is something a bit strange about that markup.</p>
<p>You wouldn't usually expect those xmlns <a href="http://msdn.microsoft.com/en-us/library/ms747086(v=vs.110).aspx">
namespaces</a>&nbsp;to appear in the markup for a Button. &nbsp;They'd usually be up the top of your Window. &nbsp;</p>
<p>What's that all about?</p>
<p>These are rather like usings in c# ( or imports in vb ) where you're telling something where to go get the classes for the stuff in the markup.</p>
<p>If you look at the markup closely you can see there are actually no x:Static or x:Name or the like used in there at all.</p>
<p>Take that second xmlns out leaving you with:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">C#</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="csharp">&lt;Button&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;xmlns=<span class="cs__string">&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;Width=<span class="cs__string">&quot;120&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;Height=<span class="cs__string">&quot;24&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;Command=<span class="cs__string">&quot;{Binding&nbsp;Hello}&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;Button&nbsp;<span class="cs__keyword">in</span>&nbsp;Xaml&nbsp;File&nbsp;
&lt;/Button&gt;</pre>
</div>
</div>
</div>
<div class="endscriptcode">f5 to run it and the application runs fine.&nbsp;</div>
<div class="endscriptcode">Take that other xmlns out as well.</div>
<div class="endscriptcode">The designer considers this to be a Xaml file like a window or usercontrol or page.</div>
<div class="endscriptcode">That Button immediately gets a squiggly blue line under it and if you mouse over you see &quot;The default namespace is not defined&quot;. It's not happy but sometimes the designer gives spurious errors.</div>
<div class="endscriptcode">Maybe we're still OK?</div>
<div class="endscriptcode">Hit f6 to compile.</div>
<div class="endscriptcode">Build succeeds.</div>
<div class="endscriptcode">So hit f5 and see what happens.</div>
<div class="endscriptcode">Click that button.</div>
<div class="endscriptcode">Ooops.</div>
<div class="endscriptcode">It errors: &quot;Cannot create unknown type 'Button'.</div>
<p>That error is from XamlReader and it's saying you didn't tell it where to go look for the definition of xaml so it doesn't know what a button is.</p>
<p>You might think this is very odd.</p>
<p>Why doesn't XamlReader know what to do with a Button - it's all about generating UI from Xaml isn't it?</p>
<p>The thing is that Xaml isn't just about WPF (Windows Store apps or Silverlight ). &nbsp;Xaml is also used to define<a href="http://msdn.microsoft.com/en-us/library/vstudio/ms735921(v=vs.90).aspx"> windows workflows</a>. &nbsp;in theory you could define your
 own object graph and create that. If that sounds a bit advanced, don't worry that's a subject for a future article.</p>
<p>This is why it isn't completely crazy that you need to tell XamlReader it's in the world of WPF and WPF objects is what it's going to be creating.</p>
<h2>txt Button</h2>
<p>This would probably be more logically called xml button, but that's very similar to Xaml so I went with txt instead. &nbsp;There's another reason but it's too early to explain that yet.</p>
<p>The file it's going to use is Button2.xml:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">XAML</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xaml</span>

<div class="preview">
<pre class="xaml"><span class="xaml__tag_start">&lt;?xml</span>&nbsp;<span class="xaml__attr_name">version</span>=<span class="xaml__attr_value">&quot;1.0&quot;</span>&nbsp;<span class="xaml__attr_name">encoding</span>=<span class="xaml__attr_value">&quot;utf-8&quot;</span>&nbsp;<span class="xaml__tag_start">?&gt;</span>&nbsp;
<span class="xaml__tag_start">&lt;Button</span>&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__attr_name">Width</span>=<span class="xaml__attr_value">&quot;120&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__attr_name">Height</span>=<span class="xaml__attr_value">&quot;24&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__attr_name">Command</span>=<span class="xaml__attr_value">&quot;{Binding&nbsp;Hello}&quot;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xaml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;Button&nbsp;in&nbsp;xml&nbsp;File&nbsp;
<span class="xaml__tag_end">&lt;/Button&gt;</span></pre>
</div>
</div>
</div>
<div class="endscriptcode">That's pretty similar to that first button except for two things.</div>
<div class="endscriptcode">
<ul>
<li>It's an xml file so it has that heading saying that's what it is. </li><li>There is none of that xmlns namespace stuff in the Button node. </li></ul>
</div>
<p>As we've seen XamlReader will need to know about those namespaces somehow. &nbsp;Plus of course if you try and just translate that directly into UI objects things are not going to go well since that xml heading is all wrong for XAML.</p>
<p>These are some of the reasons why this button click event has rather more code than that first one:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">C#</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="csharp">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;Button2_Click(<span class="cs__keyword">object</span>&nbsp;sender,&nbsp;RoutedEventArgs&nbsp;e)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;XDocument&nbsp;xmlDoc&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;XDocument();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;xmltxt&nbsp;=&nbsp;Application.GetContentStream(<span class="cs__keyword">new</span>&nbsp;Uri(@<span class="cs__string">&quot;pack://application:,,,/Button2.xml&quot;</span>));&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">string</span>&nbsp;elfull&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;StreamReader(xmltxt.Stream).ReadToEnd();&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;xmlDoc&nbsp;=&nbsp;XDocument.Parse(elfull);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;XElement&nbsp;el&nbsp;=&nbsp;xmlDoc.Root;&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;In&nbsp;a&nbsp;more&nbsp;complex&nbsp;situation,&nbsp;manipulate&nbsp;as&nbsp;XML/XElement&nbsp;tree&nbsp;</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ParserContext&nbsp;context&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;ParserContext();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;context.XmlnsDictionary.Add(<span class="cs__string">&quot;&quot;</span>,&nbsp;<span class="cs__string">&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;context.XmlnsDictionary.Add(&quot;x&quot;,&nbsp;&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;);</span>&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Button&nbsp;btn&nbsp;=&nbsp;(Button)XamlReader.Parse(el.ToString(),&nbsp;context);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">this</span>.AddHere.Children.Add(btn);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
</pre>
</div>
</div>
</div>
<div class="endscriptcode">That first way of loading up whatever you have is all very well if you don't want to manipulate the file at all. &nbsp;Often you'll want to do change things, insert objects, change values, add attributes and the like. &nbsp;</div>
<div class="endscriptcode"></div>
<div class="endscriptcode">The most convenient way to work with XAML is to treat it as xml. We can then use Linq to xml which makes such manipulation relatively easy.</div>
<div class="endscriptcode"></div>
<div class="endscriptcode">Let's go through the code and explain it though.</div>
<div class="endscriptcode"></div>
<div class="endscriptcode"></div>
<div class="endscriptcode">A pack URI is used to obtain the xml file via a stream which is then Parsed into an XDocument.</div>
<div class="endscriptcode">If you are working on a converter or a custom markup extension then this syntax is more reliable than seemingly simpler alternatives. &nbsp;It's not much more complicated anyway and understanding
<a href="http://msdn.microsoft.com/en-us/library/aa970069(v=vs.110).aspx">pack syntax</a> is useful for WPF generally.</div>
<p>The XDocument has that xml thing in the top which we only wanted so we could parse it easily. &nbsp;Now we have the thing in memory as xml we don't want that part. Using t xmlDoc.Root gets the root element and everything within that, effectively stripping
 the xml header.</p>
<p>Once we have that then it's an xml tree in memory - which just happens to also be XAML.</p>
<p>We can then manipulate that as we like.</p>
<p>You can find specific nodes on name or attribute value or combination of these and use .Add to add an XELement as a child or attribute to the node.</p>
<p>But this is an introductory article so we'll leave that for later articles where there is a meaningful task.</p>
<p>As mentioned earlier we need to tell XamlReader about those namespaces.</p>
<p>That's handled using a <a href="http://msdn.microsoft.com/en-us/library/system.windows.markup.parsercontext(v=vs.110).aspx">
ParserContext</a> - the context in question being those namespaces.</p>
<p>As you know, the x: namespace isn't necessary for this but is in there and commented out to show you how you would go about adding one.</p>
<p>Any other namespaces - like for example your own assamblies used in a usercontrol or custom attached properties - would be added to such a ParserContext as you will see in later samples.</p>
<p>Here XamlReader.<a href="http://msdn.microsoft.com/en-us/library/system.windows.markup.xamlreader.parse(v=vs.110).aspx">Parse</a> is used instead of Load in order to generate the Button object to add it into the stackpanel.</p>
<p>Parse is often more useful than Load when you're manipulating xml because it takes a string and you can easily convert an XElement.ToString() saving you loading it into a stream like the Load method wants.</p>
<p>This particular file is very simple and it's valid xml. &nbsp;Some xaml files won't quite be viable xml though and if you make them .xml files You will get warnings &nbsp;from Visual Studio. &nbsp;This is why it is often best to make these sort of xaml templates
 text files ( .txt ) instead of xml. &nbsp;That way you can have anything you like in them.</p>
<p>An oddity is that visual studio will recognise these are xml files &quot;really&quot; if you have them open whilst you build and give you warnings. &nbsp;The simple workround is just to close such files before you build.</p>
<p>Moving on from this button, next is that mysterious....</p>
<h2>Experimental Button</h2>
<p>The idea with this one is to give you a flavour of the sort of manipulation you can do.</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">C#</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="csharp"><span class="cs__keyword">private</span><span class="cs__keyword">void</span>&nbsp;Button3_Click(<span class="cs__keyword">object</span>&nbsp;sender,&nbsp;RoutedEventArgs&nbsp;e)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;XDocument&nbsp;xmlDoc&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;XDocument();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;xmltxt&nbsp;=&nbsp;Application.GetContentStream(<span class="cs__keyword">new</span>&nbsp;Uri(@<span class="cs__string">&quot;pack://application:,,,/Experiment.txt&quot;</span>));&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">string</span>&nbsp;elfull&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;StreamReader(xmltxt.Stream).ReadToEnd();&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;xmlDoc&nbsp;=&nbsp;XDocument.Parse(elfull);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;XElement&nbsp;el&nbsp;=&nbsp;xmlDoc.Root;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;XElement&nbsp;tc&nbsp;=&nbsp;el.Descendants(<span class="cs__string">&quot;DataGridTextColumn&quot;</span>).First();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span><span class="cs__keyword">string</span>&nbsp;x&nbsp;=&nbsp;<span class="cs__string">&quot;&quot;</span>;&nbsp;</span><span class="cs__com">//&nbsp;Put&nbsp;break&nbsp;point&nbsp;here</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}</pre>
</div>
</div>
</div>
<div class="endscriptcode">What this is doing is reading in Experiment.txt. &nbsp;It is Parsed into xml and the Root element extracted as above.</div>
<div class="endscriptcode">A reference to the first DataGridTextColumn is then obtained.</div>
<div class="endscriptcode">Experiment.txt looks like this:</div>
<div class="endscriptcode">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">XML</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xml</span>

<div class="preview">
<pre class="xml"><span class="xml__tag_start">&lt;?xml</span>&nbsp;<span class="xml__attr_name">version</span>=<span class="xml__attr_value">&quot;1.0&quot;</span>&nbsp;<span class="xml__attr_name">encoding</span>=<span class="xml__attr_value">&quot;utf-8&quot;</span>&nbsp;<span class="xml__tag_start">?&gt;</span>&nbsp;
<span class="xml__tag_start">&lt;DataGrid</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;<span class="xml__tag_start">&lt;DataGrid</span>.Columns<span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;DataGridTextColumn</span><span class="xml__tag_start">/&gt;</span>&nbsp;
&nbsp;&nbsp;&lt;/DataGrid.Columns&gt;&nbsp;
<span class="xml__tag_end">&lt;/DataGrid&gt;</span></pre>
</div>
</div>
</div>
<div class="endscriptcode">Put a break point in on that red line, f5 to run and click the experiment button.</div>
<div class="endscriptcode">It should break on that line and you can examine what you have.</div>
<div class="endscriptcode">Put the mouse over el, drop down the magnifying glass visualiser options and choose xml.</div>
<div class="endscriptcode"></div>
<div class="endscriptcode"><img id="131747" src="https://i1.gallery.technet.s-msft.com/wpf-dynamic-xaml-xamlreader-ac52b67d/image/file/131747/1/xml.png" alt="" width="1164" height="388"></div>
<div class="endscriptcode"></div>
<div class="endscriptcode">You should then see:</div>
<div class="endscriptcode">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">XAML</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xaml</span>

<div class="preview">
<pre class="xaml"><span class="xaml__tag_start">&lt;DataGrid</span><span class="xaml__tag_start">&gt;&nbsp;
</span><span class="xaml__tag_start">&lt;DataGrid</span>.Columns<span class="xaml__tag_start">&gt;&nbsp;
</span><span class="xaml__tag_start">&lt;DataGridTextColumn</span><span class="xaml__tag_start">/&gt;</span>&nbsp;&nbsp;
&nbsp;&nbsp;&lt;/DataGrid.Columns&gt;&nbsp;
&nbsp;&nbsp;<span class="xaml__tag_end">&lt;/DataGrid&gt;</span></pre>
</div>
</div>
</div>
<div class="endscriptcode">The DataGrid is the root, its element is Datagrid.Columns and it's Element is DataGridTextColumn.</div>
<div class="endscriptcode"><a href="http://msdn.microsoft.com/en-GB/library/bb387061.aspx">Linq to xml</a>&nbsp;has a number of methods. &nbsp;<a href="http://msdn.microsoft.com/en-us/library/system.xml.linq.xdocument.descendants(v=vs.110).aspx">Descendants</a>&nbsp;allows
 you to find a list of elements with a given name ( or all ) which are below an element ( or document ).</div>
<div class="endscriptcode">As used, tc will be that DataGridTextColumn.</div>
<div class="endscriptcode">Hover over that and repeat the xml visualisation, you should see:</div>
<div class="endscriptcode">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">XAML</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xaml</span>

<div class="preview">
<pre class="xaml"><span class="xaml__tag_start">&lt;DataGridTextColumn</span><span class="xaml__tag_start">/&gt;</span></pre>
</div>
</div>
</div>
<div class="endscriptcode">Below that click event is some commented out code.</div>
<div class="endscriptcode">Swop that with what's in the event and you should have:</div>
<div class="endscriptcode"></div>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">C#</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="csharp"><span class="cs__keyword">private</span><span class="cs__keyword">void</span>&nbsp;Button3_Click(<span class="cs__keyword">object</span>&nbsp;sender,&nbsp;RoutedEventArgs&nbsp;e)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;XDocument&nbsp;xmlDoc&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;XDocument();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;xmltxt&nbsp;=&nbsp;Application.GetContentStream(<span class="cs__keyword">new</span>&nbsp;Uri(@<span class="cs__string">&quot;pack://application:,,,/tv.txt&quot;</span>));&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">string</span>&nbsp;elfull&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;StreamReader(xmltxt.Stream).ReadToEnd();&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;xmlDoc&nbsp;=&nbsp;XDocument.Parse(elfull);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;XElement&nbsp;el&nbsp;=&nbsp;xmlDoc.Root;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;XElement&nbsp;tc&nbsp;=&nbsp;el.Descendants(<span class="cs__string">&quot;TextBlock&quot;</span>).First();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;XAttribute&nbsp;a&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;XAttribute(<span class="cs__string">&quot;Name&quot;</span>,&nbsp;<span class="cs__string">&quot;MyTextBlock&quot;</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;tc.Add(a);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span><span>&nbsp;<span class="cs__keyword">string</span>&nbsp;x&nbsp;=&nbsp;<span class="cs__string">&quot;&quot;</span>;&nbsp;&nbsp;</span><span class="cs__com">//&nbsp;Put&nbsp;break&nbsp;point&nbsp;here</span>&nbsp;</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}</pre>
</div>
</div>
</div>
<div class="endscriptcode">This does something very similar but with a slightly more interestind file.</div>
<div class="endscriptcode">As well as finding the first TextBlock, it adds a Name Attribute to that.</div>
<div class="endscriptcode">Put the break point in again and f5 to run.</div>
<div class="endscriptcode">If you examin el you will see:</div>
<div class="endscriptcode">
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title">XAML</div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xaml</span>

<div class="preview">
<pre class="xaml"><span class="xaml__tag_start">&lt;TreeViewItem</span><span class="xaml__tag_start">&gt;&nbsp;
</span><span class="xaml__tag_start">&lt;TreeViewItem</span>.Header<span class="xaml__tag_start">&gt;&nbsp;
</span><span class="xaml__tag_start">&lt;StackPanel</span><span class="xaml__attr_name">Orientation</span>=<span class="xaml__attr_value">&quot;Horizontal&quot;</span><span class="xaml__attr_name">ToolTip</span>=<span class="xaml__attr_value">&quot;Node&quot;</span><span class="xaml__tag_start">&gt;&nbsp;
</span><span class="xaml__tag_start">&lt;<span><strong>TextBlock</strong></span></span><span class="xaml__attr_name">Text</span>=<span class="xaml__attr_value">&quot;&quot;</span><span class="xaml__attr_name">VerticalAlignment</span>=<span class="xaml__attr_value">&quot;Center&quot;</span><span class="xaml__attr_name">Foreground</span>=<span class="xaml__attr_value">&quot;DarkBlue&quot;</span><span><strong><span class="xaml__attr_name">Name</span>=<span class="xaml__attr_value">&quot;MyTextBlock&quot;</span></strong></span><span class="xaml__tag_start">/&gt;</span><span class="xaml__tag_start">&lt;Label</span><span class="xaml__attr_name">Content</span>=<span class="xaml__attr_value">&quot;&quot;</span><span class="xaml__attr_name">VerticalAlignment</span>=<span class="xaml__attr_value">&quot;Center&quot;</span><span class="xaml__tag_start">/&gt;</span><span class="xaml__tag_end">&lt;/StackPanel&gt;</span>&nbsp;
&nbsp;&nbsp;&lt;/TreeViewItem.Header&gt;&nbsp;
&nbsp;&nbsp;<span class="xaml__tag_end">&lt;/TreeViewItem&gt;</span></pre>
</div>
</div>
</div>
<div class="endscriptcode">That has found the TextBlock and by adding that attrribute set what would be it's name property to &quot;MyTextBlock.</div>
<div class="endscriptcode">This is quite basic manipulation.</div>
<div class="endscriptcode">In a later article a a treeview is built by adding treeview items manupulated in a similar way using XElement.Add();&nbsp;</div>
</div>
</div>
</div>
</div>
<h2>Summary</h2>
<p>We have seen that textual representations of XAML can be parsed as xml and converted to objects, then added to an existing UI element at run time.</p>
<p>Linq to xml makes manipulating xml created from such templates fairly easy.</p>
<p>Bindings in these will still successfully connect up to viewmodels even when they viewmodel is instantiated before the UI element is created.</p>
<p>As with all development there are one or two things along the way which can catch out the unwary but we can put a break point in and check what the xml looks like and diagnose an issue.</p>
<p>&nbsp;</p>
<h2>Building Templates</h2>
<p>When working on xaml in a window you have the designer which helps you in numerous ways. &nbsp; Once that text is in a xml or txt file then you lose all that.&nbsp;</p>
<p>When making a template to use for this sort of manipulation, create a temporary window or some such and write your xaml in there. &nbsp;You can then prove it works easily before copying into a xml file.</p>
<p>Minimise use of namespaces. &nbsp;In your xaml, it is best if you have no namespaces at all. &nbsp;This is particularly true if you are adding an XElement to a parent because you can get odd things happening such as xmlns=&quot;&quot; appearing in the parent as xml
 decides it needs to &quot;reset&quot; a namespace.</p>
<p><br>
Be careful with your markup. Linq to xml expects your markup to conform to xml rules. One particular thing to avoid is spaces in node names. &nbsp;The designer will cope with such XAML fine. &nbsp;It will compile fine. &nbsp;When you try and use Linq to xml
 you will have problems.</p>
