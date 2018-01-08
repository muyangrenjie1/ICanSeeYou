using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Win32;
/// <summary>
/// 该类用于设置软件开机启动，注册表启动项，开始菜单，系统服务等方式
/// </summary>
namespace ICanSeeYou.Windows
{
    public  class AutoStartup
    {
        string targetpath = Environment.CurrentDirectory + "INCUserver.exe";
        string appname = "税务小助手";
        public bool Reg()
        {
            try
            {
                // 添加到 当前登陆用户的 注册表启动项
                RegistryKey RKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                RKey.SetValue(appname, targetpath);

                // 添加到 所有用户的 注册表启动项
                RegistryKey RKey2 = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                RKey2.SetValue(appname, targetpath);
                return true;
            }
            catch { return false; }
        }
        public bool ShutCut()
        {
            // 获取全局 开始 文件夹位置
            // 获取当前登录用户的 开始 文件夹位置
          string path= Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            return CreateShutCut(path, appname, targetpath); 

        }
        public static bool CreateShutCut(string directory, string shortcutName, string targetPath,string description = null, string iconLocation = null)
        {
            try
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                //添加引用 Com 中搜索 Windows Script Host Object Model
                string shortcutPath = Path.Combine(directory, string.Format("{0}.lnk", shortcutName));
                IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);//创建快捷方式对象
                shortcut.TargetPath = targetPath;//指定目标路径
                shortcut.WorkingDirectory = Path.GetDirectoryName(targetPath);//设置起始位置
                shortcut.WindowStyle = 1;//设置运行方式，默认为常规窗口
                shortcut.Description = description;//设置备注
                //shortcut.IconLocation = string .IsNullOrWhiteSpace(iconLocation) ? targetPath : iconLocation;//设置图标路径
                shortcut.Save();//保存快捷方式

                return true;
            }
            catch
            { }
            return false;
        }
    }
}
