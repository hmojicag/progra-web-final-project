using finalproyect.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace finalproyect.Pages {
    public class CreateMusicModel : PageModel {
        public string Message { get; set; }
        public readonly AppDbContext _db;

        public CreateMusicModel(AppDbContext _db) {
            this._db = _db;
        }

        public IActionResult OnGet() {
            Message = "Create Music";
            return Page();
        }

        public IActionResult OnPost(string inputName, string inputAlbum, string inputGenre, string inputArtist, string inputYear) {
            //Creamos una nueva instancia de la clase Music usando los datos mandados por el request POST
            Music music = new Music() {
                Name = inputName,
                Album = inputAlbum,
                Genre = inputGenre,
                Artist = inputArtist,
                Year = inputYear
            };
            //Persistimos los datos en la base de datos
            _db.Musics.Add(music);
            _db.SaveChanges();
            
            return Page();
        }
        
    }
}
