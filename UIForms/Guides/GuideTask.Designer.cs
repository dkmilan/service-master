namespace ServiceMaster.UIForms.Guides
{
    partial class GuideTask
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
            this.rbtNoKnownTask = new System.Windows.Forms.RadioButton();
            this.rbtTask = new System.Windows.Forms.RadioButton();
            this.rbtNoTask = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rbtNoKnownTask);
            this.splitContainer1.Panel2.Controls.Add(this.rbtTask);
            this.splitContainer1.Panel2.Controls.Add(this.rbtNoTask);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            // 
            // rbtNoKnownTask
            // 
            this.rbtNoKnownTask.AutoSize = true;
            this.rbtNoKnownTask.Location = new System.Drawing.Point(37, 127);
            this.rbtNoKnownTask.Name = "rbtNoKnownTask";
            this.rbtNoKnownTask.Size = new System.Drawing.Size(143, 16);
            this.rbtNoKnownTask.TabIndex = 14;
            this.rbtNoKnownTask.TabStop = true;
            this.rbtNoKnownTask.Text = "��֪��ʲô�Ǽƻ�����";
            this.rbtNoKnownTask.UseVisualStyleBackColor = true;
            // 
            // rbtTask
            // 
            this.rbtTask.AutoSize = true;
            this.rbtTask.Location = new System.Drawing.Point(37, 83);
            this.rbtTask.Name = "rbtTask";
            this.rbtTask.Size = new System.Drawing.Size(59, 16);
            this.rbtTask.TabIndex = 13;
            this.rbtTask.TabStop = true;
            this.rbtTask.Text = "������";
            this.rbtTask.UseVisualStyleBackColor = true;
            // 
            // rbtNoTask
            // 
            this.rbtNoTask.AutoSize = true;
            this.rbtNoTask.Location = new System.Drawing.Point(37, 105);
            this.rbtNoTask.Name = "rbtNoTask";
            this.rbtNoTask.Size = new System.Drawing.Size(107, 16);
            this.rbtNoTask.TabIndex = 12;
            this.rbtNoTask.TabStop = true;
            this.rbtNoTask.Text = "�����û��߲���";
            this.rbtNoTask.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "�㳣��ʹ�üƻ�����";
            // 
            // GuideTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(518, 332);
            this.Name = "GuideTask";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtNoKnownTask;
        private System.Windows.Forms.RadioButton rbtTask;
        private System.Windows.Forms.RadioButton rbtNoTask;
        private System.Windows.Forms.Label label10;
    }
}
