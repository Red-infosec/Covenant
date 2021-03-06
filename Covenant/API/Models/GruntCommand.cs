// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GruntCommand
    {
        /// <summary>
        /// Initializes a new instance of the GruntCommand class.
        /// </summary>
        public GruntCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GruntCommand class.
        /// </summary>
        public GruntCommand(string command, System.DateTime commandTime, string userId, int? id = default(int?), int? commandOutputId = default(int?), CommandOutput commandOutput = default(CommandOutput), CovenantUser user = default(CovenantUser), int? gruntId = default(int?), Grunt grunt = default(Grunt), int? gruntTaskingId = default(int?), GruntTasking gruntTasking = default(GruntTasking))
        {
            Id = id;
            Command = command;
            CommandTime = commandTime;
            CommandOutputId = commandOutputId;
            CommandOutput = commandOutput;
            UserId = userId;
            User = user;
            GruntId = gruntId;
            Grunt = grunt;
            GruntTaskingId = gruntTaskingId;
            GruntTasking = gruntTasking;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        public string Command { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commandTime")]
        public System.DateTime CommandTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commandOutputId")]
        public int? CommandOutputId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commandOutput")]
        public CommandOutput CommandOutput { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public CovenantUser User { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntId")]
        public int? GruntId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grunt")]
        public Grunt Grunt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntTaskingId")]
        public int? GruntTaskingId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntTasking")]
        public GruntTasking GruntTasking { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Command == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Command");
            }
            if (UserId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserId");
            }
            if (CommandOutput != null)
            {
                CommandOutput.Validate();
            }
            if (Grunt != null)
            {
                Grunt.Validate();
            }
            if (GruntTasking != null)
            {
                GruntTasking.Validate();
            }
        }
    }
}
