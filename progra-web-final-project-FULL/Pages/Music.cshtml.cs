using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalproyect.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace finalproyect.Pages
{
    public class MusicModel : PageModel
    {
        public string Message { get; set; }
        public List<Music> MusicList { get; set; }
        public readonly AppDbContext _db;

        public MusicModel(AppDbContext _db) {
            this._db = _db;
        }

        public IActionResult OnGet() {
            Message = "List of music";
            MusicList = _db.Musics.AsEnumerable().ToList();

            return Page();
        }

        public IActionResult OnPost(int songId) {
            Message = "List of music";

            //Search for the music using the Id in the post request
            var song2Delete = _db.Musics.Find(songId);
            if (song2Delete != null) {//If found, then Remove from DB
                _db.Musics.Remove(song2Delete);
            }
            //Save all changes into DB
            _db.SaveChanges();
            
            //Fill again the list of Music
            MusicList = _db.Musics.AsEnumerable().ToList();
            return Page();
        }
    }
}
