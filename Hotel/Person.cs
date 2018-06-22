namespace Hotel {
    public class Person {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int RoomNumber { get; set; }

        public int NumberOfNights { get; set; }

        public string ReservationDate { get; set; }

        public Person(string firstName, string lastName, int roomNumber, int numOfNights, string reservationDate) {
            FirstName = firstName;
            LastName = lastName;
            RoomNumber = roomNumber;
            NumberOfNights = numOfNights;
            ReservationDate = reservationDate;
        }

        public override bool Equals(object obj) {
            Person p = (Person)obj;
            return this.FirstName.Equals(p.FirstName) && this.LastName.Equals(p.LastName) && this.RoomNumber == p.RoomNumber && this.NumberOfNights == p.NumberOfNights && this.ReservationDate.Equals(p.ReservationDate);
        }

    }
}
