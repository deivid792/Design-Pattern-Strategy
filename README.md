# Strategy Pattern - Sistema de Pagamentos em C#

Este projeto é um exemplo simples para demonstrar o **Strategy Pattern** em C#. A ideia é mostrar de forma prática como este design pattern ajuda a desacoplar comportamentos variáveis, tornando o código mais flexível, testável e extensível.

---

## Sobre o padrão Strategy

O **Strategy Pattern** é utilizado quando temos **comportamentos que podem variar**, e queremos poder trocá-los de forma **dinâmica** sem alterar o restante do sistema.  

No exemplo deste projeto, o comportamento que varia é a forma de pagamento: **Pix, Cartão de Crédito ou PayPal**.  

Sem Strategy, o `Checkout` precisaria conhecer todos os detalhes de cada pagamento, geralmente usando `if` ou `switch`, o que deixa o código rígido e difícil de manter. Com Strategy, cada forma de pagamento é isolada em uma classe própria que implementa a interface `IPaymentStrategy`.  

### Benefícios do Strategy

- Desacopla a lógica de pagamento do fluxo principal (`Checkout`).  
- Permite **adicionar novas formas de pagamento** sem alterar o código existente.  
- Facilita testes unitários, pois cada estratégia pode ser testada isoladamente.  
- Permite **escolher a estratégia em tempo de execução**, dinamicamente.

---

## Estrutura do projeto

StrategyPatternPayment/
├── Program.cs # Ponto de entrada do programa
├── Checkout.cs # Classe que recebe a estratégia e processa o pagamento
├── Payments/
│ ├── IPaymentStrategy.cs
│ ├── PixPayment.cs
│ ├── CreditCardPayment.cs
│ └── PayPalPayment.cs

## Como rodar o projeto

1. Certifique-se de ter o **.NET 9 SDK** instalado.  
2. Abra o terminal na pasta do projeto.  
3. Execute os seguintes comandos:

```bash
dotnet restore       # Restaura as dependências (geralmente opcional em projetos simples)
dotnet run           # Roda o projeto

Você verá a saída simulando pagamentos com diferentes estratégias:

Iniciando processamento do pedido...
Pagamento de R$150,00 realizado via PIX.
Pedido finalizado!

Iniciando processamento do pedido...
Pagamento de R$250,00 realizado com Cartão de Crédito.
Pedido finalizado!
