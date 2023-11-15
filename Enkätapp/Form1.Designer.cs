namespace Enkätapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelQ1 = new Label();
            labelQ2 = new Label();
            labelQ3 = new Label();
            labelQ4 = new Label();
            numericQ1 = new NumericUpDown();
            numericQ2 = new NumericUpDown();
            numericQ3 = new NumericUpDown();
            numericQ4 = new NumericUpDown();
            createSurveryButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numericQ1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQ2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQ3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQ4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(156, 40);
            label1.Name = "label1";
            label1.Size = new Size(447, 30);
            label1.TabIndex = 0;
            label1.Text = "Välj hur många frågor som ska ingå i enkäten";
            // 
            // labelQ1
            // 
            labelQ1.AutoSize = true;
            labelQ1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelQ1.Location = new Point(162, 104);
            labelQ1.Name = "labelQ1";
            labelQ1.Size = new Size(68, 21);
            labelQ1.TabIndex = 1;
            labelQ1.Text = "Kortsvar";
            // 
            // labelQ2
            // 
            labelQ2.AutoSize = true;
            labelQ2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelQ2.Location = new Point(162, 135);
            labelQ2.Name = "labelQ2";
            labelQ2.Size = new Size(73, 21);
            labelQ2.TabIndex = 1;
            labelQ2.Text = "Långsvar";
            // 
            // labelQ3
            // 
            labelQ3.AutoSize = true;
            labelQ3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelQ3.Location = new Point(162, 165);
            labelQ3.Name = "labelQ3";
            labelQ3.Size = new Size(54, 21);
            labelQ3.TabIndex = 1;
            labelQ3.Text = "Ja/Nej";
            // 
            // labelQ4
            // 
            labelQ4.AutoSize = true;
            labelQ4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelQ4.Location = new Point(162, 199);
            labelQ4.Name = "labelQ4";
            labelQ4.Size = new Size(84, 21);
            labelQ4.TabIndex = 1;
            labelQ4.Text = "Flerval 1-5";
            // 
            // numericQ1
            // 
            numericQ1.Location = new Point(270, 104);
            numericQ1.Name = "numericQ1";
            numericQ1.Size = new Size(37, 23);
            numericQ1.TabIndex = 2;
            // 
            // numericQ2
            // 
            numericQ2.Location = new Point(270, 135);
            numericQ2.Name = "numericQ2";
            numericQ2.Size = new Size(37, 23);
            numericQ2.TabIndex = 2;
            // 
            // numericQ3
            // 
            numericQ3.Location = new Point(270, 165);
            numericQ3.Name = "numericQ3";
            numericQ3.Size = new Size(37, 23);
            numericQ3.TabIndex = 2;
            // 
            // numericQ4
            // 
            numericQ4.Location = new Point(270, 199);
            numericQ4.Name = "numericQ4";
            numericQ4.Size = new Size(37, 23);
            numericQ4.TabIndex = 2;
            // 
            // createSurveryButton
            // 
            createSurveryButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createSurveryButton.Location = new Point(200, 237);
            createSurveryButton.Name = "createSurveryButton";
            createSurveryButton.Size = new Size(107, 56);
            createSurveryButton.TabIndex = 3;
            createSurveryButton.Text = "Generera frågor";
            createSurveryButton.UseVisualStyleBackColor = true;
            createSurveryButton.Click += createSurveryButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(474, 176);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(createSurveryButton);
            Controls.Add(numericQ4);
            Controls.Add(numericQ3);
            Controls.Add(numericQ2);
            Controls.Add(numericQ1);
            Controls.Add(labelQ4);
            Controls.Add(labelQ3);
            Controls.Add(labelQ2);
            Controls.Add(labelQ1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericQ1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQ2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQ3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQ4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelQ1;
        private Label labelQ2;
        private Label labelQ3;
        private Label labelQ4;
        private NumericUpDown numericQ1;
        private NumericUpDown numericQ2;
        private NumericUpDown numericQ3;
        private NumericUpDown numericQ4;
        private Button createSurveryButton;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}