using System;
using System.Collections.Generic;

namespace ZuneRecords
{

    class Record
    {
        private string Artist;
        private string Album;
        private float Price;

        public Record(string Artist, string Album, float Price)
        {
            this.Artist = Artist;
            this.Album = Album;
            this.Price = Price;
        }

        public string getAlbumArtist()
        {
            return Artist + ", " + Album;
        }

    }

    class Inventory
    {
        private List<Record> Library = new List<Record>();

        public void addRecord(Record newRecord)
        {
            Library.Add(newRecord);
        }

        public List<Record> getLibrary()
        {
            return Library;
        }
    }

    class RecordStore
    {
        public Inventory StoreInventory = new Inventory();


    }
}