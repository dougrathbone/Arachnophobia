using System.Web;

namespace Arachnophobia.IIS
{
	/// <summary>
	/// Arachnophobia Robot Header Module
	/// Adds a 
	/// </summary>
	public class RobotsTxtHandler : IHttpHandler
	{
		public bool IsReusable
		{
			get { return true; }
		}
		public void ProcessRequest(HttpContext context)
		{
			context.Response.Write("User-agent: *\nDisallow: /");
			context.Response.End();
		}
	}
}
