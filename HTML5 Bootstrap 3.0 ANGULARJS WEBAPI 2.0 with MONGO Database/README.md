# HTML5 Bootstrap 3.0 ANGULARJS WEBAPI 2.0 with MONGO Database
## Requires
- Visual Studio 2013
## License
- MIT
## Technologies
- Bootstrap
- HTML5
- ASP.NET MVC 4
- MongoDB
- AngularJS
- ASP.NET Web API 2
## Topics
- .net with mongo db
- CURD with AngularJs
- ASP.NET Web API with Mongo Database
- HTML5 Bootstrap 3
- AngularJs Validations
- Angular js and Mongo Database
- ASP.NET Web API 2 and Mongo Database
## Updated
- 10/28/2015
## Description

<h1>Introduction</h1>
<ul>
<li>Hello friends , in this article I am planning to explain how the latest technologies such as HTML5, Bootstrap 3, ANGULARJS , WEBAPI and MONGO DATABASE can be used together as a technology stack by creating a simple sample application.
</li></ul>
<p><strong>Note :-</strong> This article is suitable for the audience who has the basic knowledge in the technologies such as HTML5, Bootstrap 3, ANGULARJS, WEBAPI and MONGO DATABASE.</p>
<h1><span>Building the Sample</span></h1>
<p>To test the functionality of this application we have to keep the&nbsp;Mongo Database Server up and running.</p>
<p><span style="font-size:20px; font-weight:bold">Description</span></p>
<p>Let's develop the sample application of Product Management. In this application we will perform the simple CRUD operations.</p>
<p>Our application will be structured in the below way.</p>
<p style="padding-left:30px"><strong>UI layer </strong></p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; is consist of HTML5 and ANGULARJS</p>
<p style="padding-left:30px"><strong>Service layer</strong></p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;is constructed by using the MVC WEBAPI 2.0</p>
<p style="padding-left:30px"><strong>Database layer</strong></p>
<p style="padding-left:30px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;is constructed by using the Mongo Database.</p>
<p>The features exposed by this application are as below.</p>
<p>1. Add products into the products collection</p>
<p>2. Search the specific product</p>
<p>3. Update the details of specific product</p>
<p>and the last one is</p>
<p>4. Delete the product from the mongo db products collection.</p>
<p><span><strong><span style="text-decoration:underline">Mongo Database Setup</span></strong></span><strong>&nbsp;</strong><em>&nbsp;</em></p>
<p>To start with this solution we have to first setup mongo database on the server / machine.</p>
<p>Please follow the&nbsp;steps as mentioned at the location on msdn artical.<span style="font-size:x-small">&nbsp;</span></p>
<p><span style="background-color:#ffffff"><span style="color:#0000ff">https://code.msdn.microsoft.com/Mongo-Database-setup-on-6963f46f</span><strong>&nbsp;</strong><em>&nbsp;</em></span></p>
<p><strong><span style="font-family:Calibri; font-size:small">Now let&rsquo;s start with the real development of an application.</span></strong></p>
<p><strong><span style="font-family:Calibri; font-size:small">1.&nbsp;</span></strong><strong><span style="text-decoration:underline"><span style="font-family:Calibri; font-size:small">Create Blank Solution</span></span></strong><strong><span style="font-family:Calibri; font-size:small">&nbsp;</span></strong></p>
<ul>
<li>Open the visual studio 2013 </li><li>Click &ldquo;New Project&rdquo; will open the new project window </li><li>Click Other Project Types </li><li>Click Visual Studio Solutions
<ul>
<li>Click &ldquo;Blank Solution&rdquo; </li><li>Enter Name as &ldquo;ProductsManagement&rdquo; </li></ul>
</li></ul>
<p><strong>&nbsp;</strong><em>&nbsp;<img id="143545" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143545/1/screen_3.png" alt="" width="941" height="575"></em><strong>&nbsp;</strong></p>
<p>2. <strong>Add UI project&nbsp;</strong>&nbsp;</p>
<ul>
<li>Right click on the solution created in step 1 </li><li>Click Add and then New Project </li><li>In the Add New Project window click Web and then Click ASP.Net Web Application
</li><li>Name the application I am naming it as &ldquo;Ui&rdquo; </li><li>Click Ok </li><li>In next window select &ldquo;Empty&rdquo; and click &ldquo;Ok&rdquo; </li></ul>
<p><img id="143546" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143546/1/screen_4.png" alt="" width="756" height="568"></p>
<p><span style="font-family:Calibri; font-size:small">Now in the Ui project setup the
<strong>Angular Js</strong> and the <strong>Bootstrap 3</strong> by installing the nuget packages. Follow the below steps.</span><span style="font-family:Calibri; font-size:small">&nbsp;</span></p>
<ul>
<li>Select the Ui project created in step 2 above<strong>&nbsp;</strong><em>&nbsp;</em>&nbsp;and Right click&nbsp;
</li><li>Click &ldquo;Manage NuGet Packages&hellip;&rdquo; </li></ul>
<div></div>
<p>In Manage NuGet Packages window enter &quot;angular&quot; in the search online text box&nbsp;then select the packages listed below (pictured below)&nbsp;&nbsp;</p>
<div></div>
<ul>
<li>AngularJS </li><li>AngularJS Core </li><li>AngularJS Route </li></ul>
<div></div>
<p><img id="143548" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143548/1/screen_5.png" alt="" width="886" height="593"></p>
<div></div>
<p>Now lets setup the Bootstrap in the UI Project created in step 2 above, follow the below steps.</p>
<div></div>
<p>Select the Ui project created in step 2 above<strong>&nbsp;</strong><em>&nbsp;</em>&nbsp;and Right click&nbsp;then Click &ldquo;Manage NuGet Packages&hellip;&rdquo;</p>
<div></div>
<p>In Manage NuGet Packages window enter &quot;bootstrap&quot; in the Search Online Text&nbsp;field&nbsp;and then select the packages listed below (pictured below)<strong>&nbsp;</strong><em>&nbsp;</em>&nbsp;</p>
<div></div>
<ul>
<li>Bootstrap </li></ul>
<div></div>
<p><img id="143549" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143549/1/screen_6.png" alt="" width="886" height="593"></p>
<div></div>
<p>With this step we have successfully installed the default bootstrap framework in our UI project.</p>
<p>Now to get the better style we will&nbsp;replace the CSS from the bootstrap.min.css file by downloading the bootstrap CSS from the
<a href="http://bootswatch.com/">http://bootswatch.com/</a> site. This will help us in developing the better UI in some clicks. follow the below steps.</p>
<ol>
<li>Navigate to the <a href="http://bootswatch.com">http://bootswatch.com</a> </li><li>Choose the template you like and download the CSS. &nbsp;In our example I am using the &quot;Cerulean&quot; theme.
</li><li>After downloading the CSS from the &quot;Cerulean&quot; copy the content of downloaded &quot;bootstrap.min.css&quot;&nbsp;file navigate to the Content folder under the&nbsp;UI project&nbsp;and paste the same in bootstrap.min.css file.
</li></ol>
<p>With this we have bootstrap setup&nbsp;in our project&nbsp;with nice theme.</p>
<p><span style="font-family:Calibri; font-size:small">Now as we have set up the<strong> Angular JS
</strong>and the <strong>Bootstrap </strong>in our Ui&nbsp;project we have to perform the below steps to add the UI template and the Angular JS Controller and Service to manage Product. Follow the below steps.</span></p>
<ol>
<li>Under Ui project add folders &ldquo;app&rdquo; , &ldquo;js&rdquo; and &ldquo;templates&rdquo;.
<ol>
<li>Under the &ldquo;app&rdquo; folder add the file &ldquo;productsMgmtApp.js&rdquo;
</li></ol>
</li><li>Under &ldquo;js&rdquo; folder added above add two folders &ldquo;controllers&rdquo; and &ldquo;services&rdquo;
<ol>
<li>Under controllers folder add the file &ldquo;productController.js&rdquo; </li><li>Under services folder add the file &ldquo;productService.js&rdquo; </li></ol>
</li><li>Under the &ldquo;templates&rdquo; folder add the below html files.
<ol>
<li>index.html </li><li>products.html </li></ol>
</li></ol>
<p><span style="font-family:Calibri; font-size:small">With the above steps the Ui project structure should look like as below.</span><strong>&nbsp;</strong><em>&nbsp;</em></p>
<p><img id="143792" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143792/1/project_struct_ui.png" alt=""></p>
<p>&nbsp;</p>
<p><span>Below screen displays the Application&nbsp;Ui&nbsp;of our Product Management application. The screen is divided into two main sections. The first section will displays the existing products and the second section provides the Ui to add new products
 into database.</span></p>
<p><span><img id="143796" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143796/1/screen_8.png" alt=""><br>
</span></p>
<p><span style="font-family:Calibri; font-size:small">Every product has the &ldquo;Edit&rdquo; button attached with it , the idea is when the user clicks the &ldquo;Edit&rdquo; button Bootstrap model popup will open by displaying the information of selected
 product to edit. User will change the details and clicks the&nbsp;Update button.</span></p>
<p><img id="143800" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143800/1/screen_17.png" alt="" width="606" height="299"></p>
<p><span style="font-family:Calibri; font-size:small">&nbsp;</span><strong>3. Add Web Api 2.0&nbsp;project in Solution</strong></p>
<p>&nbsp;Now we have to add the Web Api 2.0 project in our solution which will work as the service layer&nbsp;between&nbsp;the Ui project and the Mongo Database. follow the below steps.</p>
<ol>
</ol>
<div></div>
<p>1.Right click on the solution file &ldquo;ProductManagement&rdquo;</p>
<div></div>
<ol>
</ol>
<div></div>
<p>2.Select Add and then click New Project.</p>
<div></div>
<ol>
</ol>
<div></div>
<p>3.In add new project window choose Web template and then select <strong>&ldquo;Asp.Net Web Application&rdquo;
</strong>provide the name as <strong>&ldquo;Api&rdquo;</strong></p>
<div><img id="143797" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143797/1/screen_9.png" alt=""></div>
<div></div>
<div>4.Click Ok</div>
<ol>
</ol>
<div></div>
<p>5.In next window select &ldquo;Web Api&rdquo; as template</p>
<p><img id="143798" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143798/1/screen_10.png" alt=""></p>
<ol>
</ol>
<div></div>
<p>6.Click Change Authentication and in the popup select no authentication.</p>
<p><img id="143799" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143799/1/screen_11.png" alt="" width="706" height="313"></p>
<div></div>
<ol>
</ol>
<div></div>
<p>&nbsp;7.Click Ok</p>
<div></div>
<ol>
</ol>
<p><span style="font-family:Calibri; font-size:small"><span style="font-size:medium"><strong>Note :</strong></span></span></p>
<p>1. <span style="font-family:Calibri; font-size:small"><span style="font-size:medium"><strong>&nbsp;</strong></span>I have deleted&nbsp;the folders such as &quot;Views&quot; , &quot;Content&quot; , &quot;Scripts&quot;&nbsp;, &quot;Fonts&quot;&nbsp; etc&nbsp;... from&nbsp;the Api&nbsp;project&nbsp;as
 these are not required.</span></p>
<p><span style="font-family:Calibri; font-size:small">2. I have added the folder as &quot;DbContext&quot; in which we will create the &quot;ProductContext&quot; which provides the interface to get connected to the Mongo Database.<strong>&nbsp;</strong><em>&nbsp;</em><br>
</span></p>
<p>3. Under the Controllers added the new Api 2.0&nbsp;controller &quot;ProductController&quot; with three actions&nbsp;as below</p>
<ul>
<li><span style="font-size:x-small">GetAllProducts&nbsp;</span><span style="font-size:x-small"><span style="font-family:Consolas"><span style="font-family:Consolas">&nbsp;</span></span><span style="font-family:Consolas"><span style="font-family:Consolas">&nbsp;</span></span></span>
</li><li><span style="font-size:x-small">PostAddProduct</span><span style="font-family:Consolas; font-size:x-small"><span style="font-family:Consolas">&nbsp;</span></span>&nbsp;<span style="font-family:Consolas; font-size:x-small"><span style="font-family:Consolas">&nbsp;</span></span>
</li><li><span style="font-size:x-small">PostUpdateProduct </span></li></ul>
<p><span style="font-family:Calibri; font-size:small">Now our Api&nbsp;project&nbsp; structure should look like as below.</span></p>
<p><img id="143803" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143803/1/screen_19.png" alt=""></p>
<p><span style="font-family:Calibri; font-size:small">Now let&rsquo;s setup the Mongo Database Drivers In our Web Api project.</span></p>
<p><span style="font-family:Calibri; font-size:small">Right click the Api project and click &ldquo;Manage Nuget Packages&rdquo; search &ldquo;Mongo&rdquo; and select the MongoDB Driver from the list&nbsp; click &quot;Install&quot; and the Click &quot;I Accept&quot;.</span><span style="font-family:Calibri; font-size:small"><br>
</span></p>
<p><span style="font-family:Calibri; font-size:small"><img id="143802" src="https://i1.code.msdn.s-msft.com/windowsdesktop/html5-with-bootstrap-30-d34d94d7/image/file/143802/1/screen_18.png" alt=""></span></p>
<p>This will install the Mongo Drivers in our Web Api Project.</p>
<p><strong>Defination of&nbsp;&quot;Product&quot; Model in Api Project </strong><strong>&nbsp;</strong><em>&nbsp;</em></p>
<p>&nbsp;</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="csharp"><span class="cs__keyword">using</span>&nbsp;System;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Collections.Generic.aspx" target="_blank" title="Auto generated link to System.Collections.Generic">System.Collections.Generic</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Linq.aspx" target="_blank" title="Auto generated link to System.Linq">System.Linq</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Web.aspx" target="_blank" title="Auto generated link to System.Web">System.Web</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;MongoDB.Bson;&nbsp;
<span class="cs__keyword">using</span>&nbsp;MongoDB.Bson.Serialization.Attributes;&nbsp;
&nbsp;
<span class="cs__keyword">namespace</span>&nbsp;Api.Models&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span><span class="cs__keyword">class</span>&nbsp;Product&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[BsonRepresentation(BsonType.ObjectId)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span><span class="cs__keyword">string</span>&nbsp;Id&nbsp;{&nbsp;<span class="cs__keyword">get</span>;&nbsp;<span class="cs__keyword">set</span>;&nbsp;}&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span><span class="cs__keyword">string</span>&nbsp;Brand&nbsp;{&nbsp;<span class="cs__keyword">get</span>;&nbsp;<span class="cs__keyword">set</span>;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span><span class="cs__keyword">string</span>&nbsp;Type&nbsp;{&nbsp;<span class="cs__keyword">get</span>;&nbsp;<span class="cs__keyword">set</span>;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span><span class="cs__keyword">string</span>&nbsp;Name&nbsp;{&nbsp;<span class="cs__keyword">get</span>;&nbsp;<span class="cs__keyword">set</span>;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
}</pre>
</div>
</div>
</div>
<p>&nbsp;<strong>Defination of&nbsp;</strong><em>&nbsp;</em><strong>&quot;ProductContext&quot; in Api Project
</strong></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="csharp"><span class="cs__keyword">using</span>&nbsp;System;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Collections.Generic.aspx" target="_blank" title="Auto generated link to System.Collections.Generic">System.Collections.Generic</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Configuration.aspx" target="_blank" title="Auto generated link to System.Configuration">System.Configuration</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Linq.aspx" target="_blank" title="Auto generated link to System.Linq">System.Linq</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Web.aspx" target="_blank" title="Auto generated link to System.Web">System.Web</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;Api.Models;&nbsp;
<span class="cs__keyword">using</span>&nbsp;MongoDB.Bson;&nbsp;
<span class="cs__keyword">using</span>&nbsp;MongoDB.Bson.Serialization.Attributes;&nbsp;
<span class="cs__keyword">using</span>&nbsp;MongoDB.Driver;&nbsp;
&nbsp;
<span class="cs__keyword">namespace</span>&nbsp;Api.DbContext&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">class</span>&nbsp;ProductContext&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">const</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;CONNECTION_STRING_NAME&nbsp;=&nbsp;<span class="cs__string">&quot;productmgmt&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">const</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;DATABASE_NAME&nbsp;=&nbsp;<span class="cs__string">&quot;ProductsManagement&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">const</span>&nbsp;<span class="cs__keyword">string</span>&nbsp;PRODUCTS_COLLECTION_NAME&nbsp;=&nbsp;<span class="cs__string">&quot;Products&quot;</span>;&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;This&nbsp;is&nbsp;ok...&nbsp;Normally,&nbsp;they&nbsp;would&nbsp;be&nbsp;put&nbsp;into</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;an&nbsp;IoC&nbsp;container.</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">static</span>&nbsp;<span class="cs__keyword">readonly</span>&nbsp;IMongoClient&nbsp;_client;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">static</span>&nbsp;<span class="cs__keyword">readonly</span>&nbsp;IMongoDatabase&nbsp;_database;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">static</span>&nbsp;ProductContext()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;connectionString&nbsp;=&nbsp;ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_client&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;MongoClient(connectionString);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;_database&nbsp;=&nbsp;_client.GetDatabase(DATABASE_NAME);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;IMongoClient&nbsp;Client&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">get</span>&nbsp;{&nbsp;<span class="cs__keyword">return</span>&nbsp;_client;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;IMongoCollection&lt;Product&gt;&nbsp;Products&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">get</span>&nbsp;{&nbsp;<span class="cs__keyword">return</span>&nbsp;_database.GetCollection&lt;Product&gt;(PRODUCTS_COLLECTION_NAME);&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
}</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<div class="endscriptcode"></div>
<div class="endscriptcode"><strong>The &quot;ProductController&quot; in Api Project Exposes the below route</strong></div>
<p><span style="font-family:Consolas; font-size:x-small"><span style="font-family:Consolas; font-size:x-small">[</span></span><span style="color:#2b91af; font-family:Consolas; font-size:x-small"><span style="color:#2b91af; font-family:Consolas; font-size:x-small"><span style="color:#2b91af; font-family:Consolas; font-size:x-small">Route</span></span></span><span style="font-family:Consolas; font-size:x-small"><span style="font-family:Consolas; font-size:x-small">(</span></span><span style="color:#a31515; font-family:Consolas; font-size:x-small"><span style="color:#a31515; font-family:Consolas; font-size:x-small"><span style="color:#a31515; font-family:Consolas; font-size:x-small">&quot;v1/products/getAllProducts&quot;</span></span></span><span style="font-family:Consolas; font-size:x-small"><span style="font-family:Consolas; font-size:x-small">)]&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 :- Used to get all the products from the Mongo Repository</span></span></p>
<p><span style="font-family:Consolas; font-size:x-small"><span style="font-family:Consolas; font-size:x-small">[</span></span><span style="color:#2b91af; font-family:Consolas; font-size:x-small"><span style="color:#2b91af; font-family:Consolas; font-size:x-small"><span style="color:#2b91af; font-family:Consolas; font-size:x-small">Route</span></span></span><span style="font-family:Consolas; font-size:x-small"><span style="font-family:Consolas; font-size:x-small">(</span></span><span style="color:#a31515; font-family:Consolas; font-size:x-small"><span style="color:#a31515; font-family:Consolas; font-size:x-small"><span style="color:#a31515; font-family:Consolas; font-size:x-small">&quot;v1/products/addProduct&quot;</span></span></span><span style="font-family:Consolas; font-size:x-small"><span style="font-family:Consolas; font-size:x-small">)]&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="font-family:Consolas; font-size:xx-small">:-
 Used to&nbsp;Add&nbsp;the product in&nbsp;Mongo Repository</span></span></span></p>
<p><span style="font-family:Consolas; font-size:x-small"><span style="font-family:Consolas; font-size:x-small">[</span></span><span style="color:#2b91af; font-family:Consolas; font-size:x-small"><span style="color:#2b91af; font-family:Consolas; font-size:x-small"><span style="color:#2b91af; font-family:Consolas; font-size:x-small">Route</span></span></span><span style="font-family:Consolas; font-size:x-small"><span style="font-family:Consolas; font-size:x-small">(</span></span><span style="color:#a31515; font-family:Consolas; font-size:x-small"><span style="color:#a31515; font-family:Consolas; font-size:x-small"><span style="color:#a31515; font-family:Consolas; font-size:x-small">&quot;v1/products/updateProduct&quot;</span></span></span><span style="font-family:Consolas; font-size:x-small"><span style="font-family:Consolas; font-size:x-small">)]&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<span>:- Used to&nbsp;Update&nbsp;the product in&nbsp;Mongo Repository</span></span></span></p>
<p><span style="font-family:Consolas; font-size:small"><span style="font-family:Consolas">The code below demonstarate how the
<strong>&quot;ProductController&quot; is defined.</strong></span></span></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="csharp"><span class="cs__keyword">using</span>&nbsp;System;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Collections.Generic.aspx" target="_blank" title="Auto generated link to System.Collections.Generic">System.Collections.Generic</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Linq.aspx" target="_blank" title="Auto generated link to System.Linq">System.Linq</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Net.aspx" target="_blank" title="Auto generated link to System.Net">System.Net</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Net.Http.aspx" target="_blank" title="Auto generated link to System.Net.Http">System.Net.Http</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Threading.Tasks.aspx" target="_blank" title="Auto generated link to System.Threading.Tasks">System.Threading.Tasks</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;<a class="libraryLink" href="https://msdn.microsoft.com/en-US/library/System.Web.Http.aspx" target="_blank" title="Auto generated link to System.Web.Http">System.Web.Http</a>;&nbsp;
<span class="cs__keyword">using</span>&nbsp;Api.DbContext;&nbsp;
<span class="cs__keyword">using</span>&nbsp;MongoDB.Bson;&nbsp;
<span class="cs__keyword">using</span>&nbsp;MongoDB.Driver;&nbsp;
<span class="cs__keyword">using</span>&nbsp;Api.Models;&nbsp;
&nbsp;
<span class="cs__keyword">namespace</span>&nbsp;Api.Controllers&nbsp;
{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;<span class="cs__keyword">class</span>&nbsp;ProductController&nbsp;:&nbsp;ApiController&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;GET&nbsp;api/&lt;controller&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Route(<span class="cs__string">&quot;v1/products/getAllProducts&quot;</span>)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;async&nbsp;Task&lt;IEnumerable&lt;Product&gt;&gt;&nbsp;GetAllProducts()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;productContext&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;ProductContext();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;recentPosts&nbsp;=&nbsp;await&nbsp;productContext&nbsp;.Products.Find(x&nbsp;=&gt;&nbsp;<span class="cs__keyword">true</span>).ToListAsync();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;recentPosts;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;POST&nbsp;api/&lt;controller&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Route(<span class="cs__string">&quot;v1/products/addProduct&quot;</span>)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;async&nbsp;Task&lt;HttpResponseMessage&gt;&nbsp;PostAddProduct(Product&nbsp;product)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;productContext&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;ProductContext();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;post&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;Product&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Brand&nbsp;=&nbsp;product.Brand,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Type&nbsp;=&nbsp;product.Type,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Name&nbsp;=&nbsp;product.Name,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;};&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;await&nbsp;productContext.Products.InsertOneAsync(post);&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;Request.CreateResponse(<span class="cs__string">&quot;Product&nbsp;Successfully&nbsp;Added&quot;</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__com">//&nbsp;POST&nbsp;api/&lt;controller&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Route(<span class="cs__string">&quot;v1/products/updateProduct&quot;</span>)]&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">public</span>&nbsp;async&nbsp;Task&lt;HttpResponseMessage&gt;&nbsp;PostUpdateProduct(Product&nbsp;product)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;var&nbsp;productContext&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;ProductContext();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;await&nbsp;productContext.Products.ReplaceOneAsync(<span class="cs__keyword">new</span>&nbsp;BsonDocument(<span class="cs__string">&quot;_id&quot;</span>,&nbsp;<span class="cs__keyword">new</span>&nbsp;ObjectId(product.Id)),&nbsp;product);&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="cs__keyword">return</span>&nbsp;Request.CreateResponse(<span class="cs__string">&quot;Product&nbsp;Successfully&nbsp;Updated&quot;</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;
}</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;I have attached the solution file with this artical with all the code files used in the Ui and Web Api project.</div>
<div class="endscriptcode"></div>
<p>Happy Learning..</p>
<div></div>
<ul>
</ul>
<div></div>
