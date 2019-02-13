﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq.Expressions;

namespace Microsoft.EntityFrameworkCore.Relational.Query.PipeLine
{
    public class SqlFragmentExpression : SqlExpression
    {
        public SqlFragmentExpression(string sql)
            : base(Constant(sql))
        {
        }

        public string Sql => (string)((ConstantExpression)Expression).Value;
    }
}