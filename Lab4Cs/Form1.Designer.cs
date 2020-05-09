namespace Lab4Cs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start1 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.RichTextBox();
            this.excp = new System.Windows.Forms.Label();
            this.OupN = new System.Windows.Forms.TextBox();
            this.OupM = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите количество треугольников:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите кол-во прямоугольных треугольников:";
            // 
            // Start1
            // 
            this.Start1.BackColor = System.Drawing.Color.Transparent;
            this.Start1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start1.FlatAppearance.BorderSize = 0;
            this.Start1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start1.Location = new System.Drawing.Point(611, 24);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(145, 38);
            this.Start1.TabIndex = 3;
            this.Start1.Text = "Посчитать";
            this.Start1.UseVisualStyleBackColor = false;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(19, 77);
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(474, 360);
            this.info.TabIndex = 5;
            this.info.Text = "";
            // 
            // excp
            // 
            this.excp.AutoSize = true;
            this.excp.BackColor = System.Drawing.Color.Transparent;
            this.excp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excp.Location = new System.Drawing.Point(499, 95);
            this.excp.Name = "excp";
            this.excp.Size = new System.Drawing.Size(0, 20);
            this.excp.TabIndex = 15;
            // 
            // OupN
            // 
            this.OupN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupN.Location = new System.Drawing.Point(500, 10);
            this.OupN.Name = "OupN";
            this.OupN.Size = new System.Drawing.Size(75, 29);
            this.OupN.TabIndex = 1;
            // 
            // OupM
            // 
            this.OupM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OupM.Location = new System.Drawing.Point(500, 50);
            this.OupM.Name = "OupM";
            this.OupM.Size = new System.Drawing.Size(75, 29);
            this.OupM.TabIndex = 2;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.save.Location = new System.Drawing.Point(643, 399);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(145, 38);
            this.save.TabIndex = 16;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.Transparent;
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.FlatAppearance.BorderSize = 0;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open.ForeColor = System.Drawing.SystemColors.ControlText;
            this.open.Location = new System.Drawing.Point(499, 399);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(145, 38);
            this.open.TabIndex = 17;
            this.open.Text = "Открыть";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.OupM);
            this.Controls.Add(this.OupN);
            this.Controls.Add(this.excp);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Start1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start1;
        public System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Label excp;
        private System.Windows.Forms.TextBox OupN;
        private System.Windows.Forms.TextBox OupM;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

