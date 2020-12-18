using System;
using System.Collections.Generic;
using System.Text;
using Excpt.Entities.Exceptions;

namespace Excpt.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-Out date must be after Check-in date");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {

            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for updates must be future dates");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Check-Out date must be after Check-in date");
            }

            Checkin = checkin;
            Checkout = checkout;

        }



        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", Check-in: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", Check-out: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " Nights";
        }



    }
}
