using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalproyect.Model;
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

        public void OnGet() {
            Message = "List of music";
            MusicList = _db.Musics.AsEnumerable().ToList();
        }
    }
}
