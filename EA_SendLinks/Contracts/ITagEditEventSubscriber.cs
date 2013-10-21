// <copyright file="ITagEditEventSubscriber.cs" company="Sören Sprößig">
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
// This interface provides its implementers with the events from
// EA for editing tagged value of type AddinBroadcast.
// </summary>
using System;

namespace Contracts
{
    /// <summary>
    /// This interface provides its implementers with the events from
    /// EA for editing tagged value of type AddinBroadcast.
    /// </summary>
    public interface ITagEditEventSubscriber
    {
        /// <summary>
        /// OnElementTagEdit is called when the user clicks the ellipsis ( ... ) button for a Tagged Value of type AddinBroadcast on an element.
        /// The Add-In displays fields to show and change the value and notes; this function provides the initial values for the Tagged Value notes and value, and takes on any changes on exit of the function.
        /// </summary>
        /// <param name="repository">An EA.Repository object representing the currently open Enterprise Architect model.</param>
        /// <param name="objectID">The ID of the object (element) that this Tagged Value is on.</param>
        /// <param name="tagName">The name of the Tagged Value to edit.</param>
        /// <param name="tagValue">The current value of the tag; if the value is updated, the new value is stored in the repository on exit of the function.</param>
        /// <param name="tagNotes">The current value of the Tagged Value notes; if the value is updated, the new value is stored in the repository on exit of the function.</param>
        void OnElementTagEdit(EA.Repository repository, int objectID, String tagName, ref String tagValue, ref String tagNotes);
    }
}
