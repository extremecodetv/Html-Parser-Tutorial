using AngleSharp.Dom.Html;

namespace Parser.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
