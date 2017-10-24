using UwpFcuXUnit.POS.ViewModel;
using Xunit;

namespace UwpFcuXUnit.Tests.POS.UnitTests.ViewModel
{
    public class StartPageViewModelTests
    {
        [Fact]
        public void SampleTest()
        {
            var model = new StartPageViewModel();
            Assert.NotNull(model);
        }
    }
}
