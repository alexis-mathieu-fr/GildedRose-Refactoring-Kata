namespace GildedRoseKata;

public class Default : Item
{
    public override void UpdateQuality()
    {
        if (Quality > 0)
            Quality -= 1;

        SellIn -= 1;

        if (SellIn >= 0)
            return;

        if (Quality > 0) Quality -= 1;
    }
}