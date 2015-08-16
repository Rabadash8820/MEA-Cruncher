﻿using System;
using System.Windows.Forms;
using MEACruncher.Forms;

namespace MEACruncher.Forms {

    internal partial class MainMenuForm : Form {
        public MainMenuForm() {
            InitializeComponent();
        }

        private void ExitAppButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void LoadProjectButton_Click(object sender, EventArgs e) {
            ViewProjectsForm form = new ViewProjectsForm();
            form.ShowDialog();
        }
    }

}