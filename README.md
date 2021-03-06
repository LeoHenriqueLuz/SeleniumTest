# Testes Automatizado com Selenium - Curso básico 

Implementação de teste Web ( pagina de login/ Formulário ), utilizando conceitos básicos e boas praticas de teste.

## Tecnologias utilizadas
- Class Library (.Net Framework)
- NUnit + dependências
- Selenium WebDriver + dependências

## Conceitos abordados no curso

- Page Object => Padrão de desenho que representa a página e seus componentes em uma classe, com objetivo de evitar duplicação de código e facilitar manutenção das automatizações.

- Explicit Waits => As Esperas explícitas, permite que possamos pausar uma parte do código até que uma determinada condição aconteça.
  Exemplo: Esperar pela visualização de um elemento web ou esperar que um elemento se encontre na pagina web.

## Boas práticas aplicadas
- Manipulação de alertas c/ Selenium

- Herança com Classe Base (Eliminando código repetitivo nas classes)

- Arquivo de Configuração => É uma boa prática obter os dados de configuração do Projeto em uma fonte externa, como arquivos de configuração. Desta forma podemos mudar, por exemplo, a url da aplicação que estamos testando sem a necessidade de compilar o código.

- Captura de Tela => Implementação de uma classe responsável pela manipulação de captura da tela do ponto de falha do caso de teste.

- Data Driving Testing => Permite reutilizar os testes e executá-los com dados diferentes, permitindo a ampliação de quantidade de teste de uma funcionalidade, sem ter que modificar o código dos testes.



