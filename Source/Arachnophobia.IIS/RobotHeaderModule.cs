using System;
using System.Web;

namespace Arachnophobia.IIS
{
				/// <summary>
				/// Arachnophobia Robot Header Module
				/// Header module to add headers to all outgoing requests
				/// Works to reproduce the WebSpider tags mentioned @ http://googleblog.blogspot.com/2007/07/robots-exclusion-protocol-now-with-even.html
				/// </summary>
				public class RobotHeaderModule : HttpApplication, IHttpModule
				{
								public void Dispose() { }

								public void Init(HttpApplication context)
								{
												context.BeginRequest +=
													delegate(object source, EventArgs e)
													{ ((HttpApplication)source).Response.AddHeader("X-Robots-Tag", "noindex, noarchive, nosnippet"); };
								}
				}
}
