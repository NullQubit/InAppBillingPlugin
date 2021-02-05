using System;

namespace Plugin.InAppBilling
{
    public class BillingParameters
    {
        string obfuscatedAccountId;
        string obfuscatedProfileId;

        /// <summary>
        /// Gets or sets an obfuscated string that is uniquely associated with the user's account in your app.
        /// If you pass this value, Google Play can use it to detect irregular activity, such as many devices 
        /// making purchases on the same account in a short period of time.
        /// </summary>
        public string ObfuscatedAccountId
        {
            get => obfuscatedAccountId;
            set
            {
                if (value != null && value.Length > 64)
                {
                    throw new ArgumentException("This value is limited to 64 characters");
                }

                obfuscatedAccountId = value;
            }
        }

        /// <summary>
        /// Gets or sets an obfuscated string that is uniquely associated with the user's profile in your app.
        /// Some applications allow users to have multiple profiles within a single account. 
        /// Use this method to send the user's profile identifier to Google.
        /// </summary>
        public string ObfuscatedProfileId
        {
            get => obfuscatedProfileId;
            set
            {
                if (value != null && value.Length > 64)
                {
                    throw new ArgumentException("This value is limited to 64 characters");
                }

                obfuscatedProfileId = value;
            }
        }
    }
}
