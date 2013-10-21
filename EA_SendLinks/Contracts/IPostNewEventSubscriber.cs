// <copyright file="IPostNewEventSubscriber.cs" company="Sören Sprößig">
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
// EA after creating new entries/diagrams.
// </summary>

namespace Contracts
{
    /// <summary>
    /// This interface provides its implementers with the events from
    /// EA after creating new entries/diagrams.
    /// </summary>
    public interface IPostNewEventSubscriber
    {
        /// <summary>
        /// OnPostNewMethod notifies Add-Ins that a new method has been created on a diagram. It enables Add-Ins to modify the method upon creation.
        /// This event occurs when a user creates a new method on an element by either drag-dropping from the Project Browser, using the method's Properties dialog, or using the in-place editor on the diagram. The notification is provided immediately after the method is created. Set Repository.SuppressEADialogs to true to suppress Enterprise Architect from showing its default dialogs.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="info">Contains the following EventProperty objects for the new package: MethodID: A long value corresponding to Method.MethodID.</param>
        /// <returns>Return True if the package has been updated during this notification. Return False otherwise.</returns>
        bool OnPostNewMethod(EA.Repository repository, EA.EventProperties info);

        /// <summary>
        /// OnPostNewAttribute notifies Add-Ins that a new attribute has been created on a diagram. It enables Add-Ins to modify the attribute upon creation.
        /// This event occurs when a user creates a new attribute on an element by either drag-dropping from the Project Browser, using the Attributes Properties dialog, or using the in-place editor on the diagram. The notification is provided immediately after the attribute is created. Set Repository.SuppressEADialogs to true to suppress Enterprise Architect from showing its default dialogs.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="info">Contains the following EventProperty objects for the new package: AttributeID: A long value corresponding to Attribute.AttributeID..</param>
        /// <returns>Return True if the package has been updated during this notification. Return False otherwise.</returns>
        bool OnPostNewAttribute(EA.Repository repository, EA.EventProperties info);

        /// <summary>
        /// OnPostNewDiagramObject notifies Add-Ins that a new object has been created on a diagram. It enables Add-Ins to modify the object upon creation.
        /// This event occurs after a user has dragged a new object from the Enterprise Architect Project Browser or Resources window onto a diagram. The notification is provided immediately after the object is added to the diagram. Set Repository.SuppressEADialogs to true to suppress Enterprise Architect from showing its default dialogs.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="info">Contains the following EventProperty objects for the new package: ObjectID: A long value corresponding to Object.ObjectID.</param>
        /// <returns>Return True if the package has been updated during this notification. Return False otherwise.</returns>
        bool OnPostNewDiagramObject(EA.Repository repository, EA.EventProperties info);

        /// <summary>
        /// OnPostNewConnector notifies Add-Ins that a new connector has been created on a diagram. It enables Add-Ins to modify the connector upon creation.
        /// This event occurs after a user has dragged a new connector from the Enterprise Architect UML Toolbox or Resources window onto a diagram. The notification is provided immediately after the connector is added to the model. Set Repository.SuppressEADialogs to true to suppress Enterprise Architect from showing its default dialogs.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="info">Contains the following EventProperty objects for the new package: ConnectorID: A long value corresponding to Connector.ConnectorID.</param>
        /// <returns>Return True if the package has been updated during this notification. Return False otherwise.</returns>
        bool OnPostNewConnector(EA.Repository repository, EA.EventProperties info);

        /// <summary>
        /// OnPostNewElement notifies Add-Ins that a new element has been created on a diagram. It enables Add-Ins to modify the element upon creation.
        /// This event occurs after a user has dragged a new element from the Enterprise Architect UML Toolbox or Resources window onto a diagram. The notification is provided immediately after the element is added to the model. Set Repository.SuppressEADialogs to true to suppress Enterprise Architect from showing its default dialogs.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="info">Contains the following EventProperty objects for the new package: ElementID: A long value corresponding to Element.ElementID.</param>
        /// <returns>Return True if the package has been updated during this notification. Return False otherwise.</returns>
        bool OnPostNewElement(EA.Repository repository, EA.EventProperties info);

        /// <summary>
        /// OnPostNewPackage notifies Add-Ins that a new package has been created on a diagram. It enables Add-Ins to modify the package upon creation.
        /// This event occurs when a user drags a new package from the Enterprise Architect UML Toolbox or Resources window onto a diagram, or by selecting the New Package icon from the Project Browser. Set Repository.SuppressEADialogs to true to suppress Enterprise Architect from showing its default dialogs.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="info">Contains the following EventProperty objects for the new package: PackageID: A long value corresponding to Package.PackageID.</param>
        /// <returns>Return True if the package has been updated during this notification. Return False otherwise.</returns>
        bool OnPostNewPackage(EA.Repository repository, EA.EventProperties info);

        /// <summary>
        /// OnPostNewDiagram notifies Add-Ins that a new diagram has been created. It enables Add-Ins to modify the diagram upon creation.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="info">Contains the following EventProperty objects for the new diagram: DiagramID: A long value corresponding to Diagram.PackageID.</param>
        /// <returns>Return True if the diagram has been updated during this notification. Return False otherwise.</returns>
        bool OnPostNewDiagram(EA.Repository repository, EA.EventProperties info);
    }
}
