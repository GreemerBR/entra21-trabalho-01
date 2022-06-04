![design-sem-nome-2022-01-26t131235627-1200x460](https://user-images.githubusercontent.com/105084941/172011940-4cdc7594-5d71-4823-95c6-1d3cec75fe7e.png)

<h1 align="center">Trabalho 01</h1>
<p align="center">Repositório criado para hospedar o primeiro trabalho da disciplina de C# do Entra21 Noturno.</p>
  
## Objetivo :dart:

O objetivo trabalho foi desenvolver algoritmos em linguagem C# para suprir as necessidades propostas pelo professor [Francisco Lucas Sens](https://github.com/franciscosens) no primeiro trabalho em grupo do curso de C# Noturno do Entra21 edição 2022

  
## Tecnologias :globe_with_meridians:

Foram utilizazdos na construção deste projeto:

* <b>C#</b>;
* <b>Visual Studio 2022 - 17.0</b>;
* <b>.NET  -  6.0</b>
* <b>FluentAssertions - 6.7</b>
* <b>Microsoft NET Test Sdk - 17.2</b>
* <b>xUnit - 2.4.1</b>
* <b>xUnit Runner VisualStudio - 2.4.5</b>
* <b>GitHub</b>.

## Instalação :hammer_and_wrench:

* Você vai precisar ter instalado em sua máquina o [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/downloads/), sendo a versão mínima necessária a 10.0.

* Além disso, também é necessário possuir o [.NET 6.0](https://dotnet.microsoft.com/en-us/download). Antes de realizar o download deste verifique, por meio de um terminal, o seguinte comando:
  
```
dotnet --version
```
  
* Caso apareça a versão `6.0` o download não é necessário. Da mesma maneira, caso seja necessário instalação, utilize o comando acima para verificar se a instalação foi bem sucedida.

  
## Execução :arrow_forward:

Para a execução dos algoritmos você pode optar por duas formas:
  
**Por meio do Visual Studio 2022**
  
* Abra o <b>Visual Studio 2022</b>;
* Clone este repositório por meio do link `https://github.com/GreemerBR/entra21-trabalho-01.git`;
* Após a clonagem do repositório terminar, clique em `View` e após em `Solution Explorer`;
* Na janela que se abriu de um duplo clique em `TrabalhoOrientacaoObjetos01.sln`;
* Por fim clique em `F5` e o algoritmo será executado.
    
**Por meio do Prompt de Comando** 
  
* Faça o download do arquivo [entra21-trabalho-01-master.zip](https://github.com/GreemerBR/entra21-trabalho-01/archive/refs/heads/master.zip);
* Descompacte o arquivo `entra21-trabalho-01-master.zip` localmente;
* Entre na pasta que foi descompactada e abra um terminal. Em seguinda digite:

```
dotnet publish
```
  
* Após clicar em enter e esperar a finalização do comando acima, digite:
  
```
cd TrabalhoOrientacaoObjetos01\bin\Debug\net6.0
```
  
* Por fim, após estar no diretório net6.0, basta digitar o comando abaixo e apertar enter para executar o algoritmo.
  
```
TrabalhoOrientacaoObjetos01.exe
```

Para execução dos testes unitários

**Por meio do Visual Studio 2022**
  
* Abra o `Solution Explorer` conforme explicado anteriormente na execução dos algoritmos;
* Clique com o botão direito sobre a opção `TrabalhoOrientacaoObjetos01.Tests`;
* Clique `Run Tests`.

  
## Documentação do Sistema :books:

* O algoritmo foi desenvolvido com auxílio da IDE <b>Visual Studio 2022</b> utilizando a linguagem <b>C#</b>.
  
* Após a execução do mesmo, independente do modo acima escolhido, o `MENU PRINCIPAL` será apresentado ao usuário:
  
```
--MENU PRINCIPAL--
1 - Questão 01
2 - Questão 02
3 - Questão 03
4 - SAIR

Digite a opção desejada: 
```

* O usuário deve então informar um dos quatro valores `1`, `2`, `3` ou `4` conforme opção desejada;
 
* Caso informe qualquer valor diferente dos acima citados o menu continuará a ser apresentado ao usuário até que uma opção válida seja informada;
 
* Da mesma forma, após a finalização da `Questão 01`, `Questão 02` ou `Questão 03` o menu voltará a ser apresentado ao usuário, sendo necessário informar a opção `4` para que o algoritmo seja finalizado.
  

### Questão 01
 
Objetivo: Dado a entrada de um valor decimal, deverá escrever o mesmo por extenso.
 
 ***Utilizando o algoritmo***
 
 * Ao informar a opção `1` no `MENU PRINCIPAL` o usuário será direcionado para resolução da `Questão 01`;
 
 * Ele será apresentado a seguinte mensagem:
 
 ```
 Por favor informe um valor positivo entre 0 e 9999,99 reais (com até duas casas decimais):
 ```

 * Caso informe qualquer valor diferente dos acima citados o menu continuará a ser apresentado ao usuário até que uma opção válida seja informada;

 * Após informar o valor desejado, como por exemplo o valor `1578,24` o usuário será apresentado ao seguinte menu:

 ```
------------------MENU------------------
1 - Obter decimal por extenso
2 - Obter unidade por extenso
3 - Obter dezena por extenso
4 - Obter centena por extenso
5 - Obter unidade de milhar por extenso
6 - Obter número completo por extenso
7 - SAIR

Digite a opção desejada:
 ```

* Ao informar a opção `1` o usuário receberá a seguinte resposta:
```
Número informado: 1578,24
Vinte e quatro centavos
```

* Ao informar a opção `2` o usuário receberá a seguinte resposta:
```
Número informado: 1578,24
Oito real(is)
```

* Ao informar a opção `3` o usuário receberá a seguinte resposta:
```
Número informado: 1578,24
Setenta reais
```

* Ao informar a opção `4` o usuário receberá a seguinte resposta:
```
Número informado: 1578,24
Quinhentos reais
```

* Ao informar a opção `5` o usuário receberá a seguinte resposta:
```
Número informado: 1578,24
Mil reais
```

* Ao informar a opção `6` o usuário receberá a seguinte resposta:
```
Número informado: 1578,24
Mil Quinhentos e Setenta e Oito real(is) e Vinte e quatro centavo(s)
```

* Após a finalização das opções `1`, `2`, `3`, `4`, `5` ou `6` o menu voltará a ser apresentado ao usuário, sendo necessário informar a opção `7` para que a `Questão 01` seja finalizada.

* Ao informar a opção `7` o usuário irá retornar ao `MENU PRINCIPAL`:
```
--MENU PRINCIPAL--
1 - Questão 01
2 - Questão 02
3 - Questão 03
4 - SAIR

Digite a opção desejada: 
```
  
### Questão 02

Objetivo: Dado a entrada de uma data deverá escrever a mesma por extenso.
 
 ***Utilizando o algoritmo***
  
 * Ao informar a opção `2` no `MENU PRINCIPAL` o usuário será direcionado para resolução do `Questão 02`; 
 
 * Na tela irá aparecer a seguinte mensagem:
 
 ```
 Por favor informe uma data (dd/mm/yyyy):
 ```
 
 * Caso informe qualquer coisa diferente de uma data conforme o padrão solicitado o menu continuará a ser apresentado ao usuário até que uma opção válida seja informada;

 * Após informar a data desejada, como por exemplo o valor `17/05/1993` o usuário será apresentado ao seguinte menu:
 ```
------------------MENU------------------
1 - Obter dia por extenso
2 - Obter mes por extenso
3 - Obter ano por extenso
4 - Obter data completo por extenso
5 - SAIR

Digite a opção desejada:
 ```

* Ao informar a opção `1` o usuário receberá a seguinte resposta:
```
Data informada: 17/05/1993
Dia Dezessete
```

* Ao informar a opção `2` o usuário receberá a seguinte resposta:
```
Data informada: 17/05/1993
Maio
```

* Ao informar a opção `3` o usuário receberá a seguinte resposta:
```
Data informada: 17/05/1993
Mil Novecentos e Noventa e Três
```

* Ao informar a opção `4` o usuário receberá a seguinte resposta:
```
Data informada: 17/05/1993
Dezessete de Maio de Mil Novecentos e Noventa e Três
```

* Após a finalização das opções `1`, `2` ou `3` ou o menu voltará a ser apresentado ao usuário, sendo necessário informar a opção `5` para que a `Questão 01` seja finalizada.

* Ao informar a opção `5` o usuário irá retornar ao `MENU PRINCIPAL`:
```
--MENU PRINCIPAL--
1 - Questão 01
2 - Questão 02
3 - Questão 03
4 - SAIR

Digite a opção desejada: 
```
  
### Questão 03

Objetivo: Dado a entrada de uma hora deverá escrever a mesma por extenso.
 
 ***Utilizando o algoritmo***
  
 * Ao informar a opção `3` no `MENU PRINCIPAL` o usuário será direcionado para resolução do `Questão 03`; 
 
 * Na tela irá aparecer a seguinte mensagem:
 
 ```
 Por favor informe uma hora (hh:mm:ss):
 ```
 
 * Caso informe qualquer coisa diferente de uma hora conforme o padrão solicitado o menu continuará a ser apresentado ao usuário até que uma opção válida seja informada;

 * Após informar a hora desejada, como por exemplo o valor `06:51:10` o usuário será apresentado ao seguinte menu:
 ```
------------------MENU------------------
1 - Obter hora por extenso
2 - Obter minuto por extenso
3 - Obter segundo por extenso
4 - Obter hora completo por extenso
5 - SAIR

Digite a opção desejada:
 ```

* Ao informar a opção `1` o usuário receberá a seguinte resposta:
```
Hora informada: 06:51:10
Seis horas
```

* Ao informar a opção `2` o usuário receberá a seguinte resposta:
```
Hora informada: 06:51:10
Cinquenta e um minutos
```

* Ao informar a opção `3` o usuário receberá a seguinte resposta:
```
Hora informada: 06:51:10
Dez segundos
```

* Ao informar a opção `4` o usuário receberá a seguinte resposta:
```
Hora informada: 06:51:10
Seis horas e Cinquenta e um minutos e Dez segundos
```

* Após a finalização das opções `1`, `2` ou `3` ou o menu voltará a ser apresentado ao usuário, sendo necessário informar a opção `5` para que a `Questão 01` seja finalizada.

* Ao informar a opção `5` o usuário irá retornar ao `MENU PRINCIPAL`:
```
--MENU PRINCIPAL--
1 - Questão 01
2 - Questão 02
3 - Questão 03
4 - SAIR

Digite a opção desejada: 
```
 
## Autores :busts_in_silhouette:
<b>[Cristyan Alvir Alexandrino](https://github.com/CristyanAlexandrino)</b>
<b>[Gregory Viegas Zimmer](https://github.com/GreemerBR)</b>
<b>[Juliana Cristina Forbici](https://github.com/JulianaForbici)</b>
