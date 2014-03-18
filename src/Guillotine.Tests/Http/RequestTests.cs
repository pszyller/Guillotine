using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guillotine.Http;
using NUnit.Framework;

namespace Guillotine.Tests.Http
{
	[TestFixture]
	public class RequestTests
	{
		[Test]
		public void should_get_html()
		{
			// given
			Request request = new Request();

			// when
			string html = request.GetHtml("http://www.totaljobs.com");

			// then
			Assert.That(html, Contains.Substring("Find jobs in your industry"));
		}

		[Test]
		public void should_find_in_html()
		{
			// given
			Request request = new Request();

			// when
			string html = request.GetHtml("http://www.totaljobs.com");
			string innerHtml = request.Search(html, "#tabs");

			// then
			Console.WriteLine(innerHtml);
			Assert.That(innerHtml, Contains.Substring("<ul"));
		}
	}
}
