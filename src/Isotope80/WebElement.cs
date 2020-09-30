using System.Drawing;
using LanguageExt;

namespace Isotope80
{
    /// <summary>
    /// Immutable web-element that doesn't suffer the problems of the lazy IWebElement (namely if the IWebDriver is
    /// disposed then IWebElement fails, which is a problem for lazy processes).
    /// </summary>
    [Record]
    public partial class WebElement
    {
        /// <summary>
        /// Query selector that found this element
        /// </summary>
        public readonly Query Selector;
        
        /// <summary>
        /// This structure was made from a query.  This is the index into the query results
        /// </summary>
        public readonly int SelectionIndex;
        
        /// <summary>
        /// Element tag name
        /// </summary>
        public readonly string TagName;
        
        // <summary>
        // Element inner text
        // </summary>
        public readonly string Text;

        /// <summary>
        /// Element enabled flag
        /// </summary>
        public readonly bool Enabled;

        /// <summary>
        /// Indicates whether or not this element is selected.
        /// </summary>
        public readonly bool Selected;

        /// <summary>
        /// Gets a <see cref="T:System.Drawing.Point" /> object containing the coordinates of the upper-left corner
        /// of this element relative to the upper-left corner of the page.
        /// </summary>
        public readonly Point Location;

        /// <summary>
        /// Gets a <see cref="P:OpenQA.Selenium.IWebElement.Size" /> object containing the height and width of this element.
        /// </summary>
        /// <exception cref="T:OpenQA.Selenium.StaleElementReferenceException">Thrown when the target element is no longer valid in the document DOM.</exception>
        public readonly Size Size;

        /// <summary>
        /// Indicates whether or not this element is displayed.
        /// </summary>
        public readonly bool Displayed;
    }
}