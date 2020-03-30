namespace MyPhotosForm
{
    partial class PersonForm
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
            this.components = new System.ComponentModel.Container();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.PersonTitle = new System.Windows.Forms.TextBox();
            this.SavePerson = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AgeValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AgeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(245, 140);
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 0;
            this.FirstName.TabStop = false;
            this.FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(245, 166);
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 1;
            this.LastName.TabStop = false;
            this.LastName.Text = "LastName";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(245, 192);
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Size = new System.Drawing.Size(100, 20);
            this.Age.TabIndex = 2;
            this.Age.TabStop = false;
            this.Age.Text = "Age";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(367, 140);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(100, 20);
            this.FirstNameValue.TabIndex = 3;
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(367, 166);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(100, 20);
            this.LastNameValue.TabIndex = 4;
            // 
            // PersonTitle
            // 
            this.PersonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PersonTitle.Location = new System.Drawing.Point(245, 85);
            this.PersonTitle.Name = "PersonTitle";
            this.PersonTitle.ReadOnly = true;
            this.PersonTitle.Size = new System.Drawing.Size(222, 38);
            this.PersonTitle.TabIndex = 6;
            this.PersonTitle.TabStop = false;
            this.PersonTitle.Text = "Add Person\r\n";
            this.PersonTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SavePerson
            // 
            this.SavePerson.Location = new System.Drawing.Point(245, 232);
            this.SavePerson.Name = "SavePerson";
            this.SavePerson.Size = new System.Drawing.Size(222, 41);
            this.SavePerson.TabIndex = 7;
            this.SavePerson.Text = "Save";
            this.SavePerson.UseVisualStyleBackColor = true;
            this.SavePerson.Click += new System.EventHandler(this.SavePerson_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AgeValue
            // 
            this.AgeValue.Location = new System.Drawing.Point(367, 192);
            this.AgeValue.Name = "AgeValue";
            this.AgeValue.Size = new System.Drawing.Size(100, 20);
            this.AgeValue.TabIndex = 9;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AgeValue);
            this.Controls.Add(this.SavePerson);
            this.Controls.Add(this.PersonTitle);
            this.Controls.Add(this.LastNameValue);
            this.Controls.Add(this.FirstNameValue);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "PersonForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.AgeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.TextBox PersonTitle;
        private System.Windows.Forms.Button SavePerson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown AgeValue;
    }
}