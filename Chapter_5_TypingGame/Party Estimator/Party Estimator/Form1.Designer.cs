namespace Party_Estimator
{
    partial class formPartyPlanner
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
            this.peopleCounter = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDecoration = new System.Windows.Forms.CheckBox();
            this.checkBoxOption = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.costText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.peopleCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleCounter
            // 
            this.peopleCounter.Location = new System.Drawing.Point(25, 42);
            this.peopleCounter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.peopleCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.peopleCounter.Name = "peopleCounter";
            this.peopleCounter.Size = new System.Drawing.Size(120, 20);
            this.peopleCounter.TabIndex = 0;
            this.peopleCounter.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.peopleCounter.ValueChanged += new System.EventHandler(this.peopleCounter_ValueChanged);
            // 
            // checkBoxDecoration
            // 
            this.checkBoxDecoration.AutoSize = true;
            this.checkBoxDecoration.Location = new System.Drawing.Point(25, 95);
            this.checkBoxDecoration.Name = "checkBoxDecoration";
            this.checkBoxDecoration.Size = new System.Drawing.Size(115, 17);
            this.checkBoxDecoration.TabIndex = 1;
            this.checkBoxDecoration.Text = "Fancy Decorations";
            this.checkBoxDecoration.UseVisualStyleBackColor = true;
            this.checkBoxDecoration.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxOption
            // 
            this.checkBoxOption.AutoSize = true;
            this.checkBoxOption.Location = new System.Drawing.Point(25, 136);
            this.checkBoxOption.Name = "checkBoxOption";
            this.checkBoxOption.Size = new System.Drawing.Size(96, 17);
            this.checkBoxOption.TabIndex = 2;
            this.checkBoxOption.Text = "Healthy Option";
            this.checkBoxOption.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of People";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(50, 210);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(32, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost";
            this.costLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // costText
            // 
            this.costText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.costText.Location = new System.Drawing.Point(91, 207);
            this.costText.Name = "costText";
            this.costText.ReadOnly = true;
            this.costText.Size = new System.Drawing.Size(100, 24);
            this.costText.TabIndex = 5;
            // 
            // formPartyPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.costText);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxOption);
            this.Controls.Add(this.checkBoxDecoration);
            this.Controls.Add(this.peopleCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "formPartyPlanner";
            this.Text = "Party Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown peopleCounter;
        private System.Windows.Forms.CheckBox checkBoxDecoration;
        private System.Windows.Forms.CheckBox checkBoxOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox costText;
    }
}

