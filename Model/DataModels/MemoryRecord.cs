using System;
using System.Collections.Generic;

namespace CloudMemory.DataModels
{
	public class MemoryRecord
	{
		public int Id { get; set;}
		public string RecordContent { get; set; }
		public DateTime CreatingTimeStamp { get; set; }
		public string DeviceName { get; set; }
		public ISet<string> HashTags { get; set; }
	}
}

