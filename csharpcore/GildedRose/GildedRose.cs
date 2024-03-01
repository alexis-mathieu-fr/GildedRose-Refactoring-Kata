using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private const string SulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";
    private const string AgedBrie = "Aged Brie";
    private const string BackstagePassesToATafkal80EtcConcert = "Backstage passes to a TAFKAL80ETC concert";
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            if (item.Name != AgedBrie && item.Name != BackstagePassesToATafkal80EtcConcert)
            {
                if (item.Quality > 0 && item.Name != SulfurasHandOfRagnaros)
                {
                    decrement(item, 1);
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    increment(item, 1);

                    if (item.Name == BackstagePassesToATafkal80EtcConcert && item.SellIn < 11 && item.Quality < 50)
                    {
                        increment(item, 1);
                        if (item.SellIn < 6)
                        {
                            increment(item, 1);
                        }
                    }
                }
            }

            if (item.Name != SulfurasHandOfRagnaros)
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != AgedBrie)
                {
                    if (item.Name != BackstagePassesToATafkal80EtcConcert)
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != SulfurasHandOfRagnaros)
                            {
                                decrement(item, 1);
                            }
                        }
                    }
                    else
                    {
                        item.Quality = 0;
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        increment(item, 1);
                    }
                }
            }
        }
    }


    private void increment(Item item, int value)
    {
        item.Quality += value;
    }

    private void decrement(Item item, int value)
    {
        if (item.Quality > 0) item.Quality -= value;
    }

    public void UpdateBackstagePass(Item item)
    {
        if (item.Quality < 50)
        {
            increment(item, 1);

            if (item.Name == BackstagePassesToATafkal80EtcConcert && item.SellIn < 11 && item.Quality < 50)
            {
                increment(item, 1);
                if (item.SellIn < 6)
                {
                    increment(item, 1);
                }
            }
        }

        if (item.Name != SulfurasHandOfRagnaros)
        {
            item.SellIn = item.SellIn - 1;
        }

        if (item.SellIn >= 0) return;

        item.Quality = 0;
    }

    public void UpdateAgedBrie(Item item)
    {
        if (item.Name != AgedBrie && item.Name != BackstagePassesToATafkal80EtcConcert)
        {
            if (item.Quality > 0 && item.Name != SulfurasHandOfRagnaros)
            {
                decrement(item, 1);
            }
        }
        else
        {
            if (item.Quality < 50)
            {
                increment(item, 1);

                if (item.Name == BackstagePassesToATafkal80EtcConcert && item.SellIn < 11 && item.Quality < 50)
                {
                    increment(item, 1);
                    if (item.SellIn < 6)
                    {
                        increment(item, 1);
                    }
                }
            }
        }

        if (item.Name != SulfurasHandOfRagnaros)
        {
            item.SellIn = item.SellIn - 1;
        }

        if (item.SellIn < 0)
        {
            if (item.Name != AgedBrie)
            {
                if (item.Name != BackstagePassesToATafkal80EtcConcert)
                {
                    if (item.Quality > 0)
                    {
                        if (item.Name != SulfurasHandOfRagnaros)
                        {
                            decrement(item, 1);
                        }
                    }
                }
                else
                {
                    item.Quality = 0;
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    increment(item, 1);
                }
            }
        }
    }
    }
}