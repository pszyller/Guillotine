using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsQuery;
using RestSharp;

namespace Guillotine.Http
{
	public class Request
	{
		public string GetHtml(string url)
		{
			string html = "";

			RestClient client = new RestClient(url);
			RestRequest request = new RestRequest();
			IRestResponse response = client.Get(request);

			html = response.Content;

			return html;
		}

		public string Search(string html, string selector)
		{
			CQ cq = CQ.Create(html);
			CQ cqFind = cq.Find(selector);

			return cqFind.Html();
		}
	}
}
