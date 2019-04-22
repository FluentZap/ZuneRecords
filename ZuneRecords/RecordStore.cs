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

        public float getPrice()
        {
            return Price;
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

        //Return a list of Records that is within the ranges of our min and max
        public List<Record> getWithinRange(float min, float max)
        {
            List<Record> recordsInRange = new List<Record>();

            foreach(Record item in Library) 
            {
                float price = item.getPrice();

                // if price is higher or equal to the min and price is lower or equal to the max do stuff
                if(price >= min && price <= max)
                {
                    recordsInRange.Add(item);
                }
            }
            
            return recordsInRange;
        }

        public List<Record> getIfContains(string text)
        {
            List<Record> recordsContains = new List<Record>();

            foreach(Record item in Library)
            {
                if(item.getAlbumArtist().ToLower().Contains(text.ToLower()))
                {
                    recordsContains.Add(item);
                }
            }
            return recordsContains;
        }
    }

    class RecordStore
    {
        public Inventory StoreInventory = new Inventory();


    }
}