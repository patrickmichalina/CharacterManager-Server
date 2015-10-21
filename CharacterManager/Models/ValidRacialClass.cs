using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterManager.Models
{
    /// <summary>
    /// Race / Class combinations that are valid
    /// </summary>
    public class ValidRacialClass
    {
        public virtual Class Class { get; set; }

        public string ClassId { get; set; }

        public virtual Race Race { get; set; }

        public string RaceId { get; set; }
    }
}