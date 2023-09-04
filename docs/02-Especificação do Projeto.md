# Especificações do Projeto

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
|Lohan | Aplicativos avançados com um bom processador | Para suporte no processo criativo e agilidade na entrega do meu trabalho |
|Laura Guazelli | Encontrar pessoas dispostas a trazer vinhos das melhores vinícolas do mundo | Pagar preço justo e apreciar os vinhos da safra que lhe agrada |
|Marcela Fleury | Se disponibilizar para trazer encomendas dos países que visitar | Ter uma renda extra com as comisões que conseguir |
|Antonela Saori | Adquirir os mais diferenciados perfumes existentes no mundo | Pagar preço abaixo da tabela de importados no Brasil |
|João Schirm | Trazer para o Brasil encomendas vindas de países ao redor do mundo | Divulgar meu canal no YouTube e fidelizar a audiência |
|Camila Matias | Comprar e trazer dos países que visito roupas e calçados | Facilitar o acesso a produtos considerados de luxo por um valor justo |
|Fernanda Oliveira | Investir em equipamentos de qualidade e modernos | Melhorar a qualidade do meu trabalho cobrando um valor menor |
|Luiz Fernando | Comprar ferramentas tecnológicas | Com as ferramentas corretas consigo agilidade na entrega dos serviços |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|-------|-------------------------|----|
|RF-001| O site deve apresentar o sistema de avaliações com estrelas e comentários para cada vendedor e comprador | ALTA | 
|RF-002| O site deve exigir foto do usuário ao finalizar cadastro (thumbnail) | ALTA |
|RF-003| O site deve ter uma área de busca dos locais onde os viajantes disponíveis estão, e dos produtos que os compradores desejam. | MÉDIA |
|RF-004|	O site deve permitir acesso às formas de contato entre usuários que iniciaram negociação.	| MÉDIA |
|RF-005|	O site deve possuir uma página para cadastro de usuários (Pessoas) | ALTA |
|RF-006|	O site deve enviar notificação ao administrador do site, toda vez que um produto novo for cadastrado	| MÉDIA |
|RF-007|	O site deve permitir localizar produtos previamente cadastrados por outros usuários (imagens e descrições). |	MÉDIA |
|RF-008|	O site deve permitir cadastrar produtos (imagens e descrições).	| ALTA |
|RF-009|	O site deve garantir o pré-cadastro de produtos.	| BAIXA |
|RF-010|	O site deve enviar uma notificação solicitando a avaliação ao final do trâmite.	| MÉDIA |
|RF-011|	O site deve permitir ao usuário comprador, escolher o viajante e iniciar a negociação.	| MÉDIA |
|RF-012|	O site deve comunicar o usuário comprador se o produto foi aceito ou recusado.	| MÉDIA |
|RF-013|	O site deve permitir ao usuário viajante, analisar a negociação.	| MÉDIA |
|RF-014|	O site deve permitir ao usuário viajante, cadastrar suas próximas viagens.	| MÉDIA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001|	Na página principal, devemos deixar claro o propósito do site |	MÉDIA |
|RNF-002|	O site deve ser responsivo |	MÉDIA |
|RNF-003|	O site deve ter bom nível de contraste entre os elementos da tela em conformidade |	MÉDIA |
|RNF-004|	Compatibilidade com principais navegadores (Chrome, Firefox, Opera, Safari) |	MÉDIA |
|RNF-005|	A resposta de uma busca não pode demorar mais que 5 segundos. |	MÉDIA |
|RNF-006|	O site deve passar segurança aos usuários ao colocar seus dados pessoais. |	MÉDIA |
|RNF-007|	Inclusão de ALTs (descrições de imagens) nas fotos e ilustrações (RNF) |	MÉDIA |



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
=======
## Regras de Negócio

As regras de Negócio desse projeto, são:

|ID| Regras                                           |
|--|-------------------------------------------------------|
|01| O cadastro de viajantes e compradores só poderá ser aceito com o preenchimento dos dados obrigatórios e após a verificação do algoritmo do CPF. |
|02| A avaliação será por meio de notas (satisfeito_10 / insatisfeito_0). A somatória das notas de uma avaliação acarretará o aumento ou a diminuição do nível do usuário. |
|03| O não preenchimento da avaliação ao final do prazo da negociação suspenderá por 30 dias o usuário da plataforma, através do número do CPF do cadastro. |
|04| Não será permitido o cadastro de produtos ilícitos no Brasil, tais como, drogas, armas de fogos, remédios controlados, etc. |
|05| Não será permitido o cadastro de animais de estimação e nem animais silvestres. |
|06| Não será permitido o cadastro de produtos envolvendo pedofilia. |


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre (06/12/2023) |
|02| Vídeo de 2 minutos sobre o problema e a solução proposta |
|03| Atender todas as normas ABNT |
|04| O grupo deverá utilizar o repositório específico do curso ADS |


## Diagrama de Casos de Uso

![Casos de Uso Muamba](img/diagrama_casos_de_uso_muamba.jpg)  

## Casos de Uso

