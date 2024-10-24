using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5,ErrorMessage = "Title must be 5 charaters")]
        [MaxLength(280, ErrorMessage = "Title cannot be over 280 charaters")]
        public string Title {get; set;} = string.Empty;
        public string Content {get; set;} = string.Empty;

    }
}