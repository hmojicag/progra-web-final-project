using finalproyect.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace finalproyect.Pages {
    public class EditMusicModel : PageModel {
        public string Message { get; set; }
        public readonly AppDbContext _db;
        public Music Music { get; set; }

        public EditMusicModel(AppDbContext _db) {
            this._db = _db;
        }

        public IActionResult OnGet(int id) {
            Music = _db.Musics.Find(id);
            Message = $"Editar {Music.Name}";
            return Page();
        }

        public IActionResult OnPost(int hiddenId, string inputName, string inputAlbum, string inputGenre, string inputArtist, string inputYear) {
            //Buscamos una instancia de Music con ID inputID
            Music = _db.Musics.Find(hiddenId);
            //Sobreescribimos todos los datos excepto el ID
            Music.Name = inputName;
            Music.Album = inputAlbum;
            Music.Genre = inputGenre;
            Music.Artist = inputArtist;
            Music.Year = inputYear;
            //Actualizamos los datos en la base de datos
            _db.Musics.Update(Music);
            _db.SaveChanges();
            
            return Page();
        }
        
    }
}
