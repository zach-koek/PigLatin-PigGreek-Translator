
namespace Translator
{
    partial class frmTranslator
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
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtbxOutput = new System.Windows.Forms.TextBox();
            this.txtbxInput = new System.Windows.Forms.TextBox();
            this.rdbtnPigGreek = new System.Windows.Forms.RadioButton();
            this.rdbtnPigLatin = new System.Windows.Forms.RadioButton();
            this.lbllangTrans = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(15, 415);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(96, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(287, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtbxOutput
            // 
            this.txtbxOutput.Location = new System.Drawing.Point(12, 262);
            this.txtbxOutput.Multiline = true;
            this.txtbxOutput.Name = "txtbxOutput";
            this.txtbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxOutput.Size = new System.Drawing.Size(350, 147);
            this.txtbxOutput.TabIndex = 2;
            // 
            // txtbxInput
            // 
            this.txtbxInput.Location = new System.Drawing.Point(15, 36);
            this.txtbxInput.Multiline = true;
            this.txtbxInput.Name = "txtbxInput";
            this.txtbxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxInput.Size = new System.Drawing.Size(347, 135);
            this.txtbxInput.TabIndex = 3;
            // 
            // rdbtnPigGreek
            // 
            this.rdbtnPigGreek.AutoSize = true;
            this.rdbtnPigGreek.Location = new System.Drawing.Point(139, 196);
            this.rdbtnPigGreek.Name = "rdbtnPigGreek";
            this.rdbtnPigGreek.Size = new System.Drawing.Size(75, 19);
            this.rdbtnPigGreek.TabIndex = 4;
            this.rdbtnPigGreek.TabStop = true;
            this.rdbtnPigGreek.Tag = "greek";
            this.rdbtnPigGreek.Text = "Pig Greek";
            this.rdbtnPigGreek.UseVisualStyleBackColor = true;
            this.rdbtnPigGreek.CheckedChanged += new System.EventHandler(this.rdbtnPigGreek_CheckedChanged);
            // 
            // rdbtnPigLatin
            // 
            this.rdbtnPigLatin.AutoSize = true;
            this.rdbtnPigLatin.Location = new System.Drawing.Point(15, 196);
            this.rdbtnPigLatin.Name = "rdbtnPigLatin";
            this.rdbtnPigLatin.Size = new System.Drawing.Size(71, 19);
            this.rdbtnPigLatin.TabIndex = 5;
            this.rdbtnPigLatin.TabStop = true;
            this.rdbtnPigLatin.Tag = "latin";
            this.rdbtnPigLatin.Text = "Pig Latin";
            this.rdbtnPigLatin.UseVisualStyleBackColor = true;
            this.rdbtnPigLatin.CheckedChanged += new System.EventHandler(this.rdbtnPigLatin_CheckedChanged);
            // 
            // lbllangTrans
            // 
            this.lbllangTrans.AutoSize = true;
            this.lbllangTrans.Location = new System.Drawing.Point(23, 244);
            this.lbllangTrans.Name = "lbllangTrans";
            this.lbllangTrans.Size = new System.Drawing.Size(67, 15);
            this.lbllangTrans.TabIndex = 6;
            this.lbllangTrans.Text = "Translation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter English text here:";
            // 
            // frmTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbllangTrans);
            this.Controls.Add(this.rdbtnPigLatin);
            this.Controls.Add(this.rdbtnPigGreek);
            this.Controls.Add(this.txtbxOutput);
            this.Controls.Add(this.txtbxInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTranslate);
            this.Name = "frmTranslator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtbxOutput;
        private System.Windows.Forms.TextBox txtbxInput;
        private System.Windows.Forms.RadioButton rdbtnPigGreek;
        private System.Windows.Forms.RadioButton rdbtnPigLatin;
        private System.Windows.Forms.Label lbllangTrans;
        private System.Windows.Forms.Label label2;
    }
}

