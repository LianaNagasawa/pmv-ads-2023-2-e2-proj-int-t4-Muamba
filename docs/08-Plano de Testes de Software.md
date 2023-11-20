# Plano de Testes de Software
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| **RF-02** e **RF-05** - O site deve exigir foto do usuário ao finalizar cadastro (thumbnail) & O site deve possuir uma página para cadastro de usuários (Pessoas) |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação e incluir uma foto ao finalizar o cadastro. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br> - Clicar em "Login" <br> - E escolher a opção _Quero me cadastrar_. - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha, cidade e estado) e carregar uma foto <br> - Clicar em "Enviar" |
|Critério de Êxito | O cadastro foi realizado com sucesso. |
|Resultado Obtido | O site permite que o usuário insira todas as informações requeridas e mandatórias. Permite que finalize o cadastro.  |
|Avaliação | **APROVADO** |


| Caso de Teste 	| CT-02 – Página de Buscar Produtos |
|:---:	|:---:	|
|Requisito Associado | **RF-03** & **RF-07** & **RF-09** - O site deve ter uma área de busca dos locais onde os viajantes disponíveis estão, e dos produtos que os compradores desejam & O site deve permitir localizar produtos previamente cadastrados por outros usuários (imagens e descrições) & O site deve garantir o pré-cadastro de produtos.	|
| Objetivo do Teste 	| Página de produtos e possíveis localidades de viajantes |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br>  - Ir para página de busca de produtos <br> - Selecionar produtos por categoria <br> - Selecionar produtos por palavra-chave <br> - Cards com possíveis produtos que estejam cadastrados após a buscar. <br> - Área com possibilidade de cadastrar produtos. <br> - Área com possibilidade de escolher localidade específica |
|Critério de Êxito | Todos os botões são clicáveis e direcionam corretamente. Além de retornar resultados caso haja e em todas as opções o usuário ser informado com mensagens sobre o resultado da tentativa.|
|Resultado Obtido | O Site posui um campo para busca de locais onde os viajantes disponíveis estão. O site permite buscar produtos previamente cadastrados. O Site Permite o cadastro de produtos.|
|Avaliação | **APROVADO**  |

| Caso de Teste 	| CT-03– Página de Cadastro de Produtos |
|:---:	|:---:	|
|Requisito Associado | RF-08- O site deve permitir cadastrar produtos (imagens e descrições). |
| Objetivo do Teste 	| Cadastrar produtos que não estejam previamente disponíveis. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br>  - Ir para a página de busca de produtos <br> - Rolar a página até a seção "Não conseguiu localizar o produto?" <br> - Clicar em "Cadastrar Produto" <br> - Selecione a categoria do seu produto <br> - Insira até 10 palavras-chave <br> - Insira uma imagem do produto <br> - Clique em Cadastrar esse produto <br> - Receba uma mensagem de confirmação |
|Critério de Êxito | - Todos os botões devem ser clicáveis <br> - O botão Cadastrar esse produto deve estar inativo até que  todos os campos estejam preenchidos <br> - Há mensagem de confirmação sobre o envio e também sobre a falta de algum campo mandatório. |
|Resultado Obtido | O Site permite cadastrar produtos que não estão disponíveis (cadastrados)  |
|Avaliação | **APROVADO**  |


| Caso de Teste 	| CT-04– Notificações ao Administrador e Comprador sobre novos produtos |
|:---:	|:---:	|
|Requisito Associado | **RF-06** e **RF-12** - O site deve enviar notificação ao administrador do site, toda vez que um produto novo for cadastrado **&** O site deve comunicar o usuário comprador se o produto foi aceito ou recusado.|
| Objetivo do Teste 	| Checar novos produtos sendo cadastrados no site. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br>  - Ir para a página de produtos e realizar um novo cadastro de produto <br> - Verificar se o Admin foi propriamente notificado <br> - Aceitar o produto <br> - Fazer o mesmo processo e recusar o produto <br> - Logar como usuário comprador <br> - Verificar se a mensagem de aceita ou recusa foi propriamente recebida |
|Critério de Êxito | - Todos os botões devem ser clicáveis <br> - Ao receber uma notificação o admin deve receber todo o formulário previamente preenchido <br> - O admin tem a possibilidade de recusar ou aceitar <br> - O usuário comprador recebe a mensagem avisando sobre a decisão do admin. |
|Resultado Obtido | Todos os Critérios passaram, exceto como o usuário receberá o aviso da decisão do administrador. |
|Avaliação | **PARCIALMENTE APROVADO** |


| Caso de Teste 	| CT-05– Viajante cadastrando a próxima viagem |
|:---:	|:---:	|
|Requisito Associado | RF-14 - O site deve permitir ao usuário viajante, cadastrar suas próximas viagens.|
| Objetivo do Teste 	| Usuário viajantes cadastrando a próxima viagem. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br>  - Ir para a opção Anunciar viagem <br> - Preencher todo o formulário <br> - Clicar em Anunciar Viagem <br>
|Critério de Êxito | - Todos os botões devem ser clicáveis. - O botão de Anunciar Viagem ficará disponível após todo o formulário estar preenchido (Selecionar região, país, cidade, período da viagem sendo ida e volta). - Terá uma seção com histórico de viagens <br> - Opção de avaliar comprador, caso ainda existam pendências de viagens feitas previamente|
|Resultado Obtido | Páginas implementada com todos os requisitos. Dados e opções disponíveis como concordo nos planos de implementação|
|Avaliação | **APROVADO**  |


| Caso de Teste 	| CT-06 – Comprador escolhendo viajante |
|:---:	|:---:	|
|Requisito Associado | RF-11 - O site deve permitir ao usuário comprador, escolher o viajante e iniciar a negociação.|
| Objetivo do Teste 	| Comprador consegue escolher o viajante que se encaixa em suas necessidades. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br>  - Ir para busca de produtos <br> - Selecionar um produto <br> - Verificar os viajantes disponíveis que se encaixem na necessidade do comprados.|
|Critério de Êxito | - Todos os botões devem ser clicáveis <br> - O comprador terá cards com todos os viajantes disponíveis que atendam os requerimentos dele. |
|Resultado Obtido | O Site permite ao usuário comprador, escolher um viajante e iniciar uma negociação.  |
|Avaliação | **APROVADO**  |


| Caso de Teste 	| CT-07 – Conectando o comprador e o viajante |
|:---:	|:---:	|
|Requisito Associado | **RF-04** & **RF-13** - O site deve permitir acesso às formas de contato entre usuários que iniciaram negociação. & O site deve permitir ao usuário viajante, analisar a negociação. |
| Objetivo do Teste 	| Comunicação entre comprador e viajante.  |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br>  - Após escolher o produto e o viajante, o viajante será notificado <br> - O viajante aceitará ou não a negociação <br> - Se ele aceitar, o viajante entra em contato direto com comprador. |
|Critério de Êxito | - Todos os botões devem ser clicáveis <br> - Há mensagens de aviso em todas as etapas <br> - O viajante e o comprador tem acesso a aba Negociações <br> - Ambos conseguem se comunicar após aprovação mútua <br> - Página de análise de ofertas possui opção para Aceitar ou Recusar negociação <br> - Página como comprador mostra as chamadas de negociações do comprador com mensagens (Aceito / Recusado / Pendente). |
|Resultado Obtido | Todos os Critérios passaram, exceto as mensagens de avisos. |
|Avaliação | **PARCIALMENTE APROVADO** |


| Caso de Teste 	| CT-08 – Avaliando o comprador e o viajante |
|:---:	|:---:	|
|Requisito Associado | **RF-01** & **RF-10** - O site deve apresentar o sistema de avaliações com estrelas e comentários para cada vendedor e comprador	& O site deve enviar uma notificação solicitando a avaliação ao final do trâmite. |
| Objetivo do Teste 	| Avaliação do comprador e do viajante.  |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://muambabrasil.com.br<br>  - Ir até Minhas Avaliações <br> - Clicar na negociação feita e finalizada <br> - Responder todas as questões mandatórias <br> - Clicar em Enviar Avaliação. |
|Critério de Êxito | - Todos os botões devem ser clicáveis <br> - Há mensagens de aviso em todas as etapas <br> - O botão de Enviar Avaliação deve ficar disponível APÓS avaliação de todos os questionamentos requeridos <br> - Mensagem avisando aos usuários a importância de tal avaliação para permanecimento no site. |
|Resultado Obtido | Todos os critérios passaram, exceto as mensagens de avisos. |
|Avaliação | **PARCIALMENTE APROVADO** |

