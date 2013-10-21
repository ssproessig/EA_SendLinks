// <copyright file="IPreDeleteEventSubscriber.cs" company="Sören Sprößig">
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
// EA that occur before deleting objects.
// </summary>

using System;
using EA;

namespace Contracts
{    
    /// <summary>
    /// This interface provides its implementers with the events from
    /// EA that occur before deleting objects.
    /// </summary>
    public interface IPreDeleteEventSubscriber
    {
        /// <summary>
        /// OnPreDeleteElement notifies Add-Ins that an element is to be deleted from the model. It enables Add-Ins to permit or deny deletion of the element.
        /// This event occurs when a user deletes an element from the Project Browser or on a diagram. The notification is provided immediately before the element is deleted, so that the Add-In can disable deletion of the element.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="eventProperties">The event properties.</param>
        /// <returns>Return True to enable deletion of the element from the model. Return False to disable deletion of the element.</returns>
        Boolean OnPreDeleteElement(Repository repository, EventProperties eventProperties);

        /// <summary>
        /// EA_OnPreDeleteConnector notifies Add-Ins that a connector is to be deleted from the model. It enables Add-Ins to permit or deny deletion of the connector.
        /// This event occurs when a user attempts to permanently delete a connector on a diagram. The notification is provided immediately before the connector is deleted, so that the Add-In can disable deletion of the connector.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="eventProperties">The event properties.</param>
        /// <returns>Return True to enable deletion of the connector from the model. Return False to disable deletion of the connector.</returns>
        Boolean OnPreDeleteConnector(Repository repository, EventProperties eventProperties);
    }
}
