using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.IO;
using ServiceMaster.UIForms.Guides;
namespace ServiceMaster
{
    public partial class MainFrom : Form
    {
        ServiceController[] ser;
        public MainFrom()
        {
            InitializeComponent();            
            serviceListInit(ser,"DisplayName");
            sortTreeView.ExpandAll();
            const int CS_DropSHADOW = 0x20000;
            const int GCL_STYLE = (-26);   
            WinAPI.SetClassLong(this.Handle, GCL_STYLE, WinAPI.GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.Parent = WinAPI.GetWindow();
                return cp;
            }
        }

        private void SetWindowShadow(byte bAlpha)
        {
            WinAPI.SetWindowLong(this.Handle, (int)WinAPI.WindowStyle.GWL_EXSTYLE,
            WinAPI.GetWindowLong(this.Handle, (int)WinAPI.WindowStyle.GWL_EXSTYLE) | (uint)WinAPI.ExWindowStyle.WS_EX_LAYERED);

            WinAPI.SetLayeredWindowAttributes(this.Handle, 0, bAlpha, WinAPI.LWA_COLORKEY | WinAPI.LWA_ALPHA);
        }
        private void serviceListInit(ServiceController[] ser)
        {
            lbxRunning.DisplayMember = "DisplayName";//"DisplayName";
            lbxRunning.DataSource = ser;
            lblCount.Text = string.Format("����{0}��", ser.Length);
        }
        private void serviceListInit(ServiceController[] ser,string displayMember)
        {
            lbxRunning.DisplayMember = displayMember;
            lbxRunning.DataSource = ser;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            Welcome wel = new Welcome();
            wel.ShowDialog();
            ser = ServiceControl.getRunServices();
            MenuInit();
        }
        private void lbxRunning_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceController sc = (ServiceController)(lbxRunning.SelectedItem);;
            ServiceDetailInit(sc);
            lbxDepandentSvc.DataSource = sc.DependentServices;
            lbxSvcDependOn.DataSource = sc.ServicesDependedOn;
        }
        private void ServiceDetailInit(ServiceController sc)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            string name = sc.ServiceName;
            lblRunMode.Text = ServiceControl.getStartType(name);
            lblServiceName.Text = name;
            lblDisplayName.Text = sc.DisplayName;
            lblStatus.Text = ServiceControl.getRunStatus(sc.Status);
            tbxSysDescription.Text = ServiceControl.getSystemDescription(name);
            string comment = "";
            try
            {
                comment = ServiceControl.getComment(name);
            }
            catch(Exception)
            {
                comment = "���ݿ��ȡ����";
            }
            if (!comment.Equals(""))
            {
                tbxComment.Text = comment;
            }
            lblSuggest.Text = ServiceControl.getSuggest(name);
            lblSuggestAdv.Text = ServiceControl.getSuggestAdvance(name);
            toolTip1.SetToolTip(lbxRunning, ServiceControl.getPath(name));
            if (sc.Status == ServiceControllerStatus.Running)
            {
                btnStart.Enabled = false;
                if (sc.CanPauseAndContinue == false)
                    btnPause.Enabled = false;                    
            }
            else if (sc.Status == ServiceControllerStatus.Stopped)
            {
                btnStop.Enabled = false;
                btnPause.Enabled = false;
            }
            else if (sc.Status == ServiceControllerStatus.Paused)
            {
                btnPause.Enabled = false;
                btnStop.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceController[] ser = ServiceControl.getStopedServices();
            serviceListInit(ser);
        }

        private void sortTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lbxServiceRefresh();
        }
        private void lbxServiceRefresh()
        {
            ServiceController[] ser = ServiceControl.getServices();
            if (sortTreeView.SelectedNode.Tag == null)
            {
                ser = ServiceControl.getServices();
                lblService.Text = "ȫ������";
            }
            else if (sortTreeView.SelectedNode.Parent == sortTreeView.Nodes["ByStatus"])
            {
                int type = Convert.ToInt32(sortTreeView.SelectedNode.Tag);
                ServiceControllerStatus st = (ServiceControllerStatus)(type);
                ser = ServiceControl.getServices(st);
                lblService.Text = "��ǰϵͳ��" + sortTreeView.SelectedNode.Text + "�ķ���";
            }
            else if (sortTreeView.SelectedNode.Parent == sortTreeView.Nodes["StartType"])
            {
                int type = Convert.ToInt32(sortTreeView.SelectedNode.Tag);
                ser = ServiceControl.getServices(type);
                lblService.Text = "��ǰϵͳ��" + sortTreeView.SelectedNode.Text + "�ķ���";
            }
            else if (sortTreeView.SelectedNode.Parent == sortTreeView.Nodes["CanControl"])
            {
                int select = sortTreeView.SelectedNode.Index;
                switch (select)
                {
                    case 0:
                        ser = ServiceControl.getCanStopServices();
                        break;
                    case 1:
                        ser = ServiceControl.getCanNotStopServices();
                        break;
                    case 2:
                        ser = ServiceControl.getCanPauAndConStopServices();
                        break;
                    case 3:
                        ser = ServiceControl.getCanNotPauAndConStopServices();
                        break;
                    case 4:
                        ser = ServiceControl.getStopedServices();
                        break;
                }
                lblService.Text = "��ǰϵͳ��" + sortTreeView.SelectedNode.Text + "�ķ���";
            }
            else if (sortTreeView.SelectedNode.Parent == sortTreeView.Nodes["ServiceProcess"])
            {
                int select = sortTreeView.SelectedNode.Index;
                switch (select)
                {
                    case 0:
                        ser = ServiceControl.getOwnServices();
                        break;
                    case 1:
                        ser = ServiceControl.getShareServices();
                        break;
                    case 2:
                        ser = ServiceControl.getInteractiveService();
                        break;
                }
                lblService.Text = "��ǰϵͳ������Ϊ" + sortTreeView.SelectedNode.Text + "�ķ���";
            }
            else if (sortTreeView.SelectedNode.Parent == sortTreeView.Nodes["LogonType"])
            {
                int select = sortTreeView.SelectedNode.Index;
                switch (select)
                {
                    case 0:
                        ser = ServiceControl.getServices(ServiceAccount.LocalSystem);
                        break;
                    case 1:
                        ser = ServiceControl.getServices(ServiceAccount.LocalService);
                        break;
                    case 2:
                        ser = ServiceControl.getServices(ServiceAccount.NetworkService);
                        break;
                }
                lblService.Text = "��ǰϵͳ�е�¼����Ϊ" + sortTreeView.SelectedNode.Text + "�ķ���";
            }
            else if (sortTreeView.SelectedNode.Parent == sortTreeView.Nodes["SearchResult"])
            {
                String keyWord = sortTreeView.SelectedNode.Name;
                lblService.Text = "�������";
                //ser = ServiceMaster.getServices(keyWord);
                try
                {
                    ser = ServiceControl.getServices(keyWord);
                }
                catch(Exception)
                {
                    MessageBox.Show("���ݿ��ļ�����");
                }
            }
            serviceListInit(ser);         
        }
        private void lbxSvcDependOn_DoubleClick(object sender, EventArgs e)
        {
            ServiceController sc = (ServiceController)(((ListBox)sender).SelectedItem);
            ServiceDetailInit(sc);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Boolean success=ServiceControl.stopService(lblServiceName.Text);
            if (success)
                MessageBox.Show(lblDisplayName.Text + "������ֹͣ");
            else
                MessageBox.Show("�����޷�ֹͣ");
            lbxServiceRefresh();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text.Equals("��ͣ"))
            {
                Boolean success = ServiceControl.continueService(lblServiceName.Text);
                if (success)
                    MessageBox.Show(lblDisplayName.Text + "�����Ѽ���");
                else
                    MessageBox.Show("�����޷�����");
            }
            else
            {
                Boolean success = ServiceControl.startService(lblServiceName.Text);
                if (success)
                    MessageBox.Show(lblDisplayName.Text + "����������");
                else
                    MessageBox.Show("�����޷�����");
            }
            lbxServiceRefresh();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Boolean success = ServiceControl.pauseService(lblServiceName.Text);
            if (success)
                MessageBox.Show(lblDisplayName.Text + "��������ͣ");
            else
                MessageBox.Show("�����޷���ͣ");
            lbxServiceRefresh();
        }

        private void outputConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputSvcList svcl = new OutputSvcList();
            if (svcl.DialogResult!=DialogResult.Cancel)    
                svcl.ShowDialog();
        }

        private void inputConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.RestoreDirectory = true;
            opd.Filter = "ServiceMaster�б��ļ�(*.sml)|*.sml|�ı��ļ�(*.txt)|*.txt|�����ļ�(*.*)|*.*";
            opd.ShowDialog();
            string fileName = opd.FileName;
            if (fileName.Equals(""))
                opd.Dispose();
            else
            {
                int svcNum = ServiceControl.inputConfig(fileName);
                MessageBox.Show(svcNum + "�������������Ϣ�ѵ���");
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ServiceControl.setStartType(lblServiceName.Text, 4);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            ServiceControl.setStartType(lblServiceName.Text, 2);
        }

        private void btnDemand_Click(object sender, EventArgs e)
        {
            ServiceControl.setStartType(lblServiceName.Text, 3);
        }

        private void OptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.ShowDialog();
        }

        private void outputBatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceBatch sb = new ServiceBatch();
            sb.ShowDialog();
        }

        private void GuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuideBase[] lst ={ 
                new GuideWel(), 
                new GuideAutoUpd(), 
                new GuideCptBws(), 
                new GuidePt(), 
                new GuideLDM(),
                new GuideFW(),
                new Guideimap(),
                new GuideTask(),
                new GuideTheme(),
                new GuideVM(),
                new GuideSQL(),
                new GuideAVP(),
                new GuideFinish()};
            GuideControl gc = new GuideControl(lst);
            gc.doStart();
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortTreeView.SelectedNode = sortTreeView.Nodes[0].Nodes[0];
        }

        private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortTreeView.SelectedNode = sortTreeView.Nodes[0].Nodes[1];

        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortTreeView.SelectedNode = sortTreeView.Nodes[0].Nodes[2];
        }

        private void AutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortTreeView.SelectedNode = sortTreeView.Nodes[1].Nodes[0];
        }

        private void DemandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortTreeView.SelectedNode = sortTreeView.Nodes[1].Nodes[1];
        }

        private void DisabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortTreeView.SelectedNode = sortTreeView.Nodes[1].Nodes[2];
        }

        private void ShareToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sortTreeView.SelectedNode = sortTreeView.Nodes[3].Nodes[1];
        }

        private void OwnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortTreeView.SelectedNode = sortTreeView.Nodes[3].Nodes[0];

        }

        private void InteractiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortTreeView.SelectedNode = sortTreeView.Nodes[3].Nodes[2];
        }

        private void localSvcToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sortTreeView.SelectedNode = sortTreeView.Nodes[4].Nodes[1];
        }

        private void NTsvcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortTreeView.SelectedNode = sortTreeView.Nodes[4].Nodes[2];
        }

        private void localSysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortTreeView.SelectedNode = sortTreeView.Nodes[4].Nodes[0];
        }

        private void CurrentSvcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortTreeView.SelectedNode = sortTreeView.Nodes[0];
        }

        private void QuickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceOptimizer qso = new ServiceOptimizer(false);
            qso.ShowDialog();
        }

        private void MasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceOptimizer qso = new ServiceOptimizer(true);
            qso.ShowDialog();
        }

        private void ViewLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\EVENTLOG.LOG"))
            {
                LogViewer logVi = new LogViewer();
                logVi.ShowDialog();
            }
            else
            {
                MessageBox.Show("��־�ļ������ڣ���");
            }
        }

        private void ClearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceControl.clearEventLog();
        }

        private void sQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = (string)((ToolStripMenuItem)sender).Tag;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.bat";
            sfd.AddExtension = true;
            sfd.Title = "������������������";
            sfd.Filter = "�������ļ�(*.bat)|*.bat";
            sfd.FileName = name + " start.bat";
            sfd.ShowDialog();
            try
            {
                if (!sfd.FileName.Equals(""))
                {
                    File.Copy(Application.StartupPath + "\\BatchFile\\" + name + " start.bat", sfd.FileName,true);
                }
                sfd.Title = "����ֹͣ����������";

                sfd.FileName = name + " stop.bat";
                sfd.ShowDialog();
                if (!sfd.FileName.Equals(""))
                {
                    File.Copy(Application.StartupPath + "\\BatchFile\\" + name + " stop.bat", sfd.FileName,true);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("�ļ��Ѷ�ʧ!");
            }
        }

        private void ModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void tbxSearchText_Click(object sender, EventArgs e)
        {
            tbxSearch.SelectAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            newSearch(tbxSearch.Text);
        }

        private void OutputBatchFile_Click(object sender, EventArgs e)
        {
            int selectCount=lbxRunning.SelectedItems.Count;
            List<ServiceController> svcs = new List<ServiceController>();
            for (int i=0;i<selectCount;i++)
            {
                svcs.Add((ServiceController)lbxRunning.SelectedItems[i]);
            }
            ServiceController[] svcList = svcs.ToArray();
            ServiceBatch sb = new ServiceBatch(svcList);
            sb.ShowDialog();                    
        }
        private void newSearch(string keyWord)
        {
            TreeNode searchNodes = sortTreeView.Nodes["SearchResult"];
            TreeNode tn = new TreeNode();
            tn.Tag = "Search";
            tn.Text = "���������" + keyWord;
            tn.Name = keyWord;
            searchNodes.Nodes.Add(tn);
            searchNodes.Expand();
        }
        private void tbxSearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                newSearch(tbxSearch.Text);
        }

        private void OutputConfig_Click(object sender, EventArgs e)
        {
            ServiceController[] svcs=new ServiceController[lbxRunning.SelectedItems.Count];
            for (int i=0;i<lbxRunning.SelectedItems.Count;i++)
            {
                svcs[i]=(ServiceController)lbxRunning.SelectedItems[i];
            }
            OutputSvcList osl = new OutputSvcList(svcs);
            osl.ShowDialog();
        }

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PluginInfoForm pim = new PluginInfoForm();
            pim.ShowDialog();
        }
        private void MenuInit()
        {
            for (int i = 6; i < this.menuStrip1.Items.Count; i++)
                this.menuStrip1.Items.RemoveAt(i);
            IPluginMenu[] menus = PluginCheck.getAllPluginsMenu();
            foreach(IPluginMenu menu in menus)
                this.menuStrip1.Items.Add(menu.PluginMenu);
        }
    }
}