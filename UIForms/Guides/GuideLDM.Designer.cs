namespace ServiceMaster.UIForms.Guides
{
    partial class GuideLDM
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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbtNoDM = new System.Windows.Forms.RadioButton();
            this.rbtDM = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.radioButton3);
            this.splitContainer1.Panel2.Controls.Add(this.rbtNoDM);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.rbtDM);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(33, 166);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(167, 16);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "��֪��ʲô���߼����̹���";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbtNoDM
            // 
            this.rbtNoDM.AutoSize = true;
            this.rbtNoDM.Location = new System.Drawing.Point(33, 129);
            this.rbtNoDM.Name = "rbtNoDM";
            this.rbtNoDM.Size = new System.Drawing.Size(59, 16);
            this.rbtNoDM.TabIndex = 11;
            this.rbtNoDM.TabStop = true;
            this.rbtNoDM.Text = "������";
            this.rbtNoDM.UseVisualStyleBackColor = true;
            // 
            // rbtDM
            // 
            this.rbtDM.AutoSize = true;
            this.rbtDM.Location = new System.Drawing.Point(33, 94);
            this.rbtDM.Name = "rbtDM";
            this.rbtDM.Size = new System.Drawing.Size(47, 16);
            this.rbtDM.TabIndex = 10;
            this.rbtDM.TabStop = true;
            this.rbtDM.Text = "����";
            this.rbtDM.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "�㾭��ʹ���߼����̹���ô";
            // 
            // Guide4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(518, 332);
            this.Name = "Guide4";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbtNoDM;
        private System.Windows.Forms.RadioButton rbtDM;
        private System.Windows.Forms.Label label3;
    }
}
