namespace HW_Tests
{
    public class ProgramTests
    {
        [Fact]
        public void GetGreetings_ReturnHelloWorld_whernRequested()
        {
            var result = HW.GetGreetings();

            Assert.Equal("Hello, World!", result);
        }
    }
}