// <copyright file="IFileEventSubscriber.cs" company="Sören Sprößig">
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
    /// This interface provides its implementers with the events from
    /// EA when dealing with EA project files.
    /// </summary>
    public interface IFileEventSubscriber
    {
        /// <summary>
        /// Maps to EA_FileOpen
        /// 
        /// Event to respond to an file open event.
        /// </summary>
        /// <param name="repository">The repository.</param>
        void OnFileOpen(EA.Repository repository);

        /// <summary>
        /// Maps to EA_FileClose
        /// 
        /// Event to respond to an file close event.
        /// </summary>
        /// <param name="repository">The repository.</param>
        void OnFileClose(EA.Repository repository);

        /// <summary>
        /// Maps to EA_FileNew
        /// 
        /// Event to respond to an file new event.
        /// </summary>
        /// <param name="repository">The repository.</param>
        void OnFileNew(EA.Repository repository);
    }
}
