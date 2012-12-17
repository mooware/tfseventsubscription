Event Subscription Tool for TFS 2010
====================================

This tool provides a GUI to add and remove event subscriptions for your account on a TFS 2010 server.

.NET 3.5 is necessary to run the tool. Also, you probably need some TFS DLLs, but if you can use TFS in Visual Studio 2010 then they should already be there.

Download from http://dl.dropbox.com/u/267889/github/EventSubscriptionTool.exe.

Usage
-----

A TFS event is described by an XML document against which a filter expression is run. The filter is a mix between an SQL-like query language, and XPath to access tags and attributes of the XML document. The format of the XML document is different for each event type.

I couldn't find much documentation on the filter expressions for subscriptions. Here are some links that might help.

  * [This page](http://blogs.msdn.com/b/csell/archive/2006/11/01/tfs-event-filtering.aspx) explains a bit about the filters in general.
  * [Filtering Team Foundation Server Events](http://msdn.microsoft.com/en-us/library/bb130302.aspx) on MSDN describes the query language used.
  * [XPath Reference](http://msdn.microsoft.com/en-us/library/ms256115%28v=vs.90%29.aspx) on MSDN.

Alternatives
------------

  * **BisSubscribe** is a command line tool to add and remove subscriptions, but it is only available on the TFS server, not on clients.
  * [TFS Power Tools](http://visualstudiogallery.msdn.microsoft.com/c255a1e4-04ba-4f68-8f4e-cd473d6b971f) includes the **Alerts Explorer** VS2010 extension. It provides an editor to build filter expressions, but this editor is rather restricted and does not allow to directly specify the filter expression.

History
-------

The original version of this tool seems to come from Naren Datha or his colleague Sam (see http://blogs.msdn.com/b/narend/archive/2006/07/26/679440.aspx).

Later, it was rewritten and published on Codeplex (http://tfseventsubscription.codeplex.com/). The Codeplex project has not been changed since 2008, so I would consider it dead.

I would like to express my thanks to the previous developers of the tool. They did all the work; I only made a few changes to make it work on TFS 2010.

License
-------

The project on Codeplex from which I forked was using the **Microsoft Community License**, and so is this project. See the **LICENSE** file for its full text.
