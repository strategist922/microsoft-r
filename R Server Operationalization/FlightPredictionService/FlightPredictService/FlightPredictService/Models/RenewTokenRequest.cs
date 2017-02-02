// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace FlightService.Models
{
    using System.Linq;

    public partial class RenewTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the RenewTokenRequest class.
        /// </summary>
        public RenewTokenRequest() { }

        /// <summary>
        /// Initializes a new instance of the RenewTokenRequest class.
        /// </summary>
        /// <param name="refreshToken">A currently valid refresh token.</param>
        public RenewTokenRequest(string refreshToken = default(string))
        {
            RefreshToken = refreshToken;
        }

        /// <summary>
        /// Gets or sets a currently valid refresh token.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "refreshToken")]
        public string RefreshToken { get; set; }

    }
}