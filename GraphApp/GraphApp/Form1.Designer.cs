
namespace GraphApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.AddEdgeButton = new System.Windows.Forms.Button();
            this.ShowGraphButton = new System.Windows.Forms.Button();
            this.RemoveEdgeButton = new System.Windows.Forms.Button();
            this.SaveGrapButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DoButton = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 356);
            this.panel1.TabIndex = 0;
            // 
            // AddElementButton
            // 
            this.AddElementButton.Location = new System.Drawing.Point(12, 12);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(109, 44);
            this.AddElementButton.TabIndex = 1;
            this.AddElementButton.Text = "AddElement";
            this.AddElementButton.UseVisualStyleBackColor = true;
            this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
            // 
            // AddEdgeButton
            // 
            this.AddEdgeButton.Location = new System.Drawing.Point(242, 12);
            this.AddEdgeButton.Name = "AddEdgeButton";
            this.AddEdgeButton.Size = new System.Drawing.Size(109, 44);
            this.AddEdgeButton.TabIndex = 2;
            this.AddEdgeButton.Text = "AddEdge";
            this.AddEdgeButton.UseVisualStyleBackColor = true;
            this.AddEdgeButton.Click += new System.EventHandler(this.AddEdgeButton_Click_1);
            // 
            // ShowGraphButton
            // 
            this.ShowGraphButton.Location = new System.Drawing.Point(472, 12);
            this.ShowGraphButton.Name = "ShowGraphButton";
            this.ShowGraphButton.Size = new System.Drawing.Size(109, 44);
            this.ShowGraphButton.TabIndex = 7;
            this.ShowGraphButton.Text = "ShowGraph";
            this.ShowGraphButton.UseVisualStyleBackColor = true;
            this.ShowGraphButton.Click += new System.EventHandler(this.ShowGraphButton_Click);
            // 
            // RemoveEdgeButton
            // 
            this.RemoveEdgeButton.Location = new System.Drawing.Point(357, 12);
            this.RemoveEdgeButton.Name = "RemoveEdgeButton";
            this.RemoveEdgeButton.Size = new System.Drawing.Size(109, 44);
            this.RemoveEdgeButton.TabIndex = 9;
            this.RemoveEdgeButton.Text = "RemoveEdge";
            this.RemoveEdgeButton.UseVisualStyleBackColor = true;
            this.RemoveEdgeButton.Click += new System.EventHandler(this.RemoveEdgeButton_Click);
            // 
            // SaveGrapButton
            // 
            this.SaveGrapButton.Location = new System.Drawing.Point(127, 12);
            this.SaveGrapButton.Name = "SaveGrapButton";
            this.SaveGrapButton.Size = new System.Drawing.Size(109, 44);
            this.SaveGrapButton.TabIndex = 10;
            this.SaveGrapButton.Text = "SaveGraph";
            this.SaveGrapButton.UseVisualStyleBackColor = true;
            this.SaveGrapButton.Click += new System.EventHandler(this.SaveGrapButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "In-degree",
            "Out-degree",
            "Check Isolation",
            "Matrix of distance",
            "Reachability matrix"});
            this.comboBox1.Location = new System.Drawing.Point(587, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Operation with graph";
            // 
            // DoButton
            // 
            this.DoButton.Location = new System.Drawing.Point(612, 62);
            this.DoButton.Name = "DoButton";
            this.DoButton.Size = new System.Drawing.Size(115, 33);
            this.DoButton.TabIndex = 13;
            this.DoButton.Text = "DoSomething";
            this.DoButton.UseVisualStyleBackColor = true;
            this.DoButton.Click += new System.EventHandler(this.DoButton_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(587, 117);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(156, 265);
            this.richTextBox.TabIndex = 14;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.DoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SaveGrapButton);
            this.Controls.Add(this.RemoveEdgeButton);
            this.Controls.Add(this.ShowGraphButton);
            this.Controls.Add(this.AddEdgeButton);
            this.Controls.Add(this.AddElementButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "GraphApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddElementButton;
        private System.Windows.Forms.Button AddEdgeButton;
        private System.Windows.Forms.Button ShowGraphButton;
        private System.Windows.Forms.Button RemoveEdgeButton;
        private System.Windows.Forms.Button SaveGrapButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DoButton;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

