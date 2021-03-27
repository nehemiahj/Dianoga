﻿using System;
using System.Linq;
using System.Web;
using Sitecore.Resources.Media;

namespace Dianoga.WebP
{
	public static class Helpers
	{
		public static bool CdnEnabled => Sitecore.Configuration.Settings.GetBoolSetting("Dianoga.CDN.Enabled", false);

		public static bool BrowserSupportsWebP(this HttpContext context)
		{
			return context?.Request?.AcceptTypes != null && context.Request.AcceptTypes.Contains("image/webp");
		}

		public static bool BrowserSupportsWebP(this MediaOptions mediaOptions)
		{
			return mediaOptions?.GetCustomExtension()?.Contains("webp") ?? false;
		}

		public static bool BrowserSupportsAvif(this HttpContext context)
		{
			return context?.Request?.AcceptTypes != null && context.Request.AcceptTypes.Contains("image/avif");
		}

		public static bool BrowserSupportsAvif(this MediaOptions mediaOptions)
		{
			return mediaOptions?.GetCustomExtension()?.Contains("avif") ?? false;
		}

		public static string GetCustomExtension(this MediaOptions mediaOptions)
		{
			return mediaOptions.CustomOptions["extension"];
		}
	}
}
