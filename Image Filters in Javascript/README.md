# Image Filters in Javascript
## License
- Apache License, Version 2.0
## Technologies
- HTML5 Canvas
- HTML5/JavaScript
## Topics
- Image manipulation
- Image Filters
## Updated
- 07/10/2014
## Description

<h1>Introduction</h1>
<p>This is a simple web application developed using HTML5/Javascript to demonstrate HTML5 canvas capabilities and image filter implementations. The code will demonstrate various pixel-level manipulations involved.</p>
<h1>Building the Sample</h1>
<p>Just open the image.html file in test folder in any HTML5 compliant browser to view.</p>
<p><span style="font-size:20px; font-weight:bold">Description</span></p>
<p>This implementation demonstrate the various algorithms and pixel-level manipulations involved in creating Image Filters. The algorithms can easily be extended to your favourite programming language.</p>
<p>I chose javascript because of the ease of developement and also the fact that the code can be run on any modern browser - making it essentially cross-platform.&nbsp;</p>
<p><strong><span style="font-size:small">Image Filters:</span></strong></p>
<p><strong><span style="font-size:small">&nbsp;</span></strong>Before starting with filters, a brief introduction to how images are represented in of order. Images primarily consist of a 2D collection of pixel, where each pixel denotes the color and opacity
 at that point. Color itself however can be defined by a number of ways (often referred as color models). The definition we will use is the RGBA description of pixels where R : Red, B : Blue, G : Green and A : Alpha - which denotes the opacity. Each color visible
 to our eyes can be constructed using some combination of Red, Green and Blue. An example would be :</p>
<p><img id="119834" src="119834-rgb_illumination.jpg" alt="" width="400" height="300"></p>
<p>Thus we see that : R &#43; G = <span style="background-color:#ffff00">Yellow</span>, G &#43; B =
<span style="background-color:#00ccff">Cyan</span>, R &#43; B = <span style="background-color:#ff00ff">
Magenta</span> and All 3 combine to form White.</p>
<p>Further, each R, G, B and A values are stored in 8 bits each, thus their values ranging from 0-255 each. Thus each pixel occupies 24-bit. Hence changing colors is basically manipulating these values for each pixel. However in case we want distorted effects
 such as ripples, changing these value has no meaning, but instead we go for changing the position of the pixel.</p>
<p><span style="font-size:small"><strong>Some Terminology :</strong></span></p>
<p>The term <strong>intensity </strong>refers strictly to the amount of light that is emitted per unit of time and per unit of surface, in units of lux. Note, however, that in many fields of science this quantity is called luminous emittance, as opposed to
 luminous intensity, which is a different quantity. <br>
<strong>Luminance</strong> is the photometric brightness of an object, taking into account the wavelength-dependent sensitivity of the human eye (in units of cd/m&sup2;).<br>
<strong>Brightness</strong> is an attribute of visual perception in which a source appears to be radiating or reflecting light.[1] In other words, brightness is the perception elicited by the luminance of a visual target. This is a subjective attribute/property
 of an object being observed.&nbsp;</p>
<p>With this in mind, we start with our journey with Image Filters :</p>
<ul>
<li><strong>Grayscale</strong> : The name suggests that we do away with all colors and compose our image with black and white and shades of gray. A very simple way of doing this is averaging the values of R, G, B for each pixel and assigning it to each channel
 (R, G, and B). Thus we are reduced to :<br>
<span style="white-space:pre">&nbsp;</span><strong>R = G = B = (R &#43; G &#43; B)/3</strong><br>
Very simple indeed.&nbsp; </li><li><strong>Duotone :</strong> In this, we try to switch any 1 channel off i.e. either R or G or B, remaining with 2 others. Thus to switch off say R, we assign it the average of all 3, i.e.<br>
<span style="white-space:pre">&nbsp;</span><strong>R = (R &#43; G &#43; B)/3, G = G, B = B<br>
&nbsp;</strong> </li><li><strong>Invert :</strong> An inverted image looks like a Xray scan, only it is not. What is it then ? Well we invert the values of each channel for every pixel in the image i.e.<br>
<strong>R = 255 - R, G = 255 - G, B = 255 - B</strong><br>
<br>
</li><li><strong>Noise :</strong> Well, how about introducing some noise in your image ? Make it bit grainy. The noise depends on two parameters : the radius (how big the grains are) and the amount (amount of grains). So in order to generate random noise, we use
 Math.random() facility of javascript to create noise of random levels, again a pixel level manipulation :<br>
<strong><span style="white-space:pre">mod = Math.floor((Math.random() * radius) -
</span>max_amount) </strong>(This basically generates values between range [-radius, radius])<strong><span style="white-space:pre">
</span>R = R &#43; mod, G = G &#43; mod, B = B &#43; mod</strong><br>
<br>
</li><li><span style="white-space:pre"><span style="white-space:normal"><strong>Pixelate :</strong> Pixelation basically makes your image look coarse and as if it is stretched beyond its 100 % resolution. So how do you create such an effect ? Basically creating
 a square tiling effect of a given side length. We achieve this by taken a given fixed size of square say 3, thus our square will contain 3 * 3 = 9 pixels. We average the R, G, B values of the pixels and assign it to each pixel in that square, effectively now
 each pixel in our 3*3 square displays the same color. Thus the image overall becomes coarse.<br>
<strong>&lt;R, G, B&gt; = Average of (R, G, B) for given square.</strong><br>
<strong>For all pixel in that square, assign Pixel = &lt;R, G, B&gt;</strong><br>
&nbsp;</span></span> </li><li><span style="white-space:pre"><strong>Gamma :</strong> It is the name of a nonlinear operation used to code and decode luminance values in video or still image systems. In simple terms :
</span><strong>Vout = A * pow(Vin, gamma), often A = 1.</strong><br>
if gamma &lt; 1, it referred to as encoding gamma, otherwise decoding gamma.&nbsp;Gamma encoding of images is required to compensate for properties of human vision, hence to maximize the use of the bits or bandwidth relative to how humans perceive light and
 color. Thus varying the gamma, varies the luminance of the image.<br>
<br>
</li><li><strong>Sepia Tone :</strong> We are all familiar with sepia tone (Bing it otherwise). It creates an old-looking photograph with a yellowish-brown tinge. This can be done using something called &nbsp;a color matrix. What it does ? Well matrix multiplication.
 It is a 3*3 matrix which when multiplies by the column matrix of R, G, B produces the required colors. The matrix is :<br>
[ 0.393<span style="white-space:pre"> </span>0.769<span style="white-space:pre"> </span>
0.189&nbsp;<br>
&nbsp; 0.349 &nbsp; &nbsp; &nbsp;0.686 &nbsp; &nbsp; &nbsp; &nbsp;0.168<br>
&nbsp; 0.272 &nbsp; &nbsp; &nbsp;0.534 &nbsp; &nbsp; &nbsp; &nbsp;0.121 ]<br>
We can go and play with other values to get more color variations, however the values must be between 0-1 (i.e. normalized).<br>
<br>
</li><li><span style="color:#000000"><strong>Contrast :</strong></span> Contrast is the difference in luminance and/or color that makes an object (or its representation in an image or display) distinguishable. In visual perception of the real world, contrast is
 determined by the difference in the color and brightness of the object and other objects within the same field of view.&nbsp;<br>
<strong>R<span style="white-space:pre"> = ((((</span>R<span style="white-space:pre"> / 255) - 0.5) * amount) &#43; 0.5) * 255
</span>G<span style="white-space:pre"> = ((((</span>G<span style="white-space:pre"> / 255) - 0.5) * amount) &#43; 0.5) * 255
</span>B<span style="white-space:pre"> = ((((</span>B<span style="white-space:pre"> / 255) - 0.5) * amount) &#43; 0.5) * 255
</span></strong>&nbsp;<br>
<br>
</li><li><strong>Threshold : </strong>Very simple idea - we calculate a threshold value based on certain linear combination of R,G, B components of the pixels, and replace it with a certain value if it exceeds our given theshold. Go figure in the code.
<br>
<br>
</li><li><strong>Posterize :</strong> This effect turns your image into a cartoonish version with lesser intensity levels i.e. the finer shades would be missing. To do this, we divide the 0-255 values into certain levels (say 8), now each R, G, B value within this
 range is clamped to the minimum of that range i.e. if the R value is 74, it falls between 72 and 80, and thus is assigned 72, etc. for all other pixels and for R, G and B.<br>
<br>
</li><li><strong>Scatter :</strong> This effect basically scatters the pixel in its neighbourhood and creates an effect as if viewed through a brittle cracked glass. The idea is simple - We take a square of given dimension, we randomly pick 2 positions and swap
 the pixel R, G, B values and continue doing it till we have a sufficient number of swaps, and then continue through the whole image producing our effect.&nbsp;<br>
<br>
</li><li><strong>Solarize :</strong> Where we again calculate the threshold and if pixel intensity exceeds it, we cimply invert the pixel (subtract from 255 the channel values). Makes for some unique effects.<br>
<br>
</li><li><strong>ASCIIfy :</strong> Turn the image consisting of pixels to an image made up of ASCII symbols. We simply first posterize the image, then for each intensity level, we assign a unique character and our image is ASCIIfied.&nbsp;
</li></ul>
<p><span style="font-size:small"><strong>Kernel Convolution :</strong></span></p>
<p>This ends our basic set of filters, fairly easy to digest. We further now move along to more set of filters which use a generic technique known as Kernel Convolution. The essence - We take a fixed sized matrix, called as kernel and then traverse the image
 pixels (horizontally or vertically) and perform a convolution operation with the matrix and pixels. The basic algorithm can be given as :</p>
<pre><strong>for each</strong> <em>image row</em> <strong>in</strong> <em>output image</em>:
   <strong>for each</strong> <em>pixel</em> <strong>in</strong> <em>image row</em>:

      <strong>set</strong> <em>accumulator</em> to zero

      <strong>for each</strong> <em>kernel row</em> <strong>in</strong> <em>kernel</em>:
         <strong>for each</strong> <em>element</em> <strong>in</strong> <em>kernel row</em>:

            <strong>if</strong> <em>element position</em>  corresponding to <em>pixel position</em> <strong>then</strong>
               <strong>multiply</strong> <em>element value</em>  corresponding to <em>pixel value</em>
               <strong>add</strong> <em>result</em> to <em>accumulator</em>
            <strong>endif</strong>

      <strong>set</strong> <em>output image pixel</em> to <em>accumulator</em>
</pre>
<div>With various values of the kernel, we get various effects. Note the the values whould be normalized. The effects we can generate :</div>
<div>
<ol>
<li>Edge Detection </li><li>Lightness/Darkness manipulation </li><li>Blur/Sharpening </li><li>Median Noise Reduction </li><li>Sobel Filter </li><li>Emboss </li></ol>
Browse the code to see a simple implementation of the convolution operation and the various values of kernel leading to various effects.</div>
<h1><span>Source Code Files</span></h1>
<ul>
<li>filters.js - Contains the implementation details of various filters. </li><li>effects.js - Contains event handling codes. </li></ul>
<p>The manipulate pixels, we load the image in the HTML5 canvas and then access it with javascript. The image pixels are accessed as an array with every 4 elements denoting RGBA combination. Thus an offset of 4 is required to move from one pixel to another.
 The array is 1d is nature so appropriate steps are needed to traverse it as a 2d collection of pixels using the image dimensions.</p>
<p>The Filter library uses Reavealing module pattern to create the programming interface to call the required methods. The pattern can be described as :</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"></div>
</div>
<em>
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>JavaScript</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Edit</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">js</span>

<div class="preview">
<pre class="js"><span class="js__statement">var</span>&nbsp;Module&nbsp;=&nbsp;(<span class="js__operator">function</span>(params,&nbsp;...)&nbsp;<span class="js__brace">{</span><span class="js__sl_comment">//&nbsp;Members&nbsp;declaration&nbsp;i.e.</span><span class="js__operator">function</span>&nbsp;internal_method(params)&nbsp;<span class="js__brace">{</span><span class="js__ml_comment">/*&nbsp;code&nbsp;*/</span><span class="js__brace">}</span><span class="js__statement">var</span>&nbsp;attribute;&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__sl_comment">//Revealing&nbsp;the&nbsp;required&nbsp;methods/attributes&nbsp;in&nbsp;the&nbsp;return&nbsp;object</span><span class="js__statement">return</span><span class="js__brace">{</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;revealing_method_name&nbsp;:&nbsp;internal_method;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__sl_comment">//&nbsp;continue&nbsp;similarly&nbsp;for&nbsp;other&nbsp;methods</span><span class="js__brace">}</span><span class="js__brace">}</span>(values_to_init));&nbsp;
&nbsp;</pre>
</div>
</div>
</em></div>
<ul>
</ul>
<h1>More Information</h1>
<p><span style="font-size:small">For more information, have a look at :</span></p>
<p><span style="font-size:small"><a href="http://en.wikipedia.org/wiki/Color_model">Color Models</a></span></p>
<p><span style="font-size:small"><a href="http://en.wikipedia.org/wiki/Digital_image">Image</a></span></p>
<p><span style="font-size:small"><a href="http://en.wikipedia.org/wiki/Kernel_(image_processing)">Kernel Convolution</a></span></p>
<p><span style="font-size:small"><a href="http://tutorials.jenkov.com/html5-canvas/pixels.html">HTML5 Canvas Image Manipulation</a></span></p>
