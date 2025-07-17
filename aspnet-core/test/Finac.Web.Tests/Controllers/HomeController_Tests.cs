using System.Threading.Tasks;
using Finac.Models.TokenAuth;
using Finac.Web.Controllers;
using Shouldly;
using Xunit;

namespace Finac.Web.Tests.Controllers
{
    public class HomeController_Tests: FinacWebTestBase
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