[System.Serializable]
public class Bone
{
    public string name;
    public Rarity rarity;
    public Type type;
}

public enum Rarity
{
    COMMON,
    UNCOMMON,
    RARE,
    EPIC,
    LEGENDARY
}

public enum Type
{
    SKULL,
    ARM,
    LEG,
    BODY
}
