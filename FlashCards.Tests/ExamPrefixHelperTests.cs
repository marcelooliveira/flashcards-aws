using Web.Helpers;
using Xunit;

namespace FlashCards.Tests;

public class ExamPrefixHelperTests
{
    [Fact]
    public void ExamPrefixes_ReturnsDistinctPrefixesInOrder()
    {
        var options = new[] { "dva-1", "dva-2", "dea-01", "aif-01", "dd-fundamentals-1" };
        var result = ExamPrefixHelper.GetPrefixes(options);
        Assert.Equal(new[] { "dva", "dea", "aif", "dd" }, result);
    }

    [Fact]
    public void FilteredExamOptions_FiltersCorrectlyByPrefix()
    {
        var options = new[] { "dva-1", "dva-2", "dea-01", "aif-01" };
        var result = ExamPrefixHelper.GetFilteredOptions(options, "dva");
        Assert.Equal(new[] { "dva-1", "dva-2" }, result);
    }
}
