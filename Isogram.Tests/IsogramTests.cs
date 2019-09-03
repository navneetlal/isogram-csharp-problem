using System;
using System.Collections.Generic;
using System.Text;
using Isogram;
using Xunit;

namespace Isogram.Tests
{
    public class IsogramTests
    {

        private bool ActualExec(string str)
        {
            return IsogramCheck.IsIsogram(str);
        }



        [Fact]
        public void Isogram_IsTrueForEmptyString()
        {
            // Arrange 
            string str = "";
            bool expected = true;

            // Act
            // Assert
            Assert.Equal(expected, IsogramCheck.IsIsogram(str));
        }


        [Fact]
        public void Isogram_HoldsTrueForLowerCaseCharacter()
        {
            // Arrange 
            string str = "isogram";
            bool expected = true;

            // Act
            // Assert
            Assert.Equal(expected, IsogramCheck.IsIsogram(str));
        }

        [Fact]
        public void Isogram_HoldsFalseForWordsWithRepeatedLowerCaseCharacter()
        {
            string str = "eleven";
            bool expected = false;

            // Act
            // Assert
            Assert.Equal(expected, IsogramCheck.IsIsogram(str));
        }


        [Fact]
        public void Isogram_HoldsTrueForLongReportedEnglishWord()
        {
            string str = "subdermatoglyphic";
            bool expected = true;

            // Act
            // Assert
            Assert.Equal(expected, IsogramCheck.IsIsogram(str));
        }


        [Fact]
        public void Isogram_HoldsTrueForDuplicateCharInMixedCase()
        {
            string str = "Alphabet";
            bool expected = true;

            // Act
            // Assert
            Assert.Equal(expected, IsogramCheck.IsIsogram(str));
        }


        [Fact]
        public void Isogram_HoldsTrueForWordWithHypen()
        {
            string str = "thumbscrew-japingly";
            bool expected = true;

            // Act
            // Assert
            Assert.Equal(expected, IsogramCheck.IsIsogram(str));
        }



        [Fact]
        public void Isogram_HoldsTrueForWordWithDuplicatedHypen()
        {
            string str = "six-year-old";
            bool expected = true;

            // Act
            // Assert
            Assert.Equal(expected, IsogramCheck.IsIsogram(str));
        }



        [Fact]
        public void Isogram_HoldsTrueForSpaceSeparatedName()
        {
            string str = "six year old";
            bool expected = true;

            // Act
            // Assert
            Assert.Equal(expected, IsogramCheck.IsIsogram(str));
        }

    }
}
