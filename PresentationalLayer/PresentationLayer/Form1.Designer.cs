
namespace PresentationLayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxIndexNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxESPB = new System.Windows.Forms.TextBox();
            this.textBoxStudentYear = new System.Windows.Forms.TextBox();
            this.textBoxAverageMark = new System.Windows.Forms.TextBox();
            this.textBoxIsBudget = new System.Windows.Forms.TextBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IndexNumber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PointsESPB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "StudyYear:";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(134, 61);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentName.TabIndex = 4;
            // 
            // textBoxIndexNumber
            // 
            this.textBoxIndexNumber.Location = new System.Drawing.Point(134, 91);
            this.textBoxIndexNumber.Name = "textBoxIndexNumber";
            this.textBoxIndexNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxIndexNumber.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "AverageMark:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "IsBudget:";
            // 
            // textBoxESPB
            // 
            this.textBoxESPB.Location = new System.Drawing.Point(134, 122);
            this.textBoxESPB.Name = "textBoxESPB";
            this.textBoxESPB.Size = new System.Drawing.Size(100, 20);
            this.textBoxESPB.TabIndex = 8;
            // 
            // textBoxStudentYear
            // 
            this.textBoxStudentYear.Location = new System.Drawing.Point(134, 154);
            this.textBoxStudentYear.Name = "textBoxStudentYear";
            this.textBoxStudentYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentYear.TabIndex = 9;
            // 
            // textBoxAverageMark
            // 
            this.textBoxAverageMark.Location = new System.Drawing.Point(134, 180);
            this.textBoxAverageMark.Name = "textBoxAverageMark";
            this.textBoxAverageMark.Size = new System.Drawing.Size(100, 20);
            this.textBoxAverageMark.TabIndex = 10;
            // 
            // textBoxIsBudget
            // 
            this.textBoxIsBudget.Location = new System.Drawing.Point(134, 206);
            this.textBoxIsBudget.Name = "textBoxIsBudget";
            this.textBoxIsBudget.Size = new System.Drawing.Size(100, 20);
            this.textBoxIsBudget.TabIndex = 11;
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(134, 254);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(75, 23);
            this.buttonUnesi.TabIndex = 12;
            this.buttonUnesi.Text = "Insert";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 302);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 225);
            this.listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 564);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.textBoxIsBudget);
            this.Controls.Add(this.textBoxAverageMark);
            this.Controls.Add(this.textBoxStudentYear);
            this.Controls.Add(this.textBoxESPB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxIndexNumber);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxIndexNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxESPB;
        private System.Windows.Forms.TextBox textBoxStudentYear;
        private System.Windows.Forms.TextBox textBoxAverageMark;
        private System.Windows.Forms.TextBox textBoxIsBudget;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.ListBox listBox1;
    }
}

