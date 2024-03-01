using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private readonly IList<Item> items;

        public GildedRose(IList<Item> Items)
        {
            items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in items) item.UpdateQuality();
        }
    }
}