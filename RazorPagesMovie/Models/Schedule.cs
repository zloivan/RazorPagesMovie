using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Schedule
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string PublicSchedule { get; set; }

        [Display(Name = "Размер публичного расписания (биты)")]
        [DisplayFormat(DataFormatString = "{0:N1}")]
        public long PublicScheduleSize { get; set; }

        public string PrivateSchedule { get; set; }

        [Display(Name = "Размер приватного расписания (биты)")]
        [DisplayFormat(DataFormatString = "{0:N1}")]
        public long PrivateScheduleSize { get; set; }

        [Display(Name = "Загруженно (UTC)")]
        [DisplayFormat(DataFormatString ="{0:F}")]
        public DateTime UploadDT { get; set; }
    }
}
