using Xunit;
using BeginnersGuide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace BeginnersGuide.Tests
{
    public class P383_RansomNoteTests
    {
        [Theory]
        [InlineData("a","b",false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aab", true)]
        [InlineData("baa", "aba", true)]
        public void CanConstructTest(string ransomeNote,string magazine, bool expectedValue)
        {
            var dut = new P383_RansomNote();

            var actual = dut.CanConstruct(ransomeNote, magazine);

            actual.Should().Be(expectedValue);
        }
    }
}