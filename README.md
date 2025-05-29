# Cashflow App

O cashflow é um projeto para demonstração de técnicas de arquitetura e desenvolvimento de software. Funcionamente ele tem a função de demonstrar dados analiticos da movimentação de caixa de uma empresa ou mesmo pessoa fisica.
Features já desenvolvidas neste projeto:
- Visão geral do caixa;
- Gestão de transações, com inclusão manual de trasanções, inclusão massiva via csv, edição e deleção de transações;
- Relatório consolidado do balanço de caixa diário e mensal.

Estas features atendem os requisitos funcionais onde um gestor pode controlar seu fluxo de caixa, lançando dos débitos e créditos, tendo de facil visualização o relatório diario do balanço de caixa.

O projeto implementa requisitos técnicos como: APIs, Microsserviços, Events, Dados distribuidos, DDD.

## Arquitetura de Soluções
![image](docs/ArquiteturaCashflow.png)

> As ferramentas incluídas no desenho de solução como New Relic, SonarQube, ApiGee, JMeter, Github Actions, Helm, são ferramentas que recomendo dado as caracteristicas do projeto, mas podem ser modificadas dado as escolhas do cliente ou por questões de negociação de licenciamento.

**Você também pode acessar os diagramas C4 do projeto aqui:** ![C4 Diagrams](docs/C4-Diagrams.md)

## ADRs
Abaixo o link para os registros de decisões arquiteturais, no qual detalho a motivação para escolha de algumas ferramentas escolhidos para o projeto.
