﻿using System;
using System.Data.Linq.SqlClient;

namespace BLToolkit.Data.Linq
{
	public static class SqlExtension
	{
		public static bool Like(this string matchExpression, string pattern)
		{
			return SqlMethods.Like(matchExpression, pattern);
		}

		public static bool Like(this string matchExpression, string pattern, char escapeCharacter)
		{
			return SqlMethods.Like(matchExpression, pattern, escapeCharacter);
		}

		public static int? CharIndex(this string str, string value)
		{
			if (str == null || value == null)
				return null;

			return str.IndexOf(value) + 1;
		}

		public static int? CharIndex(this string str, string value, int startLocation)
		{
			if (str == null || value == null)
				return null;

			return str.IndexOf(value, startLocation - 1) + 1;
		}

		public static string Reverse(this string str)
		{
			if (string.IsNullOrEmpty(str))
				return str;

			var chars = str.ToCharArray();
			Array.Reverse(chars);
			return new string(chars);
		}
	}
}
