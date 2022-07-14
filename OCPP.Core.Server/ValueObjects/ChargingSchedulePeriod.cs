namespace OCPP.Core.Server.ValueObjects
{
#pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v9.0.0.0)")]
    public class ChargingSchedulePeriod
    {
        [Newtonsoft.Json.JsonProperty("startPeriod", Required = Newtonsoft.Json.Required.Always)]
        public int StartPeriod { get; set; }

        [Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.Always)]
        public decimal Limit { get; set; }

        [Newtonsoft.Json.JsonProperty("numberPhases", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberPhases { get; set; } = 3;
    }
}
