using Mirror;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManagerOnline : NetworkBehaviour
{

    [SerializeField] private List<HealthComponentOnline> playersHp;
    [SyncVar]
    [SerializeField] private int aliveCount;

    public void StartGame()
    {
        RegisterPlayersHp();
    }
    
    public void RegisterPlayersHp()
    {
        print("RegHp");
        playersHp = FindObjectsOfType<HealthComponentOnline>().ToList();
        aliveCount = playersHp.Count;
        /*foreach (var hp in playersHp)
        {
            hp.OnDie = null;
            hp.OnDie += CheckVictory;
        }*/
    }

    [Command (requiresAuthority =false)]
    public void CmdCheckVictory()
    {
        aliveCount = FindObjectsOfType<HealthComponentOnline>().Where(x => x.Alive).Count();
        RpcCheckVictory();
    }

    [ClientRpc]
    public void RpcCheckVictory()
    {
        print("CheckVictoty");
        //healthComponent.OnDie -= CheckVictory;
        
        if (aliveCount == 1)
        {
            FindObjectsOfType<HealthComponentOnline>().Where(x => x.Alive).ToList().First().gameObject.GetComponent<PlayerOnline>().ActivateWinScreen();


            
        }
    }
}
