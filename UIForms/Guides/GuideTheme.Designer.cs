namespace ServiceMaster.UIForms.Guides
{
    partial class GuideTheme
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
            this.rbtNoTheme = new System.Windows.Forms.RadioButton();
            this.rbtTheme = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rbtNoTheme);
            this.splitContainer1.Panel2.Controls.Add(this.rbtTheme);
            this.splitContainer1.Panel2.Controls.Add(this.label20);
            // 
            // rbtNoTheme
            // 
            this.rbtNoTheme.AutoSize = true;
            this.rbtNoTheme.Location = new System.Drawing.Point(67, 161);
            this.rbtNoTheme.Name = "rbtNoTheme";
            this.rbtNoTheme.Size = new System.Drawing.Size(59, 16);
            this.rbtNoTheme.TabIndex = 14;
            this.rbtNoTheme.TabStop = true;
            this.rbtNoTheme.Text = "��ʹ��";
            this.rbtNoTheme.UseVisualStyleBackColor = true;
            // 
            // rbtTheme
            // 
            this.rbtTheme.AutoSize = true;
            this.rbtTheme.Location = new System.Drawing.Point(67, 116);
            this.rbtTheme.Name = "rbtTheme";
            this.rbtTheme.Size = new System.Drawing.Size(47, 16);
            this.rbtTheme.TabIndex = 13;
            this.rbtTheme.TabStop = true;
            this.rbtTheme.Text = "ʹ��";
            this.rbtTheme.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(65, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 12);
            this.label20.TabIndex = 12;
            this.label20.Text = "��ʹ��Windows����ô";
            // 
            // GuideTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(518, 332);
            this.Name = "GuideTheme";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtNoTheme;
        private System.Windows.Forms.RadioButton rbtTheme;
        private System.Windows.Forms.Label label20;
    }
}
