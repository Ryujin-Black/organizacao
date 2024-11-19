using UnityEngine;

public class controladorjogador : MonoBehaviour
{
    public float velocidadeMaozinha;
    public geral juizDoJogo; 
    // o cd juiz vai contabilizr os pontos do jogo 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {//o primeiro codigo é para fazer a mão subir já o segundo é para ela deser 
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 465 )
        {
            Vector3 novapos = new Vector3(0, velocidadeMaozinha * Time.deltaTime, 0);
            transform.position += novapos;
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= 34)
        {
            Vector3 novapos = new Vector3(0, velocidadeMaozinha * Time.deltaTime, 0);
            transform.position -= novapos;
            //esse tipo de cod && transform.position.y >= 34 faz limitaçoes para o jogador como esse em especifico faz com que o jogador não va no limite 34 
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
        Vector3 novapos = new Vector3( Time.deltaTime * velocidadeMaozinha,0, 0);
        transform.position -= novapos;
        }
        // quando for mais de uma linha de codigo coloca {} na segunda 
        //{ if ( .....) 
        //}
        //{segundo cd
        //}
        // e não coloca ; na primeira 
        if (Input.GetKey(KeyCode. RightArrow))
        {            
            Vector3 novapos = new Vector3(velocidadeMaozinha * Time.deltaTime, 0, 0);
            transform.position += novapos;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // gando vc coloca o cod trigger e ele colidir com esse codigo ontrigger... ele vai rodar o devido cod 
        if (collision.name.StartsWith("FR"))
        {
            float posicaoY = Random.value * 465;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.x = 0;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.y = posicaoY;

            juizDoJogo.MarcarPonto();
            //esse cod faz com que se o jogador colida com a FR a FR vai voltar para a lc 0
            //o cod float posicaoY = Random.value * 465;posibilita que a FR ep em qualquer lugar 
        }
    }






}
