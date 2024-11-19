using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class geral : MonoBehaviour
{
    internal int placarJogadorNum, recordeNum;
    // essa linha contem 2 duas variaveis que vão contabilizar as coisas do jogador 
    public Text placarJogadorTexto, recordetexto;
    // bliblioteca são onde fica os codigos que o cp entende 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject gameOver, personagemPrincipal, ferramenta;
    //como é o mesmo cd para o gameouver é o do pp vc pode colocar apenas uma , e o seginte para funfar 
    void Start()
    {
        placarJogadorNum = 0;
        recordeNum = 0;
    }

    public void MarcarPonto()
    {
        placarJogadorNum += 1;
        if (recordeNum < placarJogadorNum)
            recordeNum += 1;
        AtualizarTextodoPlacar();

        GetComponent<AudioSource>().Play();
        //isso fara com que ao tocar a FR um son sera asionado 
    }
    // codigos sem ponto e vergula dependendo de onde vcnão colocar se vc colacar ele vai ficar rodando 
    // codigos com ; quer dizer que ele vai rodar na hora 
    // vai colocar um texto use " somente na palavra do testo como if (cod..(""))
    // para o geral vc não vai usar o up data 

    public void AtualizarTextodoPlacar()
    {
        placarJogadorTexto.text = "Itens coletados:" + placarJogadorNum;
        recordetexto. text = "Recorde atual:" + recordeNum;
    }
 //aqui sera o local onde os pontos do jogador seram contabilisados 

    public void IniciarPartida()
    {
        placarJogadorNum = 0;
        AtualizarTextodoPlacar();

        //reposicionar a FR ( feito)
        // velicidade "padrão" ( feito )
        //reposicionar o jogador (feito)
        // sumir o placar do jogandor (feito)

        gameOver.SetActive(false);
        personagemPrincipal.transform.position = new Vector3(875, 250, 0);
        //o primeiro cd faz com que se vc precionar o botão o jogo volta 
        // o segundo faz com que o personagem principal volte para cordenada 875, 250 e 0
        ferramenta.GetComponent<ControladorFerramenta>().posicaoFerramenta = new Vector3(0,0,0);
        // isso fara com que a ferramenta voltara para seu lugar de origem quando vc clicar o botão de rt 
        ferramenta.GetComponent<ControladorFerramenta>().deslocamentoFerramenta=
        ferramenta.GetComponent<ControladorFerramenta>().deslocamentoInicial;
        //isso faz com que o programa quarde a velocidade inicial que o programa da FR usa para iniciar e assim quando o botão ET é usado ele volta para isso 
    }
  
}
