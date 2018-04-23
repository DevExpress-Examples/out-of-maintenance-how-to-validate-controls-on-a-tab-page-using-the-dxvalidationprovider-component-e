using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.DXErrorProvider;

namespace ValidatingTabs {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void xtraTabPage1_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !dxValidationProvider1.Validate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConditionValidationRule SpinEditValidationRule = new ConditionValidationRule();
            SpinEditValidationRule.ConditionOperator = ConditionOperator.Greater;
            SpinEditValidationRule.Value1 = 10;
            SpinEditValidationRule.ErrorText = "Please enter a valid value to the spinEdit1";
            SpinEditValidationRule.ErrorType = ErrorType.Warning;

            ConditionValidationRule DateEditValidationRule = new ConditionValidationRule();
            DateEditValidationRule.ConditionOperator = ConditionOperator.Equals;
            DateEditValidationRule.Value1 = DateTime.Today;
            DateEditValidationRule.ErrorText = "Please enter a valid value to the dateEdit1";
            DateEditValidationRule.ErrorType = ErrorType.Warning;

            dxValidationProvider1.SetValidationRule(dateEdit1, DateEditValidationRule);
            dxValidationProvider1.SetValidationRule(spinEdit1, SpinEditValidationRule);
        }
    }
}