﻿using System;

namespace OData.QueryBuilder.Options
{
    public class ODataQueryBuilderOptions
    {
        public bool SuppressExceptionOfNullOrEmptyFunctionArgs { get; set; } = false;

        public bool SuppressExceptionOfNullOrEmptyOperatorArgs { get; set; } = false;

        public bool UseCorrectDateTimeFormat { get; set; } = false;

        public Func<object, string> CustomToQueryFunction { get; set; } = null;
    }
}
