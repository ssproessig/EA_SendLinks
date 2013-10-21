// <copyright file="IPreNewEventSubscriber.cs" company="Sören Sprößig">
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
// EA while creating new entries/diagrams.
// </summary>

namespace Contracts
{
	/// <summary>
	/// This interface provides its implementers with the events from
	/// EA while creating new entries/diagrams.
	/// </summary>
	public interface IPreNewEventSubscriber
	{
		/// <summary>
		/// Called by EA_OnPreNewElement.
		/// 
		/// EA_OnPreNewElement notifies Add-Ins that a new element is about to be created on a diagram. It enables Add-Ins to permit or deny creation of the new element.
		/// This event occurs when a user drags a new element from the Enterprise Architect UML Toolbox or Resources window onto a diagram. The notification is provided immediately before the element is created, so that the Add-In can disable addition of the element.
		/// </summary>
		/// <param name="repository">The repository.</param>
		/// <param name="info">Contains the following EventProperty Objects for the element to be created:
		/// Type: A string value corresponding to Element.Type
		/// Stereotype: A string value corresponding to Element.Stereotype
		/// ParentID: A long value corresponding to Element.ParentID
		/// DiagramID: A long value corresponding to the ID of the diagram to which the element is being added.</param>
		/// <returns>Return True to enable addition of the new element to the model. Return False to disable addition of the new element.</returns>
		bool OnPreNewElement(EA.Repository repository, EA.EventProperties info);

		/// <summary>
		/// Called by EA_OnPreNewConnector.
		/// 
		/// EA_OnPreNewConnector notifies Add-Ins that a new connector is about to be created on a diagram. It enables Add-Ins to permit or deny creation of a new connector.
		/// This event occurs when a user drags a new connector from the Enterprise Architect UML Toolbox or Resources window, onto a diagram. The notification is provided immediately before the connector is created, so that the Add-In can disable addition of the connector.
		/// </summary>
		/// <param name="repository">The repository.</param>
		/// <param name="info">Contains the following EventProperty Objects for the connector to be created:
		/// Type: A string value corresponding to Connector.Type
		/// Subtype: A string value corresponding to Connector.Subtype
		/// Stereotype: A string value corresponding to Connector.Stereotype
		/// ClientID: A long value corresponding to Connector.ClientID
		/// SupplierID: A long value corresponding to Connector.SupplierID
		/// DiagramID: A long value corresponding to Connector.DiagramID
		/// </param>
		/// <returns>Return True to enable addition of the new element to the model. Return False to disable addition of the new element.</returns>
		bool OnPreNewConnector(EA.Repository repository, EA.EventProperties info);

		/// <summary>
		/// Called by EA_OnPreNewDiagramObject.
		/// 
		/// EA_OnPreNewDiagramObject notifies Add-Ins that a new diagram object is about to be dropped on a diagram. It enables Add-Ins to permit or deny creation of the new object.
		/// This event occurs when a user drags an object from the Enterprise Architect Project Browser or Resources window onto a diagram. The notification is provided immediately before the object is created, so that the Add-In can disable addition of the object.
		/// </summary>
		/// <param name="repository">The repository.</param>
		/// <param name="info">Contains the following EventProperty Objects for the object to be created:
		/// Type: A string value corresponding to Object.Type
		/// Stereotype: A string value corresponding to Object.Stereotype
		/// ParentID: A long value corresponding to Object.ParentID
		/// DiagramID: A long value corresponding to the ID of the diagram to which the object is being added.
		/// </param>
		/// <returns>Return True to enable addition of the new element to the model. Return False to disable addition of the new element.</returns>
		bool OnPreNewDiagramObject(EA.Repository repository, EA.EventProperties info);

		/// <summary>
		/// Called by EA_OnPreNewAttribute.
		/// 
		/// EA_OnPreNewAttribute notifies Add-Ins that a new attribute is about to be created on an element. It enables Add-Ins to permit or deny creation of the new attribute.
		/// This event occurs when a user creates a new attribute on an element by either drag-dropping from the Project Browser, using the Attributes Properties dialog, or using the in-place editor on the diagram. The notification is provided immediately before the attribute is created, so that the Add-In can disable addition of the attribute.
		/// </summary>
		/// <param name="repository">The repository.</param>
		/// <param name="info">Contains the following EventProperty Objects for the attribute to be created:
		/// Type: A string value corresponding to Attribute.Type
		/// Stereotype: A string value corresponding to Attribute.Stereotype
		/// ParentID: A long value corresponding to Attribute.ParentID
		/// ClassifierID: A long value corresponding to Attribute.ClassifierID
		/// </param>
		/// <returns>Return True to enable addition of the new element to the model. Return False to disable addition of the new element.</returns>
		bool OnPreNewAttribute(EA.Repository repository, EA.EventProperties info);

		/// <summary>
		/// Called by EA_OnPreNewMethod.
		/// 
		/// EA_OnPreNewMethod notifies Add-Ins that a new method is about to be created on an element. It enables Add-Ins to permit or deny creation of the new method.
		/// This event occurs when a user creates a new method on an element by either drag-dropping from the Project Browser, using the method Properties dialog, or using the in-place editor on the diagram. The notification is provided immediately before the method is created, so that the Add-In can disable addition of the method.
		/// </summary>
		/// <param name="repository">The repository.</param>
		/// <param name="info">Contains the following EventProperty Objects for the method to be created:
		/// ReturnType: A string value corresponding to Method.ReturnType
		/// Stereotype: A string value corresponding to Method.Stereotype
		/// ParentID: A long value corresponding to Method.ParentID
		/// ClassifierID: A long value corresponding to Method.ClassifierID
		/// </param>
		/// <returns>Return True to enable addition of the new element to the model. Return False to disable addition of the new element.</returns>
		bool OnPreNewMethod(EA.Repository repository, EA.EventProperties info);

		/// <summary>
		/// Called by EA_OnPreNewPackage.
		/// 
		/// EA_OnPreNewPackage notifies Add-Ins that a new package is about to be created in the model. It enables Add-Ins to permit or deny creation of the new package.
		/// This event occurs when a user drags a new package from the Enterprise Architect UML Toolbox or Resources window onto a diagram, or by selecting the New Package icon from the Project Browser. The notification is provided immediately before the package is created, so that the Add-In can disable addition of the package.
		/// </summary>
		/// <param name="repository">The repository.</param>
		/// <param name="info">Contains the following EventProperty Objects for the package to be created:
		/// Stereotype: A string value corresponding to Package.Stereotype
		/// ParentID: A long value corresponding to Package.ParentID
		/// DiagramID: A long value corresponding to the ID of the diagram to which the package is being added.
		/// </param>
		/// <returns>Return True to enable addition of the new element to the model. Return False to disable addition of the new element.</returns>
		bool OnPreNewPackage(EA.Repository repository, EA.EventProperties info);
	}
}
