namespace Converso
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
            this.components = new System.ComponentModel.Container();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.cmbModeSelect = new System.Windows.Forms.ComboBox();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.btnCallAPI = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkTimer1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(430, 12);
            this.txtBoxInput.Multiline = true;
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxInput.Size = new System.Drawing.Size(669, 280);
            this.txtBoxInput.TabIndex = 1;
            this.txtBoxInput.TextChanged += new System.EventHandler(this.txtBoxInput_TextChanged);
            // 
            // cmbModeSelect
            // 
            this.cmbModeSelect.FormattingEnabled = true;
            this.cmbModeSelect.Items.AddRange(new object[] {
            "Keep Input",
            "Erase Input"});
            this.cmbModeSelect.Location = new System.Drawing.Point(195, 194);
            this.cmbModeSelect.Name = "cmbModeSelect";
            this.cmbModeSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbModeSelect.TabIndex = 2;
            this.cmbModeSelect.SelectedIndexChanged += new System.EventHandler(this.cmbModeSelect_SelectedIndexChanged);
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Location = new System.Drawing.Point(430, 418);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxOutput.Size = new System.Drawing.Size(669, 280);
            this.txtBoxOutput.TabIndex = 3;
            this.txtBoxOutput.TextChanged += new System.EventHandler(this.txtBoxOutput_TextChanged);
            // 
            // btnCallAPI
            // 
            this.btnCallAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallAPI.Location = new System.Drawing.Point(195, 418);
            this.btnCallAPI.Name = "btnCallAPI";
            this.btnCallAPI.Size = new System.Drawing.Size(121, 70);
            this.btnCallAPI.TabIndex = 4;
            this.btnCallAPI.Text = "Call API";
            this.btnCallAPI.UseVisualStyleBackColor = true;
            this.btnCallAPI.Click += new System.EventHandler(this.btnCallAPI_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkTimer1
            // 
            this.checkTimer1.AutoSize = true;
            this.checkTimer1.Location = new System.Drawing.Point(195, 235);
            this.checkTimer1.Name = "checkTimer1";
            this.checkTimer1.Size = new System.Drawing.Size(88, 17);
            this.checkTimer1.TabIndex = 5;
            this.checkTimer1.Text = "Auto Call API";
            this.checkTimer1.UseVisualStyleBackColor = true;
            this.checkTimer1.CheckedChanged += new System.EventHandler(this.checkTimer1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 710);
            this.Controls.Add(this.checkTimer1);
            this.Controls.Add(this.btnCallAPI);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.cmbModeSelect);
            this.Controls.Add(this.txtBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.ComboBox cmbModeSelect;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Button btnCallAPI;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkTimer1;
    }
}

