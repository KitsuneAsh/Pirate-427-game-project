using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    [SerializeField]
    private int CurrentHealthValue;
    [SerializeField]
    private int MaxHealthValue = 100;

    //private int health 
    //{
    //    get 
    //    {
    //        return value;
    //    }
    //    set 
    //    {
    //        value = health;
    //    }
    //}

	// Use this for initialization

	void Start () 
    {
        CurrentHealthValue = MaxHealthValue;
	}

    public int GetHealth()
    {
        return CurrentHealthValue;
    }
    public int GetMaxHealth()
    {
        return MaxHealthValue;
    }

    //Unit takes Damage
    void Damage( int x)
    {
        CurrentHealthValue -= x;
        Debug.Log(gameObject.name + " has been DAMAGED for " + x + "!" );
    }

    //Unit Heals Damage
    void Heal(int x)
    {
        CurrentHealthValue += x;
        Debug.Log(gameObject.name + " has been HEALED for " + x + "!");
    }

    //Units Maximum health increases
    void ChangeMax(int x)
    {
        MaxHealthValue += x;
        Debug.Log(gameObject.name + " 's Max health as INCREASED by " + x + "!");
    }


}
