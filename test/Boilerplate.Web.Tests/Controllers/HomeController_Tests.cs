using System.Threading.Tasks;
using Boilerplate.Models.TokenAuth;
using Boilerplate.Web.Controllers;
using Shouldly;
using Xunit;

namespace Boilerplate.Web.Tests.Controllers
{
    public class HomeController_Tests: BoilerplateWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}