namespace JoesAutomotive_Tomlinson
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oilLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.flushesGroupBox = new System.Windows.Forms.GroupBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.mufflerCheckbox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.partsLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totaloutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.partsOutputLabel = new System.Windows.Forms.Label();
            this.servicesOutputLabel = new System.Windows.Forms.Label();
            this.totalSumaryLabel = new System.Windows.Forms.Label();
            this.taxSummaryLabel = new System.Windows.Forms.Label();
            this.partsSummaryLabel = new System.Windows.Forms.Label();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilLubeGroupBox.SuspendLayout();
            this.flushesGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsLaborGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilLubeGroupBox
            // 
            this.oilLubeGroupBox.Controls.Add(this.lubeJobCheckBox);
            this.oilLubeGroupBox.Controls.Add(this.oilChangeCheckBox);
            this.oilLubeGroupBox.Location = new System.Drawing.Point(28, 12);
            this.oilLubeGroupBox.Name = "oilLubeGroupBox";
            this.oilLubeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.oilLubeGroupBox.TabIndex = 0;
            this.oilLubeGroupBox.TabStop = false;
            this.oilLubeGroupBox.Text = "Oil & Lube";
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(24, 69);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(112, 17);
            this.lubeJobCheckBox.TabIndex = 1;
            this.lubeJobCheckBox.Text = "Lube Job ($18.00)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(24, 36);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(120, 17);
            this.oilChangeCheckBox.TabIndex = 0;
            this.oilChangeCheckBox.Text = "Oil Change ($26.00)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // flushesGroupBox
            // 
            this.flushesGroupBox.Controls.Add(this.transmissionFlushCheckBox);
            this.flushesGroupBox.Controls.Add(this.radiatorFlushCheckBox);
            this.flushesGroupBox.Location = new System.Drawing.Point(295, 12);
            this.flushesGroupBox.Name = "flushesGroupBox";
            this.flushesGroupBox.Size = new System.Drawing.Size(200, 100);
            this.flushesGroupBox.TabIndex = 1;
            this.flushesGroupBox.TabStop = false;
            this.flushesGroupBox.Text = "Flushes";
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(6, 69);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(157, 17);
            this.transmissionFlushCheckBox.TabIndex = 1;
            this.transmissionFlushCheckBox.Text = "Transmission Flush ($80.00)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushCheckBox
            // 
            this.radiatorFlushCheckBox.AutoSize = true;
            this.radiatorFlushCheckBox.Location = new System.Drawing.Point(8, 36);
            this.radiatorFlushCheckBox.Name = "radiatorFlushCheckBox";
            this.radiatorFlushCheckBox.Size = new System.Drawing.Size(136, 17);
            this.radiatorFlushCheckBox.TabIndex = 0;
            this.radiatorFlushCheckBox.Text = "Radiator Flush ($30.00)";
            this.radiatorFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tireRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.mufflerCheckbox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(28, 125);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(200, 121);
            this.miscGroupBox.TabIndex = 0;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(24, 85);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(87, 30);
            this.tireRotationCheckBox.TabIndex = 2;
            this.tireRotationCheckBox.Text = "Tire Rotation\r\n($20.00)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // mufflerCheckbox
            // 
            this.mufflerCheckbox.AutoSize = true;
            this.mufflerCheckbox.Location = new System.Drawing.Point(24, 49);
            this.mufflerCheckbox.Name = "mufflerCheckbox";
            this.mufflerCheckbox.Size = new System.Drawing.Size(102, 30);
            this.mufflerCheckbox.TabIndex = 1;
            this.mufflerCheckbox.Text = "Replace Muffer \r\n($100.00)";
            this.mufflerCheckbox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(24, 19);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(117, 17);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection ($15.00)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsLaborGroupBox
            // 
            this.partsLaborGroupBox.Controls.Add(this.laborTextBox);
            this.partsLaborGroupBox.Controls.Add(this.partsTextBox);
            this.partsLaborGroupBox.Controls.Add(this.laborLabel);
            this.partsLaborGroupBox.Controls.Add(this.partsLabel);
            this.partsLaborGroupBox.Location = new System.Drawing.Point(295, 125);
            this.partsLaborGroupBox.Name = "partsLaborGroupBox";
            this.partsLaborGroupBox.Size = new System.Drawing.Size(200, 121);
            this.partsLaborGroupBox.TabIndex = 0;
            this.partsLaborGroupBox.TabStop = false;
            this.partsLaborGroupBox.Text = "Parts and Labor";
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(82, 85);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(63, 20);
            this.laborTextBox.TabIndex = 3;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(81, 31);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(64, 20);
            this.partsTextBox.TabIndex = 2;
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(28, 88);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(34, 13);
            this.laborLabel.TabIndex = 1;
            this.laborLabel.Text = "Labor";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(28, 34);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(34, 13);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts ";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totaloutputLabel);
            this.summaryGroupBox.Controls.Add(this.taxOutputLabel);
            this.summaryGroupBox.Controls.Add(this.partsOutputLabel);
            this.summaryGroupBox.Controls.Add(this.servicesOutputLabel);
            this.summaryGroupBox.Controls.Add(this.totalSumaryLabel);
            this.summaryGroupBox.Controls.Add(this.taxSummaryLabel);
            this.summaryGroupBox.Controls.Add(this.partsSummaryLabel);
            this.summaryGroupBox.Controls.Add(this.servicesLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(28, 252);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(467, 149);
            this.summaryGroupBox.TabIndex = 0;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary ";
            // 
            // totaloutputLabel
            // 
            this.totaloutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totaloutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaloutputLabel.Location = new System.Drawing.Point(194, 123);
            this.totaloutputLabel.Name = "totaloutputLabel";
            this.totaloutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totaloutputLabel.TabIndex = 7;
            this.totaloutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutputLabel.Location = new System.Drawing.Point(194, 89);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.taxOutputLabel.TabIndex = 6;
            this.taxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // partsOutputLabel
            // 
            this.partsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsOutputLabel.Location = new System.Drawing.Point(194, 50);
            this.partsOutputLabel.Name = "partsOutputLabel";
            this.partsOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.partsOutputLabel.TabIndex = 5;
            this.partsOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // servicesOutputLabel
            // 
            this.servicesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servicesOutputLabel.Location = new System.Drawing.Point(194, 16);
            this.servicesOutputLabel.Name = "servicesOutputLabel";
            this.servicesOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.servicesOutputLabel.TabIndex = 4;
            this.servicesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalSumaryLabel
            // 
            this.totalSumaryLabel.AutoSize = true;
            this.totalSumaryLabel.Location = new System.Drawing.Point(84, 124);
            this.totalSumaryLabel.Name = "totalSumaryLabel";
            this.totalSumaryLabel.Size = new System.Drawing.Size(57, 13);
            this.totalSumaryLabel.TabIndex = 3;
            this.totalSumaryLabel.Text = "Total Fees";
            // 
            // taxSummaryLabel
            // 
            this.taxSummaryLabel.AutoSize = true;
            this.taxSummaryLabel.Location = new System.Drawing.Point(72, 90);
            this.taxSummaryLabel.Name = "taxSummaryLabel";
            this.taxSummaryLabel.Size = new System.Drawing.Size(72, 13);
            this.taxSummaryLabel.TabIndex = 2;
            this.taxSummaryLabel.Text = "Tax (on parts)";
            // 
            // partsSummaryLabel
            // 
            this.partsSummaryLabel.AutoSize = true;
            this.partsSummaryLabel.Location = new System.Drawing.Point(110, 51);
            this.partsSummaryLabel.Name = "partsSummaryLabel";
            this.partsSummaryLabel.Size = new System.Drawing.Size(31, 13);
            this.partsSummaryLabel.TabIndex = 1;
            this.partsSummaryLabel.Text = "Parts";
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Location = new System.Drawing.Point(42, 17);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(99, 13);
            this.servicesLabel.TabIndex = 0;
            this.servicesLabel.Text = "Services and Labor";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(28, 443);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(95, 50);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(222, 443);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 50);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(400, 443);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(531, 521);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.partsLaborGroupBox);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.flushesGroupBox);
            this.Controls.Add(this.oilLubeGroupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joe\'s Automotive";
            this.oilLubeGroupBox.ResumeLayout(false);
            this.oilLubeGroupBox.PerformLayout();
            this.flushesGroupBox.ResumeLayout(false);
            this.flushesGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsLaborGroupBox.ResumeLayout(false);
            this.partsLaborGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilLubeGroupBox;
        private System.Windows.Forms.GroupBox flushesGroupBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.GroupBox partsLaborGroupBox;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox radiatorFlushCheckBox;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox mufflerCheckbox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label totaloutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label partsOutputLabel;
        private System.Windows.Forms.Label servicesOutputLabel;
        private System.Windows.Forms.Label totalSumaryLabel;
        private System.Windows.Forms.Label taxSummaryLabel;
        private System.Windows.Forms.Label partsSummaryLabel;
        private System.Windows.Forms.Label servicesLabel;
    }
}

