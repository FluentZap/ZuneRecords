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
            StoreOne.StoreInventory.addRecord(new Record("Black Sabbath", "Paranoid", 16.66f));
            StoreOne.StoreInventory.addRecord(new Record("Bridge Over Troubled Water", "Simon And Garfunkel", 12.50f));
            StoreOne.StoreInventory.addRecord(new Record("John Lennon/Plastic Ono Band", "John Lennon", 9.99f));

            List<Record> recordList = StoreOne.StoreInventory.getIfContains("b");

            foreach (Record item in recordList) 
            {
                Console.WriteLine(item.getAlbumArtist());
            }
        }
    }
}
