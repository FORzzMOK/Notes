﻿namespace Notes.WFPL
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNutton
            // 
            this.addNutton.Location = new System.Drawing.Point(206, 282);
            this.addNutton.Name = "addNutton";
            this.addNutton.Size = new System.Drawing.Size(274, 68);
            this.addNutton.TabIndex = 0;
            this.addNutton.Text = "ДОБАВИТЬ ЗАМЕТКУ";
            this.addNutton.UseVisualStyleBackColor = true;
            this.addNutton.Click += new System.EventHandler(this.AddNutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNutton;
    }
}

