using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Democracy.Models
{
    /// <summary>
    /// State model
    /// </summary>
    public class State
    {
        /// <summary>
        /// Gets or sets the state id
        /// </summary>
        [Key]
        public int StateId { get; set; }

        /// <summary>
        /// Gets or setS the state descripton
        /// </summary>
        public string Description { get; set; }
    }
}