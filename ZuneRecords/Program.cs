using System;
using System.Collections.Generic;

namespace ZuneRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            RecordStore StoreOne = new RecordStore();
            StoreOne.StoreInventory.addRecord(new Record("Fleetwood Mac", "Live", 14.95f));

            List<Record> recordList = StoreOne.StoreInventory.getLibrary();

            foreach (Record item in recordList) 
            {
                Console.WriteLine(item.getAlbumArtist());
            }
        }

        void addRecords()
        {
            Record one = new Record("Fleetwood Mac", "Live", 14.95f);
        }
    }
}
