namespace Register
{
    public class Register
    {

        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //[BsonElement("_id")]
        public string userId { get; set; }

       
        public string deviceId { get; set; }

        public string publicKey { get; set; }



    }
}




