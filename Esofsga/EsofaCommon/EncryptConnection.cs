using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsofaCommon
{

    /// <summary>
    /// 连接字符串中包含数据库的访问信息，帐号和密码，因此一般不以明文显示，本代码用来加密连接字符串
    /// </summary>
    public static class EncryptConnection
    {
        public static void Encrypt(bool encrypt)
        {
            Configuration configFile = null;
            try
            {
                // Open the configuration file and retrieve the connectionStrings section.
                configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConnectionStringsSection configSection = configFile.GetSection("connectionStrings") as ConnectionStringsSection;
                if ((!(configSection.ElementInformation.IsLocked)) && (!(configSection.SectionInformation.IsLocked)))
                {
                    if (encrypt && !configSection.SectionInformation.IsProtected)
                    //encrypt is false to unencrypt
                    {
                        configSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    }
                    if (!encrypt && configSection.SectionInformation.IsProtected)
                    //encrypt is true so encrypt
                    {
                        configSection.SectionInformation.UnprotectSection();
                    }
                    //re-save the configuration file section
                    configSection.SectionInformation.ForceSave = true;
                    // Save the current configuration.
                    configFile.Save();
                }
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
            finally
            {
            }
        }
        /// <summary>
        ///　对appSettings节点添加健值
        ///　如果健已经存在则更改值
        ///　添加后重新保存并刷新该节点
        /// </summary>
        /// <param name="dict">添加的健值集合</param>
        /// <param name="isProtected">是否加密appSettings节点数据,如果为TrueappSettings节点下所有数据都会被加密</param>
        public static void AddConfig(System.Collections.Generic.Dictionary<string, string> dict, bool isProtected)
        {
            if (dict == null || dict.Count <= 0) return;
            System.Configuration.Configuration configuration = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //循环添加或更改健值
            foreach (System.Collections.Generic.KeyValuePair<string, string> key_value in dict)
            {
                if (string.IsNullOrEmpty(key_value.Key)) continue;
                if (configuration.AppSettings.Settings[key_value.Key] != null)
                    configuration.AppSettings.Settings[key_value.Key].Value = key_value.Value;
                else
                    configuration.AppSettings.Settings.Add(key_value.Key, key_value.Value);
            }

            //保存配置文件
            try
            {
                //加密配置信息
                if (isProtected && !configuration.AppSettings.SectionInformation.IsProtected)
                {
                    configuration.AppSettings.SectionInformation.ForceSave = true;
                    configuration.AppSettings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
                configuration.Save();
            }
            catch (Exception)
            {
                throw;
            }
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}


