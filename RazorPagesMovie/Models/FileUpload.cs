using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class FileUpload
    {
        [Required,Display(Name = "Название"),StringLength(60,MinimumLength = 3)]
        public string Title { get; set; }

        [Required,Display(Name = "Публичное расписание")]
        public IFormFile UploadPublicSchedule { get; set; }

        [Required,Display(Name = "Приватное расписание")]
        public IFormFile UploadPrivateSchedule { get; set; }

    }
}
