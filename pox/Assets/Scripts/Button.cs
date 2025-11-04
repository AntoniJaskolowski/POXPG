using UnityEngine;
/*** A script on a child of player character
* It should have a small BoxCollider2D set to trigger to just touch the ground
***/
public class Button : MonoBehaviour
{
    public bool btn;
    public BoxCollider2D collider;
    public Animator anim;
    public void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        btn = true;
        

            anim.SetTrigger("open");
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        btn = false;
    }


}