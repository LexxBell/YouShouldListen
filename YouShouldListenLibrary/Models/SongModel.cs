
namespace YouShouldListenLibrary.Models;
internal class SongModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string SongName  { get; set; }
    public string Artist    { get; set; }
    public GenreModel Genre { get; set; }
    public GradeModel Grade { get; set; }
}
