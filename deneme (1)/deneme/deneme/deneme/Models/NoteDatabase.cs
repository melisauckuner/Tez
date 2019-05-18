using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace deneme.Models
{
    public class NoteDatabase { 
	readonly SQLiteAsyncConnection _database;

    public NoteDatabase(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Note>().Wait();
    }

    public Task<List<Note>> GetNotesAsync()
    {
        return _database.Table<Note>().ToListAsync();
    }

   public Task<List<Note>> GetNoteAsync(int id)
    {
            return _database.Table<Note>()
                            .Where(i => i.ID == id)
                          .ToListAsync();

            //return _database.Table<Note>().Where();
    }
       


        public Task<int> SaveNoteAsync(Note note)
    {
        if (note.ID != 0)
        {
            return _database.UpdateAsync(note);
        }
        else
        {
            return _database.InsertAsync(note);
        }

    }

    public Task<int> DeleteNoteAsync(Note note)
    {
        return _database.DeleteAsync(note);
    }
        
    }
}
