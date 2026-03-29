namespace Web.Helpers;

internal static class ExamPrefixHelper
{
    /// <summary>
    /// Returns distinct prefixes derived from examOptions in first-occurrence order.
    /// Prefixes are always derived from examOptions; no separate list must be maintained.
    /// </summary>
    internal static IEnumerable<string> GetPrefixes(IEnumerable<string> examOptions)
        => examOptions.Select(e => e.Split('-')[0]).Distinct();

    /// <summary>
    /// Returns exam options whose prefix (the part before the first '-') matches the given prefix.
    /// Returns an empty enumerable when prefix is null or empty.
    /// </summary>
    internal static IEnumerable<string> GetFilteredOptions(IEnumerable<string> examOptions, string prefix)
        => string.IsNullOrEmpty(prefix)
            ? Enumerable.Empty<string>()
            : examOptions.Where(e => e.Split('-')[0] == prefix);
}
