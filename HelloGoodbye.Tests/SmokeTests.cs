using System;
using System.Diagnostics;
using NUnit.Framework;

namespace HelloGoodbye.Tests
{
    [TestFixture]
    public class SmokeTests
    {
        private Process _process;

        [SetUp]
        public void SetUp()
        {
            var processStartInfo = new ProcessStartInfo(AppContext.BaseDirectory + "/HelloGoodbye.ConsoleApp.exe")
            {
                CreateNoWindow = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };
            _process = Process.Start(processStartInfo);
        }

        [TearDown]
        public void TearDown()
        {
            if(!_process.HasExited)
                _process.Kill();
            _process.Dispose();
        }

        [Test]
        public void When_I_say_hello_you_say_goodbye()
        {
            _process.StandardInput.WriteLine("Hello");
            Assert.That(_process.StandardOutput.ReadLine(), Is.EqualTo("Goodbye"));
        }

        [Test]
        public void When_I_say_sausages_you_say_say_that_again()
        {
            _process.StandardInput.WriteLine("Sausages");
            Assert.That(_process.StandardOutput.ReadLine(), Is.EqualTo("Say that again."));
        }

        [Test]
        public void When_I_say_Merry_Christmas_you_say_And_a_Happy_New_Year()
        {
            _process.StandardInput.WriteLine("Merry Christmas");
            Assert.That(_process.StandardOutput.ReadLine(), Is.EqualTo("And a Happy New Year"));
        }
    }
}
