using System;
using System.IO;

using CloudMemory.DataModels;

namespace CloudMemory.DataLayer
{
	//ToDo: Add methods to access the DataBase
	public class MemoryRecordsDatabase
	{
		private static MemoryRecordsDatabase instance;

		public static MemoryRecordsDatabase Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new MemoryRecordsDatabase();
				}

				return instance;
			}
		}
	}
}

