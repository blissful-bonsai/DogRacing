# bk-app-oop-corrida

O exerc�cio envolve a cria��o de uma simula��o de corrida de apostas. Inicialmente, o sistema deve solicitar o n�mero de apostadores que participar�o da partida, assegurando que haja pelo menos cinco apostadores, cada um come�ando com um saldo inicial de R$ 20,00. Al�m disso, o sistema precisa obter a quantidade de corredores na casa de apostas, garantindo um m�nimo de quatro corredores.

Cada corredor possui um comportamento de movimento espec�fico. Um corredor pode se mover aleatoriamente entre 0 cm e 70 cm, outro entre 30 cm e 50 cm, outro entre 20 cm e 40 cm, e o �ltimo entre 10 cm e 60 cm. Os apostadores devem escolher em qual corredor apostar antes do in�cio da corrida.

A corrida continua at� que um dos corredores atinja a marca de 100 metros, sendo declarado o vencedor. O pr�mio da corrida � dividido entre os apostadores que apostaram no corredor vencedor. Ap�s o t�rmino da corrida, o sistema deve exibir a coloca��o final de todos os corredores e o saldo final de cada apostador, refletindo os ganhos ou perdas decorrentes das apostas.

![Cachorro Pulando](docs/corrida_cachorro.gif)


## Simula��o de Corrida de Apostas

### Cen�rios de Teste

#### Funcionalidade: Configura��o de Apostas

##### Cen�rio: Definir n�mero de apostadores
- **Dado que** o sistema est� pronto para iniciar a configura��o
- **Quando** o usu�rio informa o n�mero de apostadores
- **Ent�o** o sistema deve verificar se h� no m�nimo 5 apostadores
- **E** cada apostador deve come�ar com R$ 20,00

##### Cen�rio: Definir n�mero de corredores
- **Dado que** o sistema est� pronto para iniciar a configura��o
- **Quando** o usu�rio informa o n�mero de corredores
- **Ent�o** o sistema deve verificar se h� no m�nimo 4 corredores

#### Funcionalidade: Movimento dos Corredores

##### Cen�rio: Movimento aleat�rio dos corredores
- **Dado que** a corrida est� em andamento
- **Quando** iniciar uma nova rodada
- **Ent�o** o Corredor 1 deve mover entre 0 cm e 70 cm
- **E** o Corredor 2 deve mover entre 30 cm e 50 cm
- **E** o Corredor 3 deve mover entre 20 cm e 40 cm
- **E** o Corredor 4 deve mover entre 10 cm e 60 cm

#### Funcionalidade: Apostas

##### Cen�rio: Registro de apostas
- **Dado que** o sistema est� pronto para receber apostas
- **Quando** cada apostador informa em qual corredor ir� apostar
- **Ent�o** o sistema deve registrar a aposta de cada apostador

#### Funcionalidade: Determinar o Vencedor

##### Cen�rio: Finaliza��o da corrida
- **Dado que** a corrida est� em andamento
- **Quando** um corredor atingir 100 metros
- **Ent�o** o sistema deve declarar esse corredor como o vencedor
- **E** dividir o pr�mio entre os apostadores que apostaram no corredor vencedor

#### Funcionalidade: Exibi��o dos Resultados

##### Cen�rio: Exibir resultados finais
- **Dado que** a corrida terminou
- **Quando** todos os corredores cruzarem a linha de chegada
- **Ent�o** o sistema deve exibir a coloca��o final dos corredores
- **E** o saldo final de cada apostador


## Dicas
- Crie um projeto console para rodar
- Crie um projeto class library para suas classes
- Crie um projeto de teste
