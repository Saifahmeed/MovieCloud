using MovieCloud.Models;
namespace MovieCloud.ViewModels
{
    public class AdminViewModel
    {
        public List<Admin>? Admins { get; set; }
        public int? SelectedId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
