
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_840

	''' <summary>
	'''     Determines whether any custom attributes are applied to an assembly. Parameters specify the assembly, and the
	'''     type of the custom attribute to search for.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
	''' <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	''' <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsDefined(element As Assembly, attributeType As Type) As [Boolean]
		Return Attribute.IsDefined(element, attributeType)
	End Function

	''' <summary>
	'''     Determines whether any custom attributes are applied to an assembly. Parameters specify the assembly, the
	'''     type of the custom attribute to search for, and an ignored search option.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
	''' <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	''' <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
	''' <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsDefined(element As Assembly, attributeType As Type, inherit As [Boolean]) As [Boolean]
		Return Attribute.IsDefined(element, attributeType, inherit)
	End Function
End Module


