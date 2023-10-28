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
    public class P876_MiddleOfLinkedListTests
    {
        [Theory()]
        [InlineData(5,3)]
        [InlineData(6, 4)]
        public void MiddleNodeTest(int count, int expectedValue)
        {
            //arrange
            P876_MiddleOfLinkedList.ListNode priveous = null, startItem = null, expected = null;

            for (int i = 1;  i <= count && i<=100; i++) 
            { 
                var node= new P876_MiddleOfLinkedList.ListNode();
                node.val = i;

                if(startItem is null)
                {
                    startItem = node;                    
                }
                else
                {
                    priveous.next = node;
                }

                priveous = node;

                if(i== expectedValue) expected = node;
            }

            var dut= new P876_MiddleOfLinkedList();

            //action
            var actual = dut.MiddleNode(startItem);

            //assert
            actual.Should().Be(expected);
        }
    }
}