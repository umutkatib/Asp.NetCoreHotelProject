using System;

namespace HotelProject.WebUI.Dtos.MessageDtos
{
	public class UpdateMessageDto
	{
		public int MessageID { get; set; }
		public string MessageName { get; set; }
		public string MessageSurname { get; set; }
		public string MessageMail { get; set; }
		public string MessageSubject { get; set; }
		public string MessageMessage { get; set; }
		public DateTime MessageDate { get; set; }

	}
}
