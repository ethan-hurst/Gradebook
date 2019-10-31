using Xunit;

namespace Gradebook.Tests
{
  public class BookTests
  {
    [Fact]
    public void Test1()
    {
      var book = new Book("");
      book.AddGrade(89.1);
      book.AddGrade(89.1);
      book.AddGrade(89.1);

      var result = book.GetStatistics();

      Assert.Equal(85.6, result.Average, 1);
      Assert.Equal(90.5, result.HighValue, 1);
      Assert.Equal(77.3, result.LowValue, 1);
    }
  }
}
