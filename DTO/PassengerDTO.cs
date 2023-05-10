namespace Railway_Reservation.DTO
{
    public class PassengerDTO
    {
       
       

        //------------------------------------------------------------

       
        public string Name { get; set; }

        //------------------------------------------------------------

       
        public string EmailId { get; set; }

        //------------------------------------------------------------

        
        public string Password { get; set; }

        //------------------------------------------------------------

       
        public string Phone_no { get; set; }

        //------------------------------------------------------------

       
        public int age { get; set; }

        //------------------------------------------------------------

        
        public string gender { get; set; }

        public int UserId { get; set; } //foreign key

    }

        
}
