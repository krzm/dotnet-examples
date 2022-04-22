using System.Text;
using Xunit;

namespace Net.Tests;

public class StringBuilderTests
{
	[Theory]
	[InlineData("print number: {0}", 10, "print number: 10")]
	public void IsNullOrWhiteSpace_logic(
        string format
        , int number
        , string expected)
	{
        var sut = new StringBuilder();

        var acctual = sut.AppendFormat(format, number).ToString();
		
        Assert.Equal(expected, acctual);
	}
}