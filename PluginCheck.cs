using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Collections;
namespace ServiceMaster
{
    public static class PluginCheck
    {
        /// <summary>
        /// ��ȡPlugin�ļ��������еĹ��ܲ��
        /// </summary>
        /// <returns></returns>
        public static IPluginMenu[] getAllPluginsMenu()
        {
            IPluginInfo[] plugins = getAllPluginsInfo();
            List<IPluginMenu> menus = new List<IPluginMenu>();
            foreach (IPluginInfo plugin in plugins)
            {
                if (plugin is IPluginMenu)
                    menus.Add((IPluginMenu)plugin);
            }
            return menus.ToArray();
        }
        /// <summary>
        /// ��ȡPlugin�ļ��������еĲ��
        /// </summary>
        /// <returns></returns>
        public static IPluginInfo[] getAllPluginsInfo()
        {
            if (Directory.Exists(Directory.GetCurrentDirectory() + @"\Plugin"))
            {
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Plugin");
                List<IPluginInfo> dlls = new List<IPluginInfo>();
                foreach(string file in files)
                {
                    FileInfo info = new FileInfo(file);
                    if (info.Extension == ".dll")
                        dlls.Add(getPluginClass(info.Name, "PluginInfo"));
                }
                return dlls.ToArray();
            }
            else
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Plugin");
                return new IPluginInfo[0];
            }
        }
        /// <summary>
        /// ��ȡ����е�ָ������
        /// </summary>
        /// <param name="filename">���DLL�ļ�����������׺����������Ŀ¼�����˴��ļ�����Ҫ��������������ռ�һ��</param>
        /// <param name="className">��Ҫ��������֣�����Ҫ�����ռ�</param>
        /// <returns></returns>
        public static IPluginInfo getPluginClass(string filename,string className)
        {
            Assembly ass = null;
            try
            {
                ass = Assembly.LoadFrom(@"plugin\" + filename);
            }
            catch (BadImageFormatException)
            {
                return null;
            }
            string nspace=System.IO.Path.GetFileNameWithoutExtension(filename);
            Type PluginClass = ass.GetType(nspace + "." + className);
            if (PluginClass==null)
                return null;
            Object o = Activator.CreateInstance(PluginClass);
            IPluginInfo info = (IPluginInfo)o;
            return info;
        }
        /// <summary>
        /// ��ȡ�������
        /// </summary>
        /// <param name="plugin">�������</param>
        /// <returns></returns>
        public static string getPluginType(IPluginInfo plugin)
        {
            string type = string.Empty;
            if (plugin is IPluginMenu)
                type += "���ݲ˵����";
            if (plugin is IPluginUI)
            {
                if (type != string.Empty)
                    type += ",";
                type += "��۲��";
            }
            if (plugin is IPluginSysInfo)
            {
                if (type != string.Empty)
                    type += ",";
                type += "ϵͳ��Ϣ���";
            }
            if (type == string.Empty)
                type += "�������";
            return type;
        }
    }
}
