using System.Threading.Tasks;
using Blog.Models.TokenAuth;
using Blog.Web.Controllers;
using Shouldly;
using Xunit;

namespace Blog.Web.Tests.Controllers
{
    public class HomeController_Tests: BlogWebTestBase
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