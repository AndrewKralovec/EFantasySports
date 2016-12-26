namespace EFantasySports.Models.Utility
{
    // Game response extenstion 
    public class GameResponse : Response {
        public GameResponse(bool succeeded, string message)
            :base(succeeded) {
                this.succeeded = succeeded ;
                this.messages.Add(message); 
        }
    }
}