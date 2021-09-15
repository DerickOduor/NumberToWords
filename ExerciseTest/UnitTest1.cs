using Excercise01;
using System;
using Xunit;

namespace ExerciseTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("-11")]
        [InlineData("0")]
        [InlineData("100")]
        [InlineData("18,000,000")]
        [InlineData("18000,000")]
        [InlineData("18000000")]
        [InlineData("18,456,002,032,011")]
        public void ToWords(string value)
        {
            string result = Excercise.Towards(Convert.ToInt64(value.Trim().Replace(",","")));

            Assert.True(!result.Equals("Bad input") , value + " should be a positive number input.");
        }

        [Theory]
        [InlineData("Negative eleven","-11")]
        [InlineData("zero","0")]
        [InlineData("one hundred","100")]
        [InlineData("eighteen million","18,000,000")]
        [InlineData("eighteen million", "18000,000")]
        [InlineData("eighteen million", "18000000")]
        [InlineData("eighteen billion four hundred and fifty six million two thousand and thirty two", "18,456,002,032")]
        public void Pass(string Word,string Number)
        {
            string result = Excercise.Towards(Convert.ToInt64(Number.Replace(",",""))).ToLower().Trim();
            Assert.Equal(Word.ToLower(), result);
        }

        [Theory]
        [InlineData("eleven","-11")]
        [InlineData("one","0")]
        [InlineData("one thousand","100")]
        [InlineData("eighteen million and one","18,000,000")]
        [InlineData("eighteen million only", "18000,000")]
        [InlineData("eighteen million nine thousand", "18000000")]
        [InlineData("eighteen billion four hundred and fifty six million three thousand and thirty two", "18,456,002,032")]
        public void Fail(string Word,string Number)
        {
            string result = Excercise.Towards(Convert.ToInt64(Number.Replace(",",""))).ToLower().Trim();
            Assert.NotEqual(Word.ToLower(), result);
        }
    }
}
