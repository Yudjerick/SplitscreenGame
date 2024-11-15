using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class VictoryManager : MonoBehaviour
{
    [SerializeField] private List<HealthComponent> playersHp;
    [SerializeField] private int aliveCount;
    public void RegisterPlayersHp()
    {
        playersHp = FindObjectsOfType<HealthComponent>().ToList();
        aliveCount = playersHp.Count;
        foreach (HealthComponent hp in playersHp)
        {
            hp.OnDie += CheckVictory;
        }
    }

    private void CheckVictory(HealthComponent healthComponent)
    {
        healthComponent.OnDie -= CheckVictory;
        aliveCount--;
        if (aliveCount == 1 ) {
            playersHp = FindObjectsOfType<HealthComponent>().ToList();
            foreach (HealthComponent hp in playersHp)
            {
                if (hp.Alive)
                {
                    hp.gameObject.GetComponent<Player>().ActivateWinScreen();
                }
            }
            print("Won");
        }
    }
}
