// <copyright file="IContextItemEventSubscriber.cs" company="Sören Sprößig">
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
// to access EA context item events.
// </summary>

namespace Contracts
{
    /// <summary>
    /// This interface provides its implementers with means
    /// to access EA context item events.
    /// </summary>
    public interface IContextItemEventSubscriber
    {
        /// <summary>
        /// From EA API:
        /// EA_OnContextItemChanged notifies Add-Ins that a different item is now in context.
        /// This event occurs after a user has selected an item anywhere in the Enterprise Architect GUI. Add-Ins that require knowledge of the current item in context can subscribe to this broadcast function. If ot = otRepository, then this function behaves the same as EA_FileOpen.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="guid">Contains the GUID of the new context item. This value corresponds to the following properties, depending on the value of the ot parameter: ot (ObjectType) otElement otPackage otDiagram otAttribute otMethod otConnector otRepository - GUID value - Element.ElementGUID - Package.PackageGUID - Diagram.DiagramGUID - Attribute.AttributeGUID - Method.MethodGUID - Connector.ConnectorGUID - NOT APPLICABLE, GUID is an empty string</param>
        /// <param name="objectType">Specifies the type of the new context item.</param>
        void OnContextItemChanged(EA.Repository repository, string guid, EA.ObjectType objectType);

        /// <summary>
        /// From EA API:
        /// EA_OnContextItemDoubleClicked notifies Add-Ins that the user has double-clicked the item currently in context.
        /// This event occurs when a user has double-clicked (or pressed [Enter]) on the item in context, either in a diagram or in the Project Browser. Add-Ins to handle events can subscribe to this broadcast function.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="guid">Contains the GUID of the new context item. This value corresponds to the following properties, depending on the value of the ot parameter: ot (ObjectType) otElement otPackage otDiagram otAttribute otMethod otConnector otRepository - GUID value - Element.ElementGUID - Package.PackageGUID - Diagram.DiagramGUID - Attribute.AttributeGUID - Method.MethodGUID - Connector.ConnectorGUID - NOT APPLICABLE, GUID is an empty string</param>
        /// <param name="objectType">Specifies the type of the new context item.</param>
        /// <returns>true if the handling succeeded, false if not</returns>
        bool OnContextItemDoubleClicked(EA.Repository repository, string guid, EA.ObjectType objectType);

        /// <summary>
        /// From EA API:
        /// EA_OnNotifyContextItemModified notifies Add-Ins that the current context item has been modified.
        /// This event occurs when a user has modified the context item. Add-Ins that require knowledge of when an item has been modified can subscribe to this broadcast function.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="guid">Contains the GUID of the new context item. This value corresponds to the following properties, depending on the value of the ot parameter: ot (ObjectType) otElement otPackage otDiagram otAttribute otMethod otConnector otRepository - GUID value - Element.ElementGUID - Package.PackageGUID - Diagram.DiagramGUID - Attribute.AttributeGUID - Method.MethodGUID - Connector.ConnectorGUID - NOT APPLICABLE, GUID is an empty string</param>
        /// <param name="objectType">Specifies the type of the new context item.</param>
        void OnNotifyContextItemModified(EA.Repository repository, string guid, EA.ObjectType objectType);
    }
}
