﻿using YU.Core.YUComponent;

namespace YPT.Forms
{
    partial class UserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFrm));
            this.backPanel = new System.Windows.Forms.Panel();
            this.grUserInfo = new System.Windows.Forms.GroupBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.cmbSite = new YU.Core.YUComponent.YUComboBox(this.components);
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grOther = new System.Windows.Forms.GroupBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.nudOrder = new System.Windows.Forms.NumericUpDown();
            this.cbTwo_StepVerification = new System.Windows.Forms.CheckBox();
            this.lblSecurityQuestionOrder = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            this.grUserInfo.SuspendLayout();
            this.grOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.White;
            this.backPanel.Controls.Add(this.grUserInfo);
            this.backPanel.Controls.Add(this.grOther);
            this.backPanel.Controls.Add(this.btnConfirm);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.backPanel.Size = new System.Drawing.Size(422, 467);
            this.backPanel.TabIndex = 1;
            // 
            // grUserInfo
            // 
            this.grUserInfo.Controls.Add(this.lblSite);
            this.grUserInfo.Controls.Add(this.cmbSite);
            this.grUserInfo.Controls.Add(this.lblUserName);
            this.grUserInfo.Controls.Add(this.lblPassWord);
            this.grUserInfo.Controls.Add(this.txtPassWord);
            this.grUserInfo.Controls.Add(this.txtUserName);
            this.grUserInfo.Location = new System.Drawing.Point(12, 17);
            this.grUserInfo.Name = "grUserInfo";
            this.grUserInfo.Size = new System.Drawing.Size(397, 177);
            this.grUserInfo.TabIndex = 12;
            this.grUserInfo.TabStop = false;
            this.grUserInfo.Text = "用户信息";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(25, 33);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(40, 20);
            this.lblSite.TabIndex = 5;
            this.lblSite.Text = "PT站";
            // 
            // cmbSite
            // 
            this.cmbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Items.AddRange(new object[] {
            "TTG",
            "MTEAM",
            "CHDBITS",
            "OURBITS",
            "KEEPFRDS"});
            this.cmbSite.Location = new System.Drawing.Point(93, 29);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(263, 28);
            this.cmbSite.TabIndex = 0;
            this.cmbSite.SelectedIndexChanged += new System.EventHandler(this.cmbSite_SelectedIndexChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(14, 83);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(51, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "用户名";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(28, 134);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(37, 20);
            this.lblPassWord.TabIndex = 2;
            this.lblPassWord.Text = "密码";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(93, 131);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '●';
            this.txtPassWord.Size = new System.Drawing.Size(263, 26);
            this.txtPassWord.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(93, 80);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(263, 26);
            this.txtUserName.TabIndex = 3;
            // 
            // grOther
            // 
            this.grOther.Controls.Add(this.lblTip);
            this.grOther.Controls.Add(this.nudOrder);
            this.grOther.Controls.Add(this.cbTwo_StepVerification);
            this.grOther.Controls.Add(this.lblSecurityQuestionOrder);
            this.grOther.Controls.Add(this.txtAnswer);
            this.grOther.Controls.Add(this.lblSecurityQuestion);
            this.grOther.Location = new System.Drawing.Point(12, 200);
            this.grOther.Name = "grOther";
            this.grOther.Size = new System.Drawing.Size(397, 184);
            this.grOther.TabIndex = 11;
            this.grOther.TabStop = false;
            this.grOther.Text = "登录信息";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTip.Location = new System.Drawing.Point(248, 52);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(138, 16);
            this.lblTip.TabIndex = 13;
            this.lblTip.Text = "（没有启用安全提问设置-1）";
            // 
            // nudOrder
            // 
            this.nudOrder.Location = new System.Drawing.Point(103, 47);
            this.nudOrder.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudOrder.Name = "nudOrder";
            this.nudOrder.Size = new System.Drawing.Size(139, 26);
            this.nudOrder.TabIndex = 12;
            // 
            // cbTwo_StepVerification
            // 
            this.cbTwo_StepVerification.AutoSize = true;
            this.cbTwo_StepVerification.Location = new System.Drawing.Point(103, 142);
            this.cbTwo_StepVerification.Name = "cbTwo_StepVerification";
            this.cbTwo_StepVerification.Size = new System.Drawing.Size(112, 24);
            this.cbTwo_StepVerification.TabIndex = 11;
            this.cbTwo_StepVerification.Text = "启用两步验证";
            this.cbTwo_StepVerification.UseVisualStyleBackColor = true;
            // 
            // lblSecurityQuestionOrder
            // 
            this.lblSecurityQuestionOrder.AutoSize = true;
            this.lblSecurityQuestionOrder.Location = new System.Drawing.Point(10, 50);
            this.lblSecurityQuestionOrder.Name = "lblSecurityQuestionOrder";
            this.lblSecurityQuestionOrder.Size = new System.Drawing.Size(65, 20);
            this.lblSecurityQuestionOrder.TabIndex = 7;
            this.lblSecurityQuestionOrder.Text = "问题序号";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(103, 97);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(263, 26);
            this.txtAnswer.TabIndex = 10;
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(38, 100);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(37, 20);
            this.lblSecurityQuestion.TabIndex = 9;
            this.lblSecurityQuestion.Text = "答案";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(166, 408);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 30);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // UserFrm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 467);
            this.Controls.Add(this.backPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户";
            this.backPanel.ResumeLayout(false);
            this.grUserInfo.ResumeLayout(false);
            this.grUserInfo.PerformLayout();
            this.grOther.ResumeLayout(false);
            this.grOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private YUComboBox cmbSite;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.Label lblSecurityQuestionOrder;
        private System.Windows.Forms.GroupBox grUserInfo;
        private System.Windows.Forms.GroupBox grOther;
        private System.Windows.Forms.CheckBox cbTwo_StepVerification;
        private System.Windows.Forms.NumericUpDown nudOrder;
        private System.Windows.Forms.Label lblTip;
    }
}