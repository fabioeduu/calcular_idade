# Calculadora de Idade

CheckPoint C# - Aplicação Console para calcular idade

## Descrição

Esta é uma aplicação console em C# que calcula a idade de uma pessoa com base em sua data de nascimento. O programa fornece informações adicionais como:

- Idade atual em anos
- Quantos dias faltam para o próximo aniversário
- Validação de entrada de dados
- Interface amigável em português

## Funcionalidades

- ✅ Cálculo preciso da idade em anos
- ✅ Cálculo dos dias restantes para o próximo aniversário
- ✅ Validação de formato de data (dd/MM/yyyy)
- ✅ Tratamento de erros (datas inválidas, datas futuras)
- ✅ Interface interativa em português
- ✅ Possibilidade de calcular múltiplas idades na mesma execução

## Como executar

### Pré-requisitos
- .NET 8.0 ou superior instalado

### Executando a aplicação

1. Clone o repositório:
```bash
git clone https://github.com/fabioeduu/calcular_idade.git
cd calcular_idade
```

2. Execute a aplicação:
```bash
dotnet run
```

3. Siga as instruções na tela:
   - Digite sua data de nascimento no formato dd/MM/yyyy (ex: 15/03/1990)
   - Digite 'sair' para encerrar o programa

### Exemplo de uso

```
=== CALCULADORA DE IDADE ===

Digite sua data de nascimento (dd/MM/yyyy): 15/03/1990

📅 Data de nascimento: 15/03/1990
🎂 Sua idade atual: 35 anos
🎉 Dias para o próximo aniversário: 170 dias

Digite 'sair' para encerrar ou pressione Enter para calcular outra idade...
```

## Compilação

Para compilar o projeto:
```bash
dotnet build
```

## Tecnologias utilizadas

- C# (.NET 8.0)
- Console Application
