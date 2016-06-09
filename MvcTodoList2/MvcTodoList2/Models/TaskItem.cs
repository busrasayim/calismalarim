using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcTodoList2.Models
{
    [Table("Tasks")]
    public class TaskItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Modified On")]
        public DateTime? ModifiedOn { get; set; }

        [DisplayName("Is Completed")]
        public bool IsCompleted { get; set; }

        [Required, StringLength(250)]
        [DisplayName("Description")]
        public string Description { get; set; }
    }
}