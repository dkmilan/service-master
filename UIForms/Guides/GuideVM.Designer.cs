namespace ServiceMaster.UIForms.Guides
{
    partial class GuideVM
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
            this.rbtNoVM = new System.Windows.Forms.RadioButton();
            this.rbtVM = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rbtNoVM);
            this.splitContainer1.Panel2.Controls.Add(this.rbtVM);
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Size = new System.Drawing.Size(514, 327);
            this.splitContainer1.SplitterDistance = 203;
            // 
            // rbtNoVM
            // 
            this.rbtNoVM.AutoSize = true;
            this.rbtNoVM.Location = new System.Drawing.Point(34, 161);
            this.rbtNoVM.Name = "rbtNoVM";
            this.rbtNoVM.Size = new System.Drawing.Size(47, 16);
            this.rbtNoVM.TabIndex = 13;
            this.rbtNoVM.TabStop = true;
            this.rbtNoVM.Text = "��Ҫ";
            this.rbtNoVM.UseVisualStyleBackColor = true;
            // 
            // rbtVM
            // 
            this.rbtVM.AutoSize = true;
            this.rbtVM.Location = new System.Drawing.Point(34, 130);
            this.rbtVM.Name = "rbtVM";
            this.rbtVM.Size = new System.Drawing.Size(59, 16);
            this.rbtVM.TabIndex = 14;
            this.rbtVM.TabStop = true;
            this.rbtVM.Text = "����Ҫ";
            this.rbtVM.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 12);
            this.label17.TabIndex = 12;
            this.label17.Text = "�㾭��ʹ�����������ô";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(201, 12);
            this.label16.TabIndex = 11;
            this.label16.Text = "ϵͳ��ⷢ����ʹ����VMware�����";
            // 
            // GuideVM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(514, 327);
            this.Name = "GuideVM";
            this.Enter += new System.EventHandler(this.GuideVM_Enter);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtNoVM;
        private System.Windows.Forms.RadioButton rbtVM;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}
