namespace EngineBay.Core.Tests
{
    using Xunit;

    public class ModuleTemplateTests
    {
        [Fact]
        public void DefaultPaginationParametersSkipShouldBeZero()
        {
            var paginationParameters = new PaginationParameters();
            Assert.Equal(0, paginationParameters.Skip);
        }
    }
}
