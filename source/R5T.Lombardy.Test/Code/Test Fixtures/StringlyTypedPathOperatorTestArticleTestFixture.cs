﻿using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace R5T.Lombardy.Test
{
    public abstract class StringlyTypedPathOperatorTestArticleTestFixture
    {
        #region Test-Fixture

        public IStringlyTypedPathOperatorTestArticle StringlyTypedPathOperatorTestArticle { get; set; }


        public StringlyTypedPathOperatorTestArticleTestFixture(IStringlyTypedPathOperatorTestArticle stringlyTypedPathOperatorTestArticle)
        {
            this.StringlyTypedPathOperatorTestArticle = stringlyTypedPathOperatorTestArticle;
        }

        #endregion
    }
}
