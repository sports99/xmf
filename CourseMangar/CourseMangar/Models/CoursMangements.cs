namespace CourseMangar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CoursMangements
    {
        public int Id { get; set; }

        public int ClassId { get; set; }

        public int CourseId { get; set; }

        public int TeacherId { get; set; }
    }
}
