/* Size Enum
 * Author: Sam Brunner
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Enumerator representing the size of the item.
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// The size of a small item, cheapest price and lowest calories
        /// </summary>
        Small,
        /// <summary>
        /// The size of a medium item, has the median price and calories of the item type.
        /// </summary>
        Medium,
        /// <summary>
        /// The largest size available for an item, contains the most calories and highest price.
        /// </summary>
        Large
    
    }
}
