// add a namespace for the WeatherForecastController
using WebApi.Controllers;

namespace WebApiTests;

[TestClass]
public class WeatherForecastContollerTests
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    // add a test method that tests the GetRange method of WeatherForecastContoller
    [TestMethod]
    public void TestGetRange()
    {
        // arrange
        var controller = new WeatherForecastController(null);

        // act
        var result = controller.GetRange(new DateRange { Length = 5 });

        // assert
        Assert.AreEqual(5, result.Count());
    }

}