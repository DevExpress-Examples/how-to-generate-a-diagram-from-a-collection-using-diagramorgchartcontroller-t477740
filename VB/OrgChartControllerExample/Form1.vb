Imports OrgChartControllerExample.ViewModels
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace OrgChartControllerExample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			Dim model = New MainViewModel()
			diagramOrgChartController1.DataSource = model.Contacts
		End Sub
	End Class
End Namespace
