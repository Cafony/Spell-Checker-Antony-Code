namespace Spell_Checker_Antony_Code
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
            this.buttonCheckText = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonClearHighlights = new System.Windows.Forms.Button();
            this.buttonCorrectAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonPT = new System.Windows.Forms.RadioButton();
            this.radioButtonEN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonCheckText
            // 
            this.buttonCheckText.Location = new System.Drawing.Point(69, 105);
            this.buttonCheckText.Name = "buttonCheckText";
            this.buttonCheckText.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckText.TabIndex = 0;
            this.buttonCheckText.Text = "Check Text";
            this.buttonCheckText.UseVisualStyleBackColor = true;
            this.buttonCheckText.Click += new System.EventHandler(this.buttonCheckText_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(69, 134);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(562, 274);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Dunas, são como divãs,\nBiombos indiscretos de alcatrão sujo\nRasgados por cactos e" +
    " hortelãs,\nDeitados nas Dunas, alheios a tudo,\nOlhos penetrantes,\nPensamentos la" +
    "vados.";
            // 
            // buttonClearHighlights
            // 
            this.buttonClearHighlights.Location = new System.Drawing.Point(175, 105);
            this.buttonClearHighlights.Name = "buttonClearHighlights";
            this.buttonClearHighlights.Size = new System.Drawing.Size(90, 23);
            this.buttonClearHighlights.TabIndex = 2;
            this.buttonClearHighlights.Text = "Clear Highlights";
            this.buttonClearHighlights.UseVisualStyleBackColor = true;
            this.buttonClearHighlights.Click += new System.EventHandler(this.buttonClearHighlights_Click);
            // 
            // buttonCorrectAll
            // 
            this.buttonCorrectAll.Location = new System.Drawing.Point(541, 105);
            this.buttonCorrectAll.Name = "buttonCorrectAll";
            this.buttonCorrectAll.Size = new System.Drawing.Size(90, 23);
            this.buttonCorrectAll.TabIndex = 3;
            this.buttonCorrectAll.Text = "Correct All";
            this.buttonCorrectAll.UseVisualStyleBackColor = true;
            this.buttonCorrectAll.Click += new System.EventHandler(this.buttonCorrectAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spell Check - Corrector Ortografico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Using HunSpell Library";
            // 
            // radioButtonPT
            // 
            this.radioButtonPT.AutoSize = true;
            this.radioButtonPT.Checked = true;
            this.radioButtonPT.Location = new System.Drawing.Point(666, 151);
            this.radioButtonPT.Name = "radioButtonPT";
            this.radioButtonPT.Size = new System.Drawing.Size(102, 17);
            this.radioButtonPT.TabIndex = 6;
            this.radioButtonPT.TabStop = true;
            this.radioButtonPT.Text = "Portuguese - PT";
            this.radioButtonPT.UseVisualStyleBackColor = true;
            this.radioButtonPT.CheckedChanged += new System.EventHandler(this.radioButtonPT_CheckedChanged);
            // 
            // radioButtonEN
            // 
            this.radioButtonEN.AutoSize = true;
            this.radioButtonEN.Location = new System.Drawing.Point(666, 174);
            this.radioButtonEN.Name = "radioButtonEN";
            this.radioButtonEN.Size = new System.Drawing.Size(83, 17);
            this.radioButtonEN.TabIndex = 7;
            this.radioButtonEN.Text = "English - EN";
            this.radioButtonEN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonEN);
            this.Controls.Add(this.radioButtonPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCorrectAll);
            this.Controls.Add(this.buttonClearHighlights);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonCheckText);
            this.Name = "Form1";
            this.Text = "Check Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckText;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonClearHighlights;
        private System.Windows.Forms.Button buttonCorrectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonPT;
        private System.Windows.Forms.RadioButton radioButtonEN;
    }
}

