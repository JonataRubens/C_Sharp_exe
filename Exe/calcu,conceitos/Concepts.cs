public class concepts:
{
    float health;
    int speed;
    string enemyName;

    EnemyWeapon weapon;

    int[] intArray = new int[] { 1,2,3,4,5,6,7,8,9,10 };
    //intList.Add(N), intList.Remove(N)
    List<int> intList = new List<int>() = { 1,2,3,4,5,6,7,8,9,10 };

    void Moviment()
    {

        foreach(int intNumbers in intArray)
        {

        }

        for (int i = 0; i < intArray.Length; i++)
        {
            int currenteNumber = intArray[i];
        }

        for (int i = 0; i < intList.Count; i++)
        {
            
        }

        if(speed > 0)
        {

        }
    }
    
    void Dead()
    {
        if(health < 0)
        {

        }
    }

    void Attack()
    {
        weapon.damage = 30;
        weapon.fireRate = 30;
        weapon.Shoot();
    }
}

public class EnemyWeapon
{
    public float damage;
    public float fireRate;

    public void Shoot()
    {

    }
}