namespace MyPhotosForm
{
    partial class EventForm
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
            this.EventTitle = new System.Windows.Forms.TextBox();
            this.EventName = new System.Windows.Forms.TextBox();
            this.EventNameValue = new System.Windows.Forms.TextBox();
            this.EventDescription = new System.Windows.Forms.TextBox();
            this.EventDescriptionValue = new System.Windows.Forms.TextBox();
            this.EventSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventTitle
            // 
            this.EventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EventTitle.Location = new System.Drawing.Point(270, 87);
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.ReadOnly = true;
            this.EventTitle.Size = new System.Drawing.Size(245, 38);
            this.EventTitle.TabIndex = 0;
            this.EventTitle.TabStop = false;
            this.EventTitle.Text = "Add Event";
            this.EventTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EventName
            // 
            this.EventName.Location = new System.Drawing.Point(270, 149);
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.Size = new System.Drawing.Size(100, 20);
            this.EventName.TabIndex = 1;
            this.EventName.TabStop = false;
            this.EventName.Text = "Name";
            // 
            // EventNameValue
            // 
            this.EventNameValue.Location = new System.Drawing.Point(376, 149);
            this.EventNameValue.Name = "EventNameValue";
            this.EventNameValue.Size = new System.Drawing.Size(139, 20);
            this.EventNameValue.TabIndex = 2;
            // 
            // EventDescription
            // 
            this.EventDescription.Location = new System.Drawing.Point(270, 175);
            this.EventDescription.Name = "EventDescription";
            this.EventDescription.ReadOnly = true;
            this.EventDescription.Size = new System.Drawing.Size(100, 20);
            this.EventDescription.TabIndex = 3;
            this.EventDescription.TabStop = false;
            this.EventDescription.Text = "Description";
            // 
            // EventDescriptionValue
            // 
            this.EventDescriptionValue.Location = new System.Drawing.Point(376, 175);
            this.EventDescriptionValue.Multiline = true;
            this.EventDescriptionValue.Name = "EventDescriptionValue";
            this.EventDescriptionValue.Size = new System.Drawing.Size(139, 49);
            this.EventDescriptionValue.TabIndex = 4;
            // 
            // EventSave
            // 
            this.EventSave.Location = new System.Drawing.Point(270, 248);
            this.EventSave.Name = "EventSave";
            this.EventSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EventSave.Size = new System.Drawing.Size(245, 38);
            this.EventSave.TabIndex = 5;
            this.EventSave.TabStop = false;
            this.EventSave.Text = "Save";
            this.EventSave.UseVisualStyleBackColor = true;
            this.EventSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EventSave);
            this.Controls.Add(this.EventDescriptionValue);
            this.Controls.Add(this.EventDescription);
            this.Controls.Add(this.EventNameValue);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.EventTitle);
            this.Name = "EventForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EventTitle;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.TextBox EventNameValue;
        private System.Windows.Forms.TextBox EventDescription;
        private System.Windows.Forms.TextBox EventDescriptionValue;
        private System.Windows.Forms.Button EventSave;
    }
}