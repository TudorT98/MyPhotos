namespace MyPhotosForm
{
    partial class LocationForm
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
            this.LocationNameValue = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LocationDescription = new System.Windows.Forms.TextBox();
            this.LocationType = new System.Windows.Forms.TextBox();
            this.LocationTypeValue = new System.Windows.Forms.TextBox();
            this.LocationDescriptionValue = new System.Windows.Forms.TextBox();
            this.LocationFormTitle = new System.Windows.Forms.TextBox();
            this.SaveLocationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocationNameValue
            // 
            this.LocationNameValue.Location = new System.Drawing.Point(339, 98);
            this.LocationNameValue.Name = "LocationNameValue";
            this.LocationNameValue.Size = new System.Drawing.Size(212, 20);
            this.LocationNameValue.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Name";
            // 
            // LocationDescription
            // 
            this.LocationDescription.Location = new System.Drawing.Point(224, 150);
            this.LocationDescription.Name = "LocationDescription";
            this.LocationDescription.ReadOnly = true;
            this.LocationDescription.Size = new System.Drawing.Size(100, 20);
            this.LocationDescription.TabIndex = 2;
            this.LocationDescription.Text = "Description";
            // 
            // LocationType
            // 
            this.LocationType.Location = new System.Drawing.Point(224, 124);
            this.LocationType.Name = "LocationType";
            this.LocationType.ReadOnly = true;
            this.LocationType.Size = new System.Drawing.Size(100, 20);
            this.LocationType.TabIndex = 3;
            this.LocationType.Text = "Type";
            // 
            // LocationTypeValue
            // 
            this.LocationTypeValue.Location = new System.Drawing.Point(339, 124);
            this.LocationTypeValue.Name = "LocationTypeValue";
            this.LocationTypeValue.Size = new System.Drawing.Size(212, 20);
            this.LocationTypeValue.TabIndex = 4;
            // 
            // LocationDescriptionValue
            // 
            this.LocationDescriptionValue.Location = new System.Drawing.Point(339, 150);
            this.LocationDescriptionValue.Multiline = true;
            this.LocationDescriptionValue.Name = "LocationDescriptionValue";
            this.LocationDescriptionValue.Size = new System.Drawing.Size(212, 55);
            this.LocationDescriptionValue.TabIndex = 5;
            // 
            // LocationFormTitle
            // 
            this.LocationFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LocationFormTitle.Location = new System.Drawing.Point(224, 38);
            this.LocationFormTitle.Name = "LocationFormTitle";
            this.LocationFormTitle.ReadOnly = true;
            this.LocationFormTitle.Size = new System.Drawing.Size(327, 38);
            this.LocationFormTitle.TabIndex = 6;
            this.LocationFormTitle.Text = "Add a new location";
            this.LocationFormTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveLocationButton
            // 
            this.SaveLocationButton.Location = new System.Drawing.Point(224, 238);
            this.SaveLocationButton.Name = "SaveLocationButton";
            this.SaveLocationButton.Size = new System.Drawing.Size(327, 38);
            this.SaveLocationButton.TabIndex = 7;
            this.SaveLocationButton.Text = "Save";
            this.SaveLocationButton.UseVisualStyleBackColor = true;
            this.SaveLocationButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveLocationButton);
            this.Controls.Add(this.LocationFormTitle);
            this.Controls.Add(this.LocationDescriptionValue);
            this.Controls.Add(this.LocationTypeValue);
            this.Controls.Add(this.LocationType);
            this.Controls.Add(this.LocationDescription);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LocationNameValue);
            this.Name = "LocationForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LocationNameValue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox LocationDescription;
        private System.Windows.Forms.TextBox LocationType;
        private System.Windows.Forms.TextBox LocationTypeValue;
        private System.Windows.Forms.TextBox LocationDescriptionValue;
        private System.Windows.Forms.TextBox LocationFormTitle;
        private System.Windows.Forms.Button SaveLocationButton;



    }
}