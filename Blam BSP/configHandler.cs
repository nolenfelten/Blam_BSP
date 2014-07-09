using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Blam_BSP
{
    //class configHandler
    public class mapPathsSection : ConfigurationSection    
    {
        [ConfigurationProperty("main_menu_path", DefaultValue = "", IsRequired = true)]
        public String mainMenuPath
        {
            get
            {
                return (String)this["main_menu_path"];
            }
            set
            {
                this["main_menu_path"] = value;
            }
        }
        [ConfigurationProperty("sp_shared_path", DefaultValue = "", IsRequired = true)]
        public String mainMenuPath
        {
            get
            {
                return (String)this["sp_shared_path"];
            }
            set
            {
                this["sp_shared_path"] = value;
            }
        }
        [ConfigurationProperty("mp_shared_path", DefaultValue = "", IsRequired = true)]
        public String mainMenuPath
        {
            get
            {
                return (String)this["mp_shared_path"];
            }
            set
            {
                this["mp_shared_path"] = value;
            }
        }
    }
}
