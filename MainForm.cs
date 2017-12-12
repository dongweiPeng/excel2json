﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excel2json {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            //-- componet init states
            this.comboBoxType.SelectedIndex = 0;
            this.comboBoxLowcase.SelectedIndex = 1;
            this.comboBoxHeader.SelectedIndex = 1;

            this.comboBoxEncoding.Items.Clear();
            foreach (EncodingInfo ei in Encoding.GetEncodings()) {
                Encoding e = ei.GetEncoding();
                this.comboBoxEncoding.Items.Add(e.EncodingName);
                System.Diagnostics.Debug.Print(e.EncodingName);
            }
            this.comboBoxEncoding.SelectedIndex = this.comboBoxEncoding.Items.Count - 1;
        }

        private void panelExcelDropBox_DragDrop(object sender, DragEventArgs e) {

        }

        private void btnHelp_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://neil3d.github.io");
        }
    }
}