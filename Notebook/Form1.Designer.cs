namespace Notebook
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
            this.TextBox_FirstName = new System.Windows.Forms.TextBox();
            this.TextBox_LastName = new System.Windows.Forms.TextBox();
            this.TextBox_Phone = new System.Windows.Forms.TextBox();
            this.ListBox_Notebook = new System.Windows.Forms.ListBox();
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.Label_FirstName = new System.Windows.Forms.Label();
            this.Label_LastName = new System.Windows.Forms.Label();
            this.Label_Phone = new System.Windows.Forms.Label();
            this.Label_Description = new System.Windows.Forms.Label();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_FirstName
            // 
            this.TextBox_FirstName.Location = new System.Drawing.Point(12, 28);
            this.TextBox_FirstName.Name = "TextBox_FirstName";
            this.TextBox_FirstName.Size = new System.Drawing.Size(100, 20);
            this.TextBox_FirstName.TabIndex = 1;
            // 
            // TextBox_LastName
            // 
            this.TextBox_LastName.Location = new System.Drawing.Point(12, 67);
            this.TextBox_LastName.Name = "TextBox_LastName";
            this.TextBox_LastName.Size = new System.Drawing.Size(100, 20);
            this.TextBox_LastName.TabIndex = 3;
            // 
            // TextBox_Phone
            // 
            this.TextBox_Phone.Location = new System.Drawing.Point(12, 106);
            this.TextBox_Phone.Name = "TextBox_Phone";
            this.TextBox_Phone.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Phone.TabIndex = 5;
            // 
            // ListBox_Notebook
            // 
            this.ListBox_Notebook.BackColor = System.Drawing.SystemColors.Window;
            this.ListBox_Notebook.FormattingEnabled = true;
            this.ListBox_Notebook.Location = new System.Drawing.Point(118, 12);
            this.ListBox_Notebook.Name = "ListBox_Notebook";
            this.ListBox_Notebook.Size = new System.Drawing.Size(154, 238);
            this.ListBox_Notebook.TabIndex = 6;
            this.ListBox_Notebook.SelectedIndexChanged += new System.EventHandler(this.ListBox_Notebook_SelectedIndexChanged);
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_Description.Location = new System.Drawing.Point(12, 145);
            this.TextBox_Description.Multiline = true;
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(100, 104);
            this.TextBox_Description.TabIndex = 10;
            // 
            // Label_FirstName
            // 
            this.Label_FirstName.Location = new System.Drawing.Point(12, 12);
            this.Label_FirstName.Name = "Label_FirstName";
            this.Label_FirstName.Size = new System.Drawing.Size(100, 13);
            this.Label_FirstName.TabIndex = 11;
            this.Label_FirstName.Text = "Имя*";
            this.Label_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_LastName
            // 
            this.Label_LastName.Location = new System.Drawing.Point(12, 51);
            this.Label_LastName.Name = "Label_LastName";
            this.Label_LastName.Size = new System.Drawing.Size(100, 13);
            this.Label_LastName.TabIndex = 12;
            this.Label_LastName.Text = "Фамилия*";
            this.Label_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Phone
            // 
            this.Label_Phone.Location = new System.Drawing.Point(12, 90);
            this.Label_Phone.Name = "Label_Phone";
            this.Label_Phone.Size = new System.Drawing.Size(100, 13);
            this.Label_Phone.TabIndex = 13;
            this.Label_Phone.Text = "Номер";
            this.Label_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Description
            // 
            this.Label_Description.Location = new System.Drawing.Point(12, 129);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(100, 13);
            this.Label_Description.TabIndex = 14;
            this.Label_Description.Text = "Описание";
            this.Label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(12, 267);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 25);
            this.Button_Add.TabIndex = 15;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Edit
            // 
            this.Button_Edit.Location = new System.Drawing.Point(93, 267);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(75, 25);
            this.Button_Edit.TabIndex = 16;
            this.Button_Edit.Text = "Изменить";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_Remove
            // 
            this.Button_Remove.Location = new System.Drawing.Point(174, 267);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(98, 25);
            this.Button_Remove.TabIndex = 17;
            this.Button_Remove.Text = "Удалить";
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.Button_Remove);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Label_Description);
            this.Controls.Add(this.Label_Phone);
            this.Controls.Add(this.Label_LastName);
            this.Controls.Add(this.Label_FirstName);
            this.Controls.Add(this.TextBox_Description);
            this.Controls.Add(this.ListBox_Notebook);
            this.Controls.Add(this.TextBox_Phone);
            this.Controls.Add(this.TextBox_LastName);
            this.Controls.Add(this.TextBox_FirstName);
            this.Name = "Form1";
            this.Text = "Записная книжка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_FirstName;
        private System.Windows.Forms.TextBox TextBox_LastName;
        private System.Windows.Forms.TextBox TextBox_Phone;
        private System.Windows.Forms.ListBox ListBox_Notebook;
        private System.Windows.Forms.TextBox TextBox_Description;
        private System.Windows.Forms.Label Label_FirstName;
        private System.Windows.Forms.Label Label_LastName;
        private System.Windows.Forms.Label Label_Phone;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button Button_Remove;
    }
}

