# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

•	Lohan é um especialista em design gráfico, tem 24 anos. Trabalha como free lancer e requer novas tecnologias que facilitem seu dia a dia, como por exemplo um ipad. Suas motivações são agilidade dos processadores apple, conectividade com seu iphone e compatibilidade com aplicativos avançados (ilustradores, designers e editores de video). Sua frustação é referente aos altos valores dos produtos de alta performance no Brasil devido aos impostos.

•	Ana Clara, 30 anos, trabalha com publicidade e propaganda e adora viajar. Por possuir amigos e familiares morando no exterior está sempre viajando a passeio. Suas motivações são facilitar o acesso de crianças com deficiência visual aos livros em braille que são proibidos no Brasil.

•	Laura Guazelli, 36 anos, trabalha como representante de produtos de beleza . Tem como hobbie apreciar vinhos. Sua motivação é promover eventos voltados à estética. Sua maior frustação é o alto custo dos vinhos internacionais.

•	Marcela Fleury, atuária, 38 anos. Sua maior paixão é viajar. Tem facilidade em manipular pontos de cartão de crédito e transformá-los em milhas. Sempre que vai viajar algum amigo ou familiar pede algum produto.

•	Antonela Saori, 18 anos, estudante. Gasta suas economias em perfumes importados. Possui dezenas de frascos de perfumes expostos em sua estante, tem como meta atingir 500 frascos em sua coleção.

•	João Schirm, 32 anos, youtuber. Produz conteúdo durante suas viagens ao redor do mundo. Em seus vídeos presenta a cultura e o dia a dia das cidades mais exóticas e curiosas. A cada episódio se dispõe a trazer encomendas de seus seguidores de algo característico do país em que se encontra.

•	Camila Matias, 26 anos, modelo. Quando começou a fazer viagens a trabalho se surpreendeu ao perceber a grande variedade e o baixo preço de roupas e calçados em algumas cidades que visitava. Produtos que no Brasil eram considerados de luxo e muito caros, ela encontrava em lojas simples e por um preço acessível. Foi assim que ela começou a trazer malas cheias de encomendas e presentes para amigos e familiares.

•	Fernanda Oliveira, 50 anos, fotografa. Valoriza a comodidade de fazer compra a qualquer momento, independentemente do local ou da forma da compra por gostar muito de investir no seu trabalho com equipamentos de alta qualidade que muitas vezes são mais acessíveis fora do país.

•	Luiz Fernando, 33 anos, empresário. Luiz atua na área automotiva que necessita da ferramenta correta para determinadas atividades para que a produtividade nas tarefas aumente. A compra de ferramentas tecnológicas com um custo menor propicia a ascensão do seu negócio.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO...          | QUERO/PRECISO ...                  |PARA ...                                |
|--------------------|------------------------------------|----------------------------------------|
|Lohan               | Aplicativos avançados com um bom   | Para suporte no processo criativo e    |
|                    | processador                        | agilidade na entrega do meu trabalho   |
|--------------------|------------------------------------|----------------------------------------|
|Laura Guazelli      | Encontrar pessoas dispostas a      | Pgar preço justo e apreciar os         |
|                    | trazer vinhos das melhores         | vinhos da safra que lhe agrada         |
|                    | vinícolas do mundo                 |                                        |
|--------------------|------------------------------------|----------------------------------------|
|Marcela Fleury      | Se disponibilizar para trazer      | Ter uma renda extra com as comisões    |
|                    | encomendas dos lugares que visitar | que conseguir                 |
|--------------------|------------------------------------|----------------------------------------|
|Antonela Saori      | Adquirir os mais diferenciados     | Pagar preço abaixo da tabela de        |
|                    | perfumes existentes no mundo       | importados no Brasil                   |
|--------------------|------------------------------------|----------------------------------------|
|João Schirm         | Trazer para o Brasil encomendas    | Divulgar meu canal no YouTube e        |
|                    | vindas de países ao redor do mundo | fidelizar a audiência                  |
|--------------------|------------------------------------|----------------------------------------|
|Camila Matias       | Comprar e trazer dos países que    | Facilitar o acesso a produtos          |
|                    | visito roupas e calçados           | considerados de luxo por um valor justo|
|--------------------|------------------------------------|----------------------------------------|
|Fernanda Oliveira   | Investir em equipamentos de        | Melhorar a qualidade do meu trabalho   |
|                    | qualidade e modernos               | cobrando um valor menor                |
|--------------------|------------------------------------|----------------------------------------|
|Luiz Fernando       | Busca de ferramentas tecnológicas  | Com as ferramentas corretas consigo    |
|                    |                                    | agilidade na entrega dos serviços      |
|--------------------|------------------------------------|----------------------------------------|

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
