namespace ServiceMaster.UIForms.Guides
{
    partial class GuideCptBws
    {
        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows ������������ɵĴ���

        /// <summary>
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtNoComputerBrowser = new System.Windows.Forms.RadioButton();
            this.rbtCmputerBrowser = new System.Windows.Forms.RadioButton();
            this.lable3 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rbtNoComputerBrowser);
            this.splitContainer1.Panel2.Controls.Add(this.rbtCmputerBrowser);
            this.splitContainer1.Panel2.Controls.Add(this.lable3);
            // 
            // rbtNoComputerBrowser
            // 
            this.rbtNoComputerBrowser.AutoSize = true;
            this.rbtNoComputerBrowser.Location = new System.Drawing.Point(40, 120);
            this.rbtNoComputerBrowser.Name = "rbtNoComputerBrowser";
            this.rbtNoComputerBrowser.Size = new System.Drawing.Size(59, 16);
            this.rbtNoComputerBrowser.TabIndex = 10;
            this.rbtNoComputerBrowser.TabStop = true;
            this.rbtNoComputerBrowser.Text = "������";
            this.rbtNoComputerBrowser.UseVisualStyleBackColor = true;
            // 
            // rbtCmputerBrowser
            // 
            this.rbtCmputerBrowser.AutoSize = true;
            this.rbtCmputerBrowser.Location = new System.Drawing.Point(40, 88);
            this.rbtCmputerBrowser.Name = "rbtCmputerBrowser";
            this.rbtCmputerBrowser.Size = new System.Drawing.Size(47, 16);
            this.rbtCmputerBrowser.TabIndex = 9;
            this.rbtCmputerBrowser.TabStop = true;
            this.rbtCmputerBrowser.Text = "����";
            this.rbtCmputerBrowser.UseVisualStyleBackColor = true;
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(38, 45);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(125, 12);
            this.lable3.TabIndex = 8;
            this.lable3.Text = "�㾭��ʹ�������ھ�ô";
            // 
            // Guide3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(518, 332);
            this.Name = "Guide3";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtNoComputerBrowser;
        private System.Windows.Forms.RadioButton rbtCmputerBrowser;
        private System.Windows.Forms.Label lable3;
    }
}
