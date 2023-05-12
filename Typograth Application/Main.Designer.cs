namespace Typograth_Application
{
    partial class mainForm
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
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonToDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.AcceptsTab = true;
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTextBox.Location = new System.Drawing.Point(20, 14);
            this.mainTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(1168, 618);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.Text = "";
            // 
            // buttonToDo
            // 
            this.buttonToDo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonToDo.BackColor = System.Drawing.Color.Gray;
            this.buttonToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonToDo.Location = new System.Drawing.Point(531, 642);
            this.buttonToDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonToDo.Name = "buttonToDo";
            this.buttonToDo.Size = new System.Drawing.Size(207, 51);
            this.buttonToDo.TabIndex = 1;
            this.buttonToDo.TabStop = false;
            this.buttonToDo.Text = "Типографировать";
            this.buttonToDo.UseVisualStyleBackColor = false;
            this.buttonToDo.Click += new System.EventHandler(this.buttonToDo_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1206, 709);
            this.Controls.Add(this.buttonToDo);
            this.Controls.Add(this.mainTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1219, 739);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Типограф";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.Button buttonToDo;
    }
}

