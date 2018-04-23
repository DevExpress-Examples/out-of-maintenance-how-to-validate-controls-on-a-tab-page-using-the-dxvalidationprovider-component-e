Imports Microsoft.VisualBasic
Imports System
Namespace ValidatingTabs
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
			Me.label2 = New System.Windows.Forms.Label()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.label1 = New System.Windows.Forms.Label()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
			Me.xtraTabPage2.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(192, 56)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(100, 23)
			Me.label2.TabIndex = 3
			Me.label2.Text = "Must equal Today"
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.simpleButton1)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(369, 131)
			Me.xtraTabPage2.Text = "xtraTab&Page2"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(16, 32)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(296, 23)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Page 1 has been validated successfully"
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(16, 96)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(160, 23)
			Me.simpleButton3.TabIndex = 4
			Me.simpleButton3.Text = "Submit"
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(12, 178)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(168, 23)
			Me.simpleButton2.TabIndex = 3
			Me.simpleButton2.Text = "Focus holder"
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(192, 24)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(100, 23)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Must be > 10"
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.simpleButton3)
			Me.xtraTabPage1.Controls.Add(Me.label2)
			Me.xtraTabPage1.Controls.Add(Me.label1)
			Me.xtraTabPage1.Controls.Add(Me.dateEdit1)
			Me.xtraTabPage1.Controls.Add(Me.spinEdit1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(369, 131)
			Me.xtraTabPage1.Text = "xtra&TabPage1"
'			Me.xtraTabPage1.Validating += New System.ComponentModel.CancelEventHandler(Me.xtraTabPage1_Validating);
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = New System.DateTime(2005, 7, 8, 0, 0, 0, 0)
			Me.dateEdit1.Location = New System.Drawing.Point(16, 56)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(160, 20)
			Me.dateEdit1.TabIndex = 1
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 11, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(16, 21)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Size = New System.Drawing.Size(160, 20)
			Me.spinEdit1.TabIndex = 0
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Location = New System.Drawing.Point(12, 12)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(376, 160)
			Me.xtraTabControl1.TabIndex = 2
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(400, 216)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.xtraTabPage2.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private label2 As System.Windows.Forms.Label
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private label1 As System.Windows.Forms.Label
		Private WithEvents xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
	End Class
End Namespace