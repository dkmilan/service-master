using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace ServiceMaster
{
    public partial class ServiceOptimizer : Form
    {
        Boolean isMaster;
        private ServiceChange[] scList;
        public ServiceOptimizer(Boolean isMasterMode)
        {
            InitializeComponent();
            isMaster = isMasterMode;
            if (isMaster)
                label1.Text = "��ģʽ����ϵͳ��������������ѵ��Ż�";
            scList=ServiceControl.getServiceChangeList(ServiceController.GetServices(), isMaster);
        }

        private void QuickServiceOptimizer_Load(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Next.Text.Equals("��һ��"))
            {
                ListViewItem lvi = new ListViewItem();
                foreach (ServiceChange sc in scList)
                {
                    string[] opInfo=new string[3];
                    opInfo[2]=ServiceControl.getStartType(sc.StartTypeID);
                    opInfo[1]=ServiceControl.getStartType(sc.SvcName);
                    opInfo[0]=new ServiceController(sc.SvcName).DisplayName;
                    lvi = new ListViewItem(opInfo);
                    listView1.Items.Add(lvi);
                }
                Next.Text = "���";
            }
            else
                foreach (ServiceChange sc in scList)
                {
                    sc.doChange();
                    listView1.Items.RemoveAt(0);
                    listView1.Refresh();
                }
        }
    }
}