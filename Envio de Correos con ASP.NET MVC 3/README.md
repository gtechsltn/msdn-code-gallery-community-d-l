# Envio de Correos con ASP.NET MVC 3
## Requires
- Visual Studio 2012
## License
- Apache License, Version 2.0
## Technologies
- C#
- ASP.NET MVC 3
- Razor
## Topics
- Envio de Correos
## Updated
- 06/29/2012
## Description

<p>Esta Solucion contiene referencias acerca de como podemos enviar correos electronicos con una clase C# y posteriormente implementarla con una simple vista en el modelo MVC 3 de asp.net</p>
<p>Realizado con C# sin Jquery usando el patron MVC y algunas lineas de codigo Razor&nbsp;</p>
<p>Para lograr la integracion correcta de este ejemplo, se agrego un modelo sencillo simplemente para anotrar las referencias a las variables usadas dentro de la solucion</p>
<p><strong>C#</strong>&nbsp;(pronunciado&nbsp;<em>si sharp</em>&nbsp;en ingl&eacute;s) es un&nbsp;<a title="Lenguaje de programación" href="http://es.wikipedia.org/wiki/Lenguaje_de_programaci%C3%B3n">lenguaje de programaci&oacute;n</a>&nbsp;<a title="Programación orientada a objetos" href="http://es.wikipedia.org/wiki/Programaci%C3%B3n_orientada_a_objetos">orientado
 a objetos</a>&nbsp;desarrollado y estandarizado por&nbsp;<a title="Microsoft" href="http://es.wikipedia.org/wiki/Microsoft">Microsoft</a>&nbsp;como parte de su plataforma&nbsp;<a title="Microsoft .NET" href="http://es.wikipedia.org/wiki/Microsoft_.NET">.NET</a>,
 que despu&eacute;s fue aprobado como un est&aacute;ndar por la&nbsp;<a title="Ecma International" href="http://es.wikipedia.org/wiki/Ecma_International">ECMA</a>&nbsp;(ECMA-334) e&nbsp;<a class="mw-redirect" title="Organización Internacional para la Estandarización" href="http://es.wikipedia.org/wiki/Organizaci%C3%B3n_Internacional_para_la_Estandarizaci%C3%B3n">ISO</a>&nbsp;(ISO/IEC
 23270). C# es uno de los lenguajes de programaci&oacute;n dise&ntilde;ados para la&nbsp;<a title="Infraestructura de lenguaje común" href="http://es.wikipedia.org/wiki/Infraestructura_de_lenguaje_com%C3%BAn">infraestructura de lenguaje com&uacute;n</a>.</p>
<p>Su sintaxis b&aacute;sica deriva de&nbsp;<a title="C (lenguaje de programación)" href="http://es.wikipedia.org/wiki/C_(lenguaje_de_programaci%C3%B3n)">C</a>/<a title="C&#43;&#43;" href="http://es.wikipedia.org/wiki/C%2B%2B">C&#43;&#43;</a>&nbsp;y utiliza el modelo de objetos
 de la plataforma .NET, similar al de&nbsp;<a title="Java (lenguaje de programación)" href="http://es.wikipedia.org/wiki/Java_(lenguaje_de_programaci%C3%B3n)">Java</a>, aunque incluye mejoras derivadas de otros lenguajes.</p>
<p>El nombre C Sharp fue inspirado por la&nbsp;<a title="Notación musical" href="http://es.wikipedia.org/wiki/Notaci%C3%B3n_musical">notaci&oacute;n musical</a>, donde '#' (<a title="Sostenido" href="http://es.wikipedia.org/wiki/Sostenido">sostenido</a>, en
 ingl&eacute;s&nbsp;<em>sharp</em>) indica que la nota (<em>C</em>&nbsp;es la nota do en ingl&eacute;s) es un&nbsp;<a title="Semitono" href="http://es.wikipedia.org/wiki/Semitono">semitono</a>m&aacute;s alta, sugiriendo que C# es superior a C/C&#43;&#43;. Adem&aacute;s,
 el signo '#' viene de cuatro '&#43;' pegados.<sup id="cite_ref-0" class="reference"><a href="http://es.wikipedia.org/wiki/C_Sharp#cite_note-0">1</a></sup></p>
<p>Aunque C# forma parte de la plataforma .NET, &eacute;sta es una&nbsp;<a title="Interfaz de programación de aplicaciones" href="http://es.wikipedia.org/wiki/Interfaz_de_programaci%C3%B3n_de_aplicaciones">API</a>, mientras que C# es un lenguaje de programaci&oacute;n
 independiente dise&ntilde;ado para generar programas sobre dicha plataforma. Ya existe un&nbsp;<a title="Compilador" href="http://es.wikipedia.org/wiki/Compilador">compilador</a>&nbsp;implementado que provee el marco&nbsp;<a title="Proyecto Mono" href="http://es.wikipedia.org/wiki/Proyecto_Mono">Mono</a>&nbsp;-&nbsp;<a title="DotGNU" href="http://es.wikipedia.org/wiki/DotGNU">DotGNU</a>,
 el cual genera programas para distintas plataformas como&nbsp;<a title="Microsoft Windows" href="http://es.wikipedia.org/wiki/Microsoft_Windows">Windows</a>,&nbsp;<a title="Unix" href="http://es.wikipedia.org/wiki/Unix">Unix</a>,&nbsp;<a title="Android" href="http://es.wikipedia.org/wiki/Android">Android</a>,&nbsp;<a title="IOS" href="http://es.wikipedia.org/wiki/IOS">iOS</a>,&nbsp;<a title="Windows Phone" href="http://es.wikipedia.org/wiki/Windows_Phone">Windows
 Phone</a>,&nbsp;<a title="Mac OS" href="http://es.wikipedia.org/wiki/Mac_OS">Mac OS</a>&nbsp;y&nbsp;<a title="GNU/Linux" href="http://es.wikipedia.org/wiki/GNU/Linux">GNU/Linux</a>.</p>
<p><span><br>
</span></p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Editar script</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="csharp"><span class="cs__keyword">private</span>&nbsp;<span class="cs__keyword">void</span>&nbsp;SendEmail(<span class="cs__keyword">string</span>&nbsp;EmailAddress,&nbsp;<span class="cs__keyword">string</span>&nbsp;txtSubject,&nbsp;<span class="cs__keyword">string</span>&nbsp;txtMessage)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;
&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;mail.To.Add(EmailAddress);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;mail.From&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;MailAddress(<span class="cs__string">&quot;zbarrerar@gmail.com&quot;</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;mail.Subject&nbsp;=&nbsp;txtSubject;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;mail.Body&nbsp;=&nbsp;txtMessage;&nbsp;
&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;mail.IsBodyHtml&nbsp;=&nbsp;<span class="cs__keyword">true</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SmtpClient&nbsp;smtp&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;SmtpClient();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;smtp.Host&nbsp;=&nbsp;<span class="cs__string">&quot;smtp.gmail.com&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;smtp.Credentials&nbsp;=&nbsp;<span class="cs__keyword">new</span>&nbsp;<a class="libraryLink" href="http://msdn.microsoft.com/es-ES/library/System.Net.NetworkCredential.aspx" target="_blank" title="Auto generated link to System.Net.NetworkCredential">System.Net.NetworkCredential</a>(<span class="cs__string">&quot;zbarrerar@gmail.com&quot;</span>,&nbsp;<span class="cs__string">&quot;yagami123&quot;</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;smtp.EnableSsl&nbsp;=&nbsp;<span class="cs__keyword">true</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;smtp.Send(mail);&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
