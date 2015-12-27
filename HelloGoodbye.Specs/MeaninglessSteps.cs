using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HelloGoodbye.Specs
{
    [Binding]
    public class MeaninglessSteps
    {
        [When(@"I say hello")]
        public void WhenISayHello()
        {
            SayHello();
        }

        private void SayHello()
        {
            Console.WriteLine("Hello");
        }

        [Then(@"you say goodbye")]
        public void ThenYouSayGoodbye()
        {
            var answer = SayGoodbye();
            Assert.That(answer, Is.EqualTo("Goodbye"));
        }

        private string SayGoodbye()
        {
            return "Goodbye";
        }
    }
}
