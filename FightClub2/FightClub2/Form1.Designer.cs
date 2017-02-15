namespace FightClub2
{
    partial class Form1
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
            this.labelYourHP = new System.Windows.Forms.Label();
            this.labelHisHP = new System.Windows.Forms.Label();
            this.labelChooseOne = new System.Windows.Forms.Label();
            this.radioButtonHead = new System.Windows.Forms.RadioButton();
            this.radioButtonTorso = new System.Windows.Forms.RadioButton();
            this.radioButtonLegs = new System.Windows.Forms.RadioButton();
            this.buttonHitBlock = new System.Windows.Forms.Button();
            this.textBoxYourHP = new System.Windows.Forms.TextBox();
            this.textBoxHisHP = new System.Windows.Forms.TextBox();
            this.labelHeChose = new System.Windows.Forms.Label();
            this.textBoxHeChose = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelYourHP
            // 
            this.labelYourHP.AutoSize = true;
            this.labelYourHP.Location = new System.Drawing.Point(100, 26);
            this.labelYourHP.Name = "labelYourHP";
            this.labelYourHP.Size = new System.Drawing.Size(50, 13);
            this.labelYourHP.TabIndex = 0;
            this.labelYourHP.Text = "Your HP:";
            // 
            // labelHisHP
            // 
            this.labelHisHP.AutoSize = true;
            this.labelHisHP.Location = new System.Drawing.Point(100, 49);
            this.labelHisHP.Name = "labelHisHP";
            this.labelHisHP.Size = new System.Drawing.Size(43, 13);
            this.labelHisHP.TabIndex = 1;
            this.labelHisHP.Text = "His HP:";
            // 
            // labelChooseOne
            // 
            this.labelChooseOne.AutoSize = true;
            this.labelChooseOne.Location = new System.Drawing.Point(12, 13);
            this.labelChooseOne.Name = "labelChooseOne";
            this.labelChooseOne.Size = new System.Drawing.Size(64, 13);
            this.labelChooseOne.TabIndex = 2;
            this.labelChooseOne.Text = "Choose one";
            // 
            // radioButtonHead
            // 
            this.radioButtonHead.AutoSize = true;
            this.radioButtonHead.Location = new System.Drawing.Point(12, 33);
            this.radioButtonHead.Name = "radioButtonHead";
            this.radioButtonHead.Size = new System.Drawing.Size(51, 17);
            this.radioButtonHead.TabIndex = 3;
            this.radioButtonHead.TabStop = true;
            this.radioButtonHead.Text = "Head";
            this.radioButtonHead.UseVisualStyleBackColor = true;
            // 
            // radioButtonTorso
            // 
            this.radioButtonTorso.AutoSize = true;
            this.radioButtonTorso.Location = new System.Drawing.Point(12, 53);
            this.radioButtonTorso.Name = "radioButtonTorso";
            this.radioButtonTorso.Size = new System.Drawing.Size(52, 17);
            this.radioButtonTorso.TabIndex = 4;
            this.radioButtonTorso.TabStop = true;
            this.radioButtonTorso.Text = "Torso";
            this.radioButtonTorso.UseVisualStyleBackColor = true;
            // 
            // radioButtonLegs
            // 
            this.radioButtonLegs.AutoSize = true;
            this.radioButtonLegs.Location = new System.Drawing.Point(12, 73);
            this.radioButtonLegs.Name = "radioButtonLegs";
            this.radioButtonLegs.Size = new System.Drawing.Size(48, 17);
            this.radioButtonLegs.TabIndex = 5;
            this.radioButtonLegs.TabStop = true;
            this.radioButtonLegs.Text = "Legs";
            this.radioButtonLegs.UseVisualStyleBackColor = true;
            // 
            // buttonHitBlock
            // 
            this.buttonHitBlock.Location = new System.Drawing.Point(10, 98);
            this.buttonHitBlock.Name = "buttonHitBlock";
            this.buttonHitBlock.Size = new System.Drawing.Size(65, 25);
            this.buttonHitBlock.TabIndex = 6;
            this.buttonHitBlock.Text = "Hit";
            this.buttonHitBlock.UseVisualStyleBackColor = true;
            this.buttonHitBlock.Click += new System.EventHandler(this.buttonHitBlock_Click);
            // 
            // textBoxYourHP
            // 
            this.textBoxYourHP.Enabled = false;
            this.textBoxYourHP.Location = new System.Drawing.Point(156, 21);
            this.textBoxYourHP.Name = "textBoxYourHP";
            this.textBoxYourHP.Size = new System.Drawing.Size(24, 20);
            this.textBoxYourHP.TabIndex = 7;
            this.textBoxYourHP.Text = "100";
            // 
            // textBoxHisHP
            // 
            this.textBoxHisHP.Enabled = false;
            this.textBoxHisHP.Location = new System.Drawing.Point(157, 46);
            this.textBoxHisHP.Name = "textBoxHisHP";
            this.textBoxHisHP.Size = new System.Drawing.Size(24, 20);
            this.textBoxHisHP.TabIndex = 8;
            this.textBoxHisHP.Text = "100";
            // 
            // labelHeChose
            // 
            this.labelHeChose.AutoSize = true;
            this.labelHeChose.Location = new System.Drawing.Point(112, 77);
            this.labelHeChose.Name = "labelHeChose";
            this.labelHeChose.Size = new System.Drawing.Size(53, 13);
            this.labelHeChose.TabIndex = 9;
            this.labelHeChose.Text = "He chose";
            // 
            // textBoxHeChose
            // 
            this.textBoxHeChose.Enabled = false;
            this.textBoxHeChose.Location = new System.Drawing.Point(102, 98);
            this.textBoxHeChose.Name = "textBoxHeChose";
            this.textBoxHeChose.Size = new System.Drawing.Size(78, 20);
            this.textBoxHeChose.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 137);
            this.Controls.Add(this.textBoxHeChose);
            this.Controls.Add(this.labelHeChose);
            this.Controls.Add(this.textBoxHisHP);
            this.Controls.Add(this.textBoxYourHP);
            this.Controls.Add(this.buttonHitBlock);
            this.Controls.Add(this.radioButtonLegs);
            this.Controls.Add(this.radioButtonTorso);
            this.Controls.Add(this.radioButtonHead);
            this.Controls.Add(this.labelChooseOne);
            this.Controls.Add(this.labelHisHP);
            this.Controls.Add(this.labelYourHP);
            this.Name = "Form1";
            this.Text = "FightClub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYourHP;
        private System.Windows.Forms.Label labelHisHP;
        private System.Windows.Forms.Label labelChooseOne;
        private System.Windows.Forms.RadioButton radioButtonHead;
        private System.Windows.Forms.RadioButton radioButtonTorso;
        private System.Windows.Forms.RadioButton radioButtonLegs;
        private System.Windows.Forms.Button buttonHitBlock;
        private System.Windows.Forms.TextBox textBoxYourHP;
        private System.Windows.Forms.TextBox textBoxHisHP;
        private System.Windows.Forms.Label labelHeChose;
        private System.Windows.Forms.TextBox textBoxHeChose;
    }
}

