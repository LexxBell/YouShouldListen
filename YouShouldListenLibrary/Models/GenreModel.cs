namespace YouShouldListenLibrary.Models;
public class GenreModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string GenreName { get; set; }

}
