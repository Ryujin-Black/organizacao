using UnityEngine;

public class ControladorLimite : MonoBehaviour
{
    public GameObject objetoGameOver;


        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.StartsWith("FR"))
            objetoGameOver.SetActive(true);
        //isso fara com que a tela de Game Ouver surja 
        //para surjir o game ouver ele tera que tocar no limitador que ai liga esse cd, por isso da parte do colisor no cd 
    }

}