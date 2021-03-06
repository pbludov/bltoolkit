﻿using System;
using System.Linq.Expressions;

namespace BLToolkit.Data.Linq.Builder
{
	public interface ISequenceBuilder
	{
		int                 BuildCounter { get; set; }
		bool                CanBuild     (ExpressionBuilder builder, BuildInfo buildInfo);
		IBuildContext       BuildSequence(ExpressionBuilder builder, BuildInfo buildInfo);
		SequenceConvertInfo Convert      (ExpressionBuilder builder, BuildInfo buildInfo, ParameterExpression param);
	}
}
