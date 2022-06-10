﻿using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace UploadTransaction.Web.Filters
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class ExceptionFilter : ExceptionFilterAttribute
	{
		public override void OnException(ExceptionContext context)
		{
			context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;

			var message = context.Exception switch
			{
				NotSupportedException => "Unknown format",
				_ => context.Exception.Message
			};
			
			string action = context.RouteData.Values["action"].ToString();
		
			var result = new ViewResult { ViewName = action };
			var modelMetadata = new EmptyModelMetadataProvider();
			result.ViewData = new ViewDataDictionary(modelMetadata, context.ModelState);
			result.ViewData.Add("Message", message);
			context.Result = result;
			context.ExceptionHandled = true;
			Console.WriteLine(message);
		}
	}
}