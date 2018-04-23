Namespace OrgChartControllerExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.diagramControl1 = New DevExpress.XtraDiagram.DiagramControl()
			Me.diagramOrgChartController1 = New DevExpress.XtraDiagram.DiagramOrgChartController(Me.components)
			Me.diagramContainer1 = New DevExpress.XtraDiagram.DiagramContainer()
			Me.diagramImage1 = New DevExpress.XtraDiagram.DiagramImage()
			Me.diagramShape1 = New DevExpress.XtraDiagram.DiagramShape()
			Me.diagramShape2 = New DevExpress.XtraDiagram.DiagramShape()
			Me.diagramShape3 = New DevExpress.XtraDiagram.DiagramShape()
			Me.diagramConnector1 = New DevExpress.XtraDiagram.DiagramConnector()
			DirectCast(Me.diagramControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.diagramOrgChartController1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.diagramOrgChartController1.TemplateDiagram, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' diagramControl1
			' 
			Me.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagramControl1.Location = New System.Drawing.Point(0, 0)
			Me.diagramControl1.Name = "diagramControl1"
			Me.diagramControl1.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String(){})
			Me.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter
			Me.diagramControl1.OptionsView.ShowGrid = False
			Me.diagramControl1.OptionsView.ShowPageBreaks = False
			Me.diagramControl1.OptionsView.ShowRulers = False
			Me.diagramControl1.Size = New System.Drawing.Size(1009, 711)
			Me.diagramControl1.TabIndex = 0
			' 
			' diagramOrgChartController1
			' 
			Me.diagramOrgChartController1.Diagram = Me.diagramControl1
			Me.diagramOrgChartController1.KeyMember = "Id"
			Me.diagramOrgChartController1.ParentMember = "ParentId"
			' 
			' 
			' 
			Me.diagramOrgChartController1.TemplateDiagram.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() { Me.diagramContainer1, Me.diagramConnector1})
			Me.diagramOrgChartController1.TemplateDiagram.Location = New System.Drawing.Point(0, 0)
			Me.diagramOrgChartController1.TemplateDiagram.Name = ""
			Me.diagramOrgChartController1.TemplateDiagram.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() { "TemplateDesigner"})
			Me.diagramOrgChartController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill
			Me.diagramOrgChartController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter
			Me.diagramOrgChartController1.TemplateDiagram.OptionsView.ShowPageBreaks = False
			Me.diagramOrgChartController1.TemplateDiagram.TabIndex = 0
			' 
			' diagramContainer1
			' 
			Me.diagramContainer1.Anchors = (CType((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top), DevExpress.Diagram.Core.Sides))
			Me.diagramContainer1.CanAddItems = False
            Me.diagramContainer1.CanCopyWithoutParent = True
            Me.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint
			Me.diagramContainer1.ConnectionPoints = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {
				New DevExpress.Utils.PointFloat(0.5F, 0F),
				New DevExpress.Utils.PointFloat(1F, 0.5F),
				New DevExpress.Utils.PointFloat(0.5F, 1F),
				New DevExpress.Utils.PointFloat(0F, 0.5F)
			})
			Me.diagramContainer1.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() { Me.diagramImage1, Me.diagramShape1, Me.diagramShape2, Me.diagramShape3})
			Me.diagramContainer1.ItemsCanAttachConnectorBeginPoint = False
			Me.diagramContainer1.ItemsCanAttachConnectorEndPoint = False
			Me.diagramContainer1.ItemsCanChangeParent = False
			Me.diagramContainer1.ItemsCanCopyWithoutParent = False
			Me.diagramContainer1.ItemsCanDeleteWithoutParent = False
			Me.diagramContainer1.ItemsCanEdit = False
			Me.diagramContainer1.ItemsCanMove = False
			Me.diagramContainer1.ItemsCanResize = False
			Me.diagramContainer1.ItemsCanRotate = False
			Me.diagramContainer1.ItemsCanSelect = False
			Me.diagramContainer1.ItemsCanSnapToOtherItems = False
			Me.diagramContainer1.ItemsCanSnapToThisItem = False
			Me.diagramContainer1.Padding = New System.Windows.Forms.Padding(1)
			Me.diagramContainer1.Position = New DevExpress.Utils.PointFloat(25F, 125F)
			Me.diagramContainer1.Size = New System.Drawing.SizeF(320F, 190F)
			Me.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Moderate5
			' 
			' diagramImage1
			' 
			Me.diagramImage1.Anchors = (CType((((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top) Or DevExpress.Diagram.Core.Sides.Right) Or DevExpress.Diagram.Core.Sides.Bottom), DevExpress.Diagram.Core.Sides))
			Me.diagramImage1.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Image", "Photo"))
			Me.diagramImage1.CanCopy = False
			Me.diagramImage1.CanCopyWithoutParent = False
			Me.diagramImage1.CanMove = False
			Me.diagramImage1.CanResize = False
			Me.diagramImage1.CanRotate = False
			Me.diagramImage1.CanSelect = False
			Me.diagramImage1.CanSnapToOtherItems = False
			Me.diagramImage1.CanSnapToThisItem = False
			Me.diagramImage1.Position = New DevExpress.Utils.PointFloat(1F, 1F)
			Me.diagramImage1.Size = New System.Drawing.SizeF(140F, 186F)
			Me.diagramImage1.StretchMode = DevExpress.Diagram.Core.StretchMode.UniformToFill
			Me.diagramImage1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Balanced5
			' 
			' diagramShape1
			' 
			Me.diagramShape1.Anchors = (CType((DevExpress.Diagram.Core.Sides.Top Or DevExpress.Diagram.Core.Sides.Right), DevExpress.Diagram.Core.Sides))
			Me.diagramShape1.Appearance.BorderSize = 0
			Me.diagramShape1.Appearance.Font = New System.Drawing.Font("Tahoma", 14F)
			Me.diagramShape1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.diagramShape1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.diagramShape1.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "Phone"))
			Me.diagramShape1.CanCopy = False
			Me.diagramShape1.CanCopyWithoutParent = False
			Me.diagramShape1.CanEdit = False
			Me.diagramShape1.CanMove = False
			Me.diagramShape1.CanResize = False
			Me.diagramShape1.CanRotate = False
			Me.diagramShape1.CanSelect = False
			Me.diagramShape1.CanSnapToOtherItems = False
			Me.diagramShape1.CanSnapToThisItem = False
			Me.diagramShape1.Position = New DevExpress.Utils.PointFloat(168F, 66F)
			Me.diagramShape1.Size = New System.Drawing.SizeF(129F, 20F)
			Me.diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Moderate5
			' 
			' diagramShape2
			' 
			Me.diagramShape2.Anchors = (CType((DevExpress.Diagram.Core.Sides.Right Or DevExpress.Diagram.Core.Sides.Bottom), DevExpress.Diagram.Core.Sides))
			Me.diagramShape2.Appearance.BorderSize = 0
			Me.diagramShape2.Appearance.Font = New System.Drawing.Font("Tahoma", 14F)
			Me.diagramShape2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.diagramShape2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.diagramShape2.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "FirstName"))
			Me.diagramShape2.CanCopy = False
			Me.diagramShape2.CanCopyWithoutParent = False
			Me.diagramShape2.CanEdit = False
			Me.diagramShape2.CanMove = False
			Me.diagramShape2.CanResize = False
			Me.diagramShape2.CanRotate = False
			Me.diagramShape2.CanSelect = False
			Me.diagramShape2.CanSnapToOtherItems = False
			Me.diagramShape2.CanSnapToThisItem = False
			Me.diagramShape2.Position = New DevExpress.Utils.PointFloat(168F, 94F)
			Me.diagramShape2.Size = New System.Drawing.SizeF(129F, 20F)
			Me.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Moderate5
			' 
			' diagramShape3
			' 
			Me.diagramShape3.Anchors = (CType((DevExpress.Diagram.Core.Sides.Right Or DevExpress.Diagram.Core.Sides.Bottom), DevExpress.Diagram.Core.Sides))
			Me.diagramShape3.Appearance.BorderSize = 0
			Me.diagramShape3.Appearance.Font = New System.Drawing.Font("Tahoma", 14F)
			Me.diagramShape3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.diagramShape3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.diagramShape3.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "LastName"))
			Me.diagramShape3.CanCopy = False
			Me.diagramShape3.CanCopyWithoutParent = False
			Me.diagramShape3.CanEdit = False
			Me.diagramShape3.CanMove = False
			Me.diagramShape3.CanResize = False
			Me.diagramShape3.CanRotate = False
			Me.diagramShape3.CanSelect = False
			Me.diagramShape3.CanSnapToOtherItems = False
			Me.diagramShape3.CanSnapToThisItem = False
			Me.diagramShape3.Position = New DevExpress.Utils.PointFloat(168F, 126F)
			Me.diagramShape3.Size = New System.Drawing.SizeF(129F, 20F)
			Me.diagramShape3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Moderate5
			' 
			' diagramConnector1
			' 
			Me.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White
			Me.diagramConnector1.BeginPoint = New DevExpress.Utils.PointFloat(370F, 60F)
			Me.diagramConnector1.CanChangeRoute = False
			Me.diagramConnector1.CanDragBeginPoint = False
			Me.diagramConnector1.CanDragEndPoint = False
			Me.diagramConnector1.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.IndentedFilledArrow
			Me.diagramConnector1.EndArrowSize = New System.Drawing.SizeF(12F, 7F)
			Me.diagramConnector1.EndPoint = New DevExpress.Utils.PointFloat(460F, 150F)
			Me.diagramConnector1.Points = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat(){})
			Me.diagramConnector1.ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Intense5
			Me.diagramConnector1.Type = DevExpress.Diagram.Core.ConnectorType.Straight
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1009, 711)
			Me.Controls.Add(Me.diagramControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.diagramControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.diagramOrgChartController1.TemplateDiagram, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.diagramOrgChartController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private diagramControl1 As DevExpress.XtraDiagram.DiagramControl
		Private diagramOrgChartController1 As DevExpress.XtraDiagram.DiagramOrgChartController
		Private diagramContainer1 As DevExpress.XtraDiagram.DiagramContainer
		Private diagramImage1 As DevExpress.XtraDiagram.DiagramImage
		Private diagramShape1 As DevExpress.XtraDiagram.DiagramShape
		Private diagramShape2 As DevExpress.XtraDiagram.DiagramShape
		Private diagramShape3 As DevExpress.XtraDiagram.DiagramShape
		Private diagramConnector1 As DevExpress.XtraDiagram.DiagramConnector

	End Class
End Namespace

