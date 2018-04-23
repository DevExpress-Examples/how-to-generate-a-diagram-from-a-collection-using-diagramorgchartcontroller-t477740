Imports OrgChartControllerExample.Model
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq

Namespace OrgChartControllerExample.ViewModels
	Public Class MainViewModel
		Private privateContacts As IList(Of Contact)
		Public Property Contacts() As IList(Of Contact)
			Get
				Return privateContacts
			End Get
			Protected Set(ByVal value As IList(Of Contact))
				privateContacts = value
			End Set
		End Property

		Public Sub New()
			Contacts = (New ContactContextInitializer()).Generate()
		End Sub
	End Class
End Namespace