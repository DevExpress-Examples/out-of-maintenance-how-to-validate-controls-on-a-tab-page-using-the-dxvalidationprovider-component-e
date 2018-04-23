Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace ValidatingTabs
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xtraTabPage1_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles xtraTabPage1.Validating
			e.Cancel = Not dxValidationProvider1.Validate()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim SpinEditValidationRule As New ConditionValidationRule()
			SpinEditValidationRule.ConditionOperator = ConditionOperator.Greater
			SpinEditValidationRule.Value1 = 10
			SpinEditValidationRule.ErrorText = "Please enter a valid value to the spinEdit1"
			SpinEditValidationRule.ErrorType = ErrorType.Warning

			Dim DateEditValidationRule As New ConditionValidationRule()
			DateEditValidationRule.ConditionOperator = ConditionOperator.Equals
			DateEditValidationRule.Value1 = DateTime.Today
			DateEditValidationRule.ErrorText = "Please enter a valid value to the dateEdit1"
			DateEditValidationRule.ErrorType = ErrorType.Warning

			dxValidationProvider1.SetValidationRule(dateEdit1, DateEditValidationRule)
			dxValidationProvider1.SetValidationRule(spinEdit1, SpinEditValidationRule)
		End Sub
	End Class
End Namespace