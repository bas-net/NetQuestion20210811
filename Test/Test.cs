using System;
using Lib;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        /// <summary>
        /// <para>Is this test guaranteed to succeed?</para>
        /// <para>
        /// 1. Yes
        /// 2. No
        /// 3. This code doesn't compile
        /// </para>
        /// </summary>
        [Fact]
        public void TestIndexer()
        {
            var subject = new IndexableObject();

            subject[0] = 42;
            subject[1] = 13;

            Assert.Equal(42, subject[0]);
            Assert.Equal(13, subject[1]);
        }
    }
}
