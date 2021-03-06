﻿using Microsoft.EntityFrameworkCore.Query;
using Zack.EFCore.Batch.Internal;

namespace Microsoft.EntityFrameworkCore
{
    public static class DbContextOptionsBuilderExtension
    {
        public static void UseBatchEF(this DbContextOptionsBuilder optBuilder)
        {
            optBuilder.ReplaceService<IQuerySqlGeneratorFactory, ZackQuerySqlGeneratorFactory>();
        }
    }
}
