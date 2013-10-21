// <copyright file="IMenuItemProvider.cs" company="Sören Sprößig">
// see: https://github.com/ssproessig/EA_SendLinks
//
// This source is subject to the GNU General Public License v3.0
// 
// Please see the License.txt file for more information.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
// </copyright>
// 
// <author>Sören Sprößig</author>
// <email>ssproessig@googlemail.com</email>
// <summary>
// This interface provides its implementers with means
// to add and control menu entries to EA.
// </summary>

namespace Contracts
{
    /// <summary>
    /// This interface provides its implementers with means
    /// to add and control menu entries to EA.
    /// </summary>
    public interface IMenuItemProvider
    {
        /// <summary>
        /// Returns the menu items the implementer provides.
        /// </summary>
        /// <param name="forParentMenuEntry">If given the sub-entries for the parent menu will be returned. If empty, the top-level entries are returned</param>
        /// <returns>
        /// Menu items as array of strings
        /// </returns>
        string[] ProvideMenuEntries(string forParentMenuEntry);

        /// <summary>
        /// Gets the state of the menu. Wraps the EA_GetMenuState call.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="location">The location.</param>
        /// <param name="menuName">Name of the menu.</param>
        /// <param name="itemName">Name of the item.</param>
        /// <param name="isEnabled">if set to <c>true</c> [is enabled].</param>
        /// <param name="isChecked">if set to <c>true</c> [is checked].</param>
        /// <returns>Return true if the menu was handled, false otherwise.</returns>
        bool GetMenuState(EA.Repository repository, string location, string menuName, string itemName, ref bool isEnabled, ref bool isChecked);

        /// <summary>
        /// Handles a menu click. Wraps the EA_MenuClick call.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="location">The location.</param>
        /// <param name="menuName">Name of the menu.</param>
        /// <param name="itemName">Name of the item.</param>
        void MenuClick(EA.Repository repository, string location, string menuName, string itemName);
    }
}
