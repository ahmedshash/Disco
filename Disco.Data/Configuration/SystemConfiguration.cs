﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Disco.Data.Repository;
using Disco.Models.Repository;
using System.IO;
using System.Security.Cryptography;
using Disco.Models.BI.Interop.Community;
using Newtonsoft.Json;

namespace Disco.Data.Configuration
{
    public class SystemConfiguration : ConfigurationBase
    {
        public SystemConfiguration(DiscoDataContext dbContext)
            : base(dbContext)
        {
            // Init Modules
            this.moduleBootstrapperConfiguration = new Lazy<Modules.BootstrapperConfiguration>(() => new Modules.BootstrapperConfiguration(dbContext));
            this.moduleDeviceProfilesConfiguration = new Lazy<Modules.DeviceProfilesConfiguration>(() => new Modules.DeviceProfilesConfiguration(dbContext));
            this.moduleOrganisationAddressesConfiguration = new Lazy<Modules.OrganisationAddressesConfiguration>(() => new Modules.OrganisationAddressesConfiguration(dbContext));
        }

        #region Configuration Modules

        private Lazy<Modules.BootstrapperConfiguration> moduleBootstrapperConfiguration;
        private Lazy<Modules.DeviceProfilesConfiguration> moduleDeviceProfilesConfiguration;
        private Lazy<Modules.OrganisationAddressesConfiguration> moduleOrganisationAddressesConfiguration;

        public Modules.BootstrapperConfiguration Bootstrapper
        {
            get
            {
                return moduleBootstrapperConfiguration.Value;
            }
        }
        public Modules.DeviceProfilesConfiguration DeviceProfiles
        {
            get
            {
                return moduleDeviceProfilesConfiguration.Value;
            }
        }
        public Modules.OrganisationAddressesConfiguration OrganisationAddresses
        {
            get
            {
                return moduleOrganisationAddressesConfiguration.Value;
            }
        }

        #endregion

        public override string Scope { get { return "System"; } }

        public string DataStoreLocation
        {
            get
            {
                var result = this.Get<string>(null);
                if (result == null)
                {
                    var appDataPath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data");
                    if (appDataPath.EndsWith("\\"))
                        return appDataPath;
                    else
                        return string.Concat(appDataPath, '\\');
                }
                else
                    return result;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                if (!System.IO.Directory.Exists(value))
                    throw new System.IO.DirectoryNotFoundException(string.Format("DataStoreLocation: '{0}' could not be found", value));
                string storePath;
                if (value.EndsWith("\\"))
                    storePath = value;
                else
                    storePath = string.Concat(value, '\\');
                this.Set(storePath);
            }
        }

        #region Plugin Locations
        public string PluginsLocation
        {
            get
            {
                return System.IO.Path.Combine(this.DataStoreLocation, @"Plugins\");
            }
        }
        public string PluginStorageLocation
        {
            get
            {
                return System.IO.Path.Combine(this.DataStoreLocation, @"PluginStorage\");
            }
        }
        public string PluginPackagesLocation
        {
            get
            {
                return System.IO.Path.Combine(this.DataStoreLocation, @"PluginPackages\");
            }
        }
        #endregion

        #region Organisation Details
        #region Organisation Logo
        private string OrganisationLogoPath
        {
            get
            {
                return System.IO.Path.Combine(DataStoreLocation, "OrganisationLogo.png");
            }
        }
        public string OrganisationLogoHash
        {
            get
            {
                var path = this.OrganisationLogoPath;
                if (File.Exists(path))
                    return File.GetLastWriteTimeUtc(path).ToBinary().ToString();
                else
                    return "-1";
            }
        }
        public Stream OrganisationLogo
        {
            get
            {
                var path = this.OrganisationLogoPath;
                if (File.Exists(path))
                    return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                else
                    return new MemoryStream(Disco.Data.Properties.Resources.EmptyLogo);
            }
            set
            {
                string organisationLogoPath = this.OrganisationLogoPath;
                if (value == null)
                {
                    if (System.IO.File.Exists(organisationLogoPath))
                        System.IO.File.Delete(organisationLogoPath);
                }
                else
                {
                    using (FileStream fs = new FileStream(organisationLogoPath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        value.CopyTo(fs);
                    }
                }
            }
        }
        #endregion
        public string OrganisationName
        {
            get
            {
                return this.Get<string>(null);
            }
            set
            {
                this.Set(value);
            }
        }
        public bool MultiSiteMode
        {
            get
            {
                return this.Get(false);
            }
            set
            {
                this.Set(value);
            }
        }
        #endregion

        #region Proxy Configuration
        public string ProxyAddress
        {
            get
            {
                return this.Get<string>(null);
            }
            set
            {
                this.Set(value);
            }
        }
        public int ProxyPort
        {
            get
            {
                return this.Get(8080);
            }
            set
            {
                this.Set(value);
            }
        }
        public string ProxyUsername
        {
            get
            {
                return this.Get<string>(null);
            }
            set
            {
                this.Set(value);
            }
        }
        public string ProxyPassword
        {
            get
            {
                return this.GetDeobsfucated(null);
            }
            set
            {
                this.SetObsfucated(value);
            }
        }
        #endregion

        #region UpdateCheck
        public string DeploymentId
        {
            get
            {
                return this.Get<string>(null);
            }
        }
        public UpdateResponse UpdateLastCheck
        {
            get
            {
                return this.GetFromJson<UpdateResponse>(null);
            }
            set
            {
                this.SetAsJson(value);
            }
        }
        public bool UpdateBetaDeployment
        {
            get
            {
                return this.Get<bool>(false);
            }
        }
        public Version InstalledDatabaseVersion
        {
            get
            {
                var versionString = this.Get<string>(null);
                if (string.IsNullOrEmpty(versionString))
                    return null;
                else
                    return Version.Parse(versionString);
            }
            set
            {
                this.Set<string>(value.ToString(4));
            }
        }
        #endregion

    }
}
