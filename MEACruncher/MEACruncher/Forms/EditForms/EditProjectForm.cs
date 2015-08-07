﻿using MeaData;
using MEACruncher.Events;
using MEACruncher.Properties;
using MEACruncher.Forms;

using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace MEACruncher.Forms {

    internal partial class EditProjectForm : EditEntityForm {
        // CONSTRUCTORS
        public EditProjectForm() : base() {
            InitializeComponent();
        }

        // EVENT HANDLERS
        private void UpdateButton_Click(object sender, EventArgs e) {
            this.updateEntity();
            this.closeStuff();
        }
        private void UndoButton_Click(object sender, EventArgs e) {
            this.MementoManager.Undo();
            this.manageUndoRedo();
        }
        private void RedoButton_Click(object sender, EventArgs e) {
            this.MementoManager.Redo();
            this.manageUndoRedo();
        }
        private void UndoButton_EnabledChanged(object sender, EventArgs e) {

        }
        private void RedoButton_EnabledChanged(object sender, EventArgs e) {

        }

        // FUNCTIONS
        protected override void buildForm() {
            base.buildForm();

            // Add application settings
            RowStyle lastRow = MainTableLayout.RowStyles[MainTableLayout.RowStyles.Count - 1];
            lastRow.Height = Settings.Default.ContainerHeight;
            TitleTextbox.Height = Settings.Default.ControlHeight;
            DateStartedDateTimePicker.Height = Settings.Default.ControlHeight;

            // Add data bindings
            TitleTextbox.DataBindings.Add("Text", this.BoundEntity, propertyName((Project e) => e.Name));
            DateStartedDateTimePicker.DataBindings.Add("Value", this.BoundEntity, propertyName((Project e) => e.DateStarted));
            CommentsTextbox.DataBindings.Add("Text", this.BoundEntity, propertyName((Project e) => e.Comments));

            // Remaining formats...
            DateStartedDateTimePicker.MaxDate = DateTime.Today;
            this.manageUndoRedo();
        }
        protected override void manageUndoRedo() {
            base.manageUndoRedo();

            // Enable/disable the undo/redo buttons and set their tooltip text accordingly
            UndoButton.Enabled = this.MementoManager.CanUndo;
            RedoButton.Enabled = this.MementoManager.CanRedo;
            MainToolTip.SetToolTip(UndoButton, this.MementoManager.TopUndoMessage);
            MainToolTip.SetToolTip(RedoButton, this.MementoManager.TopRedoMessage);
        }

    }

}