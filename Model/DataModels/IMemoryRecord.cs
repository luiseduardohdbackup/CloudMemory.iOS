using System;
using System.Collections.Generic;

namespace CloudMemory.iOS
{
	public interface IMemoryRecord
	{
		int Id { get; set;}
		string RecordContent { get; set; }
		DateTime CreatingTimeStamp { get; set; }
		string DeviceName { get; set; }
		ISet<string> HashTags { get; set; }
	}
}

