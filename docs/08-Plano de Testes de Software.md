# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site (link do site )l<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-02	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail e senha cadastrado  . |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site (endereço do site )<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
| **Caso de Teste** 	| - CT-03 – Escolha de prato - |
|	Requisito Associado 	| RF-03 - A aplicação deve apresentar, na página principal, a funcionalidade de mostrar pratos de diversas culinarias  para os usuários para que esses consigam achar seu prato ou culinaria . |
| Objetivo do Teste 	| Verificar se o usuário consegue buscar as  culinarias ou pratos desejados  . |
| Passos 	| - Acessar o navegador <br> - acessar paginas de pratos forfinker -navegar na home-page e buscar culinaria desejada  "" <br> - 
|Critério de Êxito | - busca da culinaria foi realizada com sucesso. |
|  	|  	|

| **Caso de Teste** 	| **CT-04 – Escolha do horario  ** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-04 - A aplicação deve apresentar, na página de reserva do restaurante , a funcionalidade de mostrar os horarios disponivel   para os usuários para que esses consigam escolher o horario adequado para sua reserva  . |
| Objetivo do Teste 	| Verificar se o usuário consegue o registro do horario desejado   . |

| **Caso de Teste** 	| **CT-05 –Reserva do Restaurante   ** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-05 - A aplicação deve possuir opção de fazer a reserva no restaurante escolhido , sendo necessario realizar o login com o endereço de e-mail e senha cadastrado  para que a reserva seja realizada com sucesso. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar a reserva no restaurante . |


| **Caso de Teste** 	| **CT-06 –Troca de idioma   ** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-06 - A aplicação deve possuir opção de fazer a troca de idioma ,optando por  linguagens de li para  seja realizada com sucesso a troca do idioma . |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar a a troca de idioma . |

 Caso de teste         | CT-07 - Cadastro e Login sem sucesso.|
| --------------------- | -----------------|
| Requisitos Associados | RF-07 - O site deve permitir ao usuário cadastrar e efetuar login.|
| Passos                | Acessar a Sessão de login  na aba de navegação em qualquer uma das páginas disponíveis  
| Objetivo do teste     | Verificar se a partir dos dados inseridos inválidos não é possível realizar do cadastro ou login.|
| Critérios de êxito    | Não conseguir efetuar cadastro como um novo usuário e não conseguir efetuar o login com os dados informados apresentando uma mensagem de erro para os dados incorretos.|






 
