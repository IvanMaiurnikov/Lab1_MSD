
namespace GUI_lab1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonShaker = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertion = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.radioButtonAssorted = new System.Windows.Forms.RadioButton();
            this.textBoxAssorted = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonGenerateArr = new System.Windows.Forms.Button();
            this.maskedTextBoxNumElements = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxStatMsgs = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxSortedArray = new System.Windows.Forms.GroupBox();
            this.textBoxSortedArray = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxStartVal = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxEndVal = new System.Windows.Forms.MaskedTextBox();
            this.buttonSorting = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxStatMsgs.SuspendLayout();
            this.groupBoxSortedArray.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonShaker);
            this.groupBox1.Controls.Add(this.radioButtonInsertion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод сортування";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonShaker
            // 
            this.radioButtonShaker.AutoSize = true;
            this.radioButtonShaker.Location = new System.Drawing.Point(19, 65);
            this.radioButtonShaker.Name = "radioButtonShaker";
            this.radioButtonShaker.Size = new System.Drawing.Size(79, 21);
            this.radioButtonShaker.TabIndex = 2;
            this.radioButtonShaker.TabStop = true;
            this.radioButtonShaker.Text = "Шейкер";
            this.radioButtonShaker.UseVisualStyleBackColor = true;
            this.radioButtonShaker.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonInsertion
            // 
            this.radioButtonInsertion.AutoSize = true;
            this.radioButtonInsertion.Location = new System.Drawing.Point(19, 37);
            this.radioButtonInsertion.Name = "radioButtonInsertion";
            this.radioButtonInsertion.Size = new System.Drawing.Size(82, 21);
            this.radioButtonInsertion.TabIndex = 1;
            this.radioButtonInsertion.TabStop = true;
            this.radioButtonInsertion.Text = "Вставка";
            this.radioButtonInsertion.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDesc);
            this.groupBox2.Controls.Add(this.radioButtonAsc);
            this.groupBox2.Controls.Add(this.radioButtonAssorted);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Якість масиву";
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.Location = new System.Drawing.Point(19, 90);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(106, 21);
            this.radioButtonDesc.TabIndex = 2;
            this.radioButtonDesc.TabStop = true;
            this.radioButtonDesc.Text = "Зменшення";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Location = new System.Drawing.Point(19, 62);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(107, 21);
            this.radioButtonAsc.TabIndex = 1;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "Збільшення";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            // 
            // radioButtonAssorted
            // 
            this.radioButtonAssorted.AutoSize = true;
            this.radioButtonAssorted.Location = new System.Drawing.Point(19, 34);
            this.radioButtonAssorted.Name = "radioButtonAssorted";
            this.radioButtonAssorted.Size = new System.Drawing.Size(128, 21);
            this.radioButtonAssorted.TabIndex = 0;
            this.radioButtonAssorted.TabStop = true;
            this.radioButtonAssorted.Text = "Не сортований";
            this.radioButtonAssorted.UseVisualStyleBackColor = true;
            // 
            // textBoxAssorted
            // 
            this.textBoxAssorted.Location = new System.Drawing.Point(6, 23);
            this.textBoxAssorted.Multiline = true;
            this.textBoxAssorted.Name = "textBoxAssorted";
            this.textBoxAssorted.Size = new System.Drawing.Size(551, 80);
            this.textBoxAssorted.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxAssorted);
            this.groupBox3.Location = new System.Drawing.Point(276, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 109);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Несортований масив";
            // 
            // buttonGenerateArr
            // 
            this.buttonGenerateArr.Location = new System.Drawing.Point(12, 365);
            this.buttonGenerateArr.Name = "buttonGenerateArr";
            this.buttonGenerateArr.Size = new System.Drawing.Size(258, 28);
            this.buttonGenerateArr.TabIndex = 4;
            this.buttonGenerateArr.Text = "Генерувати масив";
            this.buttonGenerateArr.UseVisualStyleBackColor = true;
            this.buttonGenerateArr.Click += new System.EventHandler(this.buttonGenerateArr_Click);
            // 
            // maskedTextBoxNumElements
            // 
            this.maskedTextBoxNumElements.Location = new System.Drawing.Point(241, 275);
            this.maskedTextBoxNumElements.Mask = "000";
            this.maskedTextBoxNumElements.Name = "maskedTextBoxNumElements";
            this.maskedTextBoxNumElements.Size = new System.Drawing.Size(29, 22);
            this.maskedTextBoxNumElements.TabIndex = 5;
            this.maskedTextBoxNumElements.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Число елементів масиву:";
            // 
            // groupBoxStatMsgs
            // 
            this.groupBoxStatMsgs.Controls.Add(this.textBox1);
            this.groupBoxStatMsgs.Location = new System.Drawing.Point(276, 137);
            this.groupBoxStatMsgs.Name = "groupBoxStatMsgs";
            this.groupBoxStatMsgs.Size = new System.Drawing.Size(557, 197);
            this.groupBoxStatMsgs.TabIndex = 7;
            this.groupBoxStatMsgs.TabStop = false;
            this.groupBoxStatMsgs.Text = "Хід сортировки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 170);
            this.textBox1.TabIndex = 0;
            // 
            // groupBoxSortedArray
            // 
            this.groupBoxSortedArray.Controls.Add(this.textBoxSortedArray);
            this.groupBoxSortedArray.Location = new System.Drawing.Point(276, 340);
            this.groupBoxSortedArray.Name = "groupBoxSortedArray";
            this.groupBoxSortedArray.Size = new System.Drawing.Size(551, 98);
            this.groupBoxSortedArray.TabIndex = 8;
            this.groupBoxSortedArray.TabStop = false;
            this.groupBoxSortedArray.Text = "Сортований масив:";
            // 
            // textBoxSortedArray
            // 
            this.textBoxSortedArray.Location = new System.Drawing.Point(6, 21);
            this.textBoxSortedArray.Multiline = true;
            this.textBoxSortedArray.Name = "textBoxSortedArray";
            this.textBoxSortedArray.Size = new System.Drawing.Size(539, 71);
            this.textBoxSortedArray.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Початкове значення:";
            // 
            // maskedTextBoxStartVal
            // 
            this.maskedTextBoxStartVal.Location = new System.Drawing.Point(241, 308);
            this.maskedTextBoxStartVal.Mask = "000";
            this.maskedTextBoxStartVal.Name = "maskedTextBoxStartVal";
            this.maskedTextBoxStartVal.Size = new System.Drawing.Size(29, 22);
            this.maskedTextBoxStartVal.TabIndex = 9;
            this.maskedTextBoxStartVal.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Кінцеве значення:";
            // 
            // maskedTextBoxEndVal
            // 
            this.maskedTextBoxEndVal.Location = new System.Drawing.Point(241, 337);
            this.maskedTextBoxEndVal.Mask = "000";
            this.maskedTextBoxEndVal.Name = "maskedTextBoxEndVal";
            this.maskedTextBoxEndVal.Size = new System.Drawing.Size(29, 22);
            this.maskedTextBoxEndVal.TabIndex = 11;
            this.maskedTextBoxEndVal.ValidatingType = typeof(int);
            // 
            // buttonSorting
            // 
            this.buttonSorting.Location = new System.Drawing.Point(12, 399);
            this.buttonSorting.Name = "buttonSorting";
            this.buttonSorting.Size = new System.Drawing.Size(258, 28);
            this.buttonSorting.TabIndex = 13;
            this.buttonSorting.Text = "Сортувати";
            this.buttonSorting.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.buttonSorting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxEndVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxStartVal);
            this.Controls.Add(this.groupBoxSortedArray);
            this.Controls.Add(this.groupBoxStatMsgs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxNumElements);
            this.Controls.Add(this.buttonGenerateArr);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxStatMsgs.ResumeLayout(false);
            this.groupBoxStatMsgs.PerformLayout();
            this.groupBoxSortedArray.ResumeLayout(false);
            this.groupBoxSortedArray.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonShaker;
        private System.Windows.Forms.RadioButton radioButtonInsertion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.RadioButton radioButtonAssorted;
        private System.Windows.Forms.TextBox textBoxAssorted;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonGenerateArr;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxStatMsgs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxSortedArray;
        private System.Windows.Forms.TextBox textBoxSortedArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndVal;
        private System.Windows.Forms.Button buttonSorting;
    }
}

