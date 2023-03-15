# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários. 

## Personas

| <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder/blob/main/docs/img/Personas/1.png?raw=true" title="Amaury Júnior" align="left"> | <h2 align="right"><b>Amaury Júnior</b></h2></br></br></br> <p align="left">Idade: 41 <br/><br/> Ocupação: Empresário jovem e bem-sucedido que gosta de frequentar restaurantes de alto padrão em seu tempo livre. <br/><br/> O usuário prefere uma aplicação que sinalize estabelecimentos com áreas de acessibilidade, pois ele possui mobilidade reduzida.</p> |
| --- | --- |
| Motivações <ul><li>Atendimento personalizado.</li><li>Valorização da comodidade.</li></ul> | Frustrações <br/> <ul><li>Falta de sinalização de acessibilidade.</li> <li>Reservas não confirmadas.</ul> |
| <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder/blob/main/docs/img/Personas/2.png?raw=true" title="Amanda Rosemberg" align="left"> | <h2 align="right"><b>Amanda Rosemberg</b></h2></br></br></br> <p align="left">Idade: 45 <br/><br/> Ocupação: Amanda é uma mãe ocupada que gosta de planejar tudo com antecedência. <br/><br/> Ela adora comer fora com sua família, especialmente em ocasiões especiais, como aniversários e feriados. Ela acha difícil encontrar mesas disponíveis em restaurantes em horários de pico e muitas vezes acaba fazendo reservas com semanas de antecedência. Para economizar tempo, ela prefere usar um aplicativo fácil de usar que permita que ela faça suas reservas rapidamente e passe mais tempo aproveitando a companhia de sua família.</p> |
| Motivações <ul><liSegurança.</li><li>Diversidade de restaurante.</li></ul> | Frustrações <br/> <ul><li>Problemas com reservas online.</li> <li>Dificuldade em encontrar informações.</ul> |
| <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder/blob/main/docs/img/Personas/3.png?raw=true" title="Luísa Amarantes" align="left"> | <h2 align="right"><b>Luísa Amarantes</b></h2></br></br></br> <p align="left">Idade: 25 <br/><br/> Ocupação: Luísa é uma estudante universitária que trabalha meio período para pagar suas contas. <br/><br/> Ela gosta de sair para jantar com amigos e experimentar novos restaurantes, mas geralmente tem um orçamento limitado. Ela acha difícil encontrar mesas disponíveis em restaurantes populares com preços acessíveis, especialmente nos fins de semana. Ela prefere usar um aplicativo para procurar por restaurantes que se encaixem em seu orçamento e que ofereçam ofertas especiais.</p> |
| Motivações <ul><li>Facilidade de uso.</li><li>Intuitividade.</li></ul> | Frustrações <br/> <ul><li>Falta de disponibilidade.</li> <li>Falta de ofertas ou valores comparativos.</ul> |
| <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder/blob/main/docs/img/Personas/4.png?raw=true" title="Leandro Battisti" align="left"> | <h2 align="right"><b>Leandro Battisti</b></h2></br></br></br> <p align="left">Idade: 55 <br/><br/> Ocupação: Leandro é um homem aposentado que adora viajar pelo mundo e experimentar novas culturas e culinárias. <br/><br/> Ele fala vários idiomas, incluindo espanhol, francês e italiano. No entanto, a barreira linguística e a falta de familiaridade com o processo de reserva dificultam a realização de reservas em restaurantes em outros países. Para tornar o processo mais fácil e conveniente, ele prefere usar um aplicativo que permita fazer reservas em diferentes idiomas.</p> |
| Motivações <ul><li>Sistema multilíngue.</li><li>Facilidade de cancelamento.</li></ul> | Frustrações <br/> <ul><li>Dificuldade em cancelar reservas online.</li> <li>Sistemas monolíngues.</ul> |
| <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder/blob/main/docs/img/Personas/5.png?raw=true" title="Sarah D’aulizio" align="left"> | <h2 align="right"><b>Sarah D’aulizio</b></h2></br></br></br> <p align="left">Idade: 28 <br/><br/> Ocupação: Sarah é uma blogueira de gastronomia que adora experimentar novos restaurantes e compartilhar suas experiências em seu blog. <br/><br/> Sua presença ativa nas redes sociais a leva a compartilhar suas experiências com seus seguidores. Ela prefere usar uma aplicação para agendar suas reservas e permitir que ela compartilhe suas atividades com seus seguidores nas redes sociais. Além disso, ela valoriza as opções de idioma para experimentar restaurantes em outros países..</p> |
| Motivações <ul><li>Experiência gastronômica.</li><li>Informações claras.</li></ul> | Frustrações <br/> <ul><li>Sistemas pouco intuitivos.</li> <li>Falta de opções para grupos grandes.</ul> |


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


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID | Descrição do Requisito | Prioridade |
| --- | --- | --- |
| RF-01 | A aplicação deve permitir ao usuário cadastrar uma conta. | ALTA |
| RF-02 | A aplicação deve permitir aos donos/funcionários de restaurantes cadastrar uma conta com informações sobre o estabelecimento. | ALTA |
| RF-03 | A aplicação deve permitir a pesquisa de restaurantes, por horário e disponibilidade. | ALTA |
| RF-04 | A aplicação deve permitir a reserva de mesas de restaurantes de forma online e em tempo real. | ALTA |
| RF-05 | A aplicação deve permitir o cancelamento de reservas por parte dos usuários. | ALTA |
| RF-06 | A aplicação deve disponibilizar opções de idioma para os usuários. | BAIXA |
| RF-07 | A aplicação deve permitir o usuário o gerenciamento de preferências no perfil para sugestões personalizadas de restaurantes. | MÈDIA |
| RF-08 | A aplicação deve permitir avaliações e comentários de usuários sobre restaurantes. | BAIXA ||
| RF-09 | A aplicação deve permitir a atualização e gestão de informações de restaurantes pelos próprios estabelecimentos. | MÉDIA |
| RF-10 | A aplicação deve permitir a criação de listas de restaurantes favoritos e histórico de reservas. | BAIXA |
| RF-11 | A aplicação deverá exibir quais os tipos de acessbilidades disponiveis. | ALTA |
| RF-12 | A aplicação deverá permitir que o usuário faça observações na reserva. | ALTA |

### Requisitos não Funcionais

| ID | Descrição do Requisito | Prioridade |
| --- | --- | --- |
| RFN-01 | A aplicação deve ser publicada em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku); | ALTA |
| RFN-02 | A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade. | MÉDIA |
| RFN-03 | A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). | ALTA |
| RFN-04 | A aplicação deve disponibilizar às funcionalidades ao usuário de maneira simples e intuitiva. | MÉDIA |
| RFN-05 | A aplicação deve limitar o tempo de acesso ao sistema a fim de reduzir qualquer tipo de ameaça. | MÉDIA |
| RFN-06 | A aplicação deve cumprir com as regulamentações de privacidade de dados. | ALTA |
| RFN-07 | A aplicação deve se comunicar com o banco SQL. | ALTA |
| RFN-08 | A aplicação deve utilizar às linguagem C#, HTML, CSS e JavaScript. | ALTA |
| RFN-09 | A aplicação deverá estar disponível 100% do tempo. | ALTA |
| RFN-10 | A aplicação se adaptará ao formato de tela do dispositivo utilizado, sem que ocorram distorções. | ALTA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deve ser desenvolvido como foco no Back-end. |
|02| A equipe não pode subcontratar o desenvolvimento do trabalho. |
|03| O projeto deverá ser entregue até o final do semestre. |


## Diagrama de Casos de Uso

![Diagrama de Casos de Uso](https://user-images.githubusercontent.com/114194318/225170827-c5dad8c6-710f-41d1-b1f6-40bce5eab051.png)


