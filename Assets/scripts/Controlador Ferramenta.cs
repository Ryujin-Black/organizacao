using UnityEngine;

public class ControladorFerramenta : MonoBehaviour
{
    public Vector3 posicaoFerramenta;
    public float deslocamentoFerramenta;
    public float incrementoVelocidade;

    internal float deslocamentoInicial;
    //isso vai gaurdar a velocidade inicial 

    internal int sentidoV;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentidoV = 1;
        deslocamentoInicial = deslocamentoFerramenta;
        //isso faz com que a velocidade inicial sejá a mesma progamada não iniciada pelo jogador 
    }

    // Update is called once per frame
    void Update()
    {
        posicaoFerramenta.x += + deslocamentoFerramenta * Time.deltaTime;
        posicaoFerramenta.y += + deslocamentoFerramenta * Time.deltaTime * sentidoV;

        transform.position = posicaoFerramenta;
        // += é uma variavel mais ela mesma 
        // o vezes é * 
        if (transform.position.y >= 465 && sentidoV == 1)
        sentidoV = -1;
        // (= igual) (== ele vai conputar e ver se é iqual)
        if (transform.position.y <= 35 && sentidoV == -1)
            sentidoV = 1;

        deslocamentoFerramenta += incrementoVelocidade * Time.deltaTime;
        //isso fara a FR ir mais rapida ( lembrando coloque o pblic float incrementoVelocidade; antes de colocar o cd a cima)
        //ná cf da FR vc deve comlocar quanto vc que a vl aumenta 
    }
}
