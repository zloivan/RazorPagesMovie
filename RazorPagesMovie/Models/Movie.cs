using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required, Display(Name ="Название",Prompt ="Название",Description ="Здесь выводится название фильма"), StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Дата выхода",Description ="Дата выхода фильма"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required, Display(Name = "Жанр"), RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        public string Genre { get; set; }

        [Range(1,100), DataType(DataType.Currency), Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Required, Display(Name = "Рейтинг"), RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"),StringLength(5)]
        public string Rating { get; set; }


    }
}
