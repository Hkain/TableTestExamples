using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Table.Enums;

namespace Table.Models
{

    public class ActionResult
    {
        public int NewId { get; set; }
        public int OldId { get; set; }
    }

    public class ActionDTO
    {
        public ActionType ActionType { get; set; }
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime? Date { get; set; }
    }
}