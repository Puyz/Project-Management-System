using System;
using Core.Utilities.Results.Abstracts;

namespace Core.Utilities.Business
{
	public class BusinessRules
	{
		public static IResult? Run(params IResult[] logics)
		{
			foreach (var logic in logics)
			{
				if (!logic.Success)
				{
					return logic;
				}
			}
			return null;
		}
	}
}

