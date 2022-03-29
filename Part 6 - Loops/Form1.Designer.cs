namespace Part_6___Loops
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
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtNumberInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblNumberInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(150, 80);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 0;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(150, 26);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 1;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(19, 29);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(125, 13);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Enter a Minimum Number";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(16, 83);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(128, 13);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Enter a Maximum Number";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(69, 186);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(130, 23);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Press To Enter";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtNumberInput
            // 
            this.txtNumberInput.Location = new System.Drawing.Point(150, 136);
            this.txtNumberInput.Name = "txtNumberInput";
            this.txtNumberInput.Size = new System.Drawing.Size(100, 20);
            this.txtNumberInput.TabIndex = 5;
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(289, 26);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(197, 201);
            this.lblOutput.TabIndex = 6;
            // 
            // lblNumberInput
            // 
            this.lblNumberInput.Location = new System.Drawing.Point(9, 130);
            this.lblNumberInput.Name = "lblNumberInput";
            this.lblNumberInput.Size = new System.Drawing.Size(132, 33);
            this.lblNumberInput.TabIndex = 7;
            this.lblNumberInput.Text = "Enter a Number Between Your Min and Max";
            this.lblNumberInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 253);
            this.Controls.Add(this.lblNumberInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtNumberInput);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtNumberInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblNumberInput;
    }
}

