# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
| Sarah D’aulizio | Agendar reservas em restaurantes com facilidade | Poder apreciar a diversidade gastronômica de sua cidade |
| Leandro Battisti | Fazer reservas em diversos restaurantes em um só lugar | Ter um processo de reserva mais fácil e conveniente |
| Luísa Amarantes | Encontrar mesas disponíveis em restaurantes populares com preços acessíveis | Encontrar ofertas especiais em restaurantes |
| Amanda Rosemberg | Fazer reservas rapidamente em horários de pico | Ter mais tempo para aproveitar a companhia de sua família |
| Amaury Júnior | Gerenciar todas as suas reservas em um único lugar | Encontrar restaurantes com áreas de acessibilidade |
| Sarah D’aulizio | Poder visualizar imagens e avaliações de outros clientes que já visitaram o restaurante que estou planejando reservar | Para ter uma ideia melhor do que esperar |
| Leandro Battisti | Poder encontrar informações detalhadas sobre os diferentes pratos e ingredientes em um menu, bem como as opções vegetarianas e sem glúten | Para que eu possa escolher com base em minhas necessidades alimentares |
| Luísa Amarantes | Poder ver os preços dos pratos em um menu antes de fazer uma reserva | Para garantir que sejam acessíveis dentro do meu orçamento |
| Amanda Rosemberg | Poder reservar mesas em restaurantes que oferecem áreas infantis | Para que as crianças possam se divertir enquanto a família desfrute do momento |
| Amaury Júnior | A aplicação identifique e me mostre restaurantes com áreas de acessibilidade | Pois possuo mobilidade reduzida |
| Amaury Júnior | Visualizar a disponibilidade dos estabelecimentos | Para que eu possa escolher o melhor horário de acordo com minha disponibilidade |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID | Descrição do Requisito | Prioridade |
| --- | --- | --- |
| RF-01 | A aplicação deve permitir ao usuário cadastrar uma conta. | ALTA |
| RF-02 | A aplicação deve permitir aos donos/funcionários de restaurantes cadastrar uma conta com informações sobre o estabelecimento. | ALTA |
| RF-03 | A aplicação deve permitir a pesquisa de restaurantes por localização, horário e disponibilidade. | ALTA |
| RF-04 | A aplicação deve permitir a reserva de mesas de restaurantes de forma online e em tempo real. | ALTA |
| RF-05 | A aplicação deve permitir o pagamento online e seguro das reservas realizadas. | ALTA |
| RF-06 | A aplicação deve permitir o cancelamento de reservas por parte dos usuários. | ALTA |
| RF-07 | A aplicação deve disponibilizar opções de idioma para os usuários. | BAIXA |
| RF-08 | A aplicação deve fornecer confirmações de reserva e cancelamento de reservas via e-mail ou notificação no aplicativo. | MÉDIA |
| RF-09 | A aplicação deve permitir o usuário o gerenciamento de preferências no perfil para sugestões personalizadas de restaurantes. | MÈDIA |
| RF-10 | A aplicação deve permitir avaliações e comentários de usuários sobre restaurantes. | BAIXA |
| RF-11 | A aplicação deve permitir a integração com plataformas de redes sociais para compartilhamento de informações e opiniões sobre restaurantes. | BAIXA |
| RF-12 | A aplicação deve permitir a atualização e gestão de informações de restaurantes pelos próprios estabelecimentos. | MÉDIA |
| RF-13 | A aplicação deve oferecer suporte ao cliente por meio de chat ou e-mail. | BAIXA |
| RF-14 | A aplicação deve permitir a criação de listas de restaurantes favoritos e histórico de reservas. | BAIXA |
| RF-15 | A aplicação deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário pesquisa por tipo de cozinha ou categoria de restaurante.. | ALTA |

### Requisitos não Funcionais

| ID | Descrição do Requisito | Prioridade |
| --- | --- | --- |
| RFN-01 | A aplicação deve ser publicada em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku); - ALTA | ALTA |
| RFN-02 | A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade - MÉDIA | MÉDIA |
| RFN-03 | A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) - ALTA | ALTA |
| RFN-01 | A aplicação deve disponibilizará às funcionalidades ao usuário de maneira simples e intuitiva - ALTA | MÉDIA |
| RFN-05 | A aplicação deve ser responsivas para dispositivos mobile - ALTA | MÉDIA |
| RFN-06 | A aplicação deve limitar o tempo de acesso ao sistema a fim de reduzir qualquer tipo de ameaça - BAIXA | MÉDIA |
| RFN-07 | A aplicação deve cumprir com as regulamentações de privacidade de dados. | ALTA |
| RFN-08 | A aplicação deve se comunicar com o banco SQL - ALTA | ALTA |
| RFN-09 | A aplicação deve utilizar às linguagem C#, HTML, CSS e JavaScript - ALTA | ALTA |

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
|01| O projeto deverá ser entregue no meio do semestre letivo.|
|02| A equipe não pode subcontratar o desenvolvimento do trabalho.|
|03| O projeto deverá ser entregue até o final do semestre.|


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
