namespace BashMonster;
public class Fish
{
public bool IsEdible;
public int Damage;
public float Weight;
public bool Stackable;

public int maxHp = 100;
public int hp;

public Fish()
{
    maxHp = new Random().Next(90, 110);
}

public void ResetHp()
{
hp = maxHp;
}

}