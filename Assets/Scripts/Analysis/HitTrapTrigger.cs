using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTrapTrigger : MonoBehaviour
{
    private GameManager gm;
    // private TrapFormToGoogle tftg;
    private string collisionTrap;
    [SerializeField]
    private float InvincibleTime = 3;
    private bool isInvincible = false;
    void Start(){
        gm = FindObjectOfType<GameManager>();
        // tftg = GameObject.FindObjectOfType(typeof(TrapFormToGoogle)) as TrapFormToGoogle;
    } 

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Trap") && !isInvincible){
            startInvincible();
            gm.updateInk(33.3f);
            collisionTrap = collision.gameObject.name;
            switch(collisionTrap){
                case "Trap0":
                    gm.trapsHitted[0] += 1;
                    break;
                case "Trap1":
                    gm.trapsHitted[1] += 1;
                    break;
                case "Trap2":
                    gm.trapsHitted[2] += 1;
                    break;
                default:
                    break;
            }
        }
    }
    private void startInvincible()
    {
        isInvincible = true;
        Color tmp = GetComponent<SpriteRenderer>().color;
        tmp.a = 0.6f;
        GetComponent<SpriteRenderer>().color = tmp;
        Invoke("endInvincible", InvincibleTime);
    }
    private void endInvincible()
    {
        isInvincible = false;
        Color tmp = GetComponent<SpriteRenderer>().color;
        tmp.a = 1;
        GetComponent<SpriteRenderer>().color = tmp;
    }
}
