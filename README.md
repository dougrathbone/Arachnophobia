Arachnophobia
=========================

Arachnophobia is a .Net library designed to give you an easy way to add no-index spider 

content to your ASP.Net site or IIS server with no fuss.

What is included
----------------------------

* An ASP.Net HttpHandler that responds to /robots.txt with a disallow * txt file
* An HttpModule that adds 'X-Robots-Tag' to all outgoing requests to tell spiders to not index individual files (see [this Google post](http://googleblog.blogspot.com/2007/07/robots-exclusion-protocol-now-with-even.html))

How to Install
----------------------------

###Website Installation - Download and install by hand*

* Download the release zip from [here](https://github.com/dougrathbone/Arachnophobia/downloads)

* Place the Binary of your choice (debug or release) in your Bin folder

* Add the HttpHandler and HttpModule to your sites web.config - An example is included in the download zip file including the necessary httphandler and httpmodule references.

###Server Installation - Download and install by hand*

COMING SOON

###Site Installation - Nuget

COMING SOON

###Server Installation - WebPI

COMING SOON


Release notes
----------------------------

*Version 0.1*
First release with both HttpHandler and HttpModule. No GAC support yet