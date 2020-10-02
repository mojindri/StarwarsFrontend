﻿// ***********************************************************************
// Assembly         : StarWarsApiCSharp
// Author           : M.Yankov
// Created          : 02-27-2016
//
// Last Modified By : M.Yankov
// Last Modified On : 03-17-2016
// ***********************************************************************
// <copyright file="Vehicle.cs" company="M-Yankov">
//     Copyright ©  2016
// </copyright>
// <summary>Contains Vehicle class.</summary>
// ***********************************************************************
namespace BlazerMovies.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Class Vehicle.
    /// </summary>
    /// <seealso cref="StarWarsApiCSharp.BaseEntity" />
    public class Vehicle : BaseEntity
    {
        /// <summary>
        /// The path that will be added to base API URL.
        /// </summary>
        private const string PathToEntity = "vehicles/";

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        [JsonProperty]
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the vehicle class.
        /// </summary>
        /// <value>The vehicle class.</value>
        [JsonProperty(PropertyName = "vehicle_class")]
        public string VehicleClass { get; set; }

        /// <summary>
        /// Gets or sets the manufacturer. It can return "unknown" as value.
        /// </summary>
        /// <value>The manufacturer.</value>
        [JsonProperty]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets the length. It can return "unknown" as value.
        /// </summary>
        /// <value>The length.</value>
        [JsonProperty]
        public string Length { get; set; }

        /// <summary>
        /// Gets or sets the cost in credits. It can return "unknown" as value.
        /// </summary>
        /// <value>The cost in credits.</value>
        [JsonProperty(PropertyName = "cost_in_credits")]
        public string CostInCredits { get; set; }

        /// <summary>
        /// Gets or sets the crew count as string.
        /// </summary>
        /// <value>The crew.</value>
        [JsonProperty]
        public string Crew { get; set; }

        /// <summary>
        /// Gets or sets the passengers count as string. It can return "unknown" as value.
        /// </summary>
        /// <value>The passengers.</value>
        [JsonProperty]
        public string Passengers { get; set; }

        /// <summary>
        /// Gets or sets the maximum atmospheric speed integer as string. It can return "unknown" as value.
        /// </summary>
        /// <value>The maximum atmospheric speed.</value>
        [JsonProperty(PropertyName = "max_atmosphering_speed")]
        public string MaxAtmospheringSpeed { get; set; }

        /// <summary>
        /// Gets or sets the cargo capacity. It can return "unknown" as value.
        /// </summary>
        /// <value>The cargo capacity.</value>
        [JsonProperty(PropertyName = "cargo_capacity")]
        public string CargoCapacity { get; set; }

        /// <summary>
        /// Gets or sets the consumables period. It can return "unknown" as value.
        /// </summary>
        /// <value>The consumables.</value>
        [JsonProperty]
        public string Consumables { get; set; }

        /// <summary>
        /// Gets or sets the films URLs.
        /// </summary>
        /// <value>The films.</value>
        [JsonProperty]
        public ICollection<string> Films { get; set; }

        /// <summary>
        /// Gets or sets the pilots URLs.
        /// </summary>
        /// <value>The pilots.</value>
        [JsonProperty]
        public ICollection<string> Pilots { get; set; }

        /// <summary>
        /// Gets the path for extending base URL API.
        /// </summary>
        /// <value>The path.</value>
        protected override string EntryPath
        {
            get
            {
                return PathToEntity;
            }
        }
    }
}
