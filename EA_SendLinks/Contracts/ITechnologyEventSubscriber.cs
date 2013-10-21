// <copyright file="ITechnologyEventSubscriber.cs" company="Sören Sprößig">
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
// EA for technologies.
// </summary>

namespace Contracts
{
    /// <summary>
    /// This interface provides its implementers with the events from
    /// EA for technologies.
    /// </summary>
    public interface ITechnologyEventSubscriber
    {
        /// <summary>
        /// An AddIn uses this to hand over an MDG Technology.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <returns>Single XML String with the whole MDG in it.</returns>
        object OnInitializeTechnologies(EA.Repository repository);
    }
}
