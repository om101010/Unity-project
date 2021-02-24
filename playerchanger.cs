using UnityEngine;

public class playerchanger : MonoBehaviour
{
    public all al;

    void OnMouseDown()
    {
        al.changePlayer(this.gameObject);
        GetComponent<realPlayer>().enabled = true;
    } 
}