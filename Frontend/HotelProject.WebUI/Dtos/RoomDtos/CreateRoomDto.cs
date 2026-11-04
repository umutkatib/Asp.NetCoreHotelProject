namespace HotelProject.WebUI.Dtos.RoomsDtos
{
	public class CreateRoomDto
	{
		public string RoomNumber { get; set; }
		public string RoomTitle { get; set; }
		public string RoomDescription { get; set; }
		public int RoomPrice { get; set; }
		public string RoomCoverImage { get; set; }
		public int RoomBedCount { get; set; }
		public int RoomBathCount { get; set; }
		public string RoomWifi { get; set; }
	}
}
