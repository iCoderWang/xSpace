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
    }

}

