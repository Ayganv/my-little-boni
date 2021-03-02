[System.Serializable]
public class Bone
{
    public string name;
    public Rarity rarity;
    public Type type;

    public Bone(Rarity rarity, Type type)
    {
        this.name = rarity + " " + type;
        this.rarity = rarity;
        this.type = type;
    }
}

public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}

public enum Type
{
    Skull,
    Arm,
    Leg,
    Body
}
