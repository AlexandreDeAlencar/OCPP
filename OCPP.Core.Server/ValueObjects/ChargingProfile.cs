using System;

namespace OCPP.Core.Server.ValueObjects
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v9.0.0.0)")]
    public class ChargingProfile
    {
        private int _transactionId;
        private DateTimeOffset? _validTo;
        private DateTimeOffset? _validFrom;

        [Newtonsoft.Json.JsonProperty("chargingProfileId", Required = Newtonsoft.Json.Required.Always)]
        public int ChargingProfileId { get; set; }

       
        [Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TransactionId { 
            get
            {
                return _transactionId;
            }
            set
            {
                if (ChargingProfilePurpose != ChargingProfilePurposeType.TxProfile)
                    throw new System.ApplicationException("Only valid if ChargingProfilePurpose is set to TxProfile");
                _transactionId = value;
            }
        }

        [Newtonsoft.Json.JsonProperty("stackLevel", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
        public int StackLevel { get; set; }

        [Newtonsoft.Json.JsonProperty("chargingProfilePurpose", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfilePurposeType ChargingProfilePurpose { get; set; }


        [Newtonsoft.Json.JsonProperty("chargingProfileKind", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfileKindType ChargingProfileKind { get; set; }

        [Newtonsoft.Json.JsonProperty("recurrencyKind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RecurrencyKindType RecurrencyKind { get; set; }

        [Newtonsoft.Json.JsonProperty("validFrom", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ValidFrom
        {
            get
            {
                return _validFrom;
            }
            set
            {
                if (ChargingProfilePurpose == ChargingProfilePurposeType.TxProfile)
                    throw new System.ApplicationException("Not to be used when ChargingProfilePurposeis TxProfile");
                _validFrom = value;
            }
        }

        [Newtonsoft.Json.JsonProperty("validTo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ValidTo
        {
            get
            {
                return _validTo;
            }
            set
            {
                if (ChargingProfilePurpose == ChargingProfilePurposeType.TxProfile)
                    throw new System.ApplicationException("Not to be used when ChargingProfilePurposeis TxProfile");
                _validTo = value;
            }
        }

        [Newtonsoft.Json.JsonProperty("chargingSchedule", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ChargingSchedule ChargingSchedule { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ChargingProfileKindType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Absolute")]
        Absolute = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Recurring")]
        Recurring = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Relative")]
        Relative = 2,
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ChargingProfilePurposeType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ChargePointMaxProfile")]
        ChargePointMaxProfile = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"TxDefaultProfile")]
        TxDefaultProfile = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"TxProfile")]
        TxProfile = 2,
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum RecurrencyKindType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Daily")]
        Daily = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Weekly")]
        Weekly = 1,
    }
}
