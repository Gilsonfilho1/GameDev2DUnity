using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Declaran do minha primeira variavel
        float meuNumero = 75.2f;

        // Quer dizer que eu posso fazer um comentario
        Debug.Log("Bem Vindo");
        // Agora eu estou fazendo uma mensagem de aviso
        Debug.LogWarning("alerta");
        // Essa mensagem por sua vez é de erro e meu jogo deve ser pausado
        Debug.LogError("Erro");

        Debug.Log(meuNumero);
        Debug.Log(meuNumero);
        Debug.Log(meuNumero);
        Debug.Log(meuNumero);
        Debug.Log(meuNumero);


        // Tipo de dados:
        /*
         * "Bem Vindo" - String
         *  Númerico, inteiro - Int
         *  Númerico Quebrado - Float
         */

        // Variáveis sçao palavras que guardam informações, que variam
        // Declarando uma variável
        //  Tipo de dado - Nome

        // Camel Case
        //PorqueSempreQueEuComeçarUmaPalavraNovaAPrimeiraLetraDelaSeráEmMaiusculoEIssoPareceACorCovaDeUmcamelo
        // Snake Case
        // porque_sempre_que_eu_separo_eu_coloco_uma_cobrinha

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
