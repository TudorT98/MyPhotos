namespace MyPhotosV2
{
    partial class LandScapeForm
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
            this.LandScapeNameValue = new System.Windows.Forms.TextBox();
            this.LandScapeDescriptionValue = new System.Windows.Forms.TextBox();
            this.LandScapeTypeValue = new System.Windows.Forms.TextBox();
            this.LandScapeName = new System.Windows.Forms.TextBox();
            this.LandScapeDescription = new System.Windows.Forms.TextBox();
            this.LandScapeType = new System.Windows.Forms.TextBox();
            this.LandScapeTitle = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LandScapeNameValue
            // 
            this.LandScapeNameValue.Location = new System.Drawing.Point(388, 141);
            this.LandScapeNameValue.Name = "LandScapeNameValue";
            this.LandScapeNameValue.Size = new System.Drawing.Size(100, 20);
            this.LandScapeNameValue.TabIndex = 0;
            // 
            // LandScapeDescriptionValue
            // 
            this.LandScapeDescriptionValue.Location = new System.Drawing.Point(388, 167);
            this.LandScapeDescriptionValue.Name = "LandScapeDescriptionValue";
            this.LandScapeDescriptionValue.Size = new System.Drawing.Size(100, 20);
            this.LandScapeDescriptionValue.TabIndex = 1;
            // 
            // LandScapeTypeValue
            // 
            this.LandScapeTypeValue.Location = new System.Drawing.Point(388, 193);
            this.LandScapeTypeValue.Name = "LandScapeTypeValue";
            this.LandScapeTypeValue.Size = new System.Drawing.Size(100, 20);
            this.LandScapeTypeValue.TabIndex = 2;
            // 
            // LandScapeName
            // 
            this.LandScapeName.Location = new System.Drawing.Point(282, 141);
            this.LandScapeName.Name = "LandScapeName";
            this.LandScapeName.ReadOnly = true;
            this.LandScapeName.Size = new System.Drawing.Size(100, 20);
            this.LandScapeName.TabIndex = 3;
            this.LandScapeName.TabStop = false;
            this.LandScapeName.Text = "Name";
            // 
            // LandScapeDescription
            // 
            this.LandScapeDescription.Location = new System.Drawing.Point(282, 167);
            this.LandScapeDescription.Name = "LandScapeDescription";
            this.LandScapeDescription.ReadOnly = true;
            this.LandScapeDescription.Size = new System.Drawing.Size(100, 20);
            this.LandScapeDescription.TabIndex = 4;
            this.LandScapeDescription.TabStop = false;
            this.LandScapeDescription.Text = "Description";
            // 
            // LandScapeType
            // 
            this.LandScapeType.Location = new System.Drawing.Point(282, 193);
            this.LandScapeType.Name = "LandScapeType";
            this.LandScapeType.ReadOnly = true;
            this.LandScapeType.Size = new System.Drawing.Size(100, 20);
            this.LandScapeType.TabIndex = 5;
            this.LandScapeType.TabStop = false;
            this.LandScapeType.Text = "Type";
            // 
            // LandScapeTitle
            // 
            this.LandScapeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LandScapeTitle.Location = new System.Drawing.Point(282, 88);
            this.LandScapeTitle.Name = "LandScapeTitle";
            this.LandScapeTitle.ReadOnly = true;
            this.LandScapeTitle.Size = new System.Drawing.Size(206, 38);
            this.LandScapeTitle.TabIndex = 6;
            this.LandScapeTitle.TabStop = false;
            this.LandScapeTitle.Text = "Add LandScape";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(282, 238);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(206, 37);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LandScapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LandScapeTitle);
            this.Controls.Add(this.LandScapeType);
            this.Controls.Add(this.LandScapeDescription);
            this.Controls.Add(this.LandScapeName);
            this.Controls.Add(this.LandScapeTypeValue);
            this.Controls.Add(this.LandScapeDescriptionValue);
            this.Controls.Add(this.LandScapeNameValue);
            this.Name = "LandScapeForm";
            this.Text = "LandScapeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LandScapeNameValue;
        private System.Windows.Forms.TextBox LandScapeDescriptionValue;
        private System.Windows.Forms.TextBox LandScapeTypeValue;
        private System.Windows.Forms.TextBox LandScapeName;
        private System.Windows.Forms.TextBox LandScapeDescription;
        private System.Windows.Forms.TextBox LandScapeType;
        private System.Windows.Forms.TextBox LandScapeTitle;
        private System.Windows.Forms.Button SaveButton;
    }
}