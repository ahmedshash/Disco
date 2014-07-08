﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Disco.Data.Repository;
using System.ComponentModel.DataAnnotations;
using Disco.BI;
using System.Web.Script.Serialization;
using Disco.Services.Plugins;
using Disco.Services.Plugins.Features.WarrantyProvider;
using Newtonsoft.Json;
using Disco.Services.Users;

namespace Disco.Web.Models.Job
{
    public class LogWarrantyModel
    {
        public Disco.Models.Repository.Job Job { get; set; }
        public List<PluginFeatureManifest> WarrantyProviders { get; set; }
        public PluginFeatureManifest WarrantyProvider { get; set; }
        public List<Disco.Models.BI.Config.OrganisationAddress> OrganisationAddresses { get; set; }
        public Disco.Models.BI.Config.OrganisationAddress OrganisationAddress { get; set; }

        public Disco.Models.Repository.User TechUser { get; set; }

        [Required]
        public int JobId { get; set; }
        [Required(ErrorMessage = "Please specify a Repair Address")]
        public Nullable<int> OrganisationAddressId { get; set; }
        [Required(ErrorMessage = "Please specify a Warranty Provider")]
        public string WarrantyProviderId { get; set; }
        [Required(ErrorMessage = "A fault description is required"), DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
        public string FaultDescription { get; set; }
        [Required]
        public string WarrantyAction { get; set; }

        public bool IsCustomProvider
        {
            get
            {
                return WarrantyProviderId == "CUSTOM";
            }
        }
        public string CustomProviderName { get; set; }
        public string CustomProviderReference { get; set; }

        public Type WarrantyProviderSubmitJobViewType { get; set; }
        public object WarrantyProviderSubmitJobModel { get; set; }
        public string WarrantyProviderPropertiesJson { get; set; }
        public Dictionary<string, string> WarrantyProviderProperties()
        {
            Dictionary<string, string> p = default(Dictionary<string, string>);
            if (!string.IsNullOrEmpty(this.WarrantyProviderPropertiesJson))
            {
                try
                {
                    p = JsonConvert.DeserializeObject<Dictionary<string, string>>(this.WarrantyProviderPropertiesJson);
                }
                catch (Exception)
                {
                    // Ignore Errors
                }
            }
            return p;
        }

        public Dictionary<string, string> DiscloseProperties { get; set; }

        public Exception Error { get; set; }

        public void UpdateModel(DiscoDataContext Database, bool IsPostBack)
        {
            Database.Configuration.LazyLoadingEnabled = true;
            if (Job == null)
            {
                // Update Job User's Details [#12]
                string jobUserId = Database.Jobs.Where(j => j.Id == JobId).Select(j => j.UserId).FirstOrDefault();
                if (jobUserId != null)
                {
                    // Ignore update errors (Most commonly when the User Id no longer exists in AD)
                    try
                    {
                        UserService.GetUser(jobUserId, Database, true);
                    } catch (Exception) {}
                }

                Job = (from j in Database.Jobs.Include("Device.DeviceModel").Include("JobMetaWarranty").Include("JobSubTypes")
                       where (j.Id == JobId)
                       select j).FirstOrDefault();
                if (Job == null)
                {
                    throw new ArgumentException("Invalid Job Number Specified", "JobId");
                }
            }

            // Update TechUser's Details [#12]
            this.TechUser = UserService.GetUser(UserService.CurrentUserId, Database, true);

            WarrantyProviders = Plugins.GetPluginFeatures(typeof(WarrantyProviderFeature));

            if (!IsPostBack && string.IsNullOrEmpty(WarrantyProviderId))
            {
                WarrantyProviderId = Job.Device.DeviceModel.DefaultWarrantyProvider;
            }

            if (!string.IsNullOrEmpty(WarrantyProviderId) && WarrantyProviderId != "CUSTOM")
                WarrantyProvider = Plugins.GetPluginFeature(WarrantyProviderId, typeof(WarrantyProviderFeature));

            this.OrganisationAddresses = Database.DiscoConfiguration.OrganisationAddresses.Addresses.OrderBy(a => a.Name).ToList();

            if (!IsPostBack && !this.OrganisationAddressId.HasValue)
            {
                OrganisationAddressId = Job.Device.DeviceProfile.DefaultOrganisationAddress;
            }
            if (this.OrganisationAddressId.HasValue)
                this.OrganisationAddress = this.OrganisationAddresses.FirstOrDefault(oa => oa.Id == this.OrganisationAddressId.Value);

            if (!string.IsNullOrEmpty(FaultDescription))
                FaultDescription = FaultDescription.Trim();
        }
    }
}