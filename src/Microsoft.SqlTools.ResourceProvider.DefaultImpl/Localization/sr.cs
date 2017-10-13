// WARNING:
// This file was generated by the Microsoft DataWarehouse String Resource Tool 1.37.0.0
// from information in sr.strings
// DO NOT MODIFY THIS FILE'S CONTENTS, THEY WILL BE OVERWRITTEN
//
namespace Microsoft.SqlTools.ResourceProvider.DefaultImpl
{
    using System;
    using System.Reflection;
    using System.Resources;
    using System.Globalization;

    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR
    {
        protected SR()
        { }

        public static CultureInfo Culture
        {
            get
            {
                return Keys.Culture;
            }
            set
            {
                Keys.Culture = value;
            }
        }


        public static string FailedToGetAzureDatabasesErrorMessage
        {
            get
            {
                return Keys.GetString(Keys.FailedToGetAzureDatabasesErrorMessage);
            }
        }

        public static string FailedToGetAzureSubscriptionsErrorMessage
        {
            get
            {
                return Keys.GetString(Keys.FailedToGetAzureSubscriptionsErrorMessage);
            }
        }

        public static string FailedToGetAzureResourceGroupsErrorMessage
        {
            get
            {
                return Keys.GetString(Keys.FailedToGetAzureResourceGroupsErrorMessage);
            }
        }

        public static string FailedToGetAzureSqlServersErrorMessage
        {
            get
            {
                return Keys.GetString(Keys.FailedToGetAzureSqlServersErrorMessage);
            }
        }

        public static string FailedToGetAzureSqlServersWithError
        {
            get
            {
                return Keys.GetString(Keys.FailedToGetAzureSqlServersWithError);
            }
        }

        public static string FirewallRuleCreationFailed
        {
            get
            {
                return Keys.GetString(Keys.FirewallRuleCreationFailed);
            }
        }

        public static string FirewallRuleCreationFailedWithError
        {
            get
            {
                return Keys.GetString(Keys.FirewallRuleCreationFailedWithError);
            }
        }

        public static string AzureSubscriptionFailedErrorMessage
        {
            get
            {
                return Keys.GetString(Keys.AzureSubscriptionFailedErrorMessage);
            }
        }

        public static string UnsupportedAuthType
        {
            get
            {
                return Keys.GetString(Keys.UnsupportedAuthType);
            }
        }

        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class Keys
        {
            static ResourceManager resourceManager = new ResourceManager("Microsoft.SqlTools.ResourceProvider.DefaultImpl.Localization.SR", typeof(SR).GetTypeInfo().Assembly);

            static CultureInfo _culture = null;


            public const string FailedToGetAzureDatabasesErrorMessage = "FailedToGetAzureDatabasesErrorMessage";


            public const string FailedToGetAzureSubscriptionsErrorMessage = "FailedToGetAzureSubscriptionsErrorMessage";


            public const string FailedToGetAzureResourceGroupsErrorMessage = "FailedToGetAzureResourceGroupsErrorMessage";


            public const string FailedToGetAzureSqlServersErrorMessage = "FailedToGetAzureSqlServersErrorMessage";


            public const string FailedToGetAzureSqlServersWithError = "FailedToGetAzureSqlServersWithError";


            public const string FirewallRuleCreationFailed = "FirewallRuleCreationFailed";


            public const string FirewallRuleCreationFailedWithError = "FirewallRuleCreationFailedWithError";


            public const string AzureSubscriptionFailedErrorMessage = "AzureSubscriptionFailedErrorMessage";


            public const string UnsupportedAuthType = "UnsupportedAuthType";


            private Keys()
            { }

            public static CultureInfo Culture
            {
                get
                {
                    return _culture;
                }
                set
                {
                    _culture = value;
                }
            }

            public static string GetString(string key)
            {
                return resourceManager.GetString(key, _culture);
            }

        }
    }
}
