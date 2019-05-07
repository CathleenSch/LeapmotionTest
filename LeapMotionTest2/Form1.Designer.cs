namespace LeapMotionTest2 {
    partial class FrameDataForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.displayID = new System.Windows.Forms.Label();
            this.displayTimestamp = new System.Windows.Forms.Label();
            this.displayFPS = new System.Windows.Forms.Label();
            this.displayHandCount = new System.Windows.Forms.Label();
            this.displayImages = new System.Windows.Forms.PictureBox();
            this.debugText = new System.Windows.Forms.RichTextBox();
            this.displayAngle = new System.Windows.Forms.Label();
            this.displayArm = new System.Windows.Forms.Label();
            this.displayAngleThumb = new System.Windows.Forms.Label();
            this.displayLeftOrRight = new System.Windows.Forms.Label();
            this.displayPinchStrength = new System.Windows.Forms.Label();
            this.displayPinchedFinger = new System.Windows.Forms.Label();
            this.displayThumbIndex = new System.Windows.Forms.Label();
            this.displayThumbMiddle = new System.Windows.Forms.Label();
            this.displayThumbRing = new System.Windows.Forms.Label();
            this.displayThumbPinky = new System.Windows.Forms.Label();
            this.displayThumbPos = new System.Windows.Forms.Label();
            this.displayPinkyPos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).BeginInit();
            this.SuspendLayout();
            // 
            // displayID
            // 
            this.displayID.AutoSize = true;
            this.displayID.Location = new System.Drawing.Point(24, 17);
            this.displayID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.displayID.Name = "displayID";
            this.displayID.Size = new System.Drawing.Size(70, 25);
            this.displayID.TabIndex = 0;
            this.displayID.Text = "label1";
            // 
            // displayTimestamp
            // 
            this.displayTimestamp.AutoSize = true;
            this.displayTimestamp.Location = new System.Drawing.Point(222, 17);
            this.displayTimestamp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.displayTimestamp.Name = "displayTimestamp";
            this.displayTimestamp.Size = new System.Drawing.Size(70, 25);
            this.displayTimestamp.TabIndex = 1;
            this.displayTimestamp.Text = "label2";
            // 
            // displayFPS
            // 
            this.displayFPS.AutoSize = true;
            this.displayFPS.Location = new System.Drawing.Point(444, 17);
            this.displayFPS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.displayFPS.Name = "displayFPS";
            this.displayFPS.Size = new System.Drawing.Size(70, 25);
            this.displayFPS.TabIndex = 2;
            this.displayFPS.Text = "label3";
            // 
            // displayHandCount
            // 
            this.displayHandCount.AutoSize = true;
            this.displayHandCount.Location = new System.Drawing.Point(620, 17);
            this.displayHandCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.displayHandCount.Name = "displayHandCount";
            this.displayHandCount.Size = new System.Drawing.Size(70, 25);
            this.displayHandCount.TabIndex = 3;
            this.displayHandCount.Text = "label4";
            // 
            // displayImages
            // 
            this.displayImages.Location = new System.Drawing.Point(30, 64);
            this.displayImages.Margin = new System.Windows.Forms.Padding(6);
            this.displayImages.Name = "displayImages";
            this.displayImages.Size = new System.Drawing.Size(1048, 907);
            this.displayImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.displayImages.TabIndex = 4;
            this.displayImages.TabStop = false;
            // 
            // debugText
            // 
            this.debugText.Location = new System.Drawing.Point(30, 983);
            this.debugText.Margin = new System.Windows.Forms.Padding(6);
            this.debugText.Name = "debugText";
            this.debugText.Size = new System.Drawing.Size(1276, 314);
            this.debugText.TabIndex = 5;
            this.debugText.Text = "";
            // 
            // displayAngle
            // 
            this.displayAngle.AutoSize = true;
            this.displayAngle.Location = new System.Drawing.Point(1113, 64);
            this.displayAngle.Name = "displayAngle";
            this.displayAngle.Size = new System.Drawing.Size(198, 25);
            this.displayAngle.TabIndex = 9;
            this.displayAngle.Text = "angle hand - arm: 0";
            // 
            // displayArm
            // 
            this.displayArm.AutoSize = true;
            this.displayArm.Location = new System.Drawing.Point(1113, 173);
            this.displayArm.Name = "displayArm";
            this.displayArm.Size = new System.Drawing.Size(50, 25);
            this.displayArm.TabIndex = 10;
            this.displayArm.Text = "Arm";
            // 
            // displayAngleThumb
            // 
            this.displayAngleThumb.AutoSize = true;
            this.displayAngleThumb.Location = new System.Drawing.Point(1113, 117);
            this.displayAngleThumb.Name = "displayAngleThumb";
            this.displayAngleThumb.Size = new System.Drawing.Size(221, 25);
            this.displayAngleThumb.TabIndex = 11;
            this.displayAngleThumb.Text = "angle hand - thumb: 0";
            // 
            // displayLeftOrRight
            // 
            this.displayLeftOrRight.AutoSize = true;
            this.displayLeftOrRight.Location = new System.Drawing.Point(1113, 218);
            this.displayLeftOrRight.Name = "displayLeftOrRight";
            this.displayLeftOrRight.Size = new System.Drawing.Size(114, 25);
            this.displayLeftOrRight.TabIndex = 12;
            this.displayLeftOrRight.Text = "left or right";
            // 
            // displayPinchStrength
            // 
            this.displayPinchStrength.AutoSize = true;
            this.displayPinchStrength.Location = new System.Drawing.Point(1113, 270);
            this.displayPinchStrength.Name = "displayPinchStrength";
            this.displayPinchStrength.Size = new System.Drawing.Size(148, 25);
            this.displayPinchStrength.TabIndex = 13;
            this.displayPinchStrength.Text = "pinch strength";
            // 
            // displayPinchedFinger
            // 
            this.displayPinchedFinger.AutoSize = true;
            this.displayPinchedFinger.Location = new System.Drawing.Point(1113, 318);
            this.displayPinchedFinger.Name = "displayPinchedFinger";
            this.displayPinchedFinger.Size = new System.Drawing.Size(148, 25);
            this.displayPinchedFinger.TabIndex = 14;
            this.displayPinchedFinger.Text = "pinched finger";
            // 
            // displayThumbIndex
            // 
            this.displayThumbIndex.AutoSize = true;
            this.displayThumbIndex.Location = new System.Drawing.Point(1113, 366);
            this.displayThumbIndex.Name = "displayThumbIndex";
            this.displayThumbIndex.Size = new System.Drawing.Size(229, 25);
            this.displayThumbIndex.TabIndex = 15;
            this.displayThumbIndex.Text = "distance thumb - index";
            // 
            // displayThumbMiddle
            // 
            this.displayThumbMiddle.AutoSize = true;
            this.displayThumbMiddle.Location = new System.Drawing.Point(1113, 410);
            this.displayThumbMiddle.Name = "displayThumbMiddle";
            this.displayThumbMiddle.Size = new System.Drawing.Size(240, 25);
            this.displayThumbMiddle.TabIndex = 16;
            this.displayThumbMiddle.Text = "distance thumb - middle";
            // 
            // displayThumbRing
            // 
            this.displayThumbRing.AutoSize = true;
            this.displayThumbRing.Location = new System.Drawing.Point(1113, 450);
            this.displayThumbRing.Name = "displayThumbRing";
            this.displayThumbRing.Size = new System.Drawing.Size(213, 25);
            this.displayThumbRing.TabIndex = 17;
            this.displayThumbRing.Text = "distance thumb - ring";
            // 
            // displayThumbPinky
            // 
            this.displayThumbPinky.AutoSize = true;
            this.displayThumbPinky.Location = new System.Drawing.Point(1113, 490);
            this.displayThumbPinky.Name = "displayThumbPinky";
            this.displayThumbPinky.Size = new System.Drawing.Size(228, 25);
            this.displayThumbPinky.TabIndex = 18;
            this.displayThumbPinky.Text = "distance thumb - pinky";
            // 
            // displayThumbPos
            // 
            this.displayThumbPos.AutoSize = true;
            this.displayThumbPos.Location = new System.Drawing.Point(1113, 546);
            this.displayThumbPos.Name = "displayThumbPos";
            this.displayThumbPos.Size = new System.Drawing.Size(152, 25);
            this.displayThumbPos.TabIndex = 19;
            this.displayThumbPos.Text = "thumb position";
            // 
            // displayPinkyPos
            // 
            this.displayPinkyPos.AutoSize = true;
            this.displayPinkyPos.Location = new System.Drawing.Point(1113, 582);
            this.displayPinkyPos.Name = "displayPinkyPos";
            this.displayPinkyPos.Size = new System.Drawing.Size(144, 25);
            this.displayPinkyPos.TabIndex = 20;
            this.displayPinkyPos.Text = "pinky position";
            // 
            // FrameDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2028, 1333);
            this.Controls.Add(this.displayPinkyPos);
            this.Controls.Add(this.displayThumbPos);
            this.Controls.Add(this.displayThumbPinky);
            this.Controls.Add(this.displayThumbRing);
            this.Controls.Add(this.displayThumbMiddle);
            this.Controls.Add(this.displayThumbIndex);
            this.Controls.Add(this.displayPinchedFinger);
            this.Controls.Add(this.displayPinchStrength);
            this.Controls.Add(this.displayLeftOrRight);
            this.Controls.Add(this.displayAngleThumb);
            this.Controls.Add(this.displayArm);
            this.Controls.Add(this.displayAngle);
            this.Controls.Add(this.debugText);
            this.Controls.Add(this.displayImages);
            this.Controls.Add(this.displayHandCount);
            this.Controls.Add(this.displayFPS);
            this.Controls.Add(this.displayTimestamp);
            this.Controls.Add(this.displayID);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrameDataForm";
            this.Text = "Frame Data";
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayID;
        private System.Windows.Forms.Label displayTimestamp;
        private System.Windows.Forms.Label displayFPS;
        private System.Windows.Forms.Label displayHandCount;
        private System.Windows.Forms.PictureBox displayImages;
        private System.Windows.Forms.RichTextBox debugText;
        private System.Windows.Forms.Label displayAngle;
        private System.Windows.Forms.Label displayArm;
        private System.Windows.Forms.Label displayAngleThumb;
        private System.Windows.Forms.Label displayLeftOrRight;
        private System.Windows.Forms.Label displayPinchStrength;
        private System.Windows.Forms.Label displayPinchedFinger;
        private System.Windows.Forms.Label displayThumbIndex;
        private System.Windows.Forms.Label displayThumbMiddle;
        private System.Windows.Forms.Label displayThumbRing;
        private System.Windows.Forms.Label displayThumbPinky;
        private System.Windows.Forms.Label displayThumbPos;
        private System.Windows.Forms.Label displayPinkyPos;
    }
}