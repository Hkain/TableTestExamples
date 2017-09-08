using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Table.Models
{
    /// <summary>
    /// Table row
    /// </summary>
    public class LineDTO
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Somtime text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Add date
        /// </summary>
        public DateTime? Date { get; set; }
    }
}