namespace YouShouldListenLibrary.Models;
public class GradeModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id  { get; set; }
    public char Grade { get; set; }
}
