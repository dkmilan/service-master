namespace ServiceMaster.UIForms.Guides
{
    partial class GuideAutoUpd
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
            this.rbtNoAutoUpdate = new System.Windows.Forms.RadioButton();
            this.rbtAutoUpdate = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rbtNoAutoUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.rbtAutoUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(514, 327);
            this.splitContainer1.SplitterDistance = 203;
            // 
            // rbtNoAutoUpdate
            // 
            this.rbtNoAutoUpdate.AutoSize = true;
            this.rbtNoAutoUpdate.Location = new System.Drawing.Point(19, 110);
            this.rbtNoAutoUpdate.Name = "rbtNoAutoUpdate";
            this.rbtNoAutoUpdate.Size = new System.Drawing.Size(35, 16);
            this.rbtNoAutoUpdate.TabIndex = 10;
            this.rbtNoAutoUpdate.TabStop = true;
            this.rbtNoAutoUpdate.Text = "��";
            this.rbtNoAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // rbtAutoUpdate
            // 
            this.rbtAutoUpdate.AutoSize = true;
            this.rbtAutoUpdate.Location = new System.Drawing.Point(19, 75);
            this.rbtAutoUpdate.Name = "rbtAutoUpdate";
            this.rbtAutoUpdate.Size = new System.Drawing.Size(35, 16);
            this.rbtAutoUpdate.TabIndex = 9;
            this.rbtAutoUpdate.TabStop = true;
            this.rbtAutoUpdate.Text = "��";
            this.rbtAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "�㾭��ʹ��XP�Զ�������";
            // 
            // GuideAutoUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(514, 327);
            this.Name = "GuideAutoUpd";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtNoAutoUpdate;
        private System.Windows.Forms.RadioButton rbtAutoUpdate;
        private System.Windows.Forms.Label label7;
    }
}
