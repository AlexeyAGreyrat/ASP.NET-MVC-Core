using System.ComponentModel.DataAnnotations;

namespace Lesson8.Models
{
    public class Office
    {
            public int Id { get; set; }
            public string? Title { get; set; }

            [DataType(DataType.Date)]
            public DateTime ReleaseWork { get; set; }
            public string? location { get; set; }
            public string? Type { get; set; }
            public string? Time { get; set; }

    }
}
