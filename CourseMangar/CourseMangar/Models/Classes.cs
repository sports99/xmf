namespace CourseMangar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Classes
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="����д�༶����")]
        [StringLength(20,MinimumLength =2, ErrorMessage = "�༶�������ٰ��������ַ�")]
        [Display(Name="�༶����")]
        public string Name { get; set; }

        [Display(Name = "������")]
        public int? TeacherId { get; set; }
    }
}
