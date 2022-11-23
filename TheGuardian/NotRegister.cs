namespace NotRegisterController
{
    public class NotRegisterController
    {

        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //[BsonElement("_id")]
        public string userId { get; set; }

       
        public string deviceId { get; set; }

        public string publicKey { get; set; }

        public string status { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

    }
}




