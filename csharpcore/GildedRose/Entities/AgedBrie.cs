namespace GildedRoseKata;

public class AgedBrie : Item
{
    public override void UpdateQuality()
    {
        if (Quality < 50) Quality += 1;

        SellIn -= 1;

        if (SellIn >= 0) return;

        if (Quality < 50)
            Quality += 1;
    }
}