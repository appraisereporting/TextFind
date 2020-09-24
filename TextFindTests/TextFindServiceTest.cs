using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TextFind.Services;
using Xunit;

namespace TextFindTests
{
    public class TextFindServiceTest
    {
        [Fact]
        public void FindSubStringArgumentTest()
        {
            //arrange
            ITextFindService textFindService = new TextFindService();

            //assert
            Assert.Throws<ArgumentException>(() => textFindService.FindSubString(null, "subText", false));
            Assert.Throws<ArgumentException>(() => textFindService.FindSubString("text", null, false));
            Assert.Throws<ArgumentException>(() => textFindService.FindSubString("text", "", false));
        }

        [Fact]
        public void FindSubStringResultSingleInstanceStart()
        {
            //arrange
            ITextFindService textFindService = new TextFindService();

            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string subText = "A";

            //Expected value
            var expectedResult = new List<int> { 0 };

            //Result
            var result = textFindService.FindSubString(text, subText, false);

            //Test
            Assert.Equal(expectedResult.Count, result.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void FindSubStringResultSingleInstanceMiddle()
        {
            //arrange
            ITextFindService textFindService = new TextFindService();

            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string subText = "E";

            //Expected value
            var expectedResult = new List<int> { 4 };

            //Result
            var result = textFindService.FindSubString(text, subText, false);

            //Test
            Assert.Equal(expectedResult.Count, result.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void FindSubStringResultSingleInstanceEnd()
        {
            //arrange
            ITextFindService textFindService = new TextFindService();

            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string subText = "Z";

            //Expected value
            var expectedResult = new List<int> { 25 };

            //Result
            var result = textFindService.FindSubString(text, subText, false);

            //Test
            Assert.Equal(expectedResult.Count, result.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void FindSubStringResultSingleInstanceStartLongSubString()
        {
            //arrange
            ITextFindService textFindService = new TextFindService();

            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string subText = "AB";

            //Expected value
            var expectedResult = new List<int> { 0 };

            //Result
            var result = textFindService.FindSubString(text, subText, false);

            //Test
            Assert.Equal(expectedResult.Count, result.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void FindSubStringResultSingleInstanceMiddleSubString()
        {
            //arrange
            ITextFindService textFindService = new TextFindService();

            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string subText = "EF";

            //Expected value
            var expectedResult = new List<int> { 4 };

            //Result
            var result = textFindService.FindSubString(text, subText, false);

            //Test
            Assert.Equal(expectedResult.Count, result.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void FindSubStringResultSingleInstanceEndSubString()
        {
            //arrange
            ITextFindService textFindService = new TextFindService();

            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string subText = "YZ";

            //Expected value
            var expectedResult = new List<int> { 24 };

            //Result
            var result = textFindService.FindSubString(text, subText, false);

            //Test
            Assert.Equal(expectedResult.Count, result.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void FindSubStringResultMultiple()
        {
            //arrange
            ITextFindService textFindService = new TextFindService();

            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string subText = "A";

            //Expected value
            var expectedResult = new List<int> { 0, 26 };

            //Result
            var result = textFindService.FindSubString(text, subText, false);

            //Test
            Assert.Equal(expectedResult.Count, result.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
        
        [Fact]
        public void FindSubStringResultOverlap()
        {
            //arrange
            ITextFindService textFindService = new TextFindService();

            string text = "AAABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string subText = "AA";

            //Expected value
            var expectedResult = new List<int> { 0, 1 };

            //Result
            var result = textFindService.FindSubString(text, subText, false);

            //Test
            Assert.Equal(expectedResult.Count, result.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
        
        [Fact]
        public void FindSubStringResultMultipleCaseInsensitive()
        {
            //arrange
            ITextFindService textFindService = new TextFindService();

            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string subText = "a";

            //Expected value
            var expectedResult = new List<int> { 0, 26 };

            //Result
            var result = textFindService.FindSubString(text, subText, true);

            //Test
            Assert.Equal(expectedResult.Count, result.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

    }
}
