namespace ServiceMaster.UIForms.Guides
{
    partial class GuideFW
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
            this.rbtNoFW = new System.Windows.Forms.RadioButton();
            this.rbtFW = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rbtNoFW);
            this.splitContainer1.Panel2.Controls.Add(this.rbtFW);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            // 
            // rbtNoFW
            // 
            this.rbtNoFW.AutoSize = true;
            this.rbtNoFW.Location = new System.Drawing.Point(39, 152);
            this.rbtNoFW.Name = "rbtNoFW";
            this.rbtNoFW.Size = new System.Drawing.Size(59, 16);
            this.rbtNoFW.TabIndex = 13;
            this.rbtNoFW.TabStop = true;
            this.rbtNoFW.Text = "��ʹ��";
            this.rbtNoFW.UseVisualStyleBackColor = true;
            // 
            // rbtFW
            // 
            this.rbtFW.AutoSize = true;
            this.rbtFW.Location = new System.Drawing.Point(39, 116);
            this.rbtFW.Name = "rbtFW";
            this.rbtFW.Size = new System.Drawing.Size(47, 16);
            this.rbtFW.TabIndex = 12;
            this.rbtFW.TabStop = true;
            this.rbtFW.Text = "ʹ��";
            this.rbtFW.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "��ʹ��Windows����ǽô";
            // 
            // GuideFW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(518, 332);
            this.Name = "GuideFW";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtNoFW;
        private System.Windows.Forms.RadioButton rbtFW;
        private System.Windows.Forms.Label label13;
    }
}
