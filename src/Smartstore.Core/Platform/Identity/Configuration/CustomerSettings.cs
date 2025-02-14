﻿using Microsoft.AspNetCore.Identity;
using Smartstore.Core.Configuration;

namespace Smartstore.Core.Identity
{
    public class CustomerSettings : ISettings
    {
        /// <summary>
        /// Gets or sets a value indicating the customer login type.
        /// </summary>
        public CustomerLoginType CustomerLoginType { get; set; } = CustomerLoginType.UsernameOrEmail;

        /// <summary>
        /// Gets or sets the customer number method.
        /// </summary>
        public CustomerNumberMethod CustomerNumberMethod { get; set; } = CustomerNumberMethod.Disabled;

        /// <summary>
        /// Gets or sets the customer number visibility.
        /// </summary>
        public CustomerNumberVisibility CustomerNumberVisibility { get; set; } = CustomerNumberVisibility.None;

        /// <summary>
        /// Gets or sets a value indicating whether users can check the availability of usernames (when registering or changing in 'My Account').
        /// </summary>
        public bool CheckUsernameAvailabilityEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users are allowed to change their usernames.
        /// </summary>
        public bool AllowUsersToChangeUsernames { get; set; }

        /// <summary>
        /// Default password format for customers
        /// </summary>
        public PasswordFormat DefaultPasswordFormat { get; set; } = PasswordFormat.Hashed;

        /// <summary>
        /// Gets or sets a customer password format (SHA1, MD5) when passwords are hashed.
        /// </summary>
        public string HashedPasswordFormat { get; set; } = "SHA1";

        /// <summary>
        /// Gets or sets the minimum password length.
        /// </summary>
        public int PasswordMinLength { get; set; } = 6;

        /// <summary>
        /// Gets or sets a value indicating whether password requires digits.
        /// </summary>
        public bool PasswordRequireDigit { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether password requires uppercase chars.
        /// </summary>
        public bool PasswordRequireUppercase { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether password requires lowercase chars.
        /// </summary>
        public bool PasswordRequireLowercase { get; set; } = true;

        /// <summary>
        /// Gets or sets the number of required unique chars in passwords.
        /// </summary>
        public int PasswordRequiredUniqueChars { get; set; } = 1;

        /// <summary>
        /// Gets or sets a value indicating whether password requires non alphanumeric chars.
        /// </summary>
        public bool PasswordRequireNonAlphanumeric { get; set; } = true;

        /// <summary>
        /// User registration type
        /// </summary>
        public UserRegistrationType UserRegistrationType { get; set; } = UserRegistrationType.Standard;

        /// <summary>
        /// Gets or sets a value indicating whether customers are allowed to upload avatars.
        /// </summary>
        public bool AllowCustomersToUploadAvatars { get; set; }

        /// <summary>
        /// Gets or sets the maximum file size of an avatar (in KB). The default is 10,240 (10 MB).
        /// </summary>
        public long MaxAvatarFileSize { get; set; } = 10240;

        /// <summary>
        /// Gets or sets a value indicating whether customers location is shown.
        /// </summary>
        public bool ShowCustomersLocation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show customers join date.
        /// </summary>
        public bool ShowCustomersJoinDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether customers are allowed to view profiles of other customers.
        /// </summary>
        public bool AllowViewingProfiles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'New customer' notification message should be sent to a store owner.
        /// </summary>
        public bool NotifyNewCustomerRegistration { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to hide orders tab on 'My account' page.
        /// </summary>
        public bool HideMyAccountOrders { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to hide 'Downloable products' tab on 'My account' page.
        /// </summary>
        public bool HideDownloadableProductsTab { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to hide 'Back in stock subscriptions' tab on 'My account' page.
        /// </summary>
        public bool HideBackInStockSubscriptionsTab { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to validate user when downloading products.
        /// </summary>
        public bool DownloadableProductsValidateUser { get; set; }

        /// <summary>
        /// Customer name formatting.
        /// </summary>
        public CustomerNameFormat CustomerNameFormat { get; set; } = CustomerNameFormat.ShowFirstName;

        /// <summary>
        /// Gets or sets a value indicating the maximum length of a formatted customer name.
        /// </summary>
        public int CustomerNameFormatMaxLength { get; set; } = 64;

        /// <summary>
        /// Gets or sets a value to be concated with <see cref="UserOptions.AllowedUserNameCharacters"/>.
        /// </summary>
        public string CustomerNameAllowedCharacters { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Newsletter' form field is enabled.
        /// </summary>
        public bool NewsletterEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to hide newsletter box.
        /// </summary>
        public bool HideNewsletterBlock { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the number of minutes for 'online customers' module.
        /// </summary>
        public int OnlineCustomerMinutes { get; set; } = 20;

        /// <summary>
        /// Gets or sets a value indicating we should store last visited page URL for each customer.
        /// </summary>
        public bool StoreLastVisitedPage { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating we should store last user agent for each customer.
        /// </summary>
        public bool StoreLastUserAgent { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating we should store last device family for each customer.
        /// </summary>
        public bool StoreLastDeviceFamily { get; set; } = true;

        #region Form fields

        /// <summary>
        /// Gets or sets a value indicating whether 'Gender' is enabled.
        /// </summary>
        public bool GenderEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether 'Title' is enabled.
        /// </summary>
        public bool TitleEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'FirstName' is required.
        /// </summary>
        public bool FirstNameRequired { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether 'LastName' is required.
        /// </summary>
        public bool LastNameRequired { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether 'Date of Birth' is enabled.
        /// </summary>
        public bool DateOfBirthEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether 'Company' is enabled.
        /// </summary>
        public bool CompanyEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether 'Company' is required.
        /// </summary>
        public bool CompanyRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Street address' is enabled.
        /// </summary>
        public bool StreetAddressEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Street address' is required.
        /// </summary>
        public bool StreetAddressRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Street address 2' is enabled.
        /// </summary>
        public bool StreetAddress2Enabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Street address 2' is required.
        /// </summary>
        public bool StreetAddress2Required { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Zip / postal code' is enabled.
        /// </summary>
        public bool ZipPostalCodeEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Zip / postal code' is required.
        /// </summary>
        public bool ZipPostalCodeRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'City' is enabled.
        /// </summary>
        public bool CityEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'City' is required.
        /// </summary>
        public bool CityRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Country' is enabled.
        /// </summary>
        public bool CountryEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'State / province' is enabled.
        /// </summary>
        public bool StateProvinceEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'StateProvince' is required.
        /// </summary>
        public bool StateProvinceRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Phone number' is enabled.
        /// </summary>
        public bool PhoneEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Phone number' is required.
        /// </summary>
        public bool PhoneRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Fax number' is enabled.
        /// </summary>
        public bool FaxEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 'Fax number' is required.
        /// </summary>
        public bool FaxRequired { get; set; }

        #endregion

        /// <summary>
        /// Identifier of a customer role that new registered customers will be assigned to.
        /// </summary>
        public int? RegisterCustomerRoleId { get; set; }
    }
}
