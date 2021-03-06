﻿using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace MeaData.Util.Controls {
    
    public class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;

        public CalendarEditingControl() {
            this.Format = DateTimePickerFormat.Short;
        }

        // Implements the IDataGridViewEditingControl.EditingControlFormattedValue property.
        [Browsable(true)]
        public object EditingControlFormattedValue {
            get { return this.Value.ToShortDateString(); }
            set {
                if (value is String)
                    this.Value = DateTime.Parse((String)value);
            }
        }

        // Implements the IDataGridViewEditingControl.GetEditingControlFormattedValue method.
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context) {
            return EditingControlFormattedValue;
        }

        // Implements the IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle) {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        // Implements the IDataGridViewEditingControl.EditingControlRowIndex property.
        [Browsable(true)]
        public int EditingControlRowIndex {
            get { return rowIndex; }
            set { rowIndex = value; }
        }

        // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey method.
        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey) {
            // Let the DateTimePicker handle the keys listed.
            switch (key & Keys.KeyCode) {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return false;
            }
        }

        // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit method.
        public void PrepareEditingControlForEdit(bool selectAll) {
            // No preparation needs to be done.
        }

        // Implements the IDataGridViewEditingControl.RepositionEditingControlOnValueChange property.
        [Browsable(true)]
        public bool RepositionEditingControlOnValueChange {
            get { return false; }
        }

        // Implements the IDataGridViewEditingControl.EditingControlDataGridView property.
        [Browsable(true)]
        public DataGridView EditingControlDataGridView {
            get { return dataGridView; }
            set { dataGridView = value; }
        }

        // Implements the IDataGridViewEditingControl.EditingControlValueChanged property.
        [Browsable(true)]
        public bool EditingControlValueChanged {
            get { return valueChanged; }
            set { valueChanged = value; }
        }

        // Implements the IDataGridViewEditingControl.EditingPanelCursor property.
        [Browsable(true)]
        public Cursor EditingPanelCursor {
            get { return base.Cursor; }
        }

        protected override void OnValueChanged(EventArgs eventargs) {
            // Notify the DataGridView that the contents of the cell have changed.
            valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }

}