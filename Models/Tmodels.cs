using System.ComponentModel.DataAnnotations;

namespace RailTicket.Models
{
    public class Login
    {
        [Key]
        public int? OId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }


    public class User_Registration
    {
        [Key]
        public int? RId { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public int? Pincode { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class TicketBooking
    {
        [Key]
        public int? BId { get; set; }
        public String? From_Train { get; set; }
        public String? To_Train { get; set; }   
        public String? Journey_Date { get; set; }

    }

    public class Train
    {
        [Key]
        public int? TId { get; set; }
        public string? Train_Name { get; set; }
        public int? Train_No { get; set; }
        public int? Seat_Available { get; set; }
        public string? Arrival_Time { get; set; }
        public string? Departure_Time { get; set; }

    }
    public class Passenger
    {
        [Key]
        public int? PId { get; set; }
        public string? Passenger_Name { get; set; }
        public int? Age { get; set; }
        public long? Aadhar_No { get; set; }
        public String? Select_class { get; set; }
        public int? Price { get; set; }

    }

}
