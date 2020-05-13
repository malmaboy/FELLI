#### Autores 


Hugo Carvalho Nº 21901624
Francisco Costa Nº 21903228
Luis Gomes Nº 21901362

- Hugo Carvalho 
    
    - Tabulerio
    - User Interface

- Francisco Costa
    
    - Divisão das classes e Inicialização do tabuleiro
    - Correções do tabuleiro 
    - Classe NextTurn

- Luis Gomes 
  
  - Movimento
  - Eliminações das peças


#### Arquitetura da solução

  - O código está dividido por classes. A classe "program" possui o metodo "main" que dá inicio ao programa. Dentro da classe "Game" tem os metodos "Game" e "Play". Este metodos fazem o _render_ do tabuleiro, _User Interface_, movimentação das peças e o verifica se há vitoria de um dos jogadores. O metodo "Game" é uma instância da classe "Board". Esta classe faz uma matriz do posicionamento das peças no movimento das peças. A classe "User Interface" faz _render_ do tabuleiro. A enumeração "State" diz quais são as peças do jogo.


  - As relações entre as classes estão demonstradas no diagrama de UML seguinte.
  
  [](https://github.com/malmaboy/FELLI/blob/master/Fluxograma.png)
  




#### Referências 

  - Aprenda A Programar em C# (livro)
  - [W3schools](https://www.w3schools.com/cs/cs_properties.asp)
  - Troca de ideias com o João Fonseca Nº 21905441, em como usar variaveis privadas em vez de publicas.
  - TicTacToe feito durante a aula de Linguagens de programação 1. 


####  Link para o repósitorio

  - [Link](https://github.com/malmaboy/FELLI) 
