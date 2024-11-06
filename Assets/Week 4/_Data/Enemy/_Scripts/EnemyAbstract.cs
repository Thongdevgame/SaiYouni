using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbstract : SaiBehaviour
{
    [SerializeField] protected EnemyCtrl ctrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
    }

    protected virtual void LoadEnemyCtrl()
    {
        if (this.ctrl != null) return;
        this.ctrl = GetComponentInParent<EnemyCtrl>();
       // Debug.Log(transform.name + ": LoadEnemyCtrl", gameObject);
    }
}
