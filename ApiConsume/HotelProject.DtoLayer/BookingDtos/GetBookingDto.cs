using System;

namespace HotelProject.DtoLayer.BookingDtos
{
	public class GetBookingDto
	{
		public int BookingID { get; set; }
		public string BookingName { get; set; }
		public string BookingSurname { get; set; }
		public string BookingMail { get; set; }
		public DateTime BookingCheckin { get; set; }
		public DateTime BookingCheckout { get; set; }
		public int BookingAdultCount { get; set; }
		public int BookingChildCount { get; set; }
		public int BookingRoomCount { get; set; }
		public string BookingSpecialRequest { get; set; }
		public string BookingSpecialDescription { get; set; }
		public bool BookingStatus { get; set; }
	}
}
