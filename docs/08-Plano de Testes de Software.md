# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| **RF-02** e **RF-05** - O site deve exigir foto do usuário ao finalizar cadastro (thumbnail) & O site deve possuir uma página para cadastro de usuários (Pessoas) |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação e incluir uma foto ao finalizar o cadastro. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br> - Clicar em "Login" <br> - E escolher a opção _Quero me cadastrar_. - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha, cidade e estado) e carregar uma foto <br> - Clicar em "Enviar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|

| Caso de Teste 	| CT-02 – Página de Buscar Produtos |
|:---:	|:---:	|
|Requisito Associado | **RF-03** & **RF-07**- O site deve ter uma área de busca dos locais onde os viajantes disponíveis estão, e dos produtos que os compradores desejam & O site deve permitir localizar produtos previamente cadastrados por outros usuários (imagens e descrições).|
| Objetivo do Teste 	| Página de produtos e possíveis localidades de viajantes |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br>.  - Ir para página de busca de produtos  - Selecionar produtos por categoria  - Selecionar produtos por palavra-chave. 
 - Cards com possíveis produtos que estejam cadastrados após a buscar.  - Área com possibilidade de cadastrar produtos.  - Área com possibilidade de escolher localidade específica. |
|Critério de Êxito | - Todos os botões são clicáveis e direcionam corretamente. Além de retornar resultados caso haja e em todas as opções o usuário ser informado com mensagens sobre o resultado da tentativa.  |

| Caso de Teste 	| CT-03– Página de Cadastro de Produtos |
|:---:	|:---:	|
|Requisito Associado | RF-08- O site deve permitir cadastrar produtos (imagens e descrições). |
| Objetivo do Teste 	| Cadastrar produtos que não estejam previamente disponíveis |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br>  - Ir para a página de busca de produtos. - Rolar a página até a seção "Não conseguiu localizar o produto?". - Clicar em "Cadastrar Produto". - Selecione a categoria do seu produto. - Insira até 10 palavras-chave. - Insira uma imagem do produto. - Clique em Cadastrar esse produto. - Receba uma mensagem de confirmação. |
|Critério de Êxito | - Todos os botões devem ser clicáveis. - O botão Cadastrar esse produto deve estar inativo até que  todos os campos estejam preenchidos. - Há mensagem de confirmação sobre o envio e também sobre a falta de algum campo mandatório. |

| Caso de Teste 	| CT-04– Notificações ao Administrador e Comprador sobre novos produtos |
|:---:	|:---:	|
|Requisito Associado | **RF-06** e **RF-12** - O site deve enviar notificação ao administrador do site, toda vez que um produto novo for cadastrado **&** O site deve comunicar o usuário comprador se o produto foi aceito ou recusado.|
| Objetivo do Teste 	| Checar novos produtos sendo cadastrados no site |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br>  - Ir para a página de produtos e realizar um novo cadastro de produto. - Verificar se o Admin foi propriamente notificado. - Aceitar o produto - Fazer o mesmo processo e recusar o produto. - Logar como usuário comprador. - Verificar se a mensagem de aceita ou recusa foi propriamente recebida |
|Critério de Êxito | - Todos os botões devem ser clicáveis. - Ao receber uma notificação o admin deve receber todo o formulário previamente preenchido. - O admin tem a possibilidade de recusar ou aceitar. - O usuário comprador recebe a mensagem avisando sobre a decisão do admin. |

| Caso de Teste 	| CT-05– Viajante cadastrando a próxima viagem |
|:---:	|:---:	|
|Requisito Associado | RF-14 - O site deve permitir ao usuário viajante, cadastrar suas próximas viagens.|
| Objetivo do Teste 	| Usuário viajantes cadastrando a próxima viagem |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br>  - Ir para a opção Anunciar viagem. - Preencher todo o formulário. - Clicar em Anunciar Viagem. |
|Critério de Êxito | - Todos os botões devem ser clicáveis. - O botão de Anunciar Viagem ficará disponível após todo o formulário estar preenchido (Selecionar região, país, cidade, período da viagem sendo ida e volta). - Terá uma seção com histórico de viagens. - Opção de avaliar comprador caso não tenha ainda o feito em viagens passadas |
