namespace ServiceMaster.UIForms.Guides
{
    partial class GuideAVP
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
            this.rbtNoAVP = new System.Windows.Forms.RadioButton();
            this.rbtAVP = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rbtNoAVP);
            this.splitContainer1.Panel2.Controls.Add(this.rbtAVP);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Size = new System.Drawing.Size(514, 327);
            this.splitContainer1.SplitterDistance = 203;
            // 
            // rbtNoAVP
            // 
            this.rbtNoAVP.AutoSize = true;
            this.rbtNoAVP.Location = new System.Drawing.Point(45, 170);
            this.rbtNoAVP.Name = "rbtNoAVP";
            this.rbtNoAVP.Size = new System.Drawing.Size(59, 16);
            this.rbtNoAVP.TabIndex = 15;
            this.rbtNoAVP.TabStop = true;
            this.rbtNoAVP.Text = "����Ҫ";
            this.rbtNoAVP.UseVisualStyleBackColor = true;
            // 
            // rbtAVP
            // 
            this.rbtAVP.AutoSize = true;
            this.rbtAVP.Location = new System.Drawing.Point(45, 136);
            this.rbtAVP.Name = "rbtAVP";
            this.rbtAVP.Size = new System.Drawing.Size(47, 16);
            this.rbtAVP.TabIndex = 14;
            this.rbtAVP.TabStop = true;
            this.rbtAVP.Text = "��Ҫ";
            this.rbtAVP.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 12);
            this.label15.TabIndex = 13;
            this.label15.Text = "����ķǳ���Ҫʹ�ÿ���˹��ô";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "ϵͳ��ⷢ����ʹ���˿���˹��";
            // 
            // GuideAVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(514, 327);
            this.Name = "GuideAVP";
            this.Load += new System.EventHandler(this.GuideAVP_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtNoAVP;
        private System.Windows.Forms.RadioButton rbtAVP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}
