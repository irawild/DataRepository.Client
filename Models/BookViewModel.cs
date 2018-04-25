using DataRepository.Data;
using System.ComponentModel.DataAnnotations;

namespace DataRepository.Client.Models
{
    public class BookViewModel : ViewModelBase
    {
        [Required]
        public string Name { get; set; }
    }
}
